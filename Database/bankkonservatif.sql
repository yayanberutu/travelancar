/*
SQLyog Ultimate v8.55 
MySQL - 5.5.5-10.1.31-MariaDB : Database - bankkonservatif
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`bankkonservatif` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `bankkonservatif`;

/*Table structure for table `tnasabah` */

DROP TABLE IF EXISTS `tnasabah`;

CREATE TABLE `tnasabah` (
  `no_rek` char(11) NOT NULL,
  `username` char(50) NOT NULL,
  `password` char(50) NOT NULL,
  `saldo` double DEFAULT NULL,
  PRIMARY KEY (`no_rek`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tnasabah` */

/*Table structure for table `ttransaksi` */

DROP TABLE IF EXISTS `ttransaksi`;

CREATE TABLE `ttransaksi` (
  `id` char(11) NOT NULL,
  `no_rek` char(11) DEFAULT NULL,
  `tagihan` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_transaksi` (`no_rek`),
  CONSTRAINT `FK_transaksi` FOREIGN KEY (`no_rek`) REFERENCES `tnasabah` (`no_rek`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ttransaksi` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
