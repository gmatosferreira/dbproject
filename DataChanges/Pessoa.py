import random

#Get domains data
dominios=[]
#Read one domain foreach line
counterDominios = 0
with open("EmailDominio.txt", "r") as f:
    line = f.readline()
    while line:
        dominios.append(line.strip())
        line = f.readline()
        counterDominios += 1

counter = 0
with open("Pessoa_GenerateData.sql", "r") as f:
    line = f.readline()
    while line:
        tuples = line.split("(")[2::] #Tuples
        command = "INSERT INTO GestaoEscola.Pessoa (NMec,nome,telemovel,email,emailDominio) VALUES "
        for tuple in tuples:
            counter += 1
            attrs = tuple.split("@")[0]+"'"
            dominioIndex = random.randint(1,counterDominios)
            command += f"({attrs},{dominioIndex}),"
        print(command[:-1]+";")
        line = f.readline()


print(f"\n-- {counter} tuples!")