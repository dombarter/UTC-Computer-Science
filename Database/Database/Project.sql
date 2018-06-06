CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [InvoiceID] INT NOT NULL, 
    [ProjectDescription] VARCHAR(MAX) NOT NULL DEFAULT (''), 
    [StartDate] DATETIME NOT NULL, 
    [FinishDate] DATETIME NOT NULL, 
    [ManDays] VARCHAR(MAX) NOT NULL, 
    [Cost] MONEY NOT NULL
)
