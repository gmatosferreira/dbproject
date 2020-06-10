-- SP to INSERT OR UPDATE Estudantes
ALTER PROCEDURE GestaoEscola.EstudanteSP @NMec int, @Nome varchar(65), @Telemovel int, @Email varchar(64), @EmailDominio varchar(255), @NomeEE varchar(65), @TelemovelEE int, @EmailEE varchar(64), @EmailDominioEE varchar(255), @Edit bit
AS
BEGIN

    DECLARE @State int = 1

    -- Validate arguments
    IF (@NMec IS NULL OR @Nome IS NULL OR @Telemovel IS NULL OR @Email IS NULL OR @EmailDominio IS NULL OR @NomeEE IS NULL OR @TelemovelEE IS NULL OR @EmailEE IS NULL OR @EmailDominioEE IS NULL OR @Edit IS NULL)
        BEGIN
            PRINT 'Error! There is already a tuple on GestaoEscola.Pessoa with that NMec! Aborting...'
            SET @State = -1
            RETURN @State
        END

    -- Check if NMec already exists
    SELECT * FROM GestaoEscola.Pessoa WHERE NMec=@NMec
    DECLARE @RowsAffected int = @@ROWCOUNT
    IF (@RowsAffected!=0 AND @Edit=0)
        BEGIN
            PRINT 'Error! There is already a tuple on GestaoEscola.Pessoa with that NMec! Aborting...'
            SET @State = -1
            RETURN @State
        END
    IF (@RowsAffected!=1 AND @Edit=1)
        BEGIN
            PRINT 'Error! There is no tuple on GestaoEscola.Pessoa with that NMec! The edit operation can not be accomplished! Aborting...'
            SET @State = -1
            RETURN @State
        END
    
    -- Check if @EmailDominio exists on the DB, if not create it
    DECLARE @EmailDominioID int
    SELECT @EmailDominioID=id FROM GestaoEscola.EmailDominio WHERE dominio=@EmailDominio;
    IF (@@ROWCOUNT=0)
        BEGIN
        -- Give user feedback
        PRINT 'EmailDominio '+@EmailDominio+' does not exist and is going to be created!'
        -- Get last GestaoEscola.EmailDominio id
        SELECT @EmailDominioID=id FROM GestaoEscola.EmailDominio ORDER BY id
        -- Add tuple to DB
        INSERT INTO GestaoEscola.EmailDominio VALUES (@EmailDominioID + 1, @EmailDominio)
        IF (@@ROWCOUNT=0)
            PRINT 'Error creating GestaoEscola.EmailDomio tuple! Aborting...'
            SET @State = -1
            RETURN @State
        END
    ELSE
        BEGIN
        PRINT 'EmailDominio '+@EmailDominio+' exists with id '+cast(@EmailDominioID as varchar)
        END

	-- Check if @EmailDominio_EE exists on the DB, if not create it
    DECLARE @EmailDominioID_EE int
    SELECT @EmailDominioID_EE=id FROM GestaoEscola.EmailDominio WHERE dominio=@EmailDominioEE;
    IF (@@ROWCOUNT=0)
        BEGIN
        -- Give user feedback
        PRINT 'EmailDominio '+@EmailDominioEE+' does not exist and is going to be created!'
        -- Get last GestaoEscola.EmailDominio id
        SELECT @EmailDominioID_EE=id FROM GestaoEscola.EmailDominio ORDER BY id
        -- Add tuple to DB
        INSERT INTO GestaoEscola.EmailDominio VALUES (@EmailDominioID_EE + 1, @EmailDominioEE)
        IF (@@ROWCOUNT=0)
            PRINT 'Error creating GestaoEscola.EmailDomio tuple! Aborting...'
            SET @State = -1
            RETURN @State
        END
    ELSE
        BEGIN
        PRINT 'EmailDominio '+@EmailDominioEE+' exists with id '+cast(@EmailDominioID_EE as varchar)
        END

    -- Create tuples on DB (with transction to allow rollback on error)
    BEGIN TRANSACTION 
        SAVE TRANSACTION SavepointTranBegin
        IF @Edit=0
            INSERT INTO GestaoEscola.Pessoa VALUES (@NMec, @Nome, @Telemovel, @Email, @EmailDominioID)
        ELSE
            UPDATE GestaoEscola.Pessoa SET nome=@Nome, telemovel=@Telemovel, email=@Email, emailDominio=@EmailDominioID WHERE NMec=@NMec
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Pessoa! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        IF @Edit=0
            INSERT INTO GestaoEscola.Estudante VALUES (@NMec, @NomeEE, @TelemovelEE, @EmailEE, @EmailDominioID_EE)
        ELSE
            UPDATE GestaoEscola.Estudante SET NomeEE=@NomeEE, contactoEE=@TelemovelEE, EmailEE=@EmailEE, emailDominioEE=@EmailDominioID_EE WHERE Estudante.NMec=@NMec
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Pessoa! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        -- Give user some feedback
        IF @Edit=0
            PRINT 'Sucess! Estudante was added with success to the DB! (GestaoEscola.Pessoa and GestaoEscola.Estudante)'
        ELSE
            PRINT 'Sucess! Estudante data was updated with success to the DB! (GestaoEscola.Pessoa and GestaoEscola.Estudante)'
    COMMIT

    RETURN @State 
END 