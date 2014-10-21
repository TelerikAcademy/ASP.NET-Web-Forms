USE [master]
GO

CREATE DATABASE [CountriesDB]
GO

USE [CountriesDB]
GO

CREATE TABLE [Countries](
	[CountryID] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL
)
GO

SET IDENTITY_INSERT [Countries] ON
INSERT [Countries] ([CountryID], [Name]) VALUES (1, N'Bulgaria')
INSERT [Countries] ([CountryID], [Name]) VALUES (2, N'United States')
INSERT [Countries] ([CountryID], [Name]) VALUES (3, N'France')
SET IDENTITY_INSERT [Countries] OFF

CREATE TABLE [Towns](
	[TownID] [int] IDENTITY NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL
)
GO

SET IDENTITY_INSERT [Towns] ON
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (1, N'Sofia', 1)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (2, N'Varna', 1)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (3, N'Plovdiv', 1)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (4, N'Seattle', 2)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (6, N'Los Angeles', 2)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (7, N'New York', 2)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (8, N'Paris', 3)
INSERT [Towns] ([TownID], [Name], [CountryID]) VALUES (9, N'Lion', 3)
SET IDENTITY_INSERT [Towns] OFF

ALTER TABLE [Towns] ADD CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryID])
REFERENCES [Countries] ([CountryID])
GO
