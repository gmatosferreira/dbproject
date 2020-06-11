-- Get dados do livro c/ info se está ou não requisitado
ALTER VIEW vw_LivrosComEstadoSimples 
AS 
SELECT
	Livro.ISBN, 
	Livro.biblioteca,
	Livro.IDInterno,
	COUNT(NULLIF(Requisicao.entregue, 0))-COUNT(Requisicao.entregue) as estado
	-- estado=-1 para emprestado
	-- estado=0 para disponível
FROM 
(
	GestaoEscola.Livro LEFT JOIN GestaoEscola.Requisicao
	ON Livro.ISBN = Requisicao.livro
	AND Livro.biblioteca = Requisicao.biblioteca
	AND Livro.IDInterno = Requisicao.livroIDInterno
)
GROUP BY 
	Livro.ISBN, 
	Livro.biblioteca,
	Livro.IDInterno,
	CAST(Livro.autores as VARCHAR(100))
