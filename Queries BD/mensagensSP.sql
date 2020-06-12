-- SP to INSERT OR UPDATE Estudantes
CREATE PROCEDURE GestaoEscola.mensagensSP @docenteNmec int, @assunto varchar(30), @mensagem text, @nomeT varchar(5), @nivelT int, @ano int, @NmecEst int, @dataA date, @hora time(7), @dataR datetime , @Recado bit
AS
BEGIN

    DECLARE @State int = 1

    -- Validate arguments
    IF (@docenteNmec IS NULL OR @assunto IS NULL OR @mensagem IS NULL OR @nomeT IS NULL OR @nivelT IS NULL OR @ano IS NULL OR @NmecEst IS NULL OR @dataA IS NULL OR @hora IS NULL OR @dataR IS NULL OR @Recado IS NULL)
        BEGIN
            PRINT 'Error! Aborting...'
            SET @State = -1
            RETURN @State
        END

	BEGIN TRANSACTION 
    SAVE TRANSACTION SavepointTranBegin
	IF @Recado=0 -- anuncio
		BEGIN
	    -- Check if anuncio already exists
		SELECT * FROM GestaoEscola.Anuncio WHERE turmaNivel=@nivelT AND turmaNome=@nomeT AND anoLetivo=@ano AND docente=@docenteNmec AND [data]=@dataA AND hora=@hora
		DECLARE @RowsAffected int = @@ROWCOUNT
		IF (@RowsAffected!=0)
			BEGIN
				PRINT 'Error! There is already a tuple on GestaoEscola.Anuncio with that values! Aborting...'
				SET @State = -1
				RETURN @State
			END
		ELSE
			BEGIN
				INSERT INTO GestaoEscola.Anuncio VALUES(@nivelT,@nomeT,@ano,@dataA,@hora,@docenteNmec,@assunto,@mensagem)
				IF (@@ROWCOUNT!=1)
				BEGIN
					PRINT 'Error! There was an error creating tuple on GestaoEscola.Anuncio! Aborting...'
					SET @State = -1
					ROLLBACK TRAN SavepointTranBegin
				END
			END
	END
	IF @Recado=1 -- recado
		BEGIN
	    -- Check if recado already exists
		SELECT * FROM GestaoEscola.Recado WHERE docenteNMEC=@docenteNmec AND [data]=@dataR AND estudanteNMec=@NmecEst AND assunto=@assunto
		SET @RowsAffected = @@ROWCOUNT
		IF (@RowsAffected!=0)
			BEGIN
				PRINT 'Error! There is already a tuple on GestaoEscola.Recado with that values! Aborting...'
				SET @State = -1
				RETURN @State
			END
		ELSE
			BEGIN
				INSERT INTO GestaoEscola.Recado VALUES(@NMecEst,@docenteNmec,@dataR,@assunto,@mensagem)
				IF (@@ROWCOUNT!=1)
				BEGIN
					PRINT 'Error! There was an error creating tuple on GestaoEscola.Recado! Aborting...'
					SET @State = -1
					ROLLBACK TRAN SavepointTranBegin
				END
			END
	END

        IF @Recado=1
            PRINT 'Sucess creating Recado! '
        ELSE
            PRINT 'Sucess creating Anuncio!'
    COMMIT

    RETURN @State 
END 