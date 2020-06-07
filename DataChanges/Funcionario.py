import random

salaries = [630, 750, 990, 1200]

with open("Pessoa_GenerateData.sql", "r") as f:
    line = f.readline()
    counterTuple = counterLine = 0
    while line:
        counterLine += 1
        tuples = line.split("(")[2::] #Tuples
        command = "INSERT INTO GestaoEscola.Funcionario (PNMec,salario) VALUES "
        for tuple in tuples:
            counterTuple += 1
            nmec = tuple.split(",")[0]
            salaryIndex = random.randint(0, 3)
            command += f"({nmec}, {salaries[salaryIndex]}),"
        print(command[:-1]+";")
        line = f.readline()
    print(f"\n-- {counterLine} lines processed, resulting in {counterTuple} tuples!")