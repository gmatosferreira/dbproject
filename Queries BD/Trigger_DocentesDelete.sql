-- Prevent DELETE operations on Docente
CREATE TRIGGER tr_DocentesDelete ON GestaoEscola.Docente
INSTEAD OF DELETE
AS
BEGIN
    -- Get NMec from Docente to DELETE
    DECLARE @NM int 
    SELECT @NM=NMec FROM DELETED
    PRINT 'Trigger INTEAD OF DELETE operation on GestaoEscola.Docente started for '
    -- Set personal data to NULL on GestaoEscola.Pessoa
    -- All the extra data must be kept for administrative porpuses
    UPDATE GestaoEscola.Pessoa SET nome=NULL, telemovel=NULL, email=NULL, emailDominio=null WHERE NMec=@NM
END

DROP TRIGGER GestaoEscola.tr_DocentesDelete;

DELETE FROM GestaoEscola.Docente WHERE NMec=1234

-- SEEE https://stackoverflow.com/a/31949874
