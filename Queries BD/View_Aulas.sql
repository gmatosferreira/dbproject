ALTER VIEW vw_Aulas
AS 
SELECT sala, horaInicio,horaFim,diaSemana,docente,nomeTurma,nivelTurma,Aula.anoLetivo,diretorDeTurma,Disciplina.nome AS disciplina, Pessoa.nome as nomeDT
	FROM GestaoEscola.Aula JOIN (GestaoEscola.Turma JOIN GestaoEscola.Pessoa ON NMec=diretorDeTurma) ON nomeTurma=Turma.nome JOIN GestaoEscola.Disciplina ON disciplina=codigo WHERE telemovel IS NOT NULL
