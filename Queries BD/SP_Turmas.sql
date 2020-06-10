-- SP to INSERT OR UPDATE Turmas
CREATE PROCEDURE GestaoEscola.TurmaSP @nivel int, @nome varchar(5), @dataInicio date, @dataFim date, @nmecDT int, @Edit bit
AS
BEGIN

    DECLARE @State int = 1
	    -- Validate arguments
    IF (@nivel IS NULL OR @nome IS NULL OR @dataInicio IS NULL OR @dataFim IS NULL OR @nmecDT IS NULL OR @Edit IS NULL)
        BEGIN
            PRINT 'Error! Invalid values! Aborting...'
            SET @State = -1
            RETURN @State
        END

    -- Check if @dataInicio and @dataFim exists together on the DB, if not create
    DECLARE @anoLetivoID int
    SELECT @anoLetivoID=codigo FROM GestaoEscola.AnoLetivo WHERE (@dataInicio=dataInicio AND @dataFim=dataFim);
    IF (@@ROWCOUNT=0)
        BEGIN
        -- Give user feedback
        PRINT 'Ano Letivo: '+cast(@dataInicio as varchar)+' - '+cast(@dataFim as varchar)+' does not exist and is going to be created!'
        -- Get last GestaoEscola.AnoLetivo id
        SELECT @anoLetivoID=codigo FROM GestaoEscola.AnoLetivo ORDER BY codigo
        -- Add tuple to DB
        INSERT INTO GestaoEscola.AnoLetivo VALUES (@anoLetivoID + 1, @dataInicio,@dataFim)
        IF (@@ROWCOUNT=0)
            PRINT 'Error creating GestaoEscola.AnoLetivo tuple! Aborting...'
            SET @State = -1
            RETURN @State
        END
    ELSE
        BEGIN
        PRINT 'Ano Letivo: '+cast(@dataInicio as varchar)+' - '+cast(@dataFim as varchar)+' exists with id '+cast(@anoLetivoID as varchar)
        END

    -- Check if Turma already exists
    SELECT * FROM GestaoEscola.Turma WHERE nivel=@nivel AND nome=@nome AND anoLetivo=@anoLetivoID
    DECLARE @RowsAffected int = @@ROWCOUNT
    IF (@RowsAffected!=0 AND @Edit=0)
        BEGIN
            PRINT 'Error! There is already a Turma on GestaoEscola.Turma with that nivel, nome and ano letivo! Aborting...'
            SET @State = -1
            RETURN @State
        END
    IF (@RowsAffected!=1 AND @Edit=1)
        BEGIN
            PRINT 'Error! There is no Turma on GestaoEscola.Turma with that nivel, nome and ano letivo! The edit operation can not be accomplished! Aborting...'
            SET @State = -1
            RETURN @State
        END

    -- Create tuples on DB (with transction to allow rollback on error)
    BEGIN TRANSACTION 
        SAVE TRANSACTION SavepointTranBegin
        IF @Edit=0
            INSERT INTO GestaoEscola.AnoLetivo VALUES (@anoLetivoID,@dataInicio,@dataFim)
        ELSE
            UPDATE GestaoEscola.AnoLetivo SET dataInicio=@dataInicio, dataFim=@dataFim WHERE codigo=@anoLetivoID
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.AnoLetivo! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        IF @Edit=0
            INSERT INTO GestaoEscola.Turma VALUES (@nivel, @nome, @nmecDT, @anoLetivoID)
        ELSE
			UPDATE GestaoEscola.Turma SET diretorDeTurma=@nmecDT WHERE (nivel=@nivel AND nome=@nome AND anoLetivo=@anoLetivoID)
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Turma! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        -- Give user some feedback
        IF @Edit=0
            PRINT 'Sucess! Turma was added with success to the DB! (GestaoEscola.Turma and GestaoEscola.AnoLetivo)'
        ELSE
            PRINT 'Sucess! Turma data was updated with success to the DB! (GestaoEscola.Turma and GestaoEscola.AnoLetivo)'
    COMMIT

    RETURN @State 
END 