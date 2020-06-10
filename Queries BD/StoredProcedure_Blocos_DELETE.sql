-- https://stackoverflow.com/a/7994065

-- Preventd EXCEPTIONS on DELETE operations on Turnos due to FK restrictions
ALTER PROCEDURE pr_BlocosDELETE @Coordenadas varchar(40), @Feedback varchar(4000) OUTPUT
AS
BEGIN
    SET @Feedback = 'OK'
    DECLARE @State int = 1

    BEGIN TRY
        DELETE FROM GestaoEscola.Bloco WHERE coordenadas = @Coordenadas
    END TRY
    BEGIN CATCH
        SELECT @Feedback=ERROR_MESSAGE()
        SET @State = -1
    END CATCH

    PRINT @Feedback
    RETURN @State
END

-- Usage
