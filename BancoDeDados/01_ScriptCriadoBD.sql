--DROP DATABASE dbAlmoxarifado
GO
CREATE DATABASE dbAlmoxarifado
GO
USE dbAlmoxarifado
GO

---Categoria
CREATE TABLE CATEGORIA (
  Codigo int identity(1,1) primary key,
  Descricao varchar(100) not null
)

