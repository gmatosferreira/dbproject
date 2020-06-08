SELECT Estudante.NMec, nome, telemovel, NomeEE, contactoEE, CONCAT(EmailEE, '@', dominio) AS EEemailComposed, CONCAT(email, '@', dominio) AS emailComposed 
FROM(
	(GestaoEscola.Estudante JOIN GestaoEscola.Pessoa ON Estudante.NMec = Pessoa.NMec) 
		JOIN GestaoEscola.EmailDominio ON Pessoa.emailDominio = EmailDominio.id)