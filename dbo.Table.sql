CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NOT NULL,
	[Surname] NCHAR(20) NOT NULL, 
    [Province] NCHAR(10) NOT NULL,
	[PostalCode] INT NOT NULL,
	[Email] NCHAR(20) NOT NULL
)
