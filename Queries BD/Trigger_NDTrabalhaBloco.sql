-- Prevent INSERT operations on NDTrabalhaBloco
-- To validate if ND has already a job at ththe timespan of the new one
CREATE TRIGGER tr_NDTrabalhaBloco ON GestaoEscola.ND_trabalha_Bloco
INSTEAD OF INSERT
AS
BEGIN
    -- Get arguments of command
    DECLARE @BCoordenadas varchar(40)
    DECLARE @NMec int
    DECLARE @CodFuncao int
    DECLARE @HoraInicio time
    DECLARE @HoraFim time 
    SELECT @BCoordenadas=Bcoordenadas, @NMec=NMec, @CodFuncao=codFuncao, @HoraInicio=horaInicio, @HoraFim=horaFim FROM INSERTED

    -- Check if starting is smaller than finishing time
    if (@HoraFim<=@HoraInicio)
        RAISERROR ('A hora de início deve ser menor que a de fim!' ,16,1)

    -- Get employee main shift
    DECLARE @MainTurnoHoraInicio time = null
    DECLARE @MainTurnoHoraFim time = null
    SELECT @MainTurnoHoraInicio = horaInicio, @MainTurnoHoraFim = horaFim
        FROM 
            ( 
                GestaoEscola.NaoDocente JOIN GestaoEscola.Turno 
                ON NaoDocente.turno = Turno.codigo
            )
        WHERE NMec=@NMec
    IF (@MainTurnoHoraInicio IS NULL OR @MainTurnoHoraFim IS NULL)
        RAISERROR ('Ocorreu um erro na busca do turno do não docente' ,16,1)

    -- Check that new work shift is inside main shift
    IF (@MainTurnoHoraInicio>@HoraInicio OR @MainTurnoHoraFim<@HoraFim)
        RAISERROR ('O horário da nova função deve estar dentro do turno principal do funcionário!' ,16,1)
        

    -- Check if there is another work shift inside that schedule
    DECLARE @FuncaoAtribuidaHoraInicio time
    DECLARE @FuncaoAtribuidaHoraFim time

    DECLARE funcoesAtribuidas CURSOR FOR SELECT horaInicio, horaFim FROM GestaoEscola.ND_trabalha_Bloco WHERE NMec=@NMec
    OPEN funcoesAtribuidas

    FETCH funcoesAtribuidas INTO @FuncaoAtribuidaHoraInicio, @FuncaoAtribuidaHoraFim
    
    WHILE (@@fetch_status=0)
        BEGIN
            IF NOT(@FuncaoAtribuidaHoraInicio>=@HoraFim OR @FuncaoAtribuidaHoraFim<=@HoraInicio)
                RAISERROR ('O horário da nova função colide com o horário de outra função já atribuída!' ,16,1)
            FETCH funcoesAtribuidas INTO @FuncaoAtribuidaHoraInicio, @FuncaoAtribuidaHoraFim
        END

    CLOSE funcoesAtribuidas
    DEALLOCATE funcoesAtribuidas

    PRINT 'Success, creating tuple ob db!'
    -- Add work shift (if no error was thrown before)
    INSERT INTO GestaoEscola.ND_trabalha_Bloco (Bcoordenadas, NMec, codFuncao, horaInicio, horaFim) VALUES (@BCoordenadas, @NMec, @CodFuncao, @HoraInicio, @HoraFim)

END

DROP TRIGGER GestaoEscola.tr_NDTrabalhaBloco;

-- SEEE https://stackoverflow.com/a/31949874