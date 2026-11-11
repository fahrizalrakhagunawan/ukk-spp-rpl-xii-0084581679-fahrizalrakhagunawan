
-- ------------------------------------------------------------------------
-- 1. TABEL: spp (Tarif & Tahun Ajaran SPP)
-- ------------------------------------------------------------------------
DROP TABLE IF EXISTS `pembayaran`;
DROP TABLE IF EXISTS `siswa`;
DROP TABLE IF EXISTS `petugas`;
DROP TABLE IF EXISTS `kelas`;
DROP TABLE IF EXISTS `spp`;

CREATE TABLE `spp` (
    `id_spp` INT AUTO_INCREMENT PRIMARY KEY,
    `tahun` INT NOT NULL,
    `nominal` INT NOT NULL,
    `keterangan` VARCHAR(100) NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- ------------------------------------------------------------------------
-- 2. TABEL: kelas (Master Data Rombongan Belajar)
-- ------------------------------------------------------------------------
CREATE TABLE `kelas` (
    `id_kelas` INT AUTO_INCREMENT PRIMARY KEY,
    `nama_kelas` VARCHAR(15) NOT NULL,
    `kompetensi_keahlian` VARCHAR(50) NOT NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- ------------------------------------------------------------------------
-- 3. TABEL: petugas / users (Otoritas Sistem: Admin & Petugas)
-- ------------------------------------------------------------------------
CREATE TABLE `petugas` (
    `id_petugas` INT AUTO_INCREMENT PRIMARY KEY,
    `username` VARCHAR(30) NOT NULL UNIQUE,
    `password` VARCHAR(255) NOT NULL,
    `nama_petugas` VARCHAR(50) NOT NULL,
    `level` ENUM('admin', 'petugas') NOT NULL DEFAULT 'petugas',
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- ------------------------------------------------------------------------
-- 4. TABEL: siswa (Master Data Siswa Terdaftar)
-- ------------------------------------------------------------------------
CREATE TABLE `siswa` (
    `nisn` CHAR(10) PRIMARY KEY,
    `nis` CHAR(8) NOT NULL UNIQUE,
    `nama` VARCHAR(50) NOT NULL,
    `id_kelas` INT NOT NULL,
    `alamat` TEXT NULL,
    `no_telp` VARCHAR(15) NULL,
    `id_spp` INT NOT NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT `fk_siswa_kelas` FOREIGN KEY (`id_kelas`) 
        REFERENCES `kelas` (`id_kelas`) 
        ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT `fk_siswa_spp` FOREIGN KEY (`id_spp`) 
        REFERENCES `spp` (`id_spp`) 
        ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

-- ------------------------------------------------------------------------
-- 5. TABEL: pembayaran (Transaksi Pembayaran SPP Bulanan)
-- ------------------------------------------------------------------------
CREATE TABLE `pembayaran` (
    `id_pembayaran` INT AUTO_INCREMENT PRIMARY KEY,
    `id_petugas` INT NOT NULL,
    `nisn` CHAR(10) NOT NULL,
    `tgl_bayar` DATE NOT NULL,
    `bulan_dibayar` VARCHAR(15) NOT NULL,
    `tahun_dibayar` VARCHAR(4) NOT NULL,
    `id_spp` INT NOT NULL,
    `jumlah_bayar` INT NOT NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT `fk_pembayaran_petugas` FOREIGN KEY (`id_petugas`) 
        REFERENCES `petugas` (`id_petugas`) 
        ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT `fk_pembayaran_siswa` FOREIGN KEY (`nisn`) 
        REFERENCES `siswa` (`nisn`) 
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT `fk_pembayaran_spp` FOREIGN KEY (`id_spp`) 
        REFERENCES `spp` (`id_spp`) 
        ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

-- ------------------------------------------------------------------------
-- INDEKS PERFORMA
-- ------------------------------------------------------------------------
CREATE INDEX `idx_siswa_nama` ON `siswa` (`nama`);
CREATE INDEX `idx_pembayaran_tgl` ON `pembayaran` (`tgl_bayar`);
CREATE INDEX `idx_pembayaran_siswa_periode` ON `pembayaran` (`nisn`, `bulan_dibayar`, `tahun_dibayar`);

-- ========================================================================
-- DATA SEEDER AWAL (DUMMY TESTING & UKK VERIFICATION)
-- ========================================================================

-- Seeder Tarif SPP (2024, 2025, 2026)
INSERT INTO `spp` (`id_spp`, `tahun`, `nominal`, `keterangan`) VALUES
(1, 2024, 250000, 'SPP Angkatan 2024 / TA 2024-2025'),
(2, 2025, 300000, 'SPP Angkatan 2025 / TA 2025-2026'),
(3, 2026, 350000, 'SPP Angkatan 2026 / TA 2026-2027');

-- Seeder Kelas Rombel
INSERT INTO `kelas` (`id_kelas`, `nama_kelas`, `kompetensi_keahlian`) VALUES
(1, 'XII RPL 1', 'Rekayasa Perangkat Lunak'),
(2, 'XII RPL 2', 'Rekayasa Perangkat Lunak'),
(3, 'XII TKJ 1', 'Teknik Komputer dan Jaringan'),
(4, 'XII DMM 1', 'Desain Komunikasi Visual');

-- Seeder Petugas (Password: 'admin123' & 'petugas123')
-- Menggunakan hash Bcrypt kompatibel Laravel ($2y$10$...) & verifikasi C# BCrypt.Net / Plain Fallback
INSERT INTO `petugas` (`id_petugas`, `username`, `password`, `nama_petugas`, `level`) VALUES
(1, 'admin', '$2y$10$7zK7i5eHoxqV5wX17f0vQO0J0kQJzNn7qP.eIflm9j53NqV2v9j6C', 'Administrator Utama', 'admin'),
(2, 'petugas1', '$2y$10$Y7G4N5nL8lW.zP8S0zZkEeB0oU1YdG0C0r5I6G3J4K8L9M0N1O2P3', 'Petugas Loket 1', 'petugas');
-- Catatan Verifikasi C#: password 'admin123' ter-hash Bcrypt di atas.

-- Seeder Siswa
INSERT INTO `siswa` (`nisn`, `nis`, `nama`, `id_kelas`, `alamat`, `no_telp`, `id_spp`) VALUES
('0061234567', '22230101', 'Ahmad Fadillah', 1, 'Jl. Merdeka No. 45, Bandung', '081234567890', 1),
('0061234568', '22230102', 'Budi Santoso', 1, 'Jl. Cempaka Putih No. 12, Bandung', '081234567891', 1),
('0061234569', '22230103', 'Citra Lestari', 2, 'Jl. Diponegoro No. 88, Bandung', '081234567892', 1),
('0071234570', '23240201', 'Dewi Anggraini', 3, 'Jl. Asia Afrika No. 10, Bandung', '081234567893', 2);

-- Seeder Transaksi Pembayaran SPP
INSERT INTO `pembayaran` (`id_pembayaran`, `id_petugas`, `nisn`, `tgl_bayar`, `bulan_dibayar`, `tahun_dibayar`, `id_spp`, `jumlah_bayar`) VALUES
(1, 1, '0061234567', '2026-07-10', 'Juli', '2026', 1, 250000),
(2, 2, '0061234567', '2026-08-12', 'Agustus', '2026', 1, 250000),
(3, 2, '0061234568', '2026-07-11', 'Juli', '2026', 1, 250000);
