`transaksi``user``user``transaksi``user`
CREATE DATABASE bankbung;
CREATE TABLE `transaksi` (
  `id_transaksi` INT(11) NOT NULL,
  `no_rek` INT(11) NOT NULL,
  `tagihan` INT(11) NOT NULL
) 
CREATE TABLE `user` (
  `no_rek` INT(11) NOT NULL,
  `username` VARCHAR(50) NOT NULL,
  `password` INT(6) NOT NULL,
  `saldo` INT(11) NOT NULL
) 
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `no_rek` (`no_rek`);

ALTER TABLE `user`
  ADD PRIMARY KEY (`no_rek`);


ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`no_rek`) REFERENCES `user` (`no_rek`);


