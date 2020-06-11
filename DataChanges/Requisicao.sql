-- Added attr livroIDInterno (because of Livro changes) and entregue
CREATE TABLE GestaoEscola.Requisicao(
	livro					    VARCHAR(17),
	biblioteca					VARCHAR(20),
	livroIDInterno				int,
	pessoaNMec  				INT,
	dataRequisicao				DATE			NOT NULL,
	dataEntrega					DATE			NOT NULL,
	entregue					BIT				DEFAULT 0,
	PRIMARY KEY(biblioteca, livro, livroIDInterno,dataRequisicao,pessoaNMec),
	FOREIGN KEY(livro, biblioteca, livroIDInterno) REFERENCES GestaoEscola.Livro(ISBN, biblioteca, IDInterno),
	FOREIGN KEY(pessoaNMec)	    REFERENCES GestaoEscola.Pessoa(NMec),
	CHECK(dataEntrega > dataRequisicao) 
);

INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'700-9-905-96340-9','Ler e Aprender',3001,'2016-02-18','2016-11-18');
--INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'943-1-016-43798-3','Escola do Saber',3002,'2006-01-17','2012-02-18');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'558-2-808-23512-6','Vem Descobrir',3003,'2017-03-17','2017-09-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'046-0-602-37643-0','Mentes com Poder',3004,'2006-08-16','2006-09-16');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'391-9-113-47853-6','Ler e Aprender',3005,'2005-05-18','2005-11-18');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'102-5-854-62301-5','Escola do Saber',3006,'2010-12-17','2010-12-30');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'180-9-656-99900-9','Mentes com Poder',2571,'2005-05-17','2005-08-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'804-6-141-18698-3','Vem Descobrir',3008,'2013-04-17','2013-12-19');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'845-9-004-39765-5','Mentes com Poder',3009,'2011-03-17','2011-11-17');
--INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'237-5-308-43633-4','Ler e Aprender',3010,'2019-06-17','2019-10-18');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'798-7-402-41216-8','Vem Descobrir',3011,'2018-06-18','2018-07-19');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'596-1-890-64061-8','Escola do Saber',2231,'2015-03-17','2015-07-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'009-9-101-33178-2','Vem Descobrir',3013,'2011-01-19','2011-03-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'549-0-804-85927-1','Ler e Aprender',3014,'2010-04-16','2010-08-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'372-1-926-65193-5','Escola do Saber',3015,'2017-04-19','2017-05-17');
--INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'297-0-898-38338-8','Mentes com Poder',3016,'2017-09-18','2017-11-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'545-3-190-54484-5','Vem Descobrir',2262,'2019-01-16','2019-08-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'649-6-099-82887-9','Mentes com Poder',3018,'2010-03-17','2010-05-17');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'962-8-342-32508-7','Escola do Saber',2049,'2009-02-16','2009-04-18');
INSERT INTO GestaoEscola.Requisicao(livroIDInterno,livro,biblioteca,pessoaNMec,dataRequisicao,dataEntrega) VALUES(1,'221-2-455-13050-2','Ler e Aprender',3020,'2017-06-18','2017-07-18');