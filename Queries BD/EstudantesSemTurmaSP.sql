CREATE PROCEDURE GestaoEscola.EstudantesSemTurmaSP AS
	BEGIN
		SELECT EstudanteST.NMec, nome FROM
			GestaoEscola.Pessoa JOIN 
			(SELECT NMec 
				FROM vw_Estudantes WHERE NomeEE IS NOT NULL 
					EXCEPT SELECT estudanteNMec FROM GestaoEscola.EstudanteTurma) AS EstudanteST ON Pessoa.NMec = EstudanteST.NMec
	END

-- DROP PROC GestaoEscola.EstudantesSemTurmaSP
-- EXEC GestaoEscola.EstudantesSemTurmaSP