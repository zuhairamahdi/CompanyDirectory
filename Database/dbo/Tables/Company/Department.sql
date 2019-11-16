CREATE TABLE [dbo].[Department]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(MAX) NULL, 
    [Created] DATETIME NULL, 
    [Updated] DATETIME NULL 
)
