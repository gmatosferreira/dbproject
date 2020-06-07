import random

dominios = []
"""
with open("Pessoa.sql", "r") as f:
    line = f.readline()
    while line:
        tuples = line.split("(")[2::] #Tuples
        for tuple in tuples:
            dominio = tuple.split("@")[1].split("'")[0]
            if dominio not in dominios:
                dominios.append(dominio)
        line = f.readline()
"""

#Read one domain foreach line
with open("EmailDominio.txt", "r") as f:
    line = f.readline()
    while line:
        dominios.append(line.strip())
        line = f.readline()

command = "INSERT INTO GestaoEscola.EmailDominio (id,dominio) VALUES "
counter = 0
for dominio in dominios:
    counter += 1
    command += f"({counter}, '{dominio}'),"
print(command[:-1]+";")

print(f"\n-- {counter} distinct domains!")
