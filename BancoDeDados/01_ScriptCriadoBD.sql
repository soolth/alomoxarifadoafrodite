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
GO
CREATE TABLE PRODUTO(
  Codigo int identity(1,1) primary key,
  Descricao varchar(100) not null,
  UnidadeMedida varchar(100) not null,
  EstoqueAtual FLOAT(2) DEFAULT '0.00',
  Epermanente bit DEFAULT 0,
  CodigoCategoria int not null
)
go

ALTER TABLE PRODUTO
ADD FOREIGN KEY  (CodigoCategoria) REFERENCES CATEGORIA(Codigo);