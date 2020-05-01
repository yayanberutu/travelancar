--
-- Database: `itik_air`
--

-- --------------------------------------------------------

--
-- Table structure for table `bangku`
--

CREATE TABLE bangku (
  seat_no varchar(5) NOT NULL,
  no_pesawat varchar(15) NOT NULL
);

-- --------------------------------------------------------

--
-- Table structure for table `penerbangan`
--

CREATE TABLE penerbangan (
  no_pesawat varchar(15) NOT NULL,
  bandara_asal varchar(30) NOT NULL,
  bandara_tujuan varchar(30) NOT NULL,
  tgl_berangkat date NOT NULL,
  tgl_tiba date NOT NULL,
  jam_berangkat time NOT NULL,
  jam_tiba time NOT NULL
) ;

-- --------------------------------------------------------

--
-- Table structure for table `penumpang`
--

CREATE TABLE penumpang (
  no_ktp int NOT NULL,
  nama_penumpang varchar(50) NOT NULL,
  umur_penumpang int NOT NULL,
  jk_penumpang varchar(50) NOT NULL,
  alamat_penumpang varchar(50) NOT NULL
) ;

-- --------------------------------------------------------

--
-- Table structure for table `tiket`
--

CREATE TABLE tiket (
  no_tiket int NOT NULL,
  no_ktp int NOT NULL,
  no_pesawat varchar(15) NOT NULL
) ;


--
-- Indexes for table `penerbangan`
--
ALTER TABLE penerbangan
  ADD PRIMARY KEY (no_pesawat);

--
-- Indexes for table `penumpang`
--
ALTER TABLE penumpang
  ADD PRIMARY KEY (no_ktp);

 ALTER TABLE bangku
  ADD PRIMARY KEY (seat_no);

ALTER TABLE tiket
  ADD PRIMARY KEY (no_tiket);



--
-- Constraints for table `bangku`
--
ALTER TABLE bangku
  ADD CONSTRAINT FK_No_Pesawat FOREIGN KEY (no_pesawat) REFERENCES penerbangan (no_pesawat);

--
-- Constraints for table `tiket`
--
ALTER TABLE tiket
  ADD CONSTRAINT FK_No_KTP FOREIGN KEY (no_ktp) REFERENCES penumpang (no_ktp)
ALTER TABLE tiket
  ADD CONSTRAINT FK_No_Penerbangan FOREIGN KEY (no_pesawat) REFERENCES penerbangan (no_pesawat);


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
