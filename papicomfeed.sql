-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2023 at 03:41 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `papicomfeed`
--
CREATE DATABASE IF NOT EXISTS `papicomfeed` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `papicomfeed`;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(20) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  `telp` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `nama`, `alamat`, `telp`) VALUES
(1, 'Customer 1', 'Surabaya Dekat ISTTS', 123123),
(2, 'Customer 2', 'Surabaya dekat monumen pahlawan', 456456),
(3, 'jojo', 'tpj', 813325325);

-- --------------------------------------------------------

--
-- Table structure for table `dbeli`
--

CREATE TABLE `dbeli` (
  `id` int(11) NOT NULL,
  `hbeli_id` int(11) NOT NULL,
  `kolam_id` int(11) NOT NULL,
  `ikan_id` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `nama_ikan` varchar(255) NOT NULL,
  `tanggal` date NOT NULL DEFAULT current_timestamp(),
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dbeli`
--

INSERT INTO `dbeli` (`id`, `hbeli_id`, `kolam_id`, `ikan_id`, `harga`, `jumlah`, `nama_ikan`, `tanggal`, `subtotal`) VALUES
(9, 8, 1, 1, 1000, 2, 'Cupang Hias', '2023-05-01', 2000),
(10, 9, 1, 3, 5000, 15, 'Gurami', '2023-05-02', 75000),
(11, 9, 2, 2, 2500, 10, 'Lele', '1900-01-03', 25000),
(12, 10, 1, 2, 2500, 5, 'Lele', '2023-05-14', 12500),
(13, 10, 1, 1, 1000, 15, 'Cupang Hias', '2023-05-14', 15000),
(14, 11, 1, 3, 5000, 2, 'Gurami', '2023-05-14', 10000),
(15, 11, 1, 1, 1000, 5, 'Cupang Hias', '2023-05-14', 5000),
(16, 12, 2, 2, 2500, 6, 'Lele', '2023-05-15', 15000),
(17, 12, 2, 3, 5000, 7, 'Gurami', '2023-05-15', 35000);

-- --------------------------------------------------------

--
-- Table structure for table `djual`
--

CREATE TABLE `djual` (
  `id` int(11) NOT NULL,
  `hjual_id` int(11) NOT NULL,
  `ikan_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL,
  `nama_ikan` varchar(255) NOT NULL,
  `tanggal` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `djual`
--

INSERT INTO `djual` (`id`, `hjual_id`, `ikan_id`, `qty`, `harga`, `subtotal`, `nama_ikan`, `tanggal`) VALUES
(9, 8, 1, 2, 1000, 2000, 'Cupang Hias', '2023-05-15'),
(10, 8, 2, 4, 2500, 10000, 'Lele', '2023-05-15');

-- --------------------------------------------------------

--
-- Table structure for table `hbeli`
--

CREATE TABLE `hbeli` (
  `id` int(11) NOT NULL,
  `karyawan_id` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `penjual` varchar(200) NOT NULL,
  `alamat` text NOT NULL,
  `tanggal` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hbeli`
--

INSERT INTO `hbeli` (`id`, `karyawan_id`, `total`, `penjual`, `alamat`, `tanggal`) VALUES
(8, 2, 2000, '', '', '2023-05-14 06:33:22.170189'),
(9, 2, 100000, 'jojo', 'taman', '2023-05-14 06:33:59.057597'),
(10, 2, 27500, 'ivander', 'simo', '2023-05-14 06:34:29.723788'),
(11, 2, 15000, 'wina', 'pokcan', '2023-05-14 06:34:57.040008'),
(12, 2, 50000, 'ed', 'manyar', '2023-05-15 01:23:09.595639');

-- --------------------------------------------------------

--
-- Table structure for table `hjual`
--

CREATE TABLE `hjual` (
  `id` int(11) NOT NULL,
  `karyawan_id` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `customer` int(11) NOT NULL,
  `alamat` text NOT NULL,
  `tanggal` timestamp(6) NOT NULL DEFAULT current_timestamp(6) ON UPDATE current_timestamp(6)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hjual`
--

INSERT INTO `hjual` (`id`, `karyawan_id`, `total`, `customer`, `alamat`, `tanggal`) VALUES
(8, 3, 12000, 1, 'Surabaya Dekat ISTTS', '2023-05-15 02:07:00.972245');

-- --------------------------------------------------------

--
-- Table structure for table `ikan`
--

CREATE TABLE `ikan` (
  `id` int(10) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `waktu` int(10) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ikan`
--

INSERT INTO `ikan` (`id`, `nama`, `waktu`, `harga`) VALUES
(1, 'Cupang Hias', 2, 1000),
(2, 'Lele', 2, 2500),
(3, 'Gurami', 4, 5000);

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `id` int(20) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `username` varchar(200) NOT NULL,
  `telp` varchar(200) NOT NULL,
  `role` int(20) NOT NULL,
  `status` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`id`, `nama`, `username`, `telp`, `role`, `status`) VALUES
(1, 'Calvin Adhikang', 'calvin', '123123', 0, 0),
(2, 'Edward Patrick', 'ed', '456', 2, 1),
(3, 'Jojo', 'jo', '123', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `kolam`
--

CREATE TABLE `kolam` (
  `id` int(10) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `kapasitas` int(10) NOT NULL,
  `status` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kolam`
--

INSERT INTO `kolam` (`id`, `nama`, `kapasitas`, `status`) VALUES
(1, 'Kolam Utara 1', 100, 0),
(2, 'kolam selatan', 70, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dbeli`
--
ALTER TABLE `dbeli`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `djual`
--
ALTER TABLE `djual`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `hbeli`
--
ALTER TABLE `hbeli`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `hjual`
--
ALTER TABLE `hjual`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ikan`
--
ALTER TABLE `ikan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kolam`
--
ALTER TABLE `kolam`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `dbeli`
--
ALTER TABLE `dbeli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `djual`
--
ALTER TABLE `djual`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `hbeli`
--
ALTER TABLE `hbeli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `hjual`
--
ALTER TABLE `hjual`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `ikan`
--
ALTER TABLE `ikan`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `kolam`
--
ALTER TABLE `kolam`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
