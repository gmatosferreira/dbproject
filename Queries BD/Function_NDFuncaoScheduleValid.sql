
-- Returns
-- 0 Error
-- 1 Valid
-- -1 Fora do turno principal
-- -2 Colide com turno existente
CREATE FUNCTION GestaoEscola.NDFuncaoScheduleValid(@NMec int, @HoraInicio time, @HoraFim time) RETURNS int
AS
BEGIN

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
        BEGIN
            RETURN 0
        END

    -- Check that new work shift is inside main shift
    IF (@MainTurnoHoraInicio>@HoraInicio OR @MainTurnoHoraFim<@HoraFim)
        BEGIN
            RETURN -1
        END
        

    -- Check if there is another work shift inside that schedule
    DECLARE @FuncaoAtribuidaHoraInicio time
    DECLARE @FuncaoAtribuidaHoraFim time

    DECLARE funcoesAtribuidas CURSOR FOR SELECT horaInicio, horaFim FROM GestaoEscola.ND_trabalha_Bloco WHERE NMec=@NMec
    OPEN funcoesAtribuidas

    FETCH funcoesAtribuidas INTO @FuncaoAtribuidaHoraInicio, @FuncaoAtribuidaHoraFim
    
    WHILE (@@fetch_status=0)
        BEGIN
            IF NOT(@FuncaoAtribuidaHoraInicio>=@HoraFim OR @FuncaoAtribuidaHoraFim<=@HoraInicio)
                RETURN -2
            FETCH funcoesAtribuidas INTO @FuncaoAtribuidaHoraInicio, @FuncaoAtribuidaHoraFim
        END

    CLOSE funcoesAtribuidas
    DEALLOCATE funcoesAtribuidas

    -- Same for shifts at Biblioteca
    DECLARE funcoesAtribuidasBiblioteca CURSOR FOR SELECT horaInicio, horaFim FROM GestaoEscola.ND_trabalha_Biblioteca WHERE NMec=@NMec
    OPEN funcoesAtribuidasBiblioteca

    FETCH funcoesAtribuidasBiblioteca INTO @FuncaoAtribuidaHoraInicio, @FuncaoAtribuidaHoraFim
    
    WHILE (@@fetch_status=0)
        BEGIN
            IF NOT(@FuncaoAtribuidaHoraInicio>=@HoraFim OR @FuncaoAtribuidaHoraFim<=@HoraInicio)
                RETURN -2
            FETCH funcoesAtribuidasBiblioteca INTO @FuncaoAtribuidaHoraInicio, @FuncaoAtribuidaHoraFim
        END

    CLOSE funcoesAtribuidasBiblioteca
    DEALLOCATE funcoesAtribuidasBiblioteca

    RETURN 1

END