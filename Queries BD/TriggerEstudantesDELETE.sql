-- Prevent DELETE operations on Docente
CREATE TRIGGER EstudantesDeleteTrigger ON GestaoEscola.Estudante
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
END

-- DROP TRIGGER GestaoEscola.EstudantesDeleteTrigger;