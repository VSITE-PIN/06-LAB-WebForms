CREATE TABLE [dbo].[Users](
  [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  [UserName] NVARCHAR(50) NOT NULL,
  [Password] NVARCHAR(50) NOT NULL,
  [FullName] NVARCHAR(50) NOT NULL
);

CREATE TABLE dbo.Products (
  Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Name NVARCHAR(50) NOT NULL,
  Description NVARCHAR(150) NOT NULL
);

INSERT INTO dbo.Products (Name, Description) VALUES
('Pasta', 'Pasta za zube'),
('Kupka', 'Kupka za kadu'),
('Kruh', 'Bijeli kruh'),
('Tost', 'Preprženi kruh');
