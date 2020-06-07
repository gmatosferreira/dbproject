-- Obter os salários dos funcionários associado ao seu nome e contacto 
SELECT NMec, nome, telemovel, salario
FROM (
	GestaoEscola.Funcionario JOIN GestaoEscola.Pessoa
		ON Funcionario.PNMec=Pessoa.NMec
)

-- Consultar os dados de contacto de cada funcionário (email completo - com domínio)
SELECT NMec, nome, telemovel, CONCAT(email,'@',dominio) AS email
FROM (
	GestaoEscola.Pessoa JOIN GestaoEscola.EmailDominio
		ON Pessoa.emailDominio=EmailDominio.id
)