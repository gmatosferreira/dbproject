-- Prevent INSERT operations on NDTrabalhaBloco
-- To validate if ND has already a job at ththe timespan of the new one
CREATE TRIGGER tr_NDTrabalhaBlocoInsert ON GestaoEscola.ND_trabalha_Bloco
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


    -- Validate new work shift
    DECLARE @TurnoValido INT
    SELECT @TurnoValido=GestaoEscola.NDFuncaoScheduleValid(@NMec, @HoraInicio, @HoraFim)
    
    -- 0 Error
    -- 1 Valid
    -- -1 Fora do turno principal
    -- -2 Colide com turno existente
    IF @TurnoValido=0
        RAISERROR ('Ocorreu um erro interno à base de dados.' ,16,1)
    IF @TurnoValido=-1
        RAISERROR ('O horário da nova função deve estar dentro do turno principal do funcionário!' ,16,1)
    IF @TurnoValido=-2
        RAISERROR ('O horário da nova função colide com o horário de outra função já atribuída!' ,16,1)


    IF @TurnoValido=1
    BEGIN
        PRINT 'Success, creating tuple ob db!'
        -- Add work shift (if no error was thrown before)
        INSERT INTO GestaoEscola.ND_trabalha_Bloco (Bcoordenadas, NMec, codFuncao, horaInicio, horaFim) VALUES (@BCoordenadas, @NMec, @CodFuncao, @HoraInicio, @HoraFim)
    END

END

DROP TRIGGER GestaoEscola.tr_NDTrabalhaBlocoInsert;

-- SEEE https://stackoverflow.com/a/31949874