-- Created attr IDInterno
CREATE TABLE GestaoEscola.Livro(
	ISBN						VARCHAR(17)			NOT NULL,
	biblioteca					VARCHAR(20)			NOT NULL,
	IDInterno					INT					NOT NULL,
	titulo						VARCHAR(40)			NOT NULL,
	autores						TEXT				NOT NULL,
	anoEdicao					INT,
	editora						VARCHAR(30),
	PRIMARY KEY(ISBN, biblioteca, IDInterno),
	FOREIGN KEY(biblioteca)		REFERENCES GestaoEscola.Biblioteca(nome)
);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Porto Editora','700-9-905-96340-9','Cura','Terry Moses, Arnold Winter, Finch Kylie','Ler e Aprender',2009);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Ace Books,','943-1-016-43798-3','Day 51','Lancaster Wade, Booth Morgan, Willis Andrew','Escola do Saber',2002);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Angel City Press','558-2-808-23512-6','Angel you','Lyons Isabelle, Downs Macon, Lindsay Audrey','Vem Descobrir',2010);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Arbor House','046-0-602-37643-0','Never death','Crane Kitra, Warner Mariam, Franco Diana','Mentes com Poder',2009);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Art Book','391-9-113-47853-6','Miss You','Stone Illiana, Frank Xandra, Tucker Lunea','Ler e Aprender',2004);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Editions Atlas','102-5-854-62301-5','Catch me if you can','Mckay Aline, Wilson Nicholas, Travis Kai','Escola do Saber',2018);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Fearless Books','180-9-656-99900-9','Loose Weigth','Stanton Oliver, Lester Ray, Lloyd Faith','Mentes com Poder',2010);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Baker Book House','804-6-141-18698-3','Fame','Hensley Cole, Robertson Violet, Lynn Vernon','Vem Descobrir',2002);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Harlequin','845-9-004-39765-5','Escape','Quinn Ulysses, Chase Levi, Mccullough Fitzgerald','Mentes com Poder',2004);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'LittleBook Press','237-5-308-43633-4','El odio','Kaufman Cody, Hayes Julie, Key Claire','Ler e Aprender',2007);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Fearless Books','798-7-402-41216-8','The day after','Nunez Abel, Witt Shelley, Weeks Evelyn','Vem Descobrir',2001);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Phoenix Press','596-1-890-64061-8','Physics','Bond Yvette, Dotson Orli, Woods Maisie','Escola do Saber',2008);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'LittleBook Press','009-9-101-33178-2','Vivin la Vida','Mcguire Xanthus, Rosario Dominic, Contreras Dakota','Vem Descobrir',2016);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Harlequin','549-0-804-85927-1','Informatics','Obrien Hashim, Jefferson Walker, Jefferson Rashad','Ler e Aprender',2009);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Editions Atlas','372-1-926-65193-5','Food for you','Atkins Althea, Bryant Elmo, Mullins Kamal','Escola do Saber',2004);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Baker Book House','297-0-898-38338-8','I bet','Johnston Bradley, Flynn Dakota, Aguirre Jin','Mentes com Poder',2011);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Art Book','545-3-190-54484-5','Dark','Baldwin Alisa, Mcintyre Henry, Hull Alexis','Vem Descobrir',2019);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Ace Books','649-6-099-82887-9','Elit','York Leandra, Case Luke, Acevedo Lee','Mentes com Poder',2000);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Porto Editora','962-8-342-32508-7','Ao Luar','Dillon Fiona, Vega Brock, Rivera Gregory','Escola do Saber',2016);
INSERT INTO GestaoEscola.Livro(IDInterno,editora,ISBN,titulo,autores,biblioteca,anoEdicao) VALUES(1,'Arbor House','221-2-455-13050-2','Wrong direction','Rhodes Eve, Gould Elliott, Larson Veronica','Ler e Aprender',2002);