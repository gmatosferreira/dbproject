CREATE TRIGGER GestaoEscola.TriggerNumSala on GestaoEscola.Sala
INSTEAD OF INSERT AS BEGIN
IF (SELECT count(*) FROM inserted) = 1
	BEGIN
 		DECLARE @numSala int;
		DECLARE @Bcoord varchar(40);
	
		SELECT @numSala=numero, @Bcoord=SalaCoord FROM INSERTED
		IF EXISTS(SELECT numero FROM GestaoEscola.Sala WHERE @numSala=numero)
					RAISERROR ('Este número de sala já existe!',16,1); 
		ELSE
			BEGIN
				INSERT INTO GestaoEscola.Sala VALUES (@numSala, @Bcoord);
			END
	END
END

--drop trigger GestaoEscola.TriggerNumSala