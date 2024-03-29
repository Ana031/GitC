﻿CREATE TABLE [dbo].[LivroAutor]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Livro] INT NOT NULL, 
    [Autor] INT NOT NULL, 

    CONSTRAINT [FK_LivroAutor_Livro] 
	FOREIGN KEY ([Livro]) 
	REFERENCES [Livro]([Id]), 

    CONSTRAINT [FK_LivroAutor_Autores] 
	FOREIGN KEY ([Autor]) 
	REFERENCES [Autores]([Id])
)
