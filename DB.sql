USE [master]
GO

/****** Object:  Database [RQSTS_MNGR]    Script Date: 11.06.2020 10:26:27 ******/
CREATE DATABASE [RQSTS_MNGR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RQSTS_MNGR', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.MSSQL\MSSQL\DATA\RQSTS_MNGR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RQSTS_MNGR_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.MSSQL\MSSQL\DATA\RQSTS_MNGR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RQSTS_MNGR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [RQSTS_MNGR] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET ARITHABORT OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [RQSTS_MNGR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [RQSTS_MNGR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET  DISABLE_BROKER 
GO

ALTER DATABASE [RQSTS_MNGR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [RQSTS_MNGR] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET RECOVERY FULL 
GO

ALTER DATABASE [RQSTS_MNGR] SET  MULTI_USER 
GO

ALTER DATABASE [RQSTS_MNGR] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [RQSTS_MNGR] SET DB_CHAINING OFF 
GO

ALTER DATABASE [RQSTS_MNGR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [RQSTS_MNGR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [RQSTS_MNGR] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [RQSTS_MNGR] SET QUERY_STORE = OFF
GO

ALTER DATABASE [RQSTS_MNGR] SET  READ_WRITE 
GO

