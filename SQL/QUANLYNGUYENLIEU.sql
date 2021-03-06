USE [master]
GO
/****** Object:  Database [QUANLYNGUYENLIEU]    Script Date: 1/6/2019 16:28:14 ******/
CREATE DATABASE [QUANLYNGUYENLIEU]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYNGUYENLIEU', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QUANLYNGUYENLIEU.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYNGUYENLIEU_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QUANLYNGUYENLIEU_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYNGUYENLIEU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QUANLYNGUYENLIEU]
GO
/****** Object:  Table [dbo].[GIANGUYENLIEU]    Script Date: 1/6/2019 16:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIANGUYENLIEU](
	[ID] [varchar](50) NOT NULL,
	[GIA] [float] NULL,
 CONSTRAINT [PK_GIANGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 1/6/2019 16:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHO](
	[ID] [varchar](50) NOT NULL,
	[NAME] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 1/6/2019 16:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONAN](
	[ID] [varchar](50) NOT NULL,
	[TENMONAN] [nvarchar](200) NULL,
	[NGUYENLIEU] [nvarchar](200) NULL,
	[HINHANH] [nvarchar](200) NULL,
 CONSTRAINT [PK_MONAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 1/6/2019 16:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[ID] [varchar](50) NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[KHO] [varchar](50) NULL,
 CONSTRAINT [PK_NGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[NGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK_NGUYENLIEU_KHO] FOREIGN KEY([KHO])
REFERENCES [dbo].[KHO] ([ID])
GO
ALTER TABLE [dbo].[NGUYENLIEU] CHECK CONSTRAINT [FK_NGUYENLIEU_KHO]
GO
USE [master]
GO
ALTER DATABASE [QUANLYNGUYENLIEU] SET  READ_WRITE 
GO
