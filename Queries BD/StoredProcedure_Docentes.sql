-- To edit change CREATE for ALTER
ALTER PROCEDURE pr_Docentes @NMec int, @Nome varchar(65), @Telemovel int, @Email varchar(64), @EmailDominio varchar(255), @Salario int, @GrupoDisciplinar int
AS
BEGIN

    DECLARE @State int = 1

    -- Validate arguments
    -- Check if NMec already exists
    SELECT * FROM GestaoEscola.Pessoa WHERE NMec=@NMec
    IF (@@ROWCOUNT!=0)
        BEGIN
            PRINT 'Error! There is already a tuple on GestaoEscola.Pessoa with that NMec! Aborting...'
            SET @State = -1
            RETURN @State
        END
    -- TODO Check if any variable given is null! 

    -- Check if @EmailDominio exists on the DB
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

    -- Create tuples on DB (with transction to allow rollback on error)
    BEGIN TRANSACTION 
        SAVE TRANSACTION SavepointTranBegin
        INSERT INTO GestaoEscola.Pessoa VALUES (@NMec, @Nome, @Telemovel, @Email, @EmailDominioID)
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Pessoa! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        INSERT INTO GestaoEscola.Funcionario VALUES (@Nmec, @Salario)
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Pessoa! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        INSERT INTO GestaoEscola.Docente VALUES (@NMec, @GrupoDisciplinar)
        IF (@@ROWCOUNT!=1)
            BEGIN
            PRINT 'Error! There was an error creating tuple on GestaoEscola.Pessoa! Aborting...'
            SET @State = -1
            ROLLBACK TRAN SavepointTranBegin
            END
        -- Give user some feedback
        PRINT 'Sucess! Docente was added with success to the DB! (GestaoEscola.Pessoa, GestaoEscola.Funcionario and GestaoEscola.Docente)'
    COMMIT

    RETURN @State 

END 
    


-- Usage (first already created, throws error)
EXEC pr_Docentes @NMec=1234, @Nome='Gonçalo Matos', @Telemovel=927395705, @Email='gmatos.ferreira', @EmailDominio='sapo.pt', @Salario=1200, @GrupoDisciplinar=2;
EXEC pr_Docentes @NMec=1235, @Nome='Maria Inês', @Telemovel=938462618, @Email='maria.ines', @EmailDominio='ua.pt', @Salario=1200, @GrupoDisciplinar=2;


-- C#
-- https://stackoverflow.com/a/6210055
using (SqlConnection conn = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI")) {
    conn.Open();

    // 1.  create a command object identifying the stored procedure
    SqlCommand cmd  = new SqlCommand("CustOrderHist", conn);

    // 2. set the command object so it knows to execute a stored procedure
    cmd.CommandType = CommandType.StoredProcedure;

    // 3. add parameter to command, which will be passed to the stored procedure
    cmd.Parameters.Add(new SqlParameter("@CustomerID", custId));

    // execute the command
    using (SqlDataReader rdr = cmd.ExecuteReader()) {
        // iterate through results, printing each to console
        while (rdr.Read())
        {
            Console.WriteLine("Product: {0,-35} Total: {1,2}",rdr["ProductName"],rdr["Total"]);
        }
    }
}