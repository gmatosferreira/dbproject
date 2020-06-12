-- Prevent DELETE operations on Docente
CREATE TRIGGER tr_NaoDocentesDelete ON GestaoEscola.NaoDocente
INSTEAD OF DELETE
AS
BEGIN

    DECLARE @ERROR int = 0

    -- Get NMec from Docente to DELETE
    DECLARE @NM int 
    SELECT @NM=NMec FROM DELETED
    PRINT 'Trigger INTEAD OF DELETE operation on GestaoEscola.NaoDocente started for '

    -- Check if ND supervises any block or library
    SELECT * FROM GestaoEscola.Biblioteca WHERE supervisor=@NM
    IF (@@ROWCOUNT!=0)
        BEGIN
            RAISERROR ('O funcionário não pode ser eliminado enquanto for supervisor de uma biblioteca!' ,16,1)
            SET @ERROR = 1
        END

    SELECT * FROM GestaoEscola.Bloco WHERE supervisor=@NM
    IF (@@ROWCOUNT!=0)
        BEGIN
            RAISERROR ('O funcionário não pode ser eliminado enquanto for supervisor de um bloco!' ,16,1)
            SET @ERROR = 1
        END


    -- Set personal data to NULL on GestaoEscola.Pessoa
    -- All the extra data must be kept for administrative porpuses
    IF (@ERROR=0)
        UPDATE GestaoEscola.Pessoa SET nome=NULL, telemovel=NULL, email=NULL, emailDominio=null WHERE NMec=@NM
END

DROP TRIGGER GestaoEscola.tr_NaoDocentesDelete;

DELETE FROM GestaoEscola.Docente WHERE NMec=1234

-- SEEE https://stackoverflow.com/a/31949874
