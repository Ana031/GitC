CREATE TABLE [dbo].[Frequencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Matricula] INT NOT NULL, 
    [Dia] DATE NOT NULL DEFAULT GETDATE(), 
    [Presenca] BIT NOT NULL, 

)
