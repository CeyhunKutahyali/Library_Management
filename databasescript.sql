USE [Library_Management]
GO
/****** Object:  Table [dbo].[BookGenre]    Script Date: 23.11.2023 14:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookGenre](
	[BookGenreId] [int] IDENTITY(1,1) NOT NULL,
	[BookDefinition] [nvarchar](50) NOT NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_BookGenre] PRIMARY KEY CLUSTERED 
(
	[BookGenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 23.11.2023 14:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](40) NOT NULL,
	[AuthorName] [nvarchar](30) NOT NULL,
	[AuthorSurname] [nvarchar](30) NOT NULL,
	[ISBN] [nvarchar](20) NULL,
	[BookStatu] [bit] NOT NULL,
	[RenterNumber] [int] NULL,
	[RenterDate] [date] NULL,
	[BookGenreCode] [int] NOT NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.11.2023 14:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[NameSurname] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[UserPassword] [nvarchar](10) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[StudentNumber] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_BookGenre] FOREIGN KEY([BookGenreCode])
REFERENCES [dbo].[BookGenre] ([BookGenreId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_BookGenre]
GO
