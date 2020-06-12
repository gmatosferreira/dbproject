-- SP to INSERT OR UPDATE NaoDocente
ALTER PROCEDURE pr_NaoDocentes @NMec int, @Nome varchar(65), @Telemovel int, @Email varchar(64), @EmailDominio varchar(255), @Salario money, @Turno int, @Edit bit
AS
BEGIN

    DECLARE @State int = 1

    -- Validate arguments
    IF (@NMec IS NULL OR @Nome IS NULL OR @Telemovel IS NULL OR @Email IS NULL OR @EmailDominio IS NULL OR @Salario IS NULL OR @Turno IS NULL OR @Edit IS NULL)
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
            SET @State = -2
            RETURN @State
        END
    IF (@RowsAffected!=1 AND @Edit=1)
        BEGIN
            PRINT 'Error! There is no tuple on GestaoEscola.Pessoa with that NMec! The edit operation can not be accomplished! Aborting...'
            SET @State = -2
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
            SET @State = -3
            RETURN @State
        END
    ELSE
        BEGIN
        PRINT 'EmailDominio '+@EmailDominio+' exists with id '+cast(@EmailDominioID as varchar)
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
            SET @State = -4
            ROLLBACK TRAN SavepointTranBegin
            END
        IF @Edit=0
            INSERT INTO GestaoEscola.Funcionario VALUES (@NMec, @Salario)
        ELSE
            UPDATE GestaoEscola.Funcionario SET salario=@Salario WHERE PNMec=@NMec
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Funcionario! Aborting...'
            SET @State = -4
            ROLLBACK TRAN SavepointTranBegin
            END
        IF @Edit=0
            INSERT INTO GestaoEscola.NaoDocente VALUES (@NMec, @Turno)
        ELSE
            UPDATE GestaoEscola.NaoDocente SET turno=@Turno WHERE NMec=@NMec
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.NaoDocente! Aborting...'
            SET @State = -4
            ROLLBACK TRAN SavepointTranBegin
            END
        -- Give user some feedback
        IF @Edit=0
            PRINT 'Sucess! NaoDocente was added with success to the DB! (GestaoEscola.Pessoa, GestaoEscola.Funcionario and GestaoEscola.NaoDocente)'
        ELSE
            PRINT 'Sucess! NaoDocente data was updated with success to the DB! (GestaoEscola.Pessoa, GestaoEscola.Funcionario and GestaoEscola.NaoDocente)'
    COMMIT

    RETURN @State 

END 
    


-- Usage (first already created, throws error)
EXEC pr_NaoDocentes @NMec=941, @Nome='Carlos Cardoso', @Telemovel=923658741, @Email='carlos', @EmailDominio='sapo.pt', @Salario=1200, @Turno=1, @Edit=0;



-- C# https://stackoverflow.com/a/6210055