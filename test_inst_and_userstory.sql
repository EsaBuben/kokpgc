-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Nov 13, 2023 at 11:42 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testirekisteri`
--

-- --------------------------------------------------------

--
-- Table structure for table `instruction`
--

CREATE TABLE `instruction` (
  `instruction_id` int(11) NOT NULL,
  `ref_test_id` int(11) NOT NULL,
  `info` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE `test` (
  `test_id` int(11) NOT NULL,
  `ref_functionality_id` int(11) NOT NULL,
  `responsible_user_id` int(11) DEFAULT NULL,
  `priority` int(11) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `userstory`
--

CREATE TABLE `userstory` (
  `userstory_id` int(11) NOT NULL,
  `ref_functionality_id` int(11) NOT NULL,
  `given_text` varchar(100) DEFAULT NULL,
  `when_text` varchar(100) DEFAULT NULL,
  `then_text` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `instruction`
--
ALTER TABLE `instruction`
  ADD PRIMARY KEY (`instruction_id`),
  ADD KEY `ref_test_id` (`ref_test_id`);

--
-- Indexes for table `test`
--
ALTER TABLE `test`
  ADD PRIMARY KEY (`test_id`),
  ADD KEY `ref_functionality_id` (`ref_functionality_id`),
  ADD KEY `responsible_user_id` (`responsible_user_id`);

--
-- Indexes for table `userstory`
--
ALTER TABLE `userstory`
  ADD PRIMARY KEY (`userstory_id`),
  ADD KEY `ref_functionality_id` (`ref_functionality_id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `instruction`
--
ALTER TABLE `instruction`
  ADD CONSTRAINT `instruction_ibfk_1` FOREIGN KEY (`ref_test_id`) REFERENCES `test` (`test_id`);

--
-- Constraints for table `test`
--
ALTER TABLE `test`
  ADD CONSTRAINT `test_ibfk_1` FOREIGN KEY (`ref_functionality_id`) REFERENCES `functionality` (`functionality_id`),
  ADD CONSTRAINT `test_ibfk_2` FOREIGN KEY (`responsible_user_id`) REFERENCES `user` (`user_id`);

--
-- Constraints for table `userstory`
--
ALTER TABLE `userstory`
  ADD CONSTRAINT `userstory_ibfk_1` FOREIGN KEY (`ref_functionality_id`) REFERENCES `functionality` (`functionality_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
