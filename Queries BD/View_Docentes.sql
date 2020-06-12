ALTER VIEW vw_Docentes 
AS 
SELECT
   Pessoa.NMec,
   Pessoa.nome,
   Pessoa.telemovel,
   Funcionario.Salario,
   Docente.grupoDisciplinar,
   CONCAT(email, '@', dominio) AS emailComposed 
FROM
   (
( (GestaoEscola.Docente 
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
WHERE Pessoa.nome IS NOT NULL AND Pessoa.email IS NOT NULL AND Pessoa.telemovel IS NOT NULL