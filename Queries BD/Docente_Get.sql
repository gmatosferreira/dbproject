SELECT
   Pessoa.NMec,
   Pessoa.nome,
   Pessoa.telemovel,
   Funcionario.Salario,
   Docente.grupoDisciplinar,
   CONCAT(email, '@', dominio) AS emailComposed 
FROM
(( (GestaoEscola.Docente 
      JOIN
         GestaoEscola.Funcionario 
         ON Docente.NMec = Funcionario.PNMec) 
      JOIN
         GestaoEscola.Pessoa 
         ON Docente.NMec = Pessoa.NMec) 
      JOIN
         GestaoEscola.EmailDominio 
         ON Pessoa.emailDominio = EmailDominio.id
   )
