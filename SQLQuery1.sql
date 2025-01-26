CREATE DATABASE WebFormsLabos;
GO
CREATE TABLE [dbo].[Users](
[Id] [int] IDENTITY(1,1) NOT NULL,
[UserName] [nvarchar](50) NOT NULL,
[Password] [nvarchar](50) NOT NULL,
[FullName] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE dbo.Products (
Id int IDENTITY(1,1) NOT NULL,
Name nvarchar(50) NOT NULL,
Description nvarchar(150) NOT NULL,
PRIMARY KEY (Id),
);
INSERT INTO dbo.Products (Name, Description) VALUES
('Pasta', 'Pasta za zube'),
('Kupka', 'Kupka za kadu'),
('Kruh', 'Bijeli kruh'),
('Tost', 'Preprzeni kruh');