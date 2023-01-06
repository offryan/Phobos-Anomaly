PhobosAnomaly_BANCO
CREATE DATABASE PhobosAnomaly;
USE PhobosAnomaly;

CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    [NomeUsuario] NVARCHAR (50) NOT NULL,
    [CpfUsuario] NVARCHAR (14) UNIQUE NOT NULL,
    [SenhaUsuario] NVARCHAR (6) NOT NULL,
    [DataNascUsuario] NVARCHAR (10) NOT NULL,
    [TipoUsuario]INT NOT NULL,
	
   FOREIGN KEY (TipoUsuario) REFERENCES TipoUsuario(IdTipoUsuario)
);

CREATE TABLE [dbo].[TipoUsuario]
(
    [IdTipoUsuario] INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    [DescricaoTipoUsuario] NVARCHAR(13) NOT NULL 

);




--INSERT
INSERT INTO [TipoUsuario] VALUES('Administrador');
INSERT INTO [TipoUsuario] VALUES('Outros');

INSERT INTO Usuario VALUES('Cerjio','444.444.444-44','444444','23/06/1900',1);

SELECT * FROM [Usuario];

SELECT * FROM [TipoUsuario];
SELECT IdUsuario,NomeUsuario,CpfUsuario,SenhaUsuario,DataNascUsuario,DescricaoTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario=IdTipoUsuario;
SELECT NomeUsuario,SenhaUsuario FROM USUARIO;

CREATE TABLE [dbo].[Filme] (
    [IdFilme]    INT  PRIMARY KEY IDENTITY (1,1) NOT NULL,
    [TituloFilme] NVARCHAR (50) NOT NULL,
    [GeneroFilme] NVARCHAR (50) NOT NULL,
    [ProdutoraFilme] NVARCHAR (50) NOT NULL,
    [UrlImgFilme] NVARCHAR (MAX) NOT NULL,
    [ClassificacaoFilme]INT NOT NULL,
	
   FOREIGN KEY (ClassificacaoFilme) REFERENCES Classificacao(IdClassificacao)
);

CREATE TABLE [dbo].[Classificacao]
(
    [IdClassificacao] INT  PRIMARY KEY IDENTITY (1,1) NOT NULL,
    [DescricaoClassificacao] NVARCHAR(5) NOT NULL 
    
   
);

--INSERT
INSERT INTO [Classificacao] VALUES('+18');
INSERT INTO [Classificacao] VALUES('Livre');


INSERT INTO Filme VALUES('Incapazes','Terror','Mondo Inverso','~/Imagens/Img3.jpeg',1);

SELECT * FROM Filme;
SELECT IdFilme,TituloFilme,GeneroFilme,ProdutoraFilme,UrlImgFilme,DescricaoClassificacao 
FROM Filme JOIN Classificacao ON ClassificacaoFilme=IdClassificacao;

UPDATE Filme SET UrlImgFilme = '~/Imagens/Img3.jpg'  WHERE IdFilme=3;

