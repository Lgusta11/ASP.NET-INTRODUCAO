create table Artistas(
        Id INT PRIMARY KEY IDENTITY(1,1),
        Nome NVARCHAR(255) NOT NULL,
        Bio NVARCHAR(255) NOT NULL,
        FotoPerfil NVARCHAR(255) NOT NULL
);