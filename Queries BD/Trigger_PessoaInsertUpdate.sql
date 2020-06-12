CREATE TRIGGER tr_PessoaInsertUpdate ON GestaoEscola.Pessoa
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    DECLARE @ERROR bit = 0

    -- Get arguments of command
    DECLARE @NMec int
    DECLARE @Nome varchar(65)
    DECLARE @Telemovel int
    DECLARE @Email varchar(64)
    DECLARE @EmailDom int

    SELECT 
        @NMec = NMec, 
        @Nome = nome, 
        @Telemovel = telemovel, 
        @Email = email,
        @EmailDom = emailDominio
        FROM INSERTED

    -- Check if PK are given
    if (@NMec IS NULL)
        BEGIN
            SET @ERROR = 1
            RAISERROR ('Falta a chave primária NMec' ,16,1)
        END

    -- Check if there is other Pessoa with same email or tel (this attrs must be unique)
    DECLARE @NMecEqual int = NULL
    SELECT @NMecEqual=NMec FROM GestaoEscola.Pessoa WHERE telemovel=@Telemovel

    IF (@NMecEqual IS NOT NULL)
        BEGIN
            IF (@NMecEqual!=@NMec)
                BEGIN
                    RAISERROR ('Já existe uma pessoa com o número de telemóvel fornecido!' ,16,1)
                    SET @ERROR = 1
                END
        END

    SET @NMecEqual = NULL
    SELECT @NMecEqual=NMec FROM GestaoEscola.Pessoa WHERE email=@Email

    IF (@NMecEqual IS NOT NULL)
        BEGIN
            IF (@NMecEqual!=@NMec)
                BEGIN
                    RAISERROR ('Já existe uma pessoa com o email fornecido!' ,16,1)
                    SET @ERROR = 1
                END
        END
    
    IF (@ERROR=0)
    BEGIN
        PRINT 'Validation success, creating tuple ob db!'
        
        -- Add to DB (if no error was thrown before)
        IF EXISTS(SELECT * FROM DELETED)
            BEGIN
                PRINT 'Operation is UPDATE'
                UPDATE GestaoEscola.Pessoa SET nome=@Nome, telemovel=@Telemovel, email=@Email, emailDominio=@EmailDom WHERE NMec=@NMec
            END
        ELSE
            BEGIN 
                PRINT 'Operation is INSERT'
                INSERT INTO GestaoEscola.Pessoa VALUES (@NMec, @Nome, @Telemovel, @Email, @EmailDom)
            END
    END

END

DROP TRIGGER GestaoEscola.tr_PessoaInsertUpdate;