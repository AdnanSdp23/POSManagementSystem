USE [master]
GO
/****** Object:  Database [ShopDB]    Script Date: 05/18/2015 17:27:56 ******/
CREATE DATABASE [ShopDB] ON  PRIMARY 
( NAME = N'ShopDB', FILENAME = N'D:\BIMT\POSManagement\ShopDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShopDB_log', FILENAME = N'D:\BIMT\POSManagement\ShopDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShopDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ShopDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ShopDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ShopDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ShopDB] SET ARITHABORT OFF
GO
ALTER DATABASE [ShopDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ShopDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ShopDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ShopDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ShopDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ShopDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ShopDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ShopDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ShopDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ShopDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [ShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ShopDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ShopDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ShopDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ShopDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ShopDB] SET  READ_WRITE
GO
ALTER DATABASE [ShopDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ShopDB] SET  MULTI_USER
GO
ALTER DATABASE [ShopDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ShopDB] SET DB_CHAINING OFF
GO
USE [ShopDB]
GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 05/18/2015 17:27:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_category] ON
INSERT [dbo].[tbl_category] ([Id], [Category_Name]) VALUES (1, N'Laptop')
INSERT [dbo].[tbl_category] ([Id], [Category_Name]) VALUES (7, N'Mobile')
INSERT [dbo].[tbl_category] ([Id], [Category_Name]) VALUES (8, N'Tab')
SET IDENTITY_INSERT [dbo].[tbl_category] OFF
/****** Object:  Table [dbo].[tbl_brand]    Script Date: 05/18/2015 17:27:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_brand](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_brand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_brand] ON
INSERT [dbo].[tbl_brand] ([Id], [Brand_Name]) VALUES (8, N'DELL')
INSERT [dbo].[tbl_brand] ([Id], [Brand_Name]) VALUES (9, N'HP')
INSERT [dbo].[tbl_brand] ([Id], [Brand_Name]) VALUES (10, N'DOEL')
SET IDENTITY_INSERT [dbo].[tbl_brand] OFF
/****** Object:  Table [dbo].[tbl_product]    Script Date: 05/18/2015 17:27:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Unit] [int] NULL,
	[Unit_Price] [decimal](18, 0) NULL,
	[Total _Price] [decimal](18, 0) NULL,
	[Category_Id] [int] NULL,
	[Brand_Id] [int] NULL,
 CONSTRAINT [PK_tbl_product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_product] ON
INSERT [dbo].[tbl_product] ([Id], [Unit], [Unit_Price], [Total _Price], [Category_Id], [Brand_Id]) VALUES (2, 2, CAST(1299 AS Decimal(18, 0)), CAST(2598 AS Decimal(18, 0)), 1, 8)
SET IDENTITY_INSERT [dbo].[tbl_product] OFF
/****** Object:  View [dbo].[BrandCategoryProduct]    Script Date: 05/18/2015 17:27:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[BrandCategoryProduct]
as
select p.Unit,p.Unit_Price,c.Category_Name,b.Brand_Name
FROM tbl_product AS p
inner join tbl_category as c on p.Category_Id=c.Id
inner join tbl_brand as b on p.Brand_Id=b.Id
GO
/****** Object:  ForeignKey [FK_tbl_product_tbl_category]    Script Date: 05/18/2015 17:27:58 ******/
ALTER TABLE [dbo].[tbl_product]  WITH CHECK ADD  CONSTRAINT [FK_tbl_product_tbl_category] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[tbl_category] ([Id])
GO
ALTER TABLE [dbo].[tbl_product] CHECK CONSTRAINT [FK_tbl_product_tbl_category]
GO
