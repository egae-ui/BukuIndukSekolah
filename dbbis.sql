-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 21 Nov 2026 pada 12.44
-- Versi server: 8.0.30
-- Versi PHP: 8.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Basis data: `dbbis`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `agama`
--

CREATE TABLE `agama` (
  `id_agama` int NOT NULL,
  `nama_agama` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `agama`
--

INSERT INTO `agama` (`id_agama`, `nama_agama`) VALUES
(1, 'Islam'),
(2, 'Kristen'),
(3, 'Katolik'),
(4, 'Hindu'),
(5, 'Buddha'),
(6, 'Khonghucu');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jurusan`
--

CREATE TABLE `jurusan` (
  `id_jurusan` int NOT NULL,
  `nama_jurusan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `jurusan`
--

INSERT INTO `jurusan` (`id_jurusan`, `nama_jurusan`) VALUES
(1, 'Rekayasa Perangkat Lunak'),
(2, 'Teknik Komputer dan Jaringan'),
(3, 'Teknik Pendingin dan Tata Udara'),
(4, 'Teknik Elektonika Industri'),
(6, 'Teknik Mesin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kelas`
--

CREATE TABLE `kelas` (
  `id_kelas` int NOT NULL,
  `nama_kelas` varchar(20) NOT NULL,
  `id_jurusan` int NOT NULL,
  `id_guru` int DEFAULT NULL,
  `tahun_ajaran` year NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `kelas`
--

INSERT INTO `kelas` (`id_kelas`, `nama_kelas`, `id_jurusan`, `id_guru`, `tahun_ajaran`) VALUES
(1, 'X RPL A', 1, 4, '2025'),
(2, 'X RPL B', 1, NULL, '2025'),
(3, 'XI RPL A', 1, NULL, '2025'),
(4, 'XI RPL B', 1, NULL, '2025'),
(5, 'XII RPL A', 1, NULL, '2025'),
(6, 'XII RPL B', 1, NULL, '2025'),
(7, 'X TKJ A', 2, NULL, '2025'),
(8, 'X TKJ B', 2, NULL, '2025'),
(9, 'XI TKJ A', 2, NULL, '2025'),
(10, 'XI TKJ B', 2, NULL, '2025'),
(11, 'XII TKJ A', 2, NULL, '2025'),
(12, 'XII TKJ B', 2, NULL, '2025'),
(13, 'X TPTU A', 3, NULL, '2025'),
(14, 'X TPTU B', 3, NULL, '2025'),
(15, 'XI TPTU A', 3, NULL, '2025'),
(16, 'XI TPTU B', 3, NULL, '2025'),
(17, 'XII TPTU A', 3, NULL, '2025'),
(18, 'XII TPTU B', 3, NULL, '2025'),
(19, 'X TEI A', 4, NULL, '2025'),
(20, 'X TEI B', 4, NULL, '2025'),
(21, 'XI TEI A', 4, NULL, '2025'),
(22, 'XI TEI B', 4, NULL, '2025'),
(23, 'XII TEI A', 4, NULL, '2025'),
(24, 'XII TEI B', 4, NULL, '2025');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mata_pelajaran`
--

CREATE TABLE `mata_pelajaran` (
  `id_mapel` int NOT NULL,
  `nama_mapel` varchar(100) NOT NULL,
  `kode_mapel` varchar(20) NOT NULL,
  `keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `mata_pelajaran`
--

INSERT INTO `mata_pelajaran` (`id_mapel`, `nama_mapel`, `kode_mapel`, `keterangan`) VALUES
(1, 'Matematika', 'Mat', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `role`
--

CREATE TABLE `role` (
  `Idr` int NOT NULL,
  `Role` varchar(50) NOT NULL,
  `Keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `role`
--

INSERT INTO `role` (`Idr`, `Role`, `Keterangan`) VALUES
(1, 'Admin', ''),
(2, 'Guru', ''),
(3, 'Siswa', ''),
(6, 'Guru-Honorer', ''),
(7, 'kepala sekolah', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `siswa`
--

CREATE TABLE `siswa` (
  `nipd` int NOT NULL,
  `nisn` varchar(50) NOT NULL,
  `id_kelas` int DEFAULT NULL,
  `jurusan` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `kelas` varchar(100) NOT NULL,
  `nama_lengkap` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tmp_lahir` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `id_agama` int DEFAULT NULL,
  `agama` varchar(25) NOT NULL,
  `nama_ayah` varchar(100) NOT NULL,
  `nama_ibu` varchar(100) NOT NULL,
  `alamat_domisili` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `siswa`
--

INSERT INTO `siswa` (`nipd`, `nisn`, `id_kelas`, `jurusan`, `kelas`, `nama_lengkap`, `jenis_kelamin`, `tmp_lahir`, `tgl_lahir`, `id_agama`, `agama`, `nama_ayah`, `nama_ibu`, `alamat_domisili`) VALUES
(1999001, '0123456789', 5, 'Rekayasa Perangkat Lunak', 'XII RPL A', 'Erlangga Putra Wijayaa', 'Laki-laki', 'Garut', '2008-08-03', 1, 'Islam', 'Deden', 'Lia', 'Kp.Neglasari, Galanggang, Batujajar, KBB, Jawa Barat'),
(1999002, '23456567654', 5, 'Rekayasa Perangkat Lunak', 'XII RPL A', 'Bilal', 'Laki-laki', 'cikuya', '2008-07-12', 1, 'Islam', 'Asep', 'mami', 'cikuya'),
(1999003, '346354443254', 18, 'Teknik Pendingin dan Tata Udara', 'XII TPTU B', 'nazrannn', 'Laki-laki', 'cimahi', '2008-02-19', 6, 'Khonghucu', 'sei', 'bae', 'gat'),
(1999004, '078546634255', 22, 'Teknik Elektonika Industri', 'XI TEI B', 'sapta', 'Laki-laki', 'cimahi', '2008-04-10', 2, 'Kristen', 'junn', 'aa', 'gyuyg'),
(1999005, '08863465', 5, 'Rekayasa Perangkat Lunak', 'XII RPL A', 'gaisan', 'Laki-laki', 'cimahi', '2008-01-18', 1, 'Islam', 'hahdha', 'hadywd', 'cimahi'),
(1999006, '4fdrwedr4ewsd', 7, 'Teknik Komputer dan Jaringan', 'X TKJ A', 'drwdsed', 'Perempuan', 'dwdsead', '2008-01-22', 6, 'Khonghucu', 'exwd', '4rdsewd', 'rdrwse');

--
-- Trigger `siswa`
--
DELIMITER $$
CREATE TRIGGER `trg_siswa_bi` BEFORE INSERT ON `siswa` FOR EACH ROW SET NEW.id_kelas = (SELECT id_kelas FROM kelas WHERE nama_kelas = NEW.kelas LIMIT 1),
      NEW.id_agama = (SELECT id_agama FROM agama WHERE nama_agama = NEW.agama LIMIT 1)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_siswa_bu` BEFORE UPDATE ON `siswa` FOR EACH ROW SET NEW.id_kelas = (SELECT id_kelas FROM kelas WHERE nama_kelas = NEW.kelas LIMIT 1),
      NEW.id_agama = (SELECT id_agama FROM agama WHERE nama_agama = NEW.agama LIMIT 1)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `Idu` int NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_role` int DEFAULT NULL,
  `Role` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `no_induk` varchar(50) NOT NULL,
  `nipd` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`Idu`, `Username`, `Password`, `id_role`, `Role`, `no_induk`, `nipd`) VALUES
(1, 'Admin', 'e64b78fc3bc91bcbc7dc232ba8ec59e0', 1, 'Admin', '', NULL),
(4, 'Guru1', '8f1aed01410875d49cb2e6f6c48db787', 2, 'Guru', '', NULL),
(13, 'Murid1', 'de0153072e9cccbd47c7fd43391f62af', 3, 'Siswa', '', NULL),
(14, 'GuruH1', '7b2e2c73c4882fc7b5cb19e62edac2b1', 6, 'Guru-Honorer', '', NULL),
(15, '1', 'c4ca4238a0b923820dcc509a6f75849b', 1, 'Admin', '', NULL);

--
-- Trigger `user`
--
DELIMITER $$
CREATE TRIGGER `trg_user_bi` BEFORE INSERT ON `user` FOR EACH ROW SET NEW.id_role = (SELECT Idr FROM `role` WHERE `Role` = NEW.Role LIMIT 1)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_user_bu` BEFORE UPDATE ON `user` FOR EACH ROW SET NEW.id_role = (SELECT Idr FROM `role` WHERE `Role` = NEW.Role LIMIT 1)
$$
DELIMITER ;

--
-- Indeks untuk tabel yang dibuang
--

--
-- Indeks untuk tabel `agama`
--
ALTER TABLE `agama`
  ADD PRIMARY KEY (`id_agama`);

--
-- Indeks untuk tabel `jurusan`
--
ALTER TABLE `jurusan`
  ADD PRIMARY KEY (`id_jurusan`);

--
-- Indeks untuk tabel `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`id_kelas`),
  ADD KEY `fk_kelas_jurusan` (`id_jurusan`),
  ADD KEY `fk_kelas_guru` (`id_guru`);

--
-- Indeks untuk tabel `mata_pelajaran`
--
ALTER TABLE `mata_pelajaran`
  ADD PRIMARY KEY (`id_mapel`);

--
-- Indeks untuk tabel `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`Idr`);

--
-- Indeks untuk tabel `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`nipd`),
  ADD UNIQUE KEY `nisn` (`nisn`),
  ADD KEY `fk_siswa_kelas` (`id_kelas`),
  ADD KEY `fk_siswa_agama` (`id_agama`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Idu`),
  ADD UNIQUE KEY `uq_user_nipd` (`nipd`),
  ADD KEY `fk_user_role` (`id_role`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `agama`
--
ALTER TABLE `agama`
  MODIFY `id_agama` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `jurusan`
--
ALTER TABLE `jurusan`
  MODIFY `id_jurusan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `kelas`
--
ALTER TABLE `kelas`
  MODIFY `id_kelas` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT untuk tabel `mata_pelajaran`
--
ALTER TABLE `mata_pelajaran`
  MODIFY `id_mapel` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT untuk tabel `role`
--
ALTER TABLE `role`
  MODIFY `Idr` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT untuk tabel `siswa`
--
ALTER TABLE `siswa`
  MODIFY `nipd` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1999019;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `Idu` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `kelas`
--
ALTER TABLE `kelas`
  ADD CONSTRAINT `fk_kelas_guru` FOREIGN KEY (`id_guru`) REFERENCES `user` (`Idu`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_kelas_jurusan` FOREIGN KEY (`id_jurusan`) REFERENCES `jurusan` (`id_jurusan`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `siswa`
--
ALTER TABLE `siswa`
  ADD CONSTRAINT `fk_siswa_agama` FOREIGN KEY (`id_agama`) REFERENCES `agama` (`id_agama`) ON DELETE RESTRICT ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_siswa_kelas` FOREIGN KEY (`id_kelas`) REFERENCES `kelas` (`id_kelas`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `fk_user_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`Idr`) ON DELETE RESTRICT ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_user_siswa` FOREIGN KEY (`nipd`) REFERENCES `siswa` (`nipd`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
