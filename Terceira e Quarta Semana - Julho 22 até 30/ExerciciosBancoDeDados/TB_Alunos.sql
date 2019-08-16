CREATE TABLE [dbo].[Alunos] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Matricula] INT           NOT NULL,
    [Nome]      VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 

    
);

