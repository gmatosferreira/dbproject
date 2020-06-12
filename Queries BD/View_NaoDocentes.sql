ALTER VIEW vw_NaoDocentes 
AS 
SELECT
   Pessoa.NMec,
   Pessoa.nome,
   Pessoa.telemovel,
   Funcionario.Salario,
   NaoDocente.turno,
   CONCAT(email, '@', dominio) AS emailComposed 
FROM
   (
( (GestaoEscola.NaoDocente 
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
WHERE Pessoa.nome IS NOT NULL AND Pessoa.email IS NOT NULL AND Pessoa.telemovel IS NOT NULL