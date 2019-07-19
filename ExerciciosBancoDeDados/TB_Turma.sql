CREATE TABLE [dbo].[Turma] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Turma]      VARCHAR (100)  NOT NULL,
    [Observacao] VARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

