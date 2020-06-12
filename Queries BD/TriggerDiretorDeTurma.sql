CREATE TRIGGER GestaoEscola.TriggerDiretorDeTurma on GestaoEscola.Turma
INSTEAD OF INSERT,UPDATE AS BEGIN
IF (SELECT count(*) FROM inserted) = 1
	BEGIN
 		DECLARE @nivelT int;
		DECLARE @nomeT varchar(5);
		DECLARE @diretorTurma int;
		DECLARE @ano int;
	
		SELECT @nivelT=nivel, @nomeT=nome, @diretorTurma=diretorDeTurma, @ano=anoLetivo FROM INSERTED
		IF EXISTS(SELECT diretorDeTurma FROM GestaoEscola.Turma WHERE diretorDeTurma=@diretorTurma)
					RAISERROR ('Este docente já é diretor de uma turma!',16,1); 
		ELSE
			BEGIN
				IF EXISTS(SELECT * FROM INSERTED) AND EXISTS(SELECT * FROM DELETED) -- update
					UPDATE GestaoEscola.Turma SET diretorDeTurma = @diretorTurma WHERE (nivel = @nivelT AND nome = @nomeT AND anoLetivo = @ano);
				IF EXISTS(SELECT * FROM INSERTED) AND NOT EXISTS(SELECT * FROM DELETED) -- insert
					INSERT INTO GestaoEscola.Turma VALUES (@nivelT, @nomeT,@diretorTurma, @ano);
			END
	END
END
--drop trigger GestaoEscola.TriggerDiretorDeTurma





