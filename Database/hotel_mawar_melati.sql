USE [master]
GO
/****** Object:  Database [HotelMawarMelati]    Script Date: 07/06/2020 19:35:33 ******/
CREATE DATABASE [HotelMawarMelati]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelMawarMelati', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HotelMawarMelati.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HotelMawarMelati_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HotelMawarMelati_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HotelMawarMelati] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelMawarMelati].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelMawarMelati] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelMawarMelati] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelMawarMelati] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelMawarMelati] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelMawarMelati] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET RECOVERY FULL 
GO
ALTER DATABASE [HotelMawarMelati] SET  MULTI_USER 
GO
ALTER DATABASE [HotelMawarMelati] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelMawarMelati] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelMawarMelati] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelMawarMelati] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HotelMawarMelati] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HotelMawarMelati', N'ON'
GO
USE [HotelMawarMelati]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 07/06/2020 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Booking](
	[kode_booking] [char](10) NOT NULL,
	[id_user] [char](10) NOT NULL,
	[tanggal_booking] [datetime] NOT NULL,
	[tanggal_mulai] [datetime] NOT NULL,
	[tanggal_selesai] [datetime] NOT NULL,
 CONSTRAINT [PK_booking] PRIMARY KEY CLUSTERED 
(
	[kode_booking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BookingHistory]    Script Date: 07/06/2020 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookingHistory](
	[kode_booking] [char](10) NOT NULL,
	[id_kamar] [char](10) NOT NULL,
 CONSTRAINT [PK_booking_history] PRIMARY KEY CLUSTERED 
(
	[kode_booking] ASC,
	[id_kamar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kamar]    Script Date: 07/06/2020 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kamar](
	[id] [char](10) NOT NULL,
	[no_kamar] [char](2) NOT NULL,
	[harga_akhir_pekan] [float] NOT NULL,
	[harga_biasa] [float] NOT NULL,
	[fasilitas] [text] NOT NULL,
	[kapasitas] [int] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_kamar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BookingHistory]  WITH CHECK ADD  CONSTRAINT [FK_booking_history_booking_history] FOREIGN KEY([kode_booking], [id_kamar])
REFERENCES [dbo].[BookingHistory] ([kode_booking], [id_kamar])
GO
ALTER TABLE [dbo].[BookingHistory] CHECK CONSTRAINT [FK_booking_history_booking_history]
GO
USE [master]
GO
ALTER DATABASE [HotelMawarMelati] SET  READ_WRITE 
GO
