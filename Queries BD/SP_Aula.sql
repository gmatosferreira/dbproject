-- SP to INSERT OR UPDATE Aula
ALTER PROCEDURE GestaoEscola.AulaSP @sala int, @horaI time(7), @horaF time(7), @diaS int, @disciplina varchar(30), @docente int, @nomeT varchar(5),@Edit bit
AS BEGIN

    DECLARE @State int = 1

    -- Validate arguments
    IF (@sala IS NULL OR @horaI IS NULL OR @horaF IS NULL OR @diaS IS NULL OR @disciplina IS NULL OR @docente IS NULL OR @nomeT IS NULL OR @Edit IS NULL)
        BEGIN
            PRINT 'Error! There is already a tuple on GestaoEscola.Aula with that values! Aborting...'
            SET @State = -1
            RETURN @State
        END

    -- Check if aula already exists
    SELECT * FROM GestaoEscola.Aula WHERE (sala=@sala AND horaFim=@horaF AND horaInicio=@horaI)
    DECLARE @RowsAffected int = @@ROWCOUNT
    IF (@RowsAffected!=0 AND @Edit=0)
        BEGIN
            PRINT 'Error! There is already a tuple on GestaoEscola.Aula with that values! Aborting...'
            SET @State = -1
            RETURN @State
        END
    IF (@RowsAffected!=1 AND @Edit=1)
        BEGIN
            PRINT 'Error! There is no tuple on GestaoEscola.Aula with that values! The edit operation can not be accomplished! Aborting...'
            SET @State = -1
            RETURN @State
        END
    
    -- get disciplina id
	DECLARE @disciplinaID int
    SELECT @disciplinaID=codigo FROM GestaoEscola.Disciplina WHERE nome=@disciplina;
    PRINT 'Disciplina '+@disciplina+' exists with id '+cast(@disciplinaID as varchar)

	 -- get turma
    DECLARE @nivel int
	DECLARE @DT int
	DECLARE @anoLetivoID int;
    SELECT @nivel=nivel, @DT=diretorDeTurma, @anoLetivoID=anoLetivo FROM GestaoEscola.Turma WHERE nome=@nomeT
    PRINT 'Turma '+@nomeT+' values saved'

    -- Create tuples on DB (with transction to allow rollback on error)
    BEGIN TRANSACTION 
        SAVE TRANSACTION SavepointTranBegin
        IF @Edit=0
            INSERT INTO GestaoEscola.Aula VALUES (@sala,@horaI,@horaF,@diaS,@disciplinaID,@docente,@nomeT,@nivel,@anoLetivoID)
        ELSE
            UPDATE GestaoEscola.Aula SET diaSemana=@diaS, disciplina=@disciplinaID, docente=@docente, nomeTurma=@nomeT,nivelTurma=@nivel,anoLetivo=@anoLetivoID WHERE (sala=@sala AND horaFim=@horaF AND horaInicio=@horaI)
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Aula! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END

        -- Give user some feedback
        IF @Edit=0
            PRINT 'Sucess! Aula was added with success to the DB! (GestaoEscola.Aula)'
        ELSE
            PRINT 'Sucess! Aula data was updated with success to the DB! (GestaoEscola.Aula)'
    COMMIT

    RETURN @State
END 