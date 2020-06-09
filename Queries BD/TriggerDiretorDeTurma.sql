--select * from GestaoEscola.Turma;
--select * from GestaoEscola.Docente;

CREATE TRIGGER GestaoEscola.TriggerDiretorDeTurma on GestaoEscola.Turma
AFTER INSERT,UPDATE AS
BEGIN
	IF EXISTS(SELECT diretorDeTurma FROM GestaoEscola.Turma WHERE diretorDeTurma IS NOT NULL)
			BEGIN
				RAISERROR ('Este docente já é diretor de uma turma!',16,1); 
				ROLLBACK TRAN;                                               
			END
END









