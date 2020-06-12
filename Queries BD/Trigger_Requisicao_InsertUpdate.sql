CREATE TRIGGER tr_RequisicaInsertUpdate ON GestaoEscola.Requisicao
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    DECLARE @ERROR bit = 0

    -- Get arguments of command
    DECLARE @ISBN varchar(17)
    DECLARE @Biblioteca varchar(20)
    DECLARE @IDInterno int
    DECLARE @NMec int
    DECLARE @DataRequisicao date
    DECLARE @DataEntrega date
    DECLARE @Entregue bit

    DECLARE @EditOp bit = 0
    SELECT 
        @ISBN = livro, 
        @Biblioteca = biblioteca, 
        @IDInterno = livroIDInterno, 
        @NMec = pessoaNMec,
        @DataRequisicao = dataRequisicao,
        @DataEntrega = dataEntrega,
        @Entregue = entregue
        FROM INSERTED

    -- Check if PK are given
    if (@ISBN IS NULL OR @Biblioteca IS NULL OR @IDInterno IS NULL OR @NMec IS NULL OR @DataRequisicao IS NULL)
        BEGIN
            SET @ERROR = 1
            RAISERROR ('Falta pelo menos uma das chaves primárias:livro, biblioteca, livroIDInterno, pessoaNMec dataRequisicao' ,16,1)
        END

    -- If not @Entregue, then livro must be available for requisition
    IF (@Entregue IS NOT NULL AND @Entregue=0)
        BEGIN
            DECLARE @EntregueCursor bit
            DECLARE livroDisponivel CURSOR FOR SELECT entregue FROM GestaoEscola.Requisicao WHERE livro = @ISBN AND biblioteca = @Biblioteca AND livroIDInterno = @IDInterno
            OPEN livroDisponivel

            FETCH livroDisponivel INTO @EntregueCursor
            
            WHILE (@@fetch_status=0)
                BEGIN
                    IF (@EntregueCursor=0)
                        BEGIN 
                            SET @ERROR = 1
                            RAISERROR ('A requisição não pode ser registada, pois o livro já se encontra requisitado!' ,16,1)
                        END
                    FETCH livroDisponivel INTO @EntregueCursor
                END

            CLOSE livroDisponivel
            DEALLOCATE livroDisponivel
        END

    
    IF (@ERROR=0)
    BEGIN
        PRINT 'Validation success, creating tuple ob db!'
        
        -- Add to DB (if no error was thrown before)
        IF EXISTS(SELECT * FROM DELETED)
            BEGIN
                PRINT 'Operation is UPDATE (only allows changes on @Entregue, never on @DataEntrega)'
                UPDATE GestaoEscola.Requisicao SET entregue = @Entregue WHERE livro = @ISBN AND biblioteca = @Biblioteca AND livroIDInterno = @IDInterno AND dataRequisicao = @DataRequisicao AND pessoaNMec = @NMec
            END
        ELSE
            BEGIN 
                PRINT 'Operation is INSERT'
                INSERT INTO GestaoEscola.Requisicao VALUES (@ISBN,@Biblioteca,@IDInterno,@NMec,@DataRequisicao,@DataEntrega,@Entregue)
            END
    END

END

DROP TRIGGER GestaoEscola.tr_RequisicaInsertUpdate;