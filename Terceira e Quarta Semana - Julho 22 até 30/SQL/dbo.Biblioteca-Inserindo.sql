CREATE TABLE [dbo].[Biblioteca] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Cep]    VARCHAR(8)    NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATE          NOT NULL,
    [DatAlt] DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

