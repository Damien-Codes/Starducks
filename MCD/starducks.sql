-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 28, 2024 at 07:31 PM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

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
  `numboissons` int NOT NULL,
  `nom` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `prix` float NOT NULL,
  `imageboissons` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `boissons`
--

INSERT INTO `boissons` (`numboissons`, `nom`, `prix`, `imageboissons`) VALUES
(30, 'Thé Glacée', 15, 'System.Byte[]'),
(32, 'Thé Glacée (Vanille)', 18.77, 'System.Byte[]'),
(34, 'Chocolat chaud', 11, 'System.Byte[]'),
(35, 'Chocolat froid', 9, 'System.Byte[]');

-- --------------------------------------------------------

--
-- Table structure for table `commande`
--

CREATE TABLE `commande` (
  `id` int NOT NULL,
  `datecom` datetime NOT NULL,
  `user` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `prix` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `commande`
--

INSERT INTO `commande` (`id`, `datecom`, `user`, `prix`) VALUES
(1, '2024-04-21 23:24:09', 'vacancier', 19),
(2, '2024-04-26 17:22:49', 'vacancier', 9);

-- --------------------------------------------------------

--
-- Table structure for table `responsable`
--

CREATE TABLE `responsable` (
  `code` int NOT NULL,
  `fatembauche` date NOT NULL,
  `fonction` varchar(20) COLLATE utf8mb4_general_ci NOT NULL
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
  `id` int NOT NULL,
  `user` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `mdp` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `typeuser` char(1) COLLATE utf8mb4_general_ci NOT NULL,
  `mailuser` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `numteluser` int NOT NULL
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
  `code` int NOT NULL,
  `age` int NOT NULL,
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
  `numville` int NOT NULL,
  `num` int NOT NULL,
  `rue` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `cp` varchar(5) COLLATE utf8mb4_general_ci NOT NULL,
  `ville` varchar(75) COLLATE utf8mb4_general_ci NOT NULL
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
  MODIFY `numboissons` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `commande`
--
ALTER TABLE `commande`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `responsable`
--
ALTER TABLE `responsable`
  MODIFY `code` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `vacancier`
--
ALTER TABLE `vacancier`
  MODIFY `code` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `ville`
--
ALTER TABLE `ville`
  MODIFY `numville` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
