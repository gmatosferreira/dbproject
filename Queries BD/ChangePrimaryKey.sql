-- 1st Get constraints table and get PK constraint name
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE TABLE_NAME = 'ND_trabalha_Bloco'

-- 2nd Remove coinstraint whose name was gotten on the last step 
ALTER TABLE GestaoEscola.ND_trabalha_Bloco DROP CONSTRAINT PK__ND_traba__1CC54E887BCCAD6D

-- 3rd Create new constraint with new PK
ALTER TABLE GestaoEscola.ND_trabalha_Bloco ADD CONSTRAINT pk_ndtrabalhabloco PRIMARY KEY (NMec, horaInicio)

-- Source: https://stackoverflow.com/questions/8844324/change-primary-key-column-in-sql-server