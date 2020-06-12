CREATE TRIGGER GestaoEscola.TriggerDisciplina on GestaoEscola.Disciplina
INSTEAD OF INSERT AS BEGIN
IF (SELECT count(*) FROM inserted) = 1
	BEGIN
 		DECLARE @disciplinaID int;
		DECLARE @nome varchar(30);
		DECLARE @grupoDisc int;
	
		SELECT @nome=nome,@grupoDisc=grupoDisciplinar FROM INSERTED
		IF EXISTS(SELECT nome FROM GestaoEscola.Disciplina WHERE nome=@nome)
					RAISERROR ('Esta disciplina já existe!',16,1); 
		ELSE
			BEGIN
				SELECT @disciplinaID=codigo FROM GestaoEscola.Disciplina ORDER BY codigo
				INSERT INTO GestaoEscola.Disciplina VALUES (@disciplinaID+1, @nome, @grupoDisc);
			END
	END
END


