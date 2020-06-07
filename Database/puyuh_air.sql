CREATE DATABASE puyuh_air

CREATE TABLE penerbangan (
  id_penerbangan INT PRIMARY KEY NOT NULL
, nama_maskapai NVARCHAR(250) NOT NULL
, kota_asal NVARCHAR(250) NOT NULL
, kota_tujuan NVARCHAR(250) NOT NULL
, tanggal_keberangkatan DATETIME NOT NULL
, jam_keberangkatan NVARCHAR(16) NOT NULL
, harga INT NOT NULL
);

CREATE TABLE tiket (
  id_tiket INT PRIMARY KEY NOT NULL
, id_penerbangan INT NOT NULL
, kode_booking NVARCHAR(250) NOT NULL
, waktu_booking DATETIME NULL
, batas_waktu_bayar_atm DATETIME NULL
, batas_waktu_bayar_internet_banking DATETIME NULL
, kode_bayar NVARCHAR(250) NULL
, STATUS NVARCHAR(50) NULL
, user_id INT NULL
, total_harga BIGINT NULL
);

CREATE TABLE penumpang (
  id_penumpang INT PRIMARY KEY NOT NULL
, id_tiket INT NOT NULL
, nama NVARCHAR(250) NOT NULL
, nomor_identitas NVARCHAR(250) NOT NULL
);

ALTER TABLE tiket
  ADD CONSTRAINT FK_id_Penerbangan FOREIGN KEY (id_penerbangan) REFERENCES penerbangan (id_penerbangan);



insert into penerbangan values (1 ,'Garuda', 2000000, 'Medan', 'Jakarta', '2020-12-12', '2020-12-12', '20:00','22:00')
insert into penerbangan values (1 ,'Garuda', 2000000, 'Medan', 'Jakarta', '2020-12-12', '2020-12-12', '20:00','22:00')
