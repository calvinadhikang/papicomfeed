-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 04, 2023 at 06:40 PM
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
(1, 'nama1', 'alamat1', 123);

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
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Table structure for table `ikan`
--

CREATE TABLE `ikan` (
  `id` int(10) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `waktu` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ikan`
--

INSERT INTO `ikan` (`id`, `nama`, `waktu`) VALUES
(1, 'ikan1', 2),
(2, 'ikan2', 12);

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
(1, 'Calvin Adhikang', 'calvin', '123123', 0, 0);

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
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `dbeli`
--
ALTER TABLE `dbeli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `djual`
--
ALTER TABLE `djual`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `hbeli`
--
ALTER TABLE `hbeli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `hjual`
--
ALTER TABLE `hjual`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ikan`
--
ALTER TABLE `ikan`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `kolam`
--
ALTER TABLE `kolam`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
