
/****** Object:  Database [travelmanagement]    Script Date: 2021-11-16 10:01:04 PM ******/
CREATE DATABASE [travelmanagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'travelmanagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\travelmanagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'travelmanagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\travelmanagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [travelmanagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [travelmanagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [travelmanagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [travelmanagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [travelmanagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [travelmanagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [travelmanagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [travelmanagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [travelmanagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [travelmanagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [travelmanagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [travelmanagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [travelmanagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [travelmanagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [travelmanagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [travelmanagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [travelmanagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [travelmanagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [travelmanagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [travelmanagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [travelmanagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [travelmanagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [travelmanagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [travelmanagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [travelmanagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [travelmanagement] SET  MULTI_USER 
GO
ALTER DATABASE [travelmanagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [travelmanagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [travelmanagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [travelmanagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [travelmanagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [travelmanagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [travelmanagement] SET QUERY_STORE = OFF
GO
USE [travelmanagement]
GO
/****** Object:  Table [dbo].[booking]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booking](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[name] [text] NULL,
	[number] [bigint] NULL,
	[email] [text] NULL,
	[date] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[location] [text] NULL,
	[duration] [int] NULL,
	[transport] [text] NULL,
	[accomodation] [text] NULL,
	[tripprice] [int] NULL,
	[totalprice] [int] NULL,
	[username] [text] NULL,
	[ticketno] [int] NULL,
	[displayed] [int] NULL,
	[picture] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[changepanel]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[changepanel](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[Picture] [text] NULL,
	[Pricelabel] [int] NULL,
	[Location] [text] NULL,
	[type] [int] NULL,
	[Descripition] [text] NULL,
	[Duration] [int] NULL,
	[Transport] [text] NULL,
	[Tripprice] [int] NULL,
	[Accomodation] [text] NULL,
 CONSTRAINT [PK_changepanel] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hompagechangepanel]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hompagechangepanel](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[hompagepicture] [text] NULL,
	[hompagepricelabel] [int] NULL,
	[hompagelocation] [text] NULL,
	[descripition] [text] NULL,
	[duration] [int] NULL,
	[transport] [text] NULL,
	[tripprice] [int] NULL,
	[accomodation] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imagetable]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imagetable](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[Homepage] [text] NULL,
	[Tour] [text] NULL,
	[Trekking] [text] NULL,
	[Special] [text] NULL,
 CONSTRAINT [PK_imagetable] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[SN] [int] NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Admin] [int] NULL,
	[Users] [int] NULL,
	[email] [text] NULL,
	[verify] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[message]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[message](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[title] [text] NULL,
	[message] [text] NULL,
	[date] [text] NULL,
	[sender] [text] NULL,
	[reciver] [text] NULL,
	[email] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialchangepanel]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialchangepanel](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[specialpicture] [text] NULL,
	[specialpricelabel] [int] NULL,
	[speciallocation] [text] NULL,
	[descripition] [text] NULL,
	[duration] [int] NULL,
	[transport] [text] NULL,
	[tripprice] [int] NULL,
	[accomodation] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trekchangepanel]    Script Date: 2021-11-16 10:01:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trekchangepanel](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[trekpicture] [text] NULL,
	[trekpricelabel] [int] NULL,
	[treklocation] [text] NULL,
	[description] [text] NULL,
	[duration] [int] NULL,
	[transport] [text] NULL,
	[tripprice] [int] NULL,
	[accomodation] [text] NULL,
 CONSTRAINT [PK_trekchangepanel] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [travelmanagement] SET  READ_WRITE 
GO
