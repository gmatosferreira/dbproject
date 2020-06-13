-- Prevent DELETE operations on Estudantes
ALTER TRIGGER GestaoEscola.EstudantesDeleteTrigger ON GestaoEscola.Estudante
INSTEAD OF DELETE
AS
BEGIN
    -- Get NMec from Estudante to DELETE
    DECLARE @NM int 
    SELECT @NM=NMec FROM DELETED
    PRINT 'Trigger INTEAD OF DELETE operation on GestaoEscola.Estudante started for '
    -- Set personal data to NULL on GestaoEscola.Pessoa
    -- All the extra data must be kept for administrative porpuses
    UPDATE GestaoEscola.Pessoa SET nome=NULL, telemovel=NULL, email=NULL, emailDominio=null WHERE NMec=@NM
	UPDATE GestaoEscola.Estudante SET nomeEE=NULL, contactoEE=NULL, emailEE=NULL, emailDominioEE=null WHERE NMec=@NM
END
