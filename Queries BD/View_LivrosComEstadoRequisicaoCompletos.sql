
-- Segunda view 
ALTER VIEW vw_LivrosComEstadoCompletos
AS 
SELECT 
	Livro.ISBN,
	Livro.IDInterno,
	Livro.biblioteca,
	Livro.titulo,
	Livro.anoEdicao,
	Livro.autores,
	Livro.editora,
	vw_LivrosComEstadoSimples.estado
FROM 
(
	vw_LivrosComEstadoSimples JOIN GestaoEscola.Livro
		ON 
			vw_LivrosComEstadoSimples.ISBN=Livro.ISBN 
			AND vw_LivrosComEstadoSimples.biblioteca=Livro.biblioteca
			AND vw_LivrosComEstadoSimples.IDInterno = Livro.IDInterno
)