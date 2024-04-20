-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 29, 2024 at 11:14 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `starducks`
--

-- --------------------------------------------------------

--
-- Table structure for table `boissons`
--

CREATE TABLE `boissons` (
  `numboissons` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prix` float NOT NULL,
  `imageboissons` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `boissons`
--

INSERT INTO `boissons` (`numboissons`, `nom`, `prix`, `imageboissons`) VALUES
(24, 'Yomi', 5050, '????\0JFIF\0\0`\0`\0\0??\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0'),
(25, 'Yomi Denzel', 5057900000, '????\0JFIF\0\0`\0`\0\0??\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0'),
(26, 'rdazueaozi', 5050, '?PNG\r\n\Z\n\0\0\0\rIHDR\0\0?\0\0?\0\0\0=P?\0\0 \0IDATx^???%?u'),
(27, 'Coffee latté', 14.79, '????\0JFIF\0\0`\0`\0\0??\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0');

-- --------------------------------------------------------

--
-- Table structure for table `commande`
--

CREATE TABLE `commande` (
  `id` int(11) NOT NULL,
  `datecom` datetime NOT NULL,
  `user` varchar(150) NOT NULL,
  `prix` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `responsable`
--

CREATE TABLE `responsable` (
  `code` int(11) NOT NULL,
  `fatembauche` date NOT NULL,
  `fonction` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `responsable`
--

INSERT INTO `responsable` (`code`, `fatembauche`, `fonction`) VALUES
(1, '2024-02-12', 'Serveur');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `user` varchar(50) NOT NULL,
  `mdp` varchar(50) NOT NULL,
  `typeuser` char(1) NOT NULL,
  `mailuser` varchar(50) NOT NULL,
  `numteluser` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `user`, `mdp`, `typeuser`, `mailuser`, `numteluser`) VALUES
(1, 'responsable', 'responsable1234', 'R', 'responsable1234@gmail.com', 188765432),
(2, 'vacancier', 'vacancier1234', 'V', 'vacancier1234@gmail.com', 684761492);

-- --------------------------------------------------------

--
-- Table structure for table `vacancier`
--

CREATE TABLE `vacancier` (
  `code` int(11) NOT NULL,
  `age` int(100) NOT NULL,
  `dateinscription` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vacancier`
--

INSERT INTO `vacancier` (`code`, `age`, `dateinscription`) VALUES
(1, 20, '2024-02-12');

-- --------------------------------------------------------

--
-- Table structure for table `ville`
--

CREATE TABLE `ville` (
  `numville` int(11) NOT NULL,
  `num` int(100) NOT NULL,
  `rue` varchar(150) NOT NULL,
  `cp` varchar(5) NOT NULL,
  `ville` varchar(75) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ville`
--

INSERT INTO `ville` (`numville`, `num`, `rue`, `cp`, `ville`) VALUES
(1, 5, 'rue des feuille', '91120', 'Palaiseau');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `boissons`
--
ALTER TABLE `boissons`
  ADD PRIMARY KEY (`numboissons`);

--
-- Indexes for table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `responsable`
--
ALTER TABLE `responsable`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `vacancier`
--
ALTER TABLE `vacancier`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `ville`
--
ALTER TABLE `ville`
  ADD PRIMARY KEY (`numville`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `boissons`
--
ALTER TABLE `boissons`
  MODIFY `numboissons` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `commande`
--
ALTER TABLE `commande`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `responsable`
--
ALTER TABLE `responsable`
  MODIFY `code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `vacancier`
--
ALTER TABLE `vacancier`
  MODIFY `code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `ville`
--
ALTER TABLE `ville`
  MODIFY `numville` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
