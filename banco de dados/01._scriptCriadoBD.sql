--DROP DATEBASE bdAlmoxarifado
GO
CREATE DATABASE bdAlmoxarifado
GO

--Categoria 
CREATE TABLE CATEGORIA (
codigo int identity (1,1) primary key,
Descri�ao varchar (100) not null 
)
