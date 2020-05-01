CREATE DATABASE pingiun_air;
CREATE TABLE bangku (
  seat_no VARCHAR(5) NOT NULL PRIMARY KEY,
  no_pesawat VARCHAR(15) NOT NULL
);
CREATE TABLE penerbangan (
  no_pesawat VARCHAR(15) NOT NULL PRIMARY KEY,
  bandara_asal VARCHAR(30) NOT NULL,
  bandara_tujuan VARCHAR(30) NOT NULL,
  tgl_berangkat DATE NOT NULL,
  tgl_tiba DATE NOT NULL,
  jam_berangkat TIME NOT NULL,
  jam_tiba TIME NOT NULL
);
CREATE TABLE penumpang (
  no_ktp INT NOT NULL PRIMARY KEY,
  nama_penumpang VARCHAR(50) NOT NULL,
  umur_penumpang INT NOT NULL,
  jk_penumpang VARCHAR(50) NOT NULL,
  alamat_penumpang VARCHAR(50) NOT NULL
);
CREATE TABLE tiket (
  no_tiket INT NOT NULL PRIMARY KEY,
  no_ktp INT NOT NULL,
  no_pesawat VARCHAR(15) NOT NULL
);

ALTER TABLE bangku
  ADD CONSTRAINT FK_No_Pesawat FOREIGN KEY (no_pesawat) REFERENCES penerbangan (no_pesawat);
ALTER TABLE tiket
  ADD CONSTRAINT FK_No_KTP FOREIGN KEY (no_ktp) REFERENCES penumpang (no_ktp);
ALTER TABLE tiket
  ADD CONSTRAINT FK_No_Penerbangan FOREIGN KEY (no_pesawat) REFERENCES penerbangan (no_pesawat);

