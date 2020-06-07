import random

salaries = [630, 750, 990, 1200]

salario = 0

with open("NaoDocente.sql", "r") as f:
    line = f.readline()
    counterTuple = counterLine = 0
    while line:
        counterLine += 1
        tuples = line.split("(")[2::] #Tuples
        id = tuples[0].split(",")[0]
        turno = counterLine%5+1
        command = f"UPDATE GestaoEscola.NaoDocente SET turno={turno} WHERE NMec={id};"
        print(command)
        line = f.readline()
    print(f"\n-- {counterLine} lines processed, resulting in {counterTuple} tuples!")