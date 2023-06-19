
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2023 14:42:47
-- Generated from EDMX file: C:\Users\Fábio Cabaceira\PLSI_DA_PLTV-2213128\Cinegest\Cinegest\CineGestModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CineGest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteBilhete]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_ClienteBilhete];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionarioBilhete]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_FuncionarioBilhete];
GO
IF OBJECT_ID(N'[dbo].[FK_SessaoBilhete]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_SessaoBilhete];
GO
IF OBJECT_ID(N'[dbo].[FK_CinemaSala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salas] DROP CONSTRAINT [FK_CinemaSala];
GO
IF OBJECT_ID(N'[dbo].[FK_SessaoFilme]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessaos] DROP CONSTRAINT [FK_SessaoFilme];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmeCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Filmes] DROP CONSTRAINT [FK_FilmeCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Funcionario_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Funcionario] DROP CONSTRAINT [FK_Funcionario_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bilhetes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bilhetes];
GO
IF OBJECT_ID(N'[dbo].[Cinemas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cinemas];
GO
IF OBJECT_ID(N'[dbo].[Filmes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Filmes];
GO
IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Funcionario];
GO
IF OBJECT_ID(N'[dbo].[Salas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salas];
GO
IF OBJECT_ID(N'[dbo].[Sessaos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sessaos];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bilhetes'
CREATE TABLE [dbo].[Bilhetes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Lugar] int  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [SessaoId] int  NOT NULL,
    [FuncionarioId] int  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- Creating table 'Cinemas'
CREATE TABLE [dbo].[Cinemas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Filmes'
CREATE TABLE [dbo].[Filmes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Duracao] nvarchar(max)  NOT NULL,
    [Activo] nvarchar(max)  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [NumFiscal] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Funcionario'
CREATE TABLE [dbo].[Pessoas_Funcionario] (
    [Salario] int  NOT NULL,
    [Funcao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Salas'
CREATE TABLE [dbo].[Salas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Colunas] int  NOT NULL,
    [Filas] int  NOT NULL,
    [CinemaId] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sessaos'
CREATE TABLE [dbo].[Sessaos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SalaId] int  NOT NULL,
    [Datahora] datetime  NOT NULL,
    [Preco] int  NOT NULL,
    [Filme_Id] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Activa] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [PK_Bilhetes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cinemas'
ALTER TABLE [dbo].[Cinemas]
ADD CONSTRAINT [PK_Cinemas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [PK_Filmes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Funcionario'
ALTER TABLE [dbo].[Pessoas_Funcionario]
ADD CONSTRAINT [PK_Pessoas_Funcionario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Salas'
ALTER TABLE [dbo].[Salas]
ADD CONSTRAINT [PK_Salas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sessaos'
ALTER TABLE [dbo].[Sessaos]
ADD CONSTRAINT [PK_Sessaos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_ClienteBilhete]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteBilhete'
CREATE INDEX [IX_FK_ClienteBilhete]
ON [dbo].[Bilhetes]
    ([ClienteId]);
GO

-- Creating foreign key on [FuncionarioId] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_FuncionarioBilhete]
    FOREIGN KEY ([FuncionarioId])
    REFERENCES [dbo].[Pessoas_Funcionario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioBilhete'
CREATE INDEX [IX_FK_FuncionarioBilhete]
ON [dbo].[Bilhetes]
    ([FuncionarioId]);
GO

-- Creating foreign key on [SessaoId] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_SessaoBilhete]
    FOREIGN KEY ([SessaoId])
    REFERENCES [dbo].[Sessaos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessaoBilhete'
CREATE INDEX [IX_FK_SessaoBilhete]
ON [dbo].[Bilhetes]
    ([SessaoId]);
GO

-- Creating foreign key on [CinemaId] in table 'Salas'
ALTER TABLE [dbo].[Salas]
ADD CONSTRAINT [FK_CinemaSala]
    FOREIGN KEY ([CinemaId])
    REFERENCES [dbo].[Cinemas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CinemaSala'
CREATE INDEX [IX_FK_CinemaSala]
ON [dbo].[Salas]
    ([CinemaId]);
GO

-- Creating foreign key on [Filme_Id] in table 'Sessaos'
ALTER TABLE [dbo].[Sessaos]
ADD CONSTRAINT [FK_SessaoFilme]
    FOREIGN KEY ([Filme_Id])
    REFERENCES [dbo].[Filmes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessaoFilme'
CREATE INDEX [IX_FK_SessaoFilme]
ON [dbo].[Sessaos]
    ([Filme_Id]);
GO

-- Creating foreign key on [CategoriaId] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [FK_FilmeCategoria]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmeCategoria'
CREATE INDEX [IX_FK_FilmeCategoria]
ON [dbo].[Filmes]
    ([CategoriaId]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Funcionario'
ALTER TABLE [dbo].[Pessoas_Funcionario]
ADD CONSTRAINT [FK_Funcionario_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Categorias
INSERT INTO [dbo].[Categorias] ([Nome], [Activa])
VALUES ('Comédia', 'Sim'),
       ('Sci_fi', 'Sim'),
       ('Terror', 'Sim'),       
       ('Romance', 'Sim'),
       ('Acção', 'Sim'),
       ('Thriller', 'Sim'),
       ('Drama', 'Sim'),       
       ('Mistério', 'Sim'),
       ('Crime', 'Sim'),
       ('Aventura', 'Sim'),
       ('Fantasia', 'Sim'), 
       ('Animação', 'Sim');


-- Pessoas
INSERT INTO [dbo].[Pessoas] ([Nome], [Morada])
VALUES ('João Silva', 'Rua A'),
       ('Marta Oliveira', 'Rua B'),
       ('Pedro Santos', 'Rua C'),
       ('Cliente Anónimo', 'Rua D'),
       ('Mateus Leandro', 'Rua E'),
       ('Luis Matos', 'Rua F');

-- Pessoas_Funcionario
INSERT INTO [dbo].[Pessoas_Funcionario] ([Salario], [Funcao], [Id])
VALUES ('1000', 'Bilheteira', 1),
       ('1200', 'Gerente', 2),
       ('900', 'Limpeza', 3);

-- Pessoas_Cliente
INSERT INTO [dbo].[Pessoas_Cliente] ([NumFiscal], [Id])
VALUES ('999999999', 4),
       ('987654321', 5),
       ('654321987', 6);


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------