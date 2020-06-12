CREATE TRIGGER tr_RequisicaoDelete ON GestaoEscola.Requisicao
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @ERROR bit = 0

    -- Get arguments of command
    DECLARE @ISBN varchar(17)
    DECLARE @Biblioteca varchar(20)
    DECLARE @IDInterno int
    DECLARE @NMec int
    DECLARE @DataRequisicao date
    
    DECLARE @DataHoje date
    SELECT @DataHoje=GETDATE()


    SELECT 
        @ISBN = livro, 
        @Biblioteca = biblioteca, 
        @IDInterno = livroIDInterno, 
        @NMec = pessoaNMec,
        @DataRequisicao = dataRequisicao
        FROM DELETED

    PRINT @DataRequisicao
    PRINT @DataHoje

    -- Only allow delete operations on requisitions made the day of operation
    IF (@DataRequisicao!=@DataHoje)
    BEGIN
        RAISERROR ('Não é permitido eliminar uma Requisicao cuja dataRequisicao não seja a de hoje!' ,16,1)
        set @ERROR = 1
    END

    IF (@ERROR=0)
    BEGIN
        PRINT 'Validation success, deleting tuple ob db!'        
        DELETE FROM GestaoEscola.Requisicao WHERE livro = @ISBN AND biblioteca = @Biblioteca AND livroIDInterno = @IDInterno AND dataRequisicao = @DataRequisicao AND pessoaNMec = @NMec
    END

END

DROP TRIGGER GestaoEscola.tr_RequisicaoDelete;