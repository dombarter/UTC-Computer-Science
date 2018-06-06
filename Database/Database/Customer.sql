CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NOT NULL, 
    [HouseNumber] VARCHAR(MAX) NOT NULL DEFAULT  (''), 
    [HouseName] VARCHAR(MAX) NOT NULL DEFAULT (''), 
    [HouseStreet] VARCHAR(MAX) NOT NULL, 
    [Town] VARCHAR(MAX) NOT NULL, 
    [Postcode] VARCHAR(MAX) NOT NULL
)
