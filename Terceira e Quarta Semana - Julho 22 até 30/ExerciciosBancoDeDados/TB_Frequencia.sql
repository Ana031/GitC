CREATE TABLE [dbo].[Frequencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Matricula] INT NOT NULL, 
    [Presenca1] BIT NOT NULL, 
    [Presenca2] BIT NOT NULL, 
    [Presenca3] BIT NOT NULL, 
    [Presenca4] BIT NOT NULL,
)
