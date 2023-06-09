CREATE DATABASE [assignment]

USE [assignment]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[AuthorId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_User] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_User]
GO


INSERT INTO [assignment].dbo.[User] (Email,Password) VALUES
	 (N'jack@gmail.com',N'jack'),
	 (N'kkk@123.com',N'12'),
	 (N'lin@123.com',N'123');

INSERT INTO [assignment].dbo.Article (Title,Content,AuthorId) VALUES
	 (N'Article 1',N'Content of Article 1',2),
	 (N'Article 2',N'Content of Article 2',3),
	 (N'Article 3',N'Content of Article 3',3),
	 (N'Article 4',N'Content of Article 4',2),
	 (N'Article 5',N'Content of Article 5',3),
	 (N'Article 6',N'Content of Article 6',1),
	 (N'Article 7',N'Content of Article 7',2),
	 (N'Article 8',N'Content of Article 8',3),
	 (N'Article 9',N'Content of Article 9',3),
	 (N'Article 10',N'Content of Article 10',2);
INSERT INTO [assignment].dbo.Article (Title,Content,AuthorId) VALUES
	 (N'Article 11',N'Content of Article 11',2),
	 (N'Article 12',N'Content of Article 12',3),
	 (N'Article 13',N'Content of Article 13',2),
	 (N'Article 14',N'Content of Article 14',2),
	 (N'Article 15',N'Content of Article 15',1),
	 (N'Article 16',N'Content of Article 16',2),
	 (N'Article 17',N'Content of Article 17',2),
	 (N'Article 18',N'Content of Article 18',3),
	 (N'Article 19',N'Content of Article 19',3),
	 (N'Article 20',N'Content of Article 20',2);
INSERT INTO [assignment].dbo.Article (Title,Content,AuthorId) VALUES
	 (N'Article 21',N'Content of Article 21',1),
	 (N'Article 22',N'Content of Article 22',3),
	 (N'Article 23',N'Content of Article 23',1),
	 (N'Article 24',N'Content of Article 24',3),
	 (N'Article 25',N'Content of Article 25',1),
	 (N'Article 26',N'Content of Article 26',3),
	 (N'Article 27',N'Content of Article 27',2),
	 (N'Article 28',N'Content of Article 28',1),
	 (N'Article 29',N'Content of Article 29',1),
	 (N'Article 30',N'Content of Article 30',2);
