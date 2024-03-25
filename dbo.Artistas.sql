CREATE TABLE [dbo].[Artistas] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (MAX) NULL,
    [FotoPerfil] NVARCHAR (MAX) NULL,
    [Bio]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Artistas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

