USE [master]
GO
/****** Object:  Database [Apoteka]    Script Date: 4/5/2021 1:52:03 AM ******/
CREATE DATABASE [Apoteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Apoteka', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Apoteka.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Apoteka_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Apoteka_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Apoteka] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Apoteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Apoteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Apoteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Apoteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Apoteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Apoteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [Apoteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Apoteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Apoteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Apoteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Apoteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Apoteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Apoteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Apoteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Apoteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Apoteka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Apoteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Apoteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Apoteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Apoteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Apoteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Apoteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Apoteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Apoteka] SET RECOVERY FULL 
GO
ALTER DATABASE [Apoteka] SET  MULTI_USER 
GO
ALTER DATABASE [Apoteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Apoteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Apoteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Apoteka] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Apoteka] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Apoteka', N'ON'
GO
ALTER DATABASE [Apoteka] SET QUERY_STORE = OFF
GO
USE [Apoteka]
GO
/****** Object:  Table [dbo].[Dijagnoza]    Script Date: 4/5/2021 1:52:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dijagnoza](
	[SifraBolesti] [int] NOT NULL,
	[Naziv] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Dijagnoza] PRIMARY KEY CLUSTERED 
(
	[SifraBolesti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recept]    Script Date: 4/5/2021 1:52:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recept](
	[ReceptID] [int] NOT NULL,
	[Ime] [varchar](max) NOT NULL,
	[Prezime] [varchar](max) NOT NULL,
	[BrKutija] [int] NULL,
	[SifraBolesti] [int] NOT NULL,
	[SifraLeka] [int] NOT NULL,
 CONSTRAINT [PK_Recept] PRIMARY KEY CLUSTERED 
(
	[ReceptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terapija]    Script Date: 4/5/2021 1:52:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terapija](
	[SifraBolesti] [int] NOT NULL,
	[SifraLeka] [int] NOT NULL,
	[Doza] [int] NOT NULL,
 CONSTRAINT [PK_Terapija] PRIMARY KEY CLUSTERED 
(
	[SifraBolesti] ASC,
	[SifraLeka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Dijagnoza] ([SifraBolesti], [Naziv]) VALUES (1, N'Bolest1')
INSERT [dbo].[Dijagnoza] ([SifraBolesti], [Naziv]) VALUES (2, N'Bolest2')
INSERT [dbo].[Dijagnoza] ([SifraBolesti], [Naziv]) VALUES (3, N'Bolest3')
INSERT [dbo].[Dijagnoza] ([SifraBolesti], [Naziv]) VALUES (4, N'Bolest4')
INSERT [dbo].[Recept] ([ReceptID], [Ime], [Prezime], [BrKutija], [SifraBolesti], [SifraLeka]) VALUES (1, N'Neko', N'Nekic', 5, 1, 1)
INSERT [dbo].[Recept] ([ReceptID], [Ime], [Prezime], [BrKutija], [SifraBolesti], [SifraLeka]) VALUES (2, N'Neko2', N'Nekic2', 1, 2, 2)
INSERT [dbo].[Recept] ([ReceptID], [Ime], [Prezime], [BrKutija], [SifraBolesti], [SifraLeka]) VALUES (3, N'Neko3', N'Nekic3', 2, 2, 2)
INSERT [dbo].[Recept] ([ReceptID], [Ime], [Prezime], [BrKutija], [SifraBolesti], [SifraLeka]) VALUES (4, N'Neko4', N'Nekic4', NULL, 2, 2)
INSERT [dbo].[Terapija] ([SifraBolesti], [SifraLeka], [Doza]) VALUES (1, 1, 50)
INSERT [dbo].[Terapija] ([SifraBolesti], [SifraLeka], [Doza]) VALUES (1, 2, 60)
INSERT [dbo].[Terapija] ([SifraBolesti], [SifraLeka], [Doza]) VALUES (2, 2, 75)
INSERT [dbo].[Terapija] ([SifraBolesti], [SifraLeka], [Doza]) VALUES (3, 2, 40)
INSERT [dbo].[Terapija] ([SifraBolesti], [SifraLeka], [Doza]) VALUES (3, 3, 75)
INSERT [dbo].[Terapija] ([SifraBolesti], [SifraLeka], [Doza]) VALUES (4, 1, 50)
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_Recept_Dijagnoza] FOREIGN KEY([SifraBolesti])
REFERENCES [dbo].[Dijagnoza] ([SifraBolesti])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_Recept_Dijagnoza]
GO
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_Recept_Terapija] FOREIGN KEY([SifraBolesti], [SifraLeka])
REFERENCES [dbo].[Terapija] ([SifraBolesti], [SifraLeka])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_Recept_Terapija]
GO
ALTER TABLE [dbo].[Terapija]  WITH CHECK ADD  CONSTRAINT [FK_Terapija_Dijagnoza] FOREIGN KEY([SifraBolesti])
REFERENCES [dbo].[Dijagnoza] ([SifraBolesti])
GO
ALTER TABLE [dbo].[Terapija] CHECK CONSTRAINT [FK_Terapija_Dijagnoza]
GO
USE [master]
GO
ALTER DATABASE [Apoteka] SET  READ_WRITE 
GO
