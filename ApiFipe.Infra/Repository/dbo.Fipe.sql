CREATE TABLE [dbo].[Fipe]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Marca] VARCHAR(200) NULL, 
    [Modelo] VARCHAR(200) NULL, 
    [Ano] VARCHAR(10) NULL, 
    [Preco] MONEY NULL, 
    [PrecoVenda] MONEY NULL, 
    [Codigo] INT NULL
)
