USE [master]
GO
/****** Object:  Database [PruebaDesarrolloDeadlockDb]    Script Date: 8/15/2020 7:14:15 PM ******/
CREATE DATABASE [PruebaDesarrolloDeadlockDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebaDesarrolloDeadlockDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PruebaDesarrolloDeadlockDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PruebaDesarrolloDeadlockDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PruebaDesarrolloDeadlockDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebaDesarrolloDeadlockDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET RECOVERY FULL 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET  MULTI_USER 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PruebaDesarrolloDeadlockDb', N'ON'
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET QUERY_STORE = OFF
GO
USE [PruebaDesarrolloDeadlockDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/15/2020 7:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 8/15/2020 7:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[DireccionId] [int] IDENTITY(1,1) NOT NULL,
	[Direccion1] [nvarchar](100) NOT NULL,
	[Direccion2] [nvarchar](100) NOT NULL,
	[NumeroDeCasa] [int] NOT NULL,
	[Pais] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[DireccionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/15/2020 7:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoId] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [nvarchar](50) NOT NULL,
	[ApellidoEmpleado] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](60) NOT NULL,
	[Telefono1] [nvarchar](max) NOT NULL,
	[Telefono2] [nvarchar](max) NULL,
	[Creacion] [datetime2](7) NOT NULL,
	[Modificacion] [datetime2](7) NOT NULL,
	[PosicionId] [int] NOT NULL,
	[DireccionId] [int] NOT NULL,
	[EmpleadoDocumento] [nvarchar](60) NOT NULL,
	[FechaDeNacimiento] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posiciones]    Script Date: 8/15/2020 7:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posiciones](
	[PosicionId] [int] IDENTITY(1,1) NOT NULL,
	[PosicionName] [nvarchar](50) NOT NULL,
	[Creacion] [datetime2](7) NOT NULL,
	[Modificacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Posiciones] PRIMARY KEY CLUSTERED 
(
	[PosicionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empleados_DireccionId]    Script Date: 8/15/2020 7:14:15 PM ******/
CREATE NONCLUSTERED INDEX [IX_Empleados_DireccionId] ON [dbo].[Empleados]
(
	[DireccionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empleados_PosicionId]    Script Date: 8/15/2020 7:14:15 PM ******/
CREATE NONCLUSTERED INDEX [IX_Empleados_PosicionId] ON [dbo].[Empleados]
(
	[PosicionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT ((0)) FOR [DireccionId]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (N'') FOR [EmpleadoDocumento]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [FechaDeNacimiento]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Direccion_DireccionId] FOREIGN KEY([DireccionId])
REFERENCES [dbo].[Direccion] ([DireccionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Direccion_DireccionId]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Posiciones_PosicionId] FOREIGN KEY([PosicionId])
REFERENCES [dbo].[Posiciones] ([PosicionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Posiciones_PosicionId]
GO
USE [master]
GO
ALTER DATABASE [PruebaDesarrolloDeadlockDb] SET  READ_WRITE 
GO
