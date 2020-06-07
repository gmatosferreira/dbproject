import random

salaries = [630, 750, 990, 1200]

salario = 0

with open("Turno.sql", "r") as f:
    line = f.readline()
    counterTuple = counterLine = 0
    while line:
        counterLine += 1
        tuples = line.split("(")[2::] #Tuples
        id = tuples[0].split(",")[0]
        #salario = salario+1 if salario+1 < 3 else 0 9
        horaInicio = 7+counterLine if 7+counterLine<=12 else 99
        horaFim = 14+counterLine if 7+counterLine<=19 else 99
        if (horaInicio<99):
            command = f"UPDATE GestaoEscola.Turno SET horaInicio='{horaInicio:02d}:00:00', horaFim='{horaFim:02d}:00:00' WHERE codigo={id};"
        else:
            command = f"DELETE FROM GestaoEscola.Turno WHERE codigo={id};"
        print(command)
        line = f.readline()
    print(f"\n-- {counterLine} lines processed, resulting in {counterTuple} tuples!")