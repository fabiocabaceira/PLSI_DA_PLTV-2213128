
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/04/2023 21:42:30
-- Generated from EDMX file: C:\Users\fabio\PLSI_DA_PLTV-2213128\Cinegest\Cinegest\CineGest.edmx
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

IF OBJECT_ID(N'[dbo].[FK_BilheteSessão]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_BilheteSessão];
GO
IF OBJECT_ID(N'[dbo].[FK_CinemaSala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salas] DROP CONSTRAINT [FK_CinemaSala];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteBilhete]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_ClienteBilhete];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmeCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Filmes] DROP CONSTRAINT [FK_FilmeCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_Funcionario_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Funcionario] DROP CONSTRAINT [FK_Funcionario_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionarioBilhete]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_FuncionarioBilhete];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaSessão]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessão] DROP CONSTRAINT [FK_SalaSessão];
GO
IF OBJECT_ID(N'[dbo].[FK_SessãoFilme]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessão] DROP CONSTRAINT [FK_SessãoFilme];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bilhetes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bilhetes];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
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
IF OBJECT_ID(N'[dbo].[Sessão]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sessão];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bilhetes'
CREATE TABLE [dbo].[Bilhetes] (
    [IdBilhete] int IDENTITY(1,1) NOT NULL,
    [Lugar] int  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [FuncionarioIdPessoa] int  NOT NULL,
    [ClienteIdPessoa] int  NOT NULL,
    [SessãoIdSessao] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Activa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cinemas'
CREATE TABLE [dbo].[Cinemas] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Filmes'
CREATE TABLE [dbo].[Filmes] (
    [IdFilme] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Duracao] nvarchar(max)  NOT NULL,
    [Activo] nvarchar(max)  NOT NULL,
    [Categoria_IdCategoria] int  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [NumFiscal] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Funcionario'
CREATE TABLE [dbo].[Pessoas_Funcionario] (
    [Salario] int  NOT NULL,
    [Funcao] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Salas'
CREATE TABLE [dbo].[Salas] (
    [IdSala] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Colunas] nvarchar(max)  NOT NULL,
    [Filas] nvarchar(max)  NOT NULL,
    [SessãoIdSessao] int  NOT NULL,
    [CinemaIdPessoa] int  NULL
);
GO

-- Creating table 'Sessão'
CREATE TABLE [dbo].[Sessão] (
    [IdSessao] int IDENTITY(1,1) NOT NULL,
    [DataHora] datetime  NOT NULL,
    [Preco] int  NOT NULL,
    [SalaIdSala] int  NOT NULL,
    [Filme_IdFilme] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdBilhete] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [PK_Bilhetes]
    PRIMARY KEY CLUSTERED ([IdBilhete] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Cinemas'
ALTER TABLE [dbo].[Cinemas]
ADD CONSTRAINT [PK_Cinemas]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdFilme] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [PK_Filmes]
    PRIMARY KEY CLUSTERED ([IdFilme] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoas_Funcionario'
ALTER TABLE [dbo].[Pessoas_Funcionario]
ADD CONSTRAINT [PK_Pessoas_Funcionario]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdSala] in table 'Salas'
ALTER TABLE [dbo].[Salas]
ADD CONSTRAINT [PK_Salas]
    PRIMARY KEY CLUSTERED ([IdSala] ASC);
GO

-- Creating primary key on [IdSessao] in table 'Sessão'
ALTER TABLE [dbo].[Sessão]
ADD CONSTRAINT [PK_Sessão]
    PRIMARY KEY CLUSTERED ([IdSessao] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SessãoIdSessao] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_BilheteSessão]
    FOREIGN KEY ([SessãoIdSessao])
    REFERENCES [dbo].[Sessão]
        ([IdSessao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BilheteSessão'
CREATE INDEX [IX_FK_BilheteSessão]
ON [dbo].[Bilhetes]
    ([SessãoIdSessao]);
GO

-- Creating foreign key on [ClienteIdPessoa] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_ClienteBilhete]
    FOREIGN KEY ([ClienteIdPessoa])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteBilhete'
CREATE INDEX [IX_FK_ClienteBilhete]
ON [dbo].[Bilhetes]
    ([ClienteIdPessoa]);
GO

-- Creating foreign key on [FuncionarioIdPessoa] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_FuncionarioBilhete]
    FOREIGN KEY ([FuncionarioIdPessoa])
    REFERENCES [dbo].[Pessoas_Funcionario]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioBilhete'
CREATE INDEX [IX_FK_FuncionarioBilhete]
ON [dbo].[Bilhetes]
    ([FuncionarioIdPessoa]);
GO

-- Creating foreign key on [Categoria_IdCategoria] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [FK_FilmeCategoria]
    FOREIGN KEY ([Categoria_IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmeCategoria'
CREATE INDEX [IX_FK_FilmeCategoria]
ON [dbo].[Filmes]
    ([Categoria_IdCategoria]);
GO

-- Creating foreign key on [CinemaIdPessoa] in table 'Salas'
ALTER TABLE [dbo].[Salas]
ADD CONSTRAINT [FK_CinemaSala]
    FOREIGN KEY ([CinemaIdPessoa])
    REFERENCES [dbo].[Cinemas]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CinemaSala'
CREATE INDEX [IX_FK_CinemaSala]
ON [dbo].[Salas]
    ([CinemaIdPessoa]);
GO

-- Creating foreign key on [Filme_IdFilme] in table 'Sessão'
ALTER TABLE [dbo].[Sessão]
ADD CONSTRAINT [FK_SessãoFilme]
    FOREIGN KEY ([Filme_IdFilme])
    REFERENCES [dbo].[Filmes]
        ([IdFilme])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessãoFilme'
CREATE INDEX [IX_FK_SessãoFilme]
ON [dbo].[Sessão]
    ([Filme_IdFilme]);
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoas_Funcionario'
ALTER TABLE [dbo].[Pessoas_Funcionario]
ADD CONSTRAINT [FK_Funcionario_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoas]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SalaIdSala] in table 'Sessão'
ALTER TABLE [dbo].[Sessão]
ADD CONSTRAINT [FK_SalaSessão]
    FOREIGN KEY ([SalaIdSala])
    REFERENCES [dbo].[Salas]
        ([IdSala])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaSessão'
CREATE INDEX [IX_FK_SalaSessão]
ON [dbo].[Sessão]
    ([SalaIdSala]);
GO

-- Cinemas
INSERT INTO [dbo].[Cinemas] ([Nome], [Email], [Morada])
VALUES ('Cinema 1', 'cinema1@example.com', '123 Main Street'),
       ('Cinema 2', 'cinema2@example.com', '456 Elm Street'),
       ('Cinema 3', 'cinema3@example.com', '789 Oak Street');

-- Salas
INSERT INTO [dbo].[Salas] ([Nome], [Colunas], [Filas], [SessãoIdSessao], [CinemaIdPessoa])
VALUES ('Sala 1', '10', '8', 1, 1),
       ('Sala 2', '12', '10', 2, 1),
       ('Sala 3', '15', '12', 3, 2);

-- Categorias
INSERT INTO [dbo].[Categorias] ([Nome], [Activa])
VALUES ('Ação', 'Sim'),
       ('Comédia', 'Sim'),
       ('Drama', 'Não');

-- Filmes
INSERT INTO [dbo].[Filmes] ([Nome], [Duracao], [Activo], [Categoria_IdCategoria])
VALUES ('Filme 1', '120', 'Sim', 1),
       ('Filme 2', '90', 'Não', 2),
       ('Filme 3', '105', 'Sim', 3);

-- Sessão
INSERT INTO [dbo].[Sessão] ([DataHora], [Preco], [SalaIdSala], [Filme_IdFilme])
VALUES ('2023-06-2 10:00:00', '10', 1, 1),
       ('2023-06-2 12:00:00', '12', 2, 2),
       ('2023-06-2 14:00:00', '8', 3, 3);

-- Pessoas
INSERT INTO [dbo].[Pessoas] ([Nome], [Morada])
VALUES ('João Silva', 'Rua A'),
       ('Marta Oliveira', 'Rua B'),
       ('Pedro Santos', 'Rua C'),
       ('Pedro Miguel', 'Rua D'),
       ('Mateus Leandro', 'Rua E'),
       ('Luis Matos', 'Rua F');

-- Pessoas_Funcionario
INSERT INTO [dbo].[Pessoas_Funcionario] ([Salario], [Funcao], [IdPessoa])
VALUES ('1000', 'Bilheteira', 1),
       ('1200', 'Gerente', 2),
       ('900', 'Limpeza', 3);

-- Pessoas_Cliente
INSERT INTO [dbo].[Pessoas_Cliente] ([NumFiscal], [IdPessoa])
VALUES ('123456789', 4),
       ('987654321', 5),
       ('654321987', 6);

-- Bilhetes
INSERT INTO [dbo].[Bilhetes] ([Lugar], [Estado], [FuncionarioIdPessoa], [ClienteIdPessoa], [SessãoIdSessao])
VALUES ('1', 'Vendido', 1, 4, 1),
       ('2', 'Vendido', 2, 5, 2),
       ('3', 'Disponível', 3, 6, 3);
-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------