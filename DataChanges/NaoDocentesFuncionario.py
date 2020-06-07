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
        salario = salario+1 if salario+1 < 3 else 0 
        command = f"INSERT INTO GestaoEscola.Funcionario (PNMec,salario) VALUES ({id}, {salaries[salario]})"
        print(command)
        line = f.readline()
    print(f"\n-- {counterLine} lines processed, resulting in {counterTuple} tuples!")