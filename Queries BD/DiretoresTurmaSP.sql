CREATE PROCEDURE GestaoEscola.DiretoresTurmaSP AS
	BEGIN
		SELECT Docente.NMec, Pessoa.nome 
		FROM (GestaoEscola.Turma RIGHT JOIN (GestaoEscola.Pessoa RIGHT JOIN GestaoEscola.Docente ON Pessoa.NMec = Docente.NMec ) ON diretorDeTurma = Pessoa.NMec) 
		WHERE diretorDeTurma IS NULL AND Pessoa.telemovel IS NOT NULL
	END

--DROP PROC GestaoEscola.DiretoresTurmaSP

-- EXEC GestaoEscola.DiretoresTurmaSP
