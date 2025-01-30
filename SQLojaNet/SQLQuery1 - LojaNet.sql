--CREATE DATABASE LojaNetDb
--GO

--USE LojaNetDb
--GO

--CREATE TABLE Cliente(
--	Id varchar(50) PRIMARY KEY,
--	Nome varchar(100),
--	Email varchar(100),
--	Telefone varchar(100)
--)
--GO

/*
CREATE PROCEDURE ClienteIncluir(
@Id varchar(50),
@Nome varchar(100),
@Email varchar(100),
@Telefone varchar(100)
)
as 

INSERT INTO Cliente(Id, Nome, Email, Telefone)
	VALUES(@Id, @Nome, @Email, @Telefone)
GO


CREATE PROCEDURE ClienteListar

AS

SELECT Id, Nome, Email, telefone 
FROM Cliente

*/

CREATE PROCEDURE ClienteExcluir

	@Id	VARCHAR(50)

AS

DELETE FROM Cliente WHERE Id = @Id