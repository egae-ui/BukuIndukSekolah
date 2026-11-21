-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 21 Nov 2026 pada 12.07
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
  `id_guru` int NOT NULL,
  `tahun_ajaran` year NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `kelas`
--

INSERT INTO `kelas` (`id_kelas`, `nama_kelas`, `id_jurusan`, `id_guru`, `tahun_ajaran`) VALUES
(1, 'X RPL A', 1, 4, '2025'),
(2, 'X RPL B', 1, 0, '2025'),
(3, 'XI RPL A', 1, 0, '2025'),
(4, 'XI RPL B', 1, 0, '2025'),
(5, 'XII RPL A', 1, 0, '2025'),
(6, 'XII RPL B', 1, 0, '2025'),
(7, 'X TKJ A', 2, 0, '2025'),
(8, 'X TKJ B', 2, 0, '2025'),
(9, 'XI TKJ A', 2, 0, '2025'),
(10, 'XI TKJ B', 2, 0, '2025'),
(11, 'XII TKJ A', 2, 0, '2025'),
(12, 'XII TKJ B', 2, 0, '2025'),
(13, 'X TPTU A', 3, 0, '2025'),
(14, 'X TPTU B', 3, 0, '2025'),
(15, 'XI TPTU A', 3, 0, '2025'),
(16, 'XI TPTU B', 3, 0, '2025'),
(17, 'XII TPTU A', 3, 0, '2025'),
(18, 'XII TPTU B', 3, 0, '2025'),
(19, 'X TEI A', 4, 0, '2025'),
(20, 'X TEI B', 4, 0, '2025'),
(21, 'XI TEI A', 4, 0, '2025'),
(22, 'XI TEI B', 4, 0, '2025'),
(23, 'XII TEI A', 4, 0, '2025'),
(24, 'XII TEI B', 4, 0, '2025');

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
(6, 'Guru-Honorer', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `siswa`
--

CREATE TABLE `siswa` (
  `nipd` int NOT NULL,
  `nisn` varchar(50) NOT NULL,
  `jurusan` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `kelas` varchar(100) NOT NULL,
  `nama_lengkap` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tmp_lahir` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(25) NOT NULL,
  `nama_ayah` varchar(100) NOT NULL,
  `nama_ibu` varchar(100) NOT NULL,
  `alamat_domisili` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `siswa`
--

INSERT INTO `siswa` (`nipd`, `nisn`, `jurusan`, `kelas`, `nama_lengkap`, `jenis_kelamin`, `tmp_lahir`, `tgl_lahir`, `agama`, `nama_ayah`, `nama_ibu`, `alamat_domisili`) VALUES
(1999001, '0123456789', 'Rekayasa Perangkat Lunak', 'XII RPL A', 'Erlangga Putra Wijayaa', 'Laki-laki', 'Garut', '2008-08-03', 'Islam', 'Deden', 'Lia', 'Kp.Neglasari, Galanggang, Batujajar, KBB, Jawa Barat'),
(1999002, '23456567654', 'Rekayasa Perangkat Lunak', 'XII RPL A', 'Bilal', 'Laki-laki', 'cikuya', '2008-07-12', 'Islam', 'Asep', 'mami', 'cikuya'),
(1999003, '346354443254', 'Teknik Pendingin dan Tata Udara', 'XII TPTU B', 'nazrannn', 'Laki-laki', 'cimahi', '2008-02-19', 'Khonghucu', 'sei', 'bae', 'gat'),
(1999004, '078546634255', 'Teknik Elektonika Industri', 'XI TEI B', 'sapta', 'Laki-laki', 'cimahi', '2008-04-10', 'Kristen', 'junn', 'aa', 'gyuyg'),
(1999005, '08863465', 'Rekayasa Perangkat Lunak', 'XII RPL A', 'gaisan', 'Laki-laki', 'cimahi', '2008-01-18', 'Islam', 'hahdha', 'hadywd', 'cimahi');

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `Idu` int NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Role` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `no_induk` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`Idu`, `Username`, `Password`, `Role`, `no_induk`) VALUES
(1, 'Admin', 'e64b78fc3bc91bcbc7dc232ba8ec59e0', 'Admin', ''),
(4, 'Guru1', '8f1aed01410875d49cb2e6f6c48db787', 'Guru', ''),
(13, 'Murid1', 'de0153072e9cccbd47c7fd43391f62af', 'Siswa', ''),
(14, 'GuruH1', '7b2e2c73c4882fc7b5cb19e62edac2b1', 'Guru-Honorer', '');

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
  ADD PRIMARY KEY (`id_kelas`);

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
  ADD UNIQUE KEY `nisn` (`nisn`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Idu`);

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
  MODIFY `Idr` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `siswa`
--
ALTER TABLE `siswa`
  MODIFY `nipd` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1999019;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `Idu` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
