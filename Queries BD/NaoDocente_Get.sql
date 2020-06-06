SELECT
   Pessoa.NMec,
   Pessoa.nome,
   Pessoa.telemovel,
   Funcionario.Salario,
   NaoDocente.turno,
   CONCAT(email, '@', dominio) AS emailComposed 
FROM
((
(GestaoEscola.NaoDocente 
      JOIN
         GestaoEscola.Funcionario 
         ON NaoDocente.NMec = Funcionario.PNMec) 
      JOIN
         GestaoEscola.Pessoa 
         ON NaoDocente.NMec = Pessoa.NMec)
	  JOIN
		 GestaoEscola.EmailDominio
		 ON Pessoa.emailDominio = EmailDominio.id
   )