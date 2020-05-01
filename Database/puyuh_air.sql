/*
SQLyog Ultimate v13.1.1 (64 bit)
MySQL - 10.1.21-MariaDB : Database - puyuh_air
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`puyuh_air` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `puyuh_air`;

/*Table structure for table `bangku` */

DROP TABLE IF EXISTS `bangku`;

CREATE TABLE `bangku` (
  `seat_no` varchar(5) NOT NULL,
  `no_pesawat` varchar(15) NOT NULL,
  PRIMARY KEY (`seat_no`),
  KEY `FK_No_Pesawat` (`no_pesawat`),
  CONSTRAINT `FK_No_Pesawat` FOREIGN KEY (`no_pesawat`) REFERENCES `penerbangan` (`no_pesawat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `bangku` */

/*Table structure for table `penerbangan` */

DROP TABLE IF EXISTS `penerbangan`;

CREATE TABLE `penerbangan` (
  `no_pesawat` varchar(15) NOT NULL,
  `bandara_asal` varchar(30) NOT NULL,
  `bandara_tujuan` varchar(30) NOT NULL,
  `tgl_berangkat` date NOT NULL,
  `tgl_tiba` date NOT NULL,
  `jam_berangkat` time NOT NULL,
  `jam_tiba` time NOT NULL,
  PRIMARY KEY (`no_pesawat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `penerbangan` */

/*Table structure for table `penumpang` */

DROP TABLE IF EXISTS `penumpang`;

CREATE TABLE `penumpang` (
  `no_ktp` int(11) NOT NULL,
  `nama_penumpang` varchar(50) NOT NULL,
  `umur_penumpang` int(11) NOT NULL,
  `jk_penumpang` varchar(50) NOT NULL,
  `alamat_penumpang` varchar(50) NOT NULL,
  PRIMARY KEY (`no_ktp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `penumpang` */

/*Table structure for table `tiket` */

DROP TABLE IF EXISTS `tiket`;

CREATE TABLE `tiket` (
  `no_tiket` int(11) NOT NULL,
  `no_ktp` int(11) NOT NULL,
  `no_pesawat` varchar(15) NOT NULL,
  PRIMARY KEY (`no_tiket`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tiket` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
