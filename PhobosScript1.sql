Phobos_BANCO

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
INSERT INTO Classificacao VALUES('Livre');
INSERT INTO Classificacao VALUES('+14');
INSERT INTO Classificacao VALUES('+18');


SELECT * FROM Usuario;
SELECT IdUsuario,NomeUsuario,CpfUsuario,SenhaUsuario,DataNascUsuario,DescricaoTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario=IdTipoUsuario;

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