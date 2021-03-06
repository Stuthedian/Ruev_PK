USE [master]
GO
/****** Object:  Database [410Lab2]    Script Date: 07.03.2020 10:13:15 ******/
CREATE DATABASE [410Lab2] ON  PRIMARY 
( NAME = N'410Lab2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\410Lab2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'410Lab2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\410Lab2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [410Lab2] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [410Lab2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [410Lab2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [410Lab2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [410Lab2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [410Lab2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [410Lab2] SET ARITHABORT OFF 
GO
ALTER DATABASE [410Lab2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [410Lab2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [410Lab2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [410Lab2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [410Lab2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [410Lab2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [410Lab2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [410Lab2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [410Lab2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [410Lab2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [410Lab2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [410Lab2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [410Lab2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [410Lab2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [410Lab2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [410Lab2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [410Lab2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [410Lab2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [410Lab2] SET  MULTI_USER 
GO
ALTER DATABASE [410Lab2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [410Lab2] SET DB_CHAINING OFF 
GO
USE [410Lab2]
GO
/****** Object:  Table [dbo].[Postavka]    Script Date: 07.03.2020 10:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postavka](
	[cod_pr] [int] NOT NULL,
	[cod_postsh] [int] NOT NULL,
	[data] [date] NOT NULL,
	[objem] [int] NULL,
	[stoim] [decimal](8, 2) NULL,
	[srok] [int] NULL,
	[data_proizv] [date] NULL,
 CONSTRAINT [PK_Postavka] PRIMARY KEY CLUSTERED 
(
	[cod_pr] ASC,
	[cod_postsh] ASC,
	[data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Postavshik]    Script Date: 07.03.2020 10:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postavshik](
	[cod_postsh] [int] IDENTITY(1,1) NOT NULL,
	[nazv] [varchar](50) NOT NULL,
	[gorod] [varchar](50) NULL,
 CONSTRAINT [PK_Postavshik] PRIMARY KEY CLUSTERED 
(
	[cod_postsh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produkt]    Script Date: 07.03.2020 10:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produkt](
	[cod_pr] [int] IDENTITY(1,1) NOT NULL,
	[nazv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Produkt] PRIMARY KEY CLUSTERED 
(
	[cod_pr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Postavka] ([cod_pr], [cod_postsh], [data], [objem], [stoim], [srok], [data_proizv]) VALUES (1, 2, CAST(N'2012-12-12' AS Date), 12, CAST(23.00 AS Decimal(8, 2)), 23, CAST(N'2012-12-12' AS Date))
INSERT [dbo].[Postavka] ([cod_pr], [cod_postsh], [data], [objem], [stoim], [srok], [data_proizv]) VALUES (2, 3, CAST(N'2012-12-12' AS Date), 89, CAST(67.00 AS Decimal(8, 2)), 6, CAST(N'2012-12-12' AS Date))
SET IDENTITY_INSERT [dbo].[Postavshik] ON 

INSERT [dbo].[Postavshik] ([cod_postsh], [nazv], [gorod]) VALUES (2, N'ТУЛЬСКИЙ', N'Паневежис')
INSERT [dbo].[Postavshik] ([cod_postsh], [nazv], [gorod]) VALUES (3, N'ШУШАРЫ', N'Резекне')
INSERT [dbo].[Postavshik] ([cod_postsh], [nazv], [gorod]) VALUES (4, N'ОГУРЕЧИК', N'Санкт-Петербург')
SET IDENTITY_INSERT [dbo].[Postavshik] OFF
SET IDENTITY_INSERT [dbo].[Produkt] ON 

INSERT [dbo].[Produkt] ([cod_pr], [nazv]) VALUES (1, N'Охота крепкое')
INSERT [dbo].[Produkt] ([cod_pr], [nazv]) VALUES (2, N'Бастурма')
INSERT [dbo].[Produkt] ([cod_pr], [nazv]) VALUES (3, N'Бомбастер')
INSERT [dbo].[Produkt] ([cod_pr], [nazv]) VALUES (4, N'Кофе тульский')
SET IDENTITY_INSERT [dbo].[Produkt] OFF
ALTER TABLE [dbo].[Postavka]  WITH CHECK ADD  CONSTRAINT [FK_Postavka_Postavshik] FOREIGN KEY([cod_postsh])
REFERENCES [dbo].[Postavshik] ([cod_postsh])
GO
ALTER TABLE [dbo].[Postavka] CHECK CONSTRAINT [FK_Postavka_Postavshik]
GO
ALTER TABLE [dbo].[Postavka]  WITH CHECK ADD  CONSTRAINT [FK_Postavka_Produkt] FOREIGN KEY([cod_pr])
REFERENCES [dbo].[Produkt] ([cod_pr])
GO
ALTER TABLE [dbo].[Postavka] CHECK CONSTRAINT [FK_Postavka_Produkt]
GO
USE [master]
GO
ALTER DATABASE [410Lab2] SET  READ_WRITE 
GO
