-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 25, 2025 at 11:22 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hcsansor`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_appointment`
--

CREATE TABLE `tbl_appointment` (
  `appointment_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `stylist_id` int(11) DEFAULT NULL,
  `Date` varchar(255) NOT NULL,
  `Time` varchar(255) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `Status` enum('Scheduled','No Show','Completed','Cancelled','Refunded') NOT NULL,
  `payment_status` varchar(45) NOT NULL,
  `booking_type` varchar(255) NOT NULL,
  `cancel_Request` enum('None','Requested','Approved','Denied') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_appointment`
--

INSERT INTO `tbl_appointment` (`appointment_id`, `customer_id`, `stylist_id`, `Date`, `Time`, `start_time`, `end_time`, `Status`, `payment_status`, `booking_type`, `cancel_Request`) VALUES
(878, 56, NULL, '2025-10-25 00:00:00', '', '09:00:00', '09:25:00', 'Scheduled', 'Unpaid', 'Online', 'None'),
(879, 56, NULL, '2025-10-29 00:00:00', '', '09:00:00', '09:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(880, 56, NULL, '2025-10-25 00:00:00', '', '11:00:00', '11:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(881, 56, NULL, '2025-10-25 00:00:00', '', '12:00:00', '12:25:00', 'Scheduled', 'Unpaid', 'Online', 'None'),
(882, 48, NULL, '2025-11-08 00:00:00', '', '09:00:00', '09:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(883, 48, NULL, '2025-10-25 00:00:00', '', '10:00:00', '10:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(884, 48, NULL, '2025-10-25 00:00:00', '', '09:00:00', '09:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(885, 48, NULL, '2025-11-05 00:00:00', '', '10:00:00', '10:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(886, 48, NULL, '2025-11-04 00:00:00', '', '09:00:00', '09:25:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_appointment_archive`
--

CREATE TABLE `tbl_appointment_archive` (
  `appointment_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `stylist_id` int(11) NOT NULL,
  `Date` varchar(255) NOT NULL,
  `Time` varchar(255) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `Status` enum('Pending','Approved','Disapproved','Completed','Cancelled') NOT NULL,
  `cancel_Request` enum('None','Requested','Approved','Denied') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_appointment_archive`
--

INSERT INTO `tbl_appointment_archive` (`appointment_id`, `customer_id`, `stylist_id`, `Date`, `Time`, `start_time`, `end_time`, `Status`, `cancel_Request`) VALUES
(4, 37, 4, '2025-01-03', '', '09:00:00', '09:20:00', 'Pending', 'None'),
(5, 37, 4, '2025-01-03', '', '10:00:00', '10:20:00', 'Pending', 'None'),
(6, 37, 4, '2025-01-03', '', '11:00:00', '11:20:00', 'Pending', 'None'),
(7, 37, 4, '2025-01-05', '', '09:00:00', '09:20:00', 'Pending', 'None'),
(8, 37, 4, '2025-01-05', '', '10:00:00', '10:20:00', 'Pending', 'None'),
(9, 37, 4, '2025-01-05', '', '11:00:00', '11:20:00', 'Pending', 'None'),
(10, 37, 4, '2025-02-18', '', '09:00:00', '09:20:00', 'Pending', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_appointment_services`
--

CREATE TABLE `tbl_appointment_services` (
  `appointment_service_id` int(11) NOT NULL,
  `appointment_id` int(11) DEFAULT NULL,
  `serviceName_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_appointment_services`
--

INSERT INTO `tbl_appointment_services` (`appointment_service_id`, `appointment_id`, `serviceName_id`) VALUES
(934, 878, 96),
(935, 879, 96),
(936, 880, 96),
(937, 881, 96),
(938, 882, 96),
(939, 883, 96),
(940, 884, 96),
(941, 885, 96),
(942, 886, 96);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_appointment_services_archive`
--

CREATE TABLE `tbl_appointment_services_archive` (
  `appointment_service_id` int(11) NOT NULL,
  `appointment_id` int(11) DEFAULT NULL,
  `serviceName_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_appointment_services_archive`
--

INSERT INTO `tbl_appointment_services_archive` (`appointment_service_id`, `appointment_id`, `serviceName_id`) VALUES
(743, 713, 73),
(744, 714, 73),
(745, 715, 73),
(746, 716, 73),
(747, 717, 73),
(748, 718, 73),
(749, 719, 73);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_audit_trail`
--

CREATE TABLE `tbl_audit_trail` (
  `id` int(11) NOT NULL,
  `user` varchar(255) NOT NULL,
  `action` varchar(255) NOT NULL,
  `module` varchar(255) NOT NULL,
  `note` varchar(255) NOT NULL,
  `timestamp` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_audit_trail`
--

INSERT INTO `tbl_audit_trail` (`id`, `user`, `action`, `module`, `note`, `timestamp`) VALUES
(33, 'admin', 'Create', 'Manage User', 'Created new user for testtest on 10/10/2025 12:00:00 AM at 00:00:00', '2025-10-10 12:40:37'),
(34, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 14:30:02', '2025-10-10 14:30:02'),
(35, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 14:52:30', '2025-10-10 14:52:30'),
(36, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 14:53:04', '2025-10-10 14:53:04'),
(37, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 14:53:09', '2025-10-10 14:53:09'),
(38, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:20:40', '2025-10-10 15:20:40'),
(39, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 15:20:46', '2025-10-10 15:20:46'),
(40, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 15:20:46', '2025-10-10 15:20:46'),
(41, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:20:50', '2025-10-10 15:20:50'),
(42, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:21:09', '2025-10-10 15:21:09'),
(43, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:21:43', '2025-10-10 15:21:43'),
(44, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:21:46', '2025-10-10 15:21:46'),
(45, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:31:41', '2025-10-10 15:31:41'),
(46, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:31:48', '2025-10-10 15:31:48'),
(47, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:36:15', '2025-10-10 15:36:15'),
(48, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:36:18', '2025-10-10 15:36:18'),
(49, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:41:22', '2025-10-10 15:41:22'),
(50, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:41:25', '2025-10-10 15:41:25'),
(51, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:42:10', '2025-10-10 15:42:10'),
(52, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:42:13', '2025-10-10 15:42:13'),
(53, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-10 at 15:42:34', '2025-10-10 15:42:34'),
(54, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-10 at 15:42:38', '2025-10-10 15:42:38'),
(55, 'Kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-10 at 15:42:43', '2025-10-10 15:42:43'),
(56, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:44:15', '2025-10-10 15:44:15'),
(57, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:44:18', '2025-10-10 15:44:18'),
(58, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:44:35', '2025-10-10 15:44:35'),
(59, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-10 at 15:44:36', '2025-10-10 15:44:36'),
(60, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:44:49', '2025-10-10 15:44:49'),
(61, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:44:52', '2025-10-10 15:44:52'),
(62, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:45:57', '2025-10-10 15:45:57'),
(63, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:46:01', '2025-10-10 15:46:01'),
(64, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 15:46:23', '2025-10-10 15:46:23'),
(65, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:46:24', '2025-10-10 15:46:24'),
(66, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 15:46:24', '2025-10-10 15:46:24'),
(67, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:46:25', '2025-10-10 15:46:25'),
(68, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:47:30', '2025-10-10 15:47:30'),
(69, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:47:33', '2025-10-10 15:47:33'),
(70, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:50:43', '2025-10-10 15:50:43'),
(71, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:50:46', '2025-10-10 15:50:46'),
(72, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-10 at 15:50:47', '2025-10-10 15:50:47'),
(73, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-10 at 15:50:51', '2025-10-10 15:50:51'),
(74, 'Kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-10 at 15:50:52', '2025-10-10 15:50:52'),
(75, 'Kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-10 at 15:50:53', '2025-10-10 15:50:53'),
(76, 'Kindeo', 'View', 'Delivery Report', 'Viewed Delivery Report on 2025-10-10 at 15:50:53', '2025-10-10 15:50:53'),
(77, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-10 at 15:50:54', '2025-10-10 15:50:54'),
(78, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-10 at 15:50:54', '2025-10-10 15:50:54'),
(79, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:55:28', '2025-10-10 15:55:28'),
(80, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:55:32', '2025-10-10 15:55:32'),
(81, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-10 at 15:55:34', '2025-10-10 15:55:34'),
(82, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 15:56:19', '2025-10-10 15:56:19'),
(83, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 15:56:27', '2025-10-10 15:56:27'),
(84, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-10 at 15:56:30', '2025-10-10 15:56:30'),
(85, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 17:59:01', '2025-10-10 17:59:01'),
(86, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 18:00:37', '2025-10-10 18:00:37'),
(87, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 18:02:21', '2025-10-10 18:02:21'),
(88, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 18:02:21', '2025-10-10 18:02:21'),
(89, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 18:03:19', '2025-10-10 18:03:19'),
(90, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-10 at 18:03:32', '2025-10-10 18:03:32'),
(91, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 18:04:29', '2025-10-10 18:04:29'),
(92, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 18:04:30', '2025-10-10 18:04:30'),
(93, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 18:04:40', '2025-10-10 18:04:40'),
(94, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 18:05:28', '2025-10-10 18:05:28'),
(95, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 18:05:48', '2025-10-10 18:05:48'),
(96, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 18:05:53', '2025-10-10 18:05:53'),
(97, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 18:06:14', '2025-10-10 18:06:14'),
(98, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 18:06:17', '2025-10-10 18:06:17'),
(99, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 18:06:18', '2025-10-10 18:06:18'),
(100, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-10 at 18:06:24', '2025-10-10 18:06:24'),
(101, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:06:32', '2025-10-10 19:06:32'),
(102, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:06:39', '2025-10-10 19:06:39'),
(103, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:09:09', '2025-10-10 19:09:09'),
(104, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:09:13', '2025-10-10 19:09:13'),
(105, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:14:00', '2025-10-10 19:14:00'),
(106, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:14:06', '2025-10-10 19:14:06'),
(107, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:25:48', '2025-10-10 19:25:48'),
(108, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:25:53', '2025-10-10 19:25:53'),
(109, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:27:27', '2025-10-10 19:27:27'),
(110, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:27:31', '2025-10-10 19:27:31'),
(111, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:35:38', '2025-10-10 19:35:38'),
(112, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:35:42', '2025-10-10 19:35:42'),
(113, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:40:18', '2025-10-10 19:40:18'),
(114, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:40:24', '2025-10-10 19:40:24'),
(115, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:41:58', '2025-10-10 19:41:58'),
(116, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 19:42:04', '2025-10-10 19:42:04'),
(117, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Nail\' on 2025-10-10 at 19:42:42', '2025-10-10 19:42:42'),
(118, 'Kindeo', 'Create', 'Manage Sub-Categories', 'Created sub-category \'Nail Treatment\' for (Nail Treatment) on 2025-10-10 at 19:42:58', '2025-10-10 19:42:58'),
(119, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Nail \' on 2025-10-10 at 19:43:32', '2025-10-10 19:43:32'),
(120, 'Kindeo', 'Create', 'Manage Products', 'Created product \'nail treatment\' on 2025-10-10 at 19:44:12', '2025-10-10 19:44:12'),
(121, 'Kindeo', 'Add', 'Manage Delivery', 'Added delivery for product \'\' (Qty: 20, Volume: 4000) on 2025-10-10 at 19:44:36', '2025-10-10 19:44:36'),
(122, 'Kindeo', 'Create', 'Manage Services', 'Created service \'Nail Treatment\' on 2025-10-10 at 19:44:57', '2025-10-10 19:44:57'),
(123, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'nail treatment\' for (Nail Treatment) on 2025-10-10 at 19:45:09', '2025-10-10 19:45:09'),
(124, 'Kindeo', 'Create', 'Service Price', 'Created service \'Nail Treatment\' with a price of ₱100 on 2025-10-10 at 19:45:25', '2025-10-10 19:45:25'),
(125, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-10 at 19:45:55', '2025-10-10 19:45:55'),
(126, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 19:46:35', '2025-10-10 19:46:35'),
(127, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:46:39', '2025-10-10 19:46:39'),
(128, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 19:46:58', '2025-10-10 19:46:58'),
(129, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-10 at 19:48:01', '2025-10-10 19:48:01'),
(130, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 19:48:09', '2025-10-10 19:48:09'),
(131, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:48:10', '2025-10-10 19:48:10'),
(132, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 19:57:51', '2025-10-10 19:57:51'),
(133, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 19:57:55', '2025-10-10 19:57:55'),
(134, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:57:56', '2025-10-10 19:57:56'),
(135, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 19:57:58', '2025-10-10 19:57:58'),
(136, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-10 at 19:58:22', '2025-10-10 19:58:22'),
(137, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 19:59:12', '2025-10-10 19:59:12'),
(138, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 19:59:17', '2025-10-10 19:59:17'),
(139, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 19:59:37', '2025-10-10 19:59:37'),
(140, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 20:14:16', '2025-10-10 20:14:16'),
(141, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 20:14:21', '2025-10-10 20:14:21'),
(142, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-10 at 20:14:46', '2025-10-10 20:14:46'),
(143, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 20:14:57', '2025-10-10 20:14:57'),
(144, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 20:15:18', '2025-10-10 20:15:18'),
(145, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 20:15:20', '2025-10-10 20:15:20'),
(146, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 20:15:22', '2025-10-10 20:15:22'),
(147, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 20:15:26', '2025-10-10 20:15:26'),
(148, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 20:48:21', '2025-10-10 20:48:21'),
(149, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 20:48:27', '2025-10-10 20:48:27'),
(150, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:05:16', '2025-10-10 21:05:16'),
(151, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:05:23', '2025-10-10 21:05:23'),
(152, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:06:09', '2025-10-10 21:06:09'),
(153, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:06:13', '2025-10-10 21:06:13'),
(154, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:07:29', '2025-10-10 21:07:29'),
(155, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:07:33', '2025-10-10 21:07:33'),
(156, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:09:25', '2025-10-10 21:09:25'),
(157, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:09:28', '2025-10-10 21:09:28'),
(158, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:19:18', '2025-10-10 21:19:18'),
(159, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:19:22', '2025-10-10 21:19:22'),
(160, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:21:33', '2025-10-10 21:21:33'),
(161, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:21:44', '2025-10-10 21:21:44'),
(162, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:23:09', '2025-10-10 21:23:09'),
(163, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:23:13', '2025-10-10 21:23:13'),
(164, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 21:35:41', '2025-10-10 21:35:41'),
(165, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 21:35:44', '2025-10-10 21:35:44'),
(166, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 22:31:28', '2025-10-10 22:31:28'),
(167, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 22:31:32', '2025-10-10 22:31:32'),
(168, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 22:31:44', '2025-10-10 22:31:44'),
(169, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 22:31:46', '2025-10-10 22:31:46'),
(170, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 22:31:48', '2025-10-10 22:31:48'),
(171, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 22:33:22', '2025-10-10 22:33:22'),
(172, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 22:33:26', '2025-10-10 22:33:26'),
(173, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 22:33:28', '2025-10-10 22:33:28'),
(174, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 22:33:30', '2025-10-10 22:33:30'),
(175, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-10 at 22:33:43', '2025-10-10 22:33:43'),
(176, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 22:33:48', '2025-10-10 22:33:48'),
(177, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 22:34:02', '2025-10-10 22:34:02'),
(178, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:00:05', '2025-10-10 23:00:05'),
(179, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:00:08', '2025-10-10 23:00:08'),
(180, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:05:32', '2025-10-10 23:05:32'),
(181, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:05:36', '2025-10-10 23:05:36'),
(182, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-10 at 23:05:51', '2025-10-10 23:05:51'),
(183, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:06:32', '2025-10-10 23:06:32'),
(184, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:07:50', '2025-10-10 23:07:50'),
(185, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-10 at 23:08:10', '2025-10-10 23:08:10'),
(186, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:08:23', '2025-10-10 23:08:23'),
(187, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:31:34', '2025-10-10 23:31:34'),
(188, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:31:45', '2025-10-10 23:31:45'),
(189, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-10 at 23:32:05', '2025-10-10 23:32:05'),
(190, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:32:21', '2025-10-10 23:32:21'),
(191, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:35:39', '2025-10-10 23:35:39'),
(192, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:40:38', '2025-10-10 23:40:38'),
(193, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:42:04', '2025-10-10 23:42:04'),
(194, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'nail treatment\' for (Hair color) on 2025-10-10 at 23:42:15', '2025-10-10 23:42:15'),
(195, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:42:21', '2025-10-10 23:42:21'),
(196, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 23:42:23', '2025-10-10 23:42:23'),
(197, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-10 at 23:42:44', '2025-10-10 23:42:44'),
(198, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 23:43:16', '2025-10-10 23:43:16'),
(199, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 23:43:19', '2025-10-10 23:43:19'),
(200, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:43:47', '2025-10-10 23:43:47'),
(201, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 23:44:04', '2025-10-10 23:44:04'),
(202, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-10 at 23:44:05', '2025-10-10 23:44:05'),
(203, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 23:44:46', '2025-10-10 23:44:46'),
(204, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:48:14', '2025-10-10 23:48:14'),
(205, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:50:28', '2025-10-10 23:50:28'),
(206, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-10 at 23:50:48', '2025-10-10 23:50:48'),
(207, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'test123 123 123\' on 2025-10-10 at 23:51:03', '2025-10-10 23:51:03'),
(208, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-10 at 23:51:09', '2025-10-10 23:51:09'),
(209, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 23:51:11', '2025-10-10 23:51:11'),
(210, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 23:51:18', '2025-10-10 23:51:18'),
(211, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-10 at 23:51:32', '2025-10-10 23:51:32'),
(212, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-10 at 23:51:37', '2025-10-10 23:51:37'),
(213, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:51:43', '2025-10-10 23:51:43'),
(214, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:51:48', '2025-10-10 23:51:48'),
(215, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:54:38', '2025-10-10 23:54:38'),
(216, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:54:44', '2025-10-10 23:54:44'),
(217, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:54:48', '2025-10-10 23:54:48'),
(218, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-10 at 23:58:35', '2025-10-10 23:58:35'),
(219, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-10 at 23:58:40', '2025-10-10 23:58:40'),
(220, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-11 at 16:54:57', '2025-10-11 16:54:57'),
(221, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-11 at 16:55:17', '2025-10-11 16:55:17'),
(222, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-11 at 17:01:02', '2025-10-11 17:01:02'),
(223, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-11 at 17:01:17', '2025-10-11 17:01:17'),
(224, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-11 at 17:01:47', '2025-10-11 17:01:47'),
(225, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-11 at 21:22:39', '2025-10-11 21:22:39'),
(226, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-11 at 21:23:00', '2025-10-11 21:23:00'),
(227, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-11 at 21:23:05', '2025-10-11 21:23:05'),
(228, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-11 at 21:26:44', '2025-10-11 21:26:44'),
(229, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 19:16:26', '2025-10-12 19:16:26'),
(230, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-12 at 19:16:59', '2025-10-12 19:16:59'),
(231, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 20:14:47', '2025-10-12 20:14:47'),
(232, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 20:20:55', '2025-10-12 20:20:55'),
(233, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 21:33:47', '2025-10-12 21:33:47'),
(234, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 21:47:08', '2025-10-12 21:47:08'),
(235, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 21:48:23', '2025-10-12 21:48:23'),
(236, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 21:52:09', '2025-10-12 21:52:09'),
(237, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 21:59:55', '2025-10-12 21:59:55'),
(238, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:04:16', '2025-10-12 22:04:16'),
(239, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:05:55', '2025-10-12 22:05:55'),
(240, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:11:23', '2025-10-12 22:11:23'),
(241, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:15:35', '2025-10-12 22:15:35'),
(242, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:22:07', '2025-10-12 22:22:07'),
(243, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:23:06', '2025-10-12 22:23:06'),
(244, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:25:49', '2025-10-12 22:25:49'),
(245, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'test123 123 123\' on 2025-10-12 at 22:26:27', '2025-10-12 22:26:27'),
(246, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:27:19', '2025-10-12 22:27:19'),
(247, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:28:49', '2025-10-12 22:28:49'),
(248, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-12 at 22:28:55', '2025-10-12 22:28:55'),
(249, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 22:28:56', '2025-10-12 22:28:56'),
(250, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-12 at 22:28:57', '2025-10-12 22:28:57'),
(251, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 22:29:19', '2025-10-12 22:29:19'),
(252, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-12 at 22:29:19', '2025-10-12 22:29:19'),
(253, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:32:46', '2025-10-12 22:32:46'),
(254, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:35:02', '2025-10-12 22:35:02'),
(255, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:36:11', '2025-10-12 22:36:11'),
(256, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:40:56', '2025-10-12 22:40:56'),
(257, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 22:47:28', '2025-10-12 22:47:28'),
(258, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-12 at 22:47:53', '2025-10-12 22:47:53'),
(259, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:11:41', '2025-10-12 23:11:41'),
(260, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:14:12', '2025-10-12 23:14:12'),
(261, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:14:16', '2025-10-12 23:14:16'),
(262, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:14:19', '2025-10-12 23:14:19'),
(263, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-12 at 23:14:37', '2025-10-12 23:14:37'),
(264, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-12 at 23:14:52', '2025-10-12 23:14:52'),
(265, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:14:53', '2025-10-12 23:14:53'),
(266, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-12 at 23:14:55', '2025-10-12 23:14:55'),
(267, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:14:58', '2025-10-12 23:14:58'),
(268, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:15:05', '2025-10-12 23:15:05'),
(269, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:16:37', '2025-10-12 23:16:37'),
(270, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-12 at 23:16:56', '2025-10-12 23:16:56'),
(271, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-12 at 23:17:15', '2025-10-12 23:17:15'),
(272, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-12 at 23:17:20', '2025-10-12 23:17:20'),
(273, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-12 at 23:17:32', '2025-10-12 23:17:32'),
(274, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:17:34', '2025-10-12 23:17:34'),
(275, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:17:55', '2025-10-12 23:17:55'),
(276, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-12 at 23:18:09', '2025-10-12 23:18:09'),
(277, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:22:40', '2025-10-12 23:22:40'),
(278, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-12 at 23:22:57', '2025-10-12 23:22:57'),
(279, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-12 at 23:23:10', '2025-10-12 23:23:10'),
(280, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:23:18', '2025-10-12 23:23:18'),
(281, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:23:21', '2025-10-12 23:23:21'),
(282, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:23:27', '2025-10-12 23:23:27'),
(283, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-12 at 23:23:36', '2025-10-12 23:23:36'),
(284, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-12 at 23:23:36', '2025-10-12 23:23:36'),
(285, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:27:03', '2025-10-12 23:27:03'),
(286, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:27:07', '2025-10-12 23:27:07'),
(287, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:28:03', '2025-10-12 23:28:03'),
(288, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:31:13', '2025-10-12 23:31:13'),
(289, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:32:59', '2025-10-12 23:32:59'),
(290, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:33:03', '2025-10-12 23:33:03'),
(291, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-12 at 23:33:23', '2025-10-12 23:33:23'),
(292, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:33:27', '2025-10-12 23:33:27'),
(293, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:33:35', '2025-10-12 23:33:35'),
(294, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:33:42', '2025-10-12 23:33:42'),
(295, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-12 at 23:34:03', '2025-10-12 23:34:03'),
(296, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:34:05', '2025-10-12 23:34:05'),
(297, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:37:32', '2025-10-12 23:37:32'),
(298, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:37:36', '2025-10-12 23:37:36'),
(299, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:37:41', '2025-10-12 23:37:41'),
(300, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:37:53', '2025-10-12 23:37:53'),
(301, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-12 at 23:40:44', '2025-10-12 23:40:44'),
(302, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:40:51', '2025-10-12 23:40:51'),
(303, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-12 at 23:40:58', '2025-10-12 23:40:58'),
(304, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-12 at 23:42:04', '2025-10-12 23:42:04'),
(305, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-12 at 23:42:05', '2025-10-12 23:42:05'),
(306, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-12 at 23:44:50', '2025-10-12 23:44:50'),
(307, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 00:40:01', '2025-10-13 00:40:01'),
(308, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 00:40:08', '2025-10-13 00:40:08'),
(309, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-13 at 00:40:17', '2025-10-13 00:40:17'),
(310, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-13 at 00:40:17', '2025-10-13 00:40:17'),
(311, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 00:40:31', '2025-10-13 00:40:31'),
(312, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 00:40:37', '2025-10-13 00:40:37'),
(313, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 00:40:47', '2025-10-13 00:40:47'),
(314, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-13 at 00:40:58', '2025-10-13 00:40:58'),
(315, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 00:42:43', '2025-10-13 00:42:43'),
(316, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 00:42:52', '2025-10-13 00:42:52'),
(317, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 00:43:02', '2025-10-13 00:43:02'),
(318, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 00:43:03', '2025-10-13 00:43:03'),
(319, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:23:24', '2025-10-13 01:23:24'),
(320, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:23:28', '2025-10-13 01:23:28'),
(321, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:24:24', '2025-10-13 01:24:24'),
(322, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:24:27', '2025-10-13 01:24:27'),
(323, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:27:43', '2025-10-13 01:27:43'),
(324, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:27:46', '2025-10-13 01:27:46'),
(325, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:30:33', '2025-10-13 01:30:33'),
(326, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:30:35', '2025-10-13 01:30:35'),
(327, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:31:37', '2025-10-13 01:31:37'),
(328, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:31:44', '2025-10-13 01:31:44'),
(329, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:31:54', '2025-10-13 01:31:54'),
(330, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:32:05', '2025-10-13 01:32:05'),
(331, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-13 at 01:32:11', '2025-10-13 01:32:11'),
(332, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:32:32', '2025-10-13 01:32:32'),
(333, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:32:35', '2025-10-13 01:32:35'),
(334, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:32:56', '2025-10-13 01:32:56'),
(335, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:32:59', '2025-10-13 01:32:59'),
(336, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-13 at 01:33:10', '2025-10-13 01:33:10'),
(337, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:34:39', '2025-10-13 01:34:39'),
(338, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:34:42', '2025-10-13 01:34:42'),
(339, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:35:07', '2025-10-13 01:35:07'),
(340, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:35:10', '2025-10-13 01:35:10'),
(341, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-13 at 01:35:15', '2025-10-13 01:35:15'),
(342, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:35:43', '2025-10-13 01:35:43'),
(343, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:35:46', '2025-10-13 01:35:46'),
(344, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 01:35:55', '2025-10-13 01:35:55'),
(345, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 01:36:03', '2025-10-13 01:36:03'),
(346, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:36:08', '2025-10-13 01:36:08'),
(347, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 01:53:22', '2025-10-13 01:53:22'),
(348, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:53:46', '2025-10-13 01:53:46'),
(349, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 01:53:55', '2025-10-13 01:53:55'),
(350, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 01:53:58', '2025-10-13 01:53:58'),
(351, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 01:53:58', '2025-10-13 01:53:58'),
(352, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 01:54:01', '2025-10-13 01:54:01'),
(353, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:06:08', '2025-10-13 02:06:08'),
(354, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 02:06:11', '2025-10-13 02:06:11'),
(355, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:06:12', '2025-10-13 02:06:12'),
(356, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 02:06:14', '2025-10-13 02:06:14'),
(357, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:07:40', '2025-10-13 02:07:40'),
(358, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 02:07:43', '2025-10-13 02:07:43'),
(359, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:07:45', '2025-10-13 02:07:45'),
(360, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 02:07:46', '2025-10-13 02:07:46'),
(361, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:09:20', '2025-10-13 02:09:20'),
(362, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:09:24', '2025-10-13 02:09:24'),
(363, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 02:09:25', '2025-10-13 02:09:25'),
(364, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:11:06', '2025-10-13 02:11:06'),
(365, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 02:11:09', '2025-10-13 02:11:09'),
(366, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:11:12', '2025-10-13 02:11:12'),
(367, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-13 at 02:11:13', '2025-10-13 02:11:13'),
(368, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 02:11:18', '2025-10-13 02:11:18'),
(369, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:11:52', '2025-10-13 02:11:52'),
(370, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:11:55', '2025-10-13 02:11:55'),
(371, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 02:11:56', '2025-10-13 02:11:56'),
(372, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:12:25', '2025-10-13 02:12:25'),
(373, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:12:28', '2025-10-13 02:12:28'),
(374, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 02:12:30', '2025-10-13 02:12:30'),
(375, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-13 at 02:12:35', '2025-10-13 02:12:35'),
(376, 'Kindeo', 'View', 'Delivery Report', 'Viewed Delivery Report on 2025-10-13 at 02:12:38', '2025-10-13 02:12:38'),
(377, 'Kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-13 at 02:12:39', '2025-10-13 02:12:39'),
(378, 'Kindeo', 'View', 'Customer Report', 'Viewed Customer Report on 2025-10-13 at 02:12:39', '2025-10-13 02:12:39'),
(379, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-13 at 02:12:40', '2025-10-13 02:12:40'),
(380, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-13 at 02:12:41', '2025-10-13 02:12:41'),
(381, 'Kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-13 at 02:12:41', '2025-10-13 02:12:41'),
(382, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-13 at 02:12:43', '2025-10-13 02:12:43'),
(383, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-13 at 02:12:44', '2025-10-13 02:12:44'),
(384, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-13 at 02:12:45', '2025-10-13 02:12:45'),
(385, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-13 at 02:12:57', '2025-10-13 02:12:57'),
(386, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:56:07', '2025-10-13 02:56:07'),
(387, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 02:56:11', '2025-10-13 02:56:11'),
(388, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 02:58:54', '2025-10-13 02:58:54'),
(389, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 02:58:58', '2025-10-13 02:58:58'),
(390, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 02:59:00', '2025-10-13 02:59:00'),
(391, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 02:59:00', '2025-10-13 02:59:00'),
(392, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 03:04:58', '2025-10-13 03:04:58'),
(393, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 03:05:26', '2025-10-13 03:05:26'),
(394, 'Kindeo', 'Restock', 'Manage Delivery', 'Restocked existing product \'\' (Qty: 12, Volume: 2400) on 2025-10-13 at 03:05:44', '2025-10-13 03:05:44'),
(395, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 03:05:47', '2025-10-13 03:05:47'),
(396, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-13 at 03:05:57', '2025-10-13 03:05:57'),
(397, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 03:06:29', '2025-10-13 03:06:29'),
(398, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-13 at 03:06:32', '2025-10-13 03:06:32'),
(399, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 03:09:26', '2025-10-13 03:09:26'),
(400, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 03:09:30', '2025-10-13 03:09:30'),
(401, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-13 at 03:09:31', '2025-10-13 03:09:31'),
(402, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 03:14:37', '2025-10-13 03:14:37'),
(403, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 03:14:41', '2025-10-13 03:14:41'),
(404, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-13 at 03:14:43', '2025-10-13 03:14:43'),
(405, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 03:14:55', '2025-10-13 03:14:55'),
(406, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 03:14:56', '2025-10-13 03:14:56'),
(407, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 04:08:03', '2025-10-13 04:08:03'),
(408, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 04:08:15', '2025-10-13 04:08:15'),
(409, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 04:08:25', '2025-10-13 04:08:25'),
(410, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 06:33:55', '2025-10-13 06:33:55'),
(411, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: Mohaifa ) on 2025-10-13 at 06:34:28', '2025-10-13 06:34:28'),
(412, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: Mohaifa ) on 2025-10-13 at 06:34:33', '2025-10-13 06:34:33'),
(413, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: Mohaifa ) on 2025-10-13 at 06:34:37', '2025-10-13 06:34:37'),
(414, 'Kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'\' (Stylist: Mohaifa ) on 2025-10-13 at 06:35:01', '2025-10-13 06:35:01'),
(415, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-13 at 06:35:38', '2025-10-13 06:35:38'),
(416, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 06:36:05', '2025-10-13 06:36:05'),
(417, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 06:36:09', '2025-10-13 06:36:09'),
(418, 'Kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: ) on 2025-10-13 at 06:36:52', '2025-10-13 06:36:52'),
(419, 'Kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: ) on 2025-10-13 at 06:36:53', '2025-10-13 06:36:53'),
(420, 'Kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: ) on 2025-10-13 at 06:36:55', '2025-10-13 06:36:55'),
(421, 'Kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: ) on 2025-10-13 at 06:36:57', '2025-10-13 06:36:57'),
(422, 'Kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'\' (Stylist: Mohaifa ) on 2025-10-13 at 06:37:08', '2025-10-13 06:37:08'),
(423, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: Mohaifa ) on 2025-10-13 at 06:37:15', '2025-10-13 06:37:15'),
(424, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'monday\' (Stylist: Mohaifa ) on 2025-10-13 at 06:37:31', '2025-10-13 06:37:31'),
(425, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-13 at 06:37:44', '2025-10-13 06:37:44'),
(426, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-13 at 06:38:00', '2025-10-13 06:38:00'),
(427, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 06:38:21', '2025-10-13 06:38:21'),
(428, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 06:41:28', '2025-10-13 06:41:28'),
(429, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 06:41:33', '2025-10-13 06:41:33'),
(430, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-13 at 06:41:56', '2025-10-13 06:41:56'),
(431, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-13 at 06:41:57', '2025-10-13 06:41:57'),
(432, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 06:43:50', '2025-10-13 06:43:50'),
(433, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 06:44:20', '2025-10-13 06:44:20'),
(434, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 06:45:57', '2025-10-13 06:45:57'),
(435, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 06:46:31', '2025-10-13 06:46:31'),
(436, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 06:46:36', '2025-10-13 06:46:36'),
(437, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 06:46:40', '2025-10-13 06:46:40'),
(438, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 06:46:50', '2025-10-13 06:46:50'),
(439, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-13 at 06:46:54', '2025-10-13 06:46:54'),
(440, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-13 at 06:46:59', '2025-10-13 06:46:59'),
(441, 'Kindeo', 'View', 'Profit/Lost Report', 'Viewed Proft/Lost Report on 2025-10-13 at 06:47:14', '2025-10-13 06:47:14'),
(442, 'Kindeo', 'View', 'Customer Report', 'Viewed Customer Report on 2025-10-13 at 06:47:23', '2025-10-13 06:47:23'),
(443, 'Kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-13 at 06:47:32', '2025-10-13 06:47:32'),
(444, 'Kindeo', 'View', 'Delivery Report', 'Viewed Delivery Report on 2025-10-13 at 06:47:42', '2025-10-13 06:47:42'),
(445, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-13 at 06:47:51', '2025-10-13 06:47:51'),
(446, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 06:47:58', '2025-10-13 06:47:58'),
(447, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 08:56:51', '2025-10-13 08:56:51'),
(448, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-13 at 08:57:14', '2025-10-13 08:57:14'),
(449, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 09:25:10', '2025-10-13 09:25:10'),
(450, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 09:27:27', '2025-10-13 09:27:27'),
(451, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 09:28:48', '2025-10-13 09:28:48'),
(452, 'Kindeo', 'Create', 'Manage User', 'Created new user for Nissan Malik on 2025-10-13 at 09:31:49', '2025-10-13 09:31:49'),
(453, 'Kindeo', 'View', 'Manage User', 'Viewed user Nissan Malik on 2025-10-13 at 09:31:54', '2025-10-13 09:31:54'),
(454, 'Kindeo', 'Create', 'Manage Customer', 'Created customer \'Louis Jay Castillo\' on 2025-10-13 at 09:33:04', '2025-10-13 09:33:04'),
(455, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 09:33:59', '2025-10-13 09:33:59'),
(456, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 09:34:00', '2025-10-13 09:34:00'),
(457, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 09:34:34', '2025-10-13 09:34:34'),
(458, 'Kindeo', 'Update', 'Manage Customer', 'Updated customer \'Louis Jay Castillo\' on 2025-10-13 at 09:35:15', '2025-10-13 09:35:15'),
(459, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 09:36:24', '2025-10-13 09:36:24'),
(460, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 09:36:26', '2025-10-13 09:36:26'),
(461, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 09:39:54', '2025-10-13 09:39:54'),
(462, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-13 at 09:40:16', '2025-10-13 09:40:16');
INSERT INTO `tbl_audit_trail` (`id`, `user`, `action`, `module`, `note`, `timestamp`) VALUES
(463, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 09:40:23', '2025-10-13 09:40:23'),
(464, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-13 at 09:41:01', '2025-10-13 09:41:01'),
(465, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-13 at 09:41:01', '2025-10-13 09:41:01'),
(466, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-13 at 09:43:02', '2025-10-13 09:43:02'),
(467, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'monday\' (Stylist: kindeo123) on 2025-10-13 at 09:44:21', '2025-10-13 09:44:21'),
(468, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 09:46:19', '2025-10-13 09:46:19'),
(469, 'Kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-13 at 09:46:35', '2025-10-13 09:46:35'),
(470, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 09:48:42', '2025-10-13 09:48:42'),
(471, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 09:50:15', '2025-10-13 09:50:15'),
(472, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 09:50:16', '2025-10-13 09:50:16'),
(473, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 09:52:21', '2025-10-13 09:52:21'),
(474, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-13 at 09:52:29', '2025-10-13 09:52:29'),
(475, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-13 at 09:52:37', '2025-10-13 09:52:37'),
(476, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-13 at 09:52:46', '2025-10-13 09:52:46'),
(477, 'Kindeo', 'Create', 'Manage Products', 'Created product \'conditioner\' on 2025-10-13 at 10:13:59', '2025-10-13 10:13:59'),
(478, 'Kindeo', 'Update', 'Manage Products', 'Updated product \'conditioner\' on 2025-10-13 at 10:14:15', '2025-10-13 10:14:15'),
(479, 'Kindeo', 'Delete', 'Manage Products', 'Deleted product \'conditioner\' on 2025-10-13 at 10:14:21', '2025-10-13 10:14:21'),
(480, 'Kindeo', 'Update', 'Manage Categories', 'Updated category \'Nail Services\' on 2025-10-13 at 10:15:26', '2025-10-13 10:15:26'),
(481, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Others\' on 2025-10-13 at 10:15:38', '2025-10-13 10:15:38'),
(482, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Others\' on 2025-10-13 at 10:15:55', '2025-10-13 10:15:55'),
(483, 'Kindeo', 'Update', 'Manage Categories', 'Updated category \'Other Services\' on 2025-10-13 at 10:16:05', '2025-10-13 10:16:05'),
(484, 'Kindeo', 'Create', 'Manage Sub-Categories', 'Created sub-category \'Hair Cut\' for (Hair Cut) on 2025-10-13 at 10:19:49', '2025-10-13 10:19:49'),
(485, 'Kindeo', 'Update', 'Manage Sub-Categories', 'Updated sub-category \'Regular Nail Polish\' for (Regular Nail Polish) on 2025-10-13 at 10:20:22', '2025-10-13 10:20:22'),
(486, 'Kindeo', 'Create', 'Manage Products', 'Created product \'Hair Straightener\' on 2025-10-13 at 10:21:03', '2025-10-13 10:21:03'),
(487, 'Kindeo', 'Create', 'Manage Products', 'Created product \'Hair Neutralizer\' on 2025-10-13 at 10:21:40', '2025-10-13 10:21:40'),
(488, 'Kindeo', 'Delete', 'Manage Products', 'Deleted product \'Hair Color\' on 2025-10-13 at 10:21:46', '2025-10-13 10:21:46'),
(489, 'Kindeo', 'Delete', 'Manage Products', 'Deleted product \'nail treatment\' on 2025-10-13 at 10:21:49', '2025-10-13 10:21:49'),
(490, 'Kindeo', 'Add', 'Manage Delivery', 'Added delivery for product \'\' (Qty: 20, Volume: 20000) on 2025-10-13 at 10:23:01', '2025-10-13 10:23:01'),
(491, 'Kindeo', 'Add', 'Manage Delivery', 'Added delivery for product \'\' (Qty: 20, Volume: 20000) on 2025-10-13 at 10:23:01', '2025-10-13 10:23:01'),
(492, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'Hair Straightener\' for (Hair color) on 2025-10-13 at 10:23:42', '2025-10-13 10:23:42'),
(493, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'Hair Straightener\' for (Hair color) on 2025-10-13 at 10:23:45', '2025-10-13 10:23:45'),
(494, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Straightener\' for (Hair color) on 2025-10-13 at 10:24:15', '2025-10-13 10:24:15'),
(495, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Neutralizer\' for (Hair color) on 2025-10-13 at 10:24:31', '2025-10-13 10:24:31'),
(496, 'Kindeo', 'Delete', 'Service Price', 'Deleted service \'Nail Treatment\' with a price of ₱100 on 2025-10-13 at 10:24:56', '2025-10-13 10:24:56'),
(497, 'Kindeo', 'Delete', 'Service Price', 'Deleted service \'\' with a price of ₱200 on 2025-10-13 at 10:24:59', '2025-10-13 10:24:59'),
(498, 'Kindeo', 'Create', 'Service Price', 'Created service \'Hair color\' with a price of ₱150 on 2025-10-13 at 10:26:22', '2025-10-13 10:26:22'),
(499, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 10:28:06', '2025-10-13 10:28:06'),
(500, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 10:28:10', '2025-10-13 10:28:10'),
(501, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 10:28:10', '2025-10-13 10:28:10'),
(502, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 10:28:10', '2025-10-13 10:28:10'),
(503, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 10:28:30', '2025-10-13 10:28:30'),
(504, 'Kindeo', 'Create', 'Manage Services', 'Created service \'Rebond w/ Keratin\' on 2025-10-13 at 10:29:30', '2025-10-13 10:29:30'),
(505, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Straightener\' for (Rebond w/ Keratin) on 2025-10-13 at 10:30:03', '2025-10-13 10:30:03'),
(506, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Neutralizer\' for (Rebond w/ Keratin) on 2025-10-13 at 10:30:29', '2025-10-13 10:30:29'),
(507, 'Kindeo', 'Delete', 'Manage Services', 'Deleted service \'Nail Treatment\' on 2025-10-13 at 10:30:41', '2025-10-13 10:30:41'),
(508, 'Kindeo', 'Delete', 'Manage Services', 'Deleted service \'Hair color\' on 2025-10-13 at 10:30:45', '2025-10-13 10:30:45'),
(509, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:31:33', '2025-10-13 10:31:33'),
(510, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:32:22', '2025-10-13 10:32:22'),
(511, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:33:42', '2025-10-13 10:33:42'),
(512, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:35:45', '2025-10-13 10:35:45'),
(513, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:36:37', '2025-10-13 10:36:37'),
(514, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:37:39', '2025-10-13 10:37:39'),
(515, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:38:51', '2025-10-13 10:38:51'),
(516, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:39:37', '2025-10-13 10:39:37'),
(517, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:40:54', '2025-10-13 10:40:54'),
(518, 'Kindeo', 'Create', 'Service Price', 'Created service \'Rebond w/ Keratin\' with a price of ₱180 on 2025-10-13 at 10:41:25', '2025-10-13 10:41:25'),
(519, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Louis Jay L Castillo\' on 2025-10-13 at 10:42:52', '2025-10-13 10:42:52'),
(520, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Wednesday\' (Stylist: Mohaifa ) on 2025-10-13 at 10:44:01', '2025-10-13 10:44:01'),
(521, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Thursday\' (Stylist: Mohaifa ) on 2025-10-13 at 10:44:27', '2025-10-13 10:44:27'),
(522, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Friday\' (Stylist: Mohaifa ) on 2025-10-13 at 10:44:45', '2025-10-13 10:44:45'),
(523, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Saturday\' (Stylist: Mohaifa ) on 2025-10-13 at 10:45:04', '2025-10-13 10:45:04'),
(524, 'Kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Sunday\' (Stylist: Mohaifa ) on 2025-10-13 at 10:45:19', '2025-10-13 10:45:19'),
(525, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-13 at 10:45:34', '2025-10-13 10:45:34'),
(526, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-13 at 10:46:03', '2025-10-13 10:46:03'),
(527, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-13 at 10:46:14', '2025-10-13 10:46:14'),
(528, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 10:46:19', '2025-10-13 10:46:19'),
(529, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 10:46:25', '2025-10-13 10:46:25'),
(530, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 10:47:04', '2025-10-13 10:47:04'),
(531, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-13 at 10:47:44', '2025-10-13 10:47:44'),
(532, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Louis Jay L Castillo\' on 2025-10-13 at 10:47:44', '2025-10-13 10:47:44'),
(533, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 10:47:47', '2025-10-13 10:47:47'),
(534, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 10:50:10', '2025-10-13 10:50:10'),
(535, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 10:50:12', '2025-10-13 10:50:12'),
(536, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 10:50:23', '2025-10-13 10:50:23'),
(537, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 10:51:00', '2025-10-13 10:51:00'),
(538, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 10:51:16', '2025-10-13 10:51:16'),
(539, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-13 at 10:51:37', '2025-10-13 10:51:37'),
(540, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 10:52:11', '2025-10-13 10:52:11'),
(541, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-13 at 10:52:13', '2025-10-13 10:52:13'),
(542, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-13 at 10:52:38', '2025-10-13 10:52:38'),
(543, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-13 at 10:52:41', '2025-10-13 10:52:41'),
(544, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-13 at 10:52:42', '2025-10-13 10:52:42'),
(545, 'Kindeo', 'View', 'Profit/Lost Report', 'Viewed Proft/Lost Report on 2025-10-13 at 10:52:43', '2025-10-13 10:52:43'),
(546, 'Kindeo', 'View', 'Customer Report', 'Viewed Customer Report on 2025-10-13 at 10:52:45', '2025-10-13 10:52:45'),
(547, 'Kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-13 at 10:52:47', '2025-10-13 10:52:47'),
(548, 'Kindeo', 'View', 'Delivery Report', 'Viewed Delivery Report on 2025-10-13 at 10:52:48', '2025-10-13 10:52:48'),
(549, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-13 at 10:52:50', '2025-10-13 10:52:50'),
(550, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-13 at 10:52:52', '2025-10-13 10:52:52'),
(551, 'Kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-13 at 10:53:05', '2025-10-13 10:53:05'),
(552, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-13 at 10:54:51', '2025-10-13 10:54:51'),
(553, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-13 at 10:55:09', '2025-10-13 10:55:09'),
(554, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-13 at 10:55:13', '2025-10-13 10:55:13'),
(555, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-13 at 10:56:02', '2025-10-13 10:56:02'),
(556, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-13 at 10:56:21', '2025-10-13 10:56:21'),
(557, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-15 at 23:58:20', '2025-10-15 23:58:20'),
(558, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'Hair Services\' on 2025-10-15 at 23:58:34', '2025-10-15 23:58:34'),
(559, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 00:22:50', '2025-10-16 00:22:50'),
(560, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'test\' on 2025-10-16 at 00:23:11', '2025-10-16 00:23:11'),
(561, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test\' on 2025-10-16 at 00:23:14', '2025-10-16 00:23:14'),
(562, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 00:25:23', '2025-10-16 00:25:23'),
(563, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test\' on 2025-10-16 at 00:25:31', '2025-10-16 00:25:31'),
(564, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-16 at 00:26:08', '2025-10-16 00:26:08'),
(565, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test\' on 2025-10-16 at 00:26:15', '2025-10-16 00:26:15'),
(566, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 00:26:59', '2025-10-16 00:26:59'),
(567, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 00:28:17', '2025-10-16 00:28:17'),
(568, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 01:10:25', '2025-10-16 01:10:25'),
(569, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 01:17:13', '2025-10-16 01:17:13'),
(570, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 01:18:52', '2025-10-16 01:18:52'),
(571, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 01:38:35', '2025-10-16 01:38:35'),
(572, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 01:39:51', '2025-10-16 01:39:51'),
(573, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 01:53:16', '2025-10-16 01:53:16'),
(574, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 10:52:14', '2025-10-16 10:52:14'),
(575, 'Kindeo', 'View', 'Manage User', 'Viewed user Nissan Malik on 2025-10-16 at 10:52:24', '2025-10-16 10:52:24'),
(576, 'Kindeo', 'View', 'Manage User', 'Viewed user Nissan Malik on 2025-10-16 at 10:52:30', '2025-10-16 10:52:30'),
(577, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:30:05', '2025-10-16 11:30:05'),
(578, 'Kindeo', 'Delete', 'Manage User', 'Deleted user test test on 2025-10-16 at 11:30:16', '2025-10-16 11:30:16'),
(579, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:32:21', '2025-10-16 11:32:21'),
(580, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user test test on 2025-10-16 at 11:32:53', '2025-10-16 11:32:53'),
(581, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:42:46', '2025-10-16 11:42:46'),
(582, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:46:24', '2025-10-16 11:46:24'),
(583, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user test test on 2025-10-16 at 11:46:34', '2025-10-16 11:46:34'),
(584, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:51:35', '2025-10-16 11:51:35'),
(585, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:56:04', '2025-10-16 11:56:04'),
(586, 'Kindeo', 'Activate', 'Manage User', 'Activated user test test on 2025-10-16 at 11:56:23', '2025-10-16 11:56:23'),
(587, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 11:59:41', '2025-10-16 11:59:41'),
(588, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 12:34:55', '2025-10-16 12:34:55'),
(589, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user test test on 2025-10-16 at 12:35:13', '2025-10-16 12:35:13'),
(590, 'Kindeo', 'Activate', 'Manage User', 'Activated user test test on 2025-10-16 at 12:35:22', '2025-10-16 12:35:22'),
(591, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user test test on 2025-10-16 at 12:35:35', '2025-10-16 12:35:35'),
(592, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 12:36:24', '2025-10-16 12:36:24'),
(593, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user test test on 2025-10-16 at 12:36:31', '2025-10-16 12:36:31'),
(594, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 12:36:48', '2025-10-16 12:36:48'),
(595, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:32:26', '2025-10-16 13:32:26'),
(596, 'Kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo123 ken on 2025-10-16 at 13:32:35', '2025-10-16 13:32:35'),
(597, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:33:07', '2025-10-16 13:33:07'),
(598, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:33:25', '2025-10-16 13:33:25'),
(599, 'Kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo123 ken on 2025-10-16 at 13:33:31', '2025-10-16 13:33:31'),
(600, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:37:03', '2025-10-16 13:37:03'),
(601, 'Kindeo', 'Activate', 'Manage Stylist', 'Activated stylist kindeo123 ken on 2025-10-16 at 13:37:38', '2025-10-16 13:37:38'),
(602, 'Kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo123 ken on 2025-10-16 at 13:37:52', '2025-10-16 13:37:52'),
(603, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:39:23', '2025-10-16 13:39:23'),
(604, 'Kindeo', 'Activate', 'Manage Stylist', 'Activated stylist kindeo123 ken on 2025-10-16 at 13:39:30', '2025-10-16 13:39:30'),
(605, 'Kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo123 ken on 2025-10-16 at 13:39:39', '2025-10-16 13:39:39'),
(606, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:43:11', '2025-10-16 13:43:11'),
(607, 'Kindeo', 'Activate', 'Manage Stylist', 'Activated stylist kindeo123 ken on 2025-10-16 at 13:43:19', '2025-10-16 13:43:19'),
(608, 'Kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo123 ken on 2025-10-16 at 13:43:22', '2025-10-16 13:43:22'),
(609, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:44:38', '2025-10-16 13:44:38'),
(610, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-16 at 13:44:46', '2025-10-16 13:44:46'),
(611, 'Kindeo', 'Activate', 'Manage Stylist', 'Activated stylist kindeo123 ken on 2025-10-16 at 13:44:50', '2025-10-16 13:44:50'),
(612, 'Kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo123 ken on 2025-10-16 at 13:44:52', '2025-10-16 13:44:52'),
(613, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 13:52:10', '2025-10-16 13:52:10'),
(614, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user Nissan Malik on 2025-10-16 at 13:52:19', '2025-10-16 13:52:19'),
(615, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-16 at 13:53:20', '2025-10-16 13:53:20'),
(616, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-16 at 13:53:34', '2025-10-16 13:53:34'),
(617, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-16 at 13:53:47', '2025-10-16 13:53:47'),
(618, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-16 at 13:53:49', '2025-10-16 13:53:49'),
(619, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-16 at 13:54:09', '2025-10-16 13:54:09'),
(620, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-16 at 13:54:27', '2025-10-16 13:54:27'),
(621, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-16 at 16:11:45', '2025-10-16 16:11:45'),
(622, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-16 at 16:12:42', '2025-10-16 16:12:42'),
(623, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-16 at 16:14:26', '2025-10-16 16:14:26'),
(624, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-16 at 16:14:29', '2025-10-16 16:14:29'),
(625, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-16 at 16:14:34', '2025-10-16 16:14:34'),
(626, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-16 at 16:14:45', '2025-10-16 16:14:45'),
(627, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-16 at 16:14:49', '2025-10-16 16:14:49'),
(628, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:19:22', '2025-10-18 00:19:22'),
(629, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:25:15', '2025-10-18 00:25:15'),
(630, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:25:55', '2025-10-18 00:25:55'),
(631, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:34:55', '2025-10-18 00:34:55'),
(632, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:36:31', '2025-10-18 00:36:31'),
(633, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:39:04', '2025-10-18 00:39:04'),
(634, 'Kindeo', 'Delete', 'Manage Customer', 'Deleted customer \'test123 123\' on 2025-10-18 at 00:39:18', '2025-10-18 00:39:18'),
(635, 'Kindeo', 'Activate', 'Manage Customer', 'Activated customer \'test123 123\' on 2025-10-18 at 00:39:27', '2025-10-18 00:39:27'),
(636, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:41:31', '2025-10-18 00:41:31'),
(637, 'Kindeo', 'Delete', 'Manage Customer', 'Deleted customer \'test123 123\' on 2025-10-18 at 00:41:38', '2025-10-18 00:41:38'),
(638, 'Kindeo', 'Activate', 'Manage Customer', 'Activated customer \'test123 123\' on 2025-10-18 at 00:42:07', '2025-10-18 00:42:07'),
(639, 'Kindeo', 'Delete', 'Manage Customer', 'Deleted customer \'test123 123\' on 2025-10-18 at 00:42:18', '2025-10-18 00:42:18'),
(640, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 00:46:07', '2025-10-18 00:46:07'),
(641, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 01:58:07', '2025-10-18 01:58:07'),
(642, 'Kindeo', 'Delete', 'Manage Supplier', 'Deleted supplier \'kindeo\' on 2025-10-18 at 01:58:13', '2025-10-18 01:58:13'),
(643, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 01:59:05', '2025-10-18 01:59:05'),
(644, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'Others\' on 2025-10-18 at 01:59:47', '2025-10-18 01:59:47'),
(645, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:08:24', '2025-10-18 02:08:24'),
(646, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:08:49', '2025-10-18 02:08:49'),
(647, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:10:15', '2025-10-18 02:10:15'),
(648, 'Kindeo', 'Create', 'Manage Sub-Categories', 'Created sub-category \'test\' for (test) on 2025-10-18 at 02:10:24', '2025-10-18 02:10:24'),
(649, 'Kindeo', 'Delete', 'Manage Sub-Categories', 'Deleted sub-category \'test\' for (Hair) on 2025-10-18 at 02:10:27', '2025-10-18 02:10:27'),
(650, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:18:09', '2025-10-18 02:18:09'),
(651, 'Kindeo', 'Create', 'Manage Products', 'Created product \'test\' on 2025-10-18 at 02:18:24', '2025-10-18 02:18:24'),
(652, 'Kindeo', 'Delete', 'Manage Products', 'Deleted product \'test\' on 2025-10-18 at 02:18:40', '2025-10-18 02:18:40'),
(653, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:19:11', '2025-10-18 02:19:11'),
(654, 'Kindeo', 'Delete', 'Manage Products', 'Deleted product \'test\' on 2025-10-18 at 02:19:17', '2025-10-18 02:19:17'),
(655, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:19:47', '2025-10-18 02:19:47'),
(656, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:29:05', '2025-10-18 02:29:05'),
(657, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-18 at 02:29:12', '2025-10-18 02:29:12'),
(658, 'Kindeo', 'Create', 'Manage Services', 'Created service \'test\' on 2025-10-18 at 02:29:22', '2025-10-18 02:29:22'),
(659, 'Kindeo', 'Delete', 'Manage Services', 'Deleted service \'test\' on 2025-10-18 at 02:29:25', '2025-10-18 02:29:25'),
(660, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-18 at 02:29:59', '2025-10-18 02:29:59'),
(661, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:38:42', '2025-10-18 02:38:42'),
(662, 'Kindeo', 'Delete', 'Service Price', 'Deleted service \'Rebond w/ Keratin\' with a price of ₱180 on 2025-10-18 at 02:39:02', '2025-10-18 02:39:02'),
(663, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 02:39:17', '2025-10-18 02:39:17'),
(664, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-18 at 02:39:18', '2025-10-18 02:39:18'),
(665, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-18 at 02:39:59', '2025-10-18 02:39:59'),
(666, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:40:02', '2025-10-18 02:40:02'),
(667, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-18 at 02:40:03', '2025-10-18 02:40:03'),
(668, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-18 at 02:40:06', '2025-10-18 02:40:06'),
(669, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 02:40:09', '2025-10-18 02:40:09'),
(670, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:40:10', '2025-10-18 02:40:10'),
(671, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'\' on 2025-10-18 at 02:40:33', '2025-10-18 02:40:33'),
(672, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'\' on 2025-10-18 at 02:40:42', '2025-10-18 02:40:42'),
(673, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'\' on 2025-10-18 at 02:40:50', '2025-10-18 02:40:50'),
(674, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:40:52', '2025-10-18 02:40:52'),
(675, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'\' on 2025-10-18 at 02:41:00', '2025-10-18 02:41:00'),
(676, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:41:18', '2025-10-18 02:41:18'),
(677, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:42:17', '2025-10-18 02:42:17'),
(678, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:42:20', '2025-10-18 02:42:20'),
(679, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-18 at 02:42:32', '2025-10-18 02:42:32'),
(680, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:42:36', '2025-10-18 02:42:36'),
(681, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'\' on 2025-10-18 at 02:42:45', '2025-10-18 02:42:45'),
(682, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:43:40', '2025-10-18 02:43:40'),
(683, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:43:46', '2025-10-18 02:43:46'),
(684, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Louis Jay L Castillo\' on 2025-10-18 at 02:43:53', '2025-10-18 02:43:53'),
(685, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-18 at 02:44:04', '2025-10-18 02:44:04'),
(686, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Louis Jay L Castillo\' on 2025-10-18 at 02:44:04', '2025-10-18 02:44:04'),
(687, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 02:44:06', '2025-10-18 02:44:06'),
(688, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:44:06', '2025-10-18 02:44:06'),
(689, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:44:11', '2025-10-18 02:44:11'),
(690, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 02:44:20', '2025-10-18 02:44:20'),
(691, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 02:44:20', '2025-10-18 02:44:20'),
(692, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Promo\' with rate (20%) on 2025-10-18 at 02:44:38', '2025-10-18 02:44:38'),
(693, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Senior/PWD\' with rate (20%) on 2025-10-18 at 02:44:42', '2025-10-18 02:44:42'),
(694, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Senior/PWD\' with rate (20%) on 2025-10-18 at 02:44:45', '2025-10-18 02:44:45'),
(695, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Senior/PWD\' with rate (20%) on 2025-10-18 at 02:44:46', '2025-10-18 02:44:46'),
(696, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Senior/PWD\' with rate (20%) on 2025-10-18 at 02:44:48', '2025-10-18 02:44:48'),
(697, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Promo\' with rate (15%) on 2025-10-18 at 02:44:50', '2025-10-18 02:44:50'),
(698, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:51:39', '2025-10-18 02:51:39'),
(699, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Promo\' with rate (10%) on 2025-10-18 at 02:51:49', '2025-10-18 02:51:49'),
(700, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:52:34', '2025-10-18 02:52:34'),
(701, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Promo\' with rate (10%) on 2025-10-18 at 02:52:41', '2025-10-18 02:52:41'),
(702, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:53:10', '2025-10-18 02:53:10'),
(703, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:53:57', '2025-10-18 02:53:57'),
(704, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:54:20', '2025-10-18 02:54:20'),
(705, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 02:55:00', '2025-10-18 02:55:00'),
(706, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:56:41', '2025-10-18 02:56:41'),
(707, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 02:56:46', '2025-10-18 02:56:46'),
(708, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:59:23', '2025-10-18 02:59:23'),
(709, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 02:59:28', '2025-10-18 02:59:28'),
(710, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 02:59:43', '2025-10-18 02:59:43'),
(711, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 02:59:47', '2025-10-18 02:59:47'),
(712, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:04:42', '2025-10-18 03:04:42'),
(713, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:05:23', '2025-10-18 03:05:23'),
(714, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:06:15', '2025-10-18 03:06:15'),
(715, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 03:06:30', '2025-10-18 03:06:30'),
(716, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:07:07', '2025-10-18 03:07:07'),
(717, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:08:25', '2025-10-18 03:08:25'),
(718, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 03:08:30', '2025-10-18 03:08:30'),
(719, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:09:16', '2025-10-18 03:09:16'),
(720, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 03:09:21', '2025-10-18 03:09:21'),
(721, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:10:16', '2025-10-18 03:10:16'),
(722, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 03:10:21', '2025-10-18 03:10:21'),
(723, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:28:45', '2025-10-18 03:28:45'),
(724, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Rebond w/ Keratin) on 2025-10-18 at 03:28:59', '2025-10-18 03:28:59'),
(725, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:29:19', '2025-10-18 03:29:19'),
(726, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Rebond w/ Keratin) on 2025-10-18 at 03:29:30', '2025-10-18 03:29:30'),
(727, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:29:58', '2025-10-18 03:29:58'),
(728, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:32:06', '2025-10-18 03:32:06'),
(729, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Rebond w/ Keratin) on 2025-10-18 at 03:32:16', '2025-10-18 03:32:16'),
(730, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:35:21', '2025-10-18 03:35:21'),
(731, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:40:02', '2025-10-18 03:40:02'),
(732, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Rebond w/ Keratin) on 2025-10-18 at 03:40:10', '2025-10-18 03:40:10'),
(733, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 03:41:06', '2025-10-18 03:41:06'),
(734, 'Kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Rebond w/ Keratin) on 2025-10-18 at 03:41:15', '2025-10-18 03:41:15'),
(735, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 04:06:12', '2025-10-18 04:06:12'),
(736, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 04:07:15', '2025-10-18 04:07:15'),
(737, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: Mohaifa ) on 2025-10-18 at 04:07:28', '2025-10-18 04:07:28'),
(738, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 04:10:41', '2025-10-18 04:10:41'),
(739, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: kindeo123) on 2025-10-18 at 04:10:51', '2025-10-18 04:10:51'),
(740, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 04:13:15', '2025-10-18 04:13:15'),
(741, 'Kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'\' (Stylist: kindeo123) on 2025-10-18 at 04:13:24', '2025-10-18 04:13:24'),
(742, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 04:29:47', '2025-10-18 04:29:47'),
(743, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 04:29:51', '2025-10-18 04:29:51'),
(744, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 04:29:51', '2025-10-18 04:29:51'),
(745, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 04:31:00', '2025-10-18 04:31:00'),
(746, 'Kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: ) on 2025-10-18 at 04:31:14', '2025-10-18 04:31:14'),
(747, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-18 at 04:33:18', '2025-10-18 04:33:18'),
(748, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 04:33:18', '2025-10-18 04:33:18'),
(749, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 04:33:20', '2025-10-18 04:33:20'),
(750, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 04:33:20', '2025-10-18 04:33:20'),
(751, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 13:52:09', '2025-10-18 13:52:09'),
(752, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 13:52:47', '2025-10-18 13:52:47'),
(753, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 13:53:30', '2025-10-18 13:53:30'),
(754, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (10%) on 2025-10-18 at 13:54:26', '2025-10-18 13:54:26'),
(755, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 14:09:52', '2025-10-18 14:09:52'),
(756, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (12%) on 2025-10-18 at 14:10:29', '2025-10-18 14:10:29'),
(757, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 14:31:30', '2025-10-18 14:31:30'),
(758, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 14:31:35', '2025-10-18 14:31:35'),
(759, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 14:33:55', '2025-10-18 14:33:55'),
(760, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 14:33:59', '2025-10-18 14:33:59'),
(761, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Promo\' with rate (3.00%) on 2025-10-18 at 14:34:04', '2025-10-18 14:34:04'),
(762, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 14:37:07', '2025-10-18 14:37:07'),
(763, 'Kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Promo\' with rate (3.00%) on 2025-10-18 at 14:37:35', '2025-10-18 14:37:35'),
(764, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (5%) on 2025-10-18 at 14:37:53', '2025-10-18 14:37:53'),
(765, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 14:41:04', '2025-10-18 14:41:04'),
(766, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (5%) on 2025-10-18 at 14:41:20', '2025-10-18 14:41:20'),
(767, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:01:14', '2025-10-18 15:01:14'),
(768, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (9%) on 2025-10-18 at 15:01:32', '2025-10-18 15:01:32'),
(769, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:03:52', '2025-10-18 15:03:52'),
(770, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (10%) on 2025-10-18 at 15:04:36', '2025-10-18 15:04:36'),
(771, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:05:17', '2025-10-18 15:05:17'),
(772, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (20%) on 2025-10-18 at 15:05:41', '2025-10-18 15:05:41'),
(773, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:16:27', '2025-10-18 15:16:27'),
(774, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 15:16:32', '2025-10-18 15:16:32'),
(775, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (10%) on 2025-10-18 at 15:16:55', '2025-10-18 15:16:55'),
(776, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (20%) on 2025-10-18 at 15:17:51', '2025-10-18 15:17:51'),
(777, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:39:33', '2025-10-18 15:39:33'),
(778, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:47:24', '2025-10-18 15:47:24'),
(779, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:49:02', '2025-10-18 15:49:02'),
(780, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:50:00', '2025-10-18 15:50:00'),
(781, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (50%) on 2025-10-18 at 15:50:10', '2025-10-18 15:50:10'),
(782, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:51:46', '2025-10-18 15:51:46'),
(783, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (25%) on 2025-10-18 at 15:51:58', '2025-10-18 15:51:58'),
(784, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 15:54:18', '2025-10-18 15:54:18'),
(785, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (100%) on 2025-10-18 at 15:54:29', '2025-10-18 15:54:29'),
(786, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 16:00:38', '2025-10-18 16:00:38'),
(787, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (44%) on 2025-10-18 at 16:00:50', '2025-10-18 16:00:50'),
(788, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 16:01:37', '2025-10-18 16:01:37'),
(789, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 16:01:40', '2025-10-18 16:01:40'),
(790, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (200%) on 2025-10-18 at 16:01:48', '2025-10-18 16:01:48'),
(791, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (25%) on 2025-10-18 at 16:02:36', '2025-10-18 16:02:36'),
(792, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 16:12:09', '2025-10-18 16:12:09'),
(793, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (2%) on 2025-10-18 at 16:12:33', '2025-10-18 16:12:33'),
(794, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (20%) on 2025-10-18 at 16:13:27', '2025-10-18 16:13:27'),
(795, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 19:37:32', '2025-10-18 19:37:32'),
(796, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-18 at 19:37:49', '2025-10-18 19:37:49'),
(797, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 20:17:59', '2025-10-18 20:17:59'),
(798, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-18 at 20:18:28', '2025-10-18 20:18:28'),
(799, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:26:01', '2025-10-18 21:26:01'),
(800, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-18 at 21:27:26', '2025-10-18 21:27:26'),
(801, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-18 at 21:28:02', '2025-10-18 21:28:02'),
(802, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:28:48', '2025-10-18 21:28:48'),
(803, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-18 at 21:29:10', '2025-10-18 21:29:10'),
(804, 'Kindeo', 'Delete', 'Manage Customer', 'Deleted customer \'Louis Jay Castillo\' on 2025-10-18 at 21:29:32', '2025-10-18 21:29:32'),
(805, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:33:21', '2025-10-18 21:33:21'),
(806, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:34:08', '2025-10-18 21:34:08'),
(807, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-18 at 21:34:26', '2025-10-18 21:34:26'),
(808, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'test123 123 123\' on 2025-10-18 at 21:34:41', '2025-10-18 21:34:41'),
(809, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-18 at 21:35:07', '2025-10-18 21:35:07'),
(810, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-18 at 21:35:22', '2025-10-18 21:35:22'),
(811, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-18 at 21:35:44', '2025-10-18 21:35:44'),
(812, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 21:36:38', '2025-10-18 21:36:38'),
(813, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-18 at 21:39:25', '2025-10-18 21:39:25'),
(814, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-18 at 21:39:25', '2025-10-18 21:39:25'),
(815, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:39:38', '2025-10-18 21:39:38'),
(816, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:46:27', '2025-10-18 21:46:27'),
(817, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:47:14', '2025-10-18 21:47:14'),
(818, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:47:22', '2025-10-18 21:47:22'),
(819, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:48:16', '2025-10-18 21:48:16'),
(820, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:48:20', '2025-10-18 21:48:20'),
(821, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:48:33', '2025-10-18 21:48:33'),
(822, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:48:36', '2025-10-18 21:48:36'),
(823, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:50:32', '2025-10-18 21:50:32'),
(824, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:50:36', '2025-10-18 21:50:36'),
(825, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:50:41', '2025-10-18 21:50:41'),
(826, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:50:53', '2025-10-18 21:50:53'),
(827, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:51:29', '2025-10-18 21:51:29'),
(828, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:51:33', '2025-10-18 21:51:33'),
(829, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:51:58', '2025-10-18 21:51:58'),
(830, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:52:01', '2025-10-18 21:52:01'),
(831, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:54:15', '2025-10-18 21:54:15'),
(832, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:54:18', '2025-10-18 21:54:18'),
(833, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:54:46', '2025-10-18 21:54:46'),
(834, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 21:54:49', '2025-10-18 21:54:49'),
(835, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:55:25', '2025-10-18 21:55:25'),
(836, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:56:43', '2025-10-18 21:56:43'),
(837, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:57:14', '2025-10-18 21:57:14'),
(838, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 21:57:36', '2025-10-18 21:57:36'),
(839, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:00:49', '2025-10-18 22:00:49'),
(840, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:02:27', '2025-10-18 22:02:27'),
(841, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:04:00', '2025-10-18 22:04:00'),
(842, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:06:39', '2025-10-18 22:06:39'),
(843, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:07:34', '2025-10-18 22:07:34'),
(844, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:07:45', '2025-10-18 22:07:45'),
(845, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:08:16', '2025-10-18 22:08:16'),
(846, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:08:20', '2025-10-18 22:08:20'),
(847, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:10:10', '2025-10-18 22:10:10'),
(848, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:10:15', '2025-10-18 22:10:15'),
(849, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:11:02', '2025-10-18 22:11:02'),
(850, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:11:07', '2025-10-18 22:11:07'),
(851, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:12:38', '2025-10-18 22:12:38'),
(852, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:12:43', '2025-10-18 22:12:43'),
(853, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:15:40', '2025-10-18 22:15:40'),
(854, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:15:45', '2025-10-18 22:15:45'),
(855, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:18:33', '2025-10-18 22:18:33'),
(856, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:22:52', '2025-10-18 22:22:52'),
(857, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:23:10', '2025-10-18 22:23:10'),
(858, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:25:04', '2025-10-18 22:25:04'),
(859, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:25:34', '2025-10-18 22:25:34'),
(860, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:27:19', '2025-10-18 22:27:19'),
(861, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:27:57', '2025-10-18 22:27:57'),
(862, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:29:40', '2025-10-18 22:29:40'),
(863, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:30:13', '2025-10-18 22:30:13'),
(864, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:30:38', '2025-10-18 22:30:38'),
(865, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:30:42', '2025-10-18 22:30:42'),
(866, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:31:10', '2025-10-18 22:31:10'),
(867, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:31:14', '2025-10-18 22:31:14'),
(868, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:32:30', '2025-10-18 22:32:30'),
(869, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:32:35', '2025-10-18 22:32:35'),
(870, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:32:51', '2025-10-18 22:32:51'),
(871, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:32:56', '2025-10-18 22:32:56'),
(872, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:33:07', '2025-10-18 22:33:07'),
(873, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:34:01', '2025-10-18 22:34:01'),
(874, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:34:07', '2025-10-18 22:34:07'),
(875, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:34:10', '2025-10-18 22:34:10'),
(876, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:36:01', '2025-10-18 22:36:01'),
(877, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:38:37', '2025-10-18 22:38:37'),
(878, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:39:31', '2025-10-18 22:39:31'),
(879, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:40:00', '2025-10-18 22:40:00'),
(880, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:40:21', '2025-10-18 22:40:21'),
(881, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:40:32', '2025-10-18 22:40:32'),
(882, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:40:48', '2025-10-18 22:40:48'),
(883, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:40:54', '2025-10-18 22:40:54'),
(884, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:41:46', '2025-10-18 22:41:46'),
(885, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:41:52', '2025-10-18 22:41:52'),
(886, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:42:48', '2025-10-18 22:42:48'),
(887, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:45:47', '2025-10-18 22:45:47'),
(888, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:45:52', '2025-10-18 22:45:52'),
(889, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:46:51', '2025-10-18 22:46:51');
INSERT INTO `tbl_audit_trail` (`id`, `user`, `action`, `module`, `note`, `timestamp`) VALUES
(890, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:48:40', '2025-10-18 22:48:40'),
(891, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:48:45', '2025-10-18 22:48:45'),
(892, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:49:12', '2025-10-18 22:49:12'),
(893, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:49:19', '2025-10-18 22:49:19'),
(894, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:50:52', '2025-10-18 22:50:52'),
(895, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:50:57', '2025-10-18 22:50:57'),
(896, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:57:01', '2025-10-18 22:57:01'),
(897, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:57:06', '2025-10-18 22:57:06'),
(898, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-18 at 22:57:12', '2025-10-18 22:57:12'),
(899, 'Kindeo', 'View', 'Manage User', 'Viewed user Nissan Malik on 2025-10-18 at 22:57:28', '2025-10-18 22:57:28'),
(900, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-18 at 22:57:44', '2025-10-18 22:57:44'),
(901, 'Nissan', 'Log In', 'User', 'Log In \'Nissan\'on 2025-10-18 at 22:57:51', '2025-10-18 22:57:51'),
(902, 'Nissan', 'Log Out', 'User', 'Log Out \'Nissan\'on 2025-10-18 at 22:57:57', '2025-10-18 22:57:57'),
(903, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:07:18', '2025-10-19 01:07:18'),
(904, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:07:23', '2025-10-19 01:07:23'),
(905, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:08:59', '2025-10-19 01:08:59'),
(906, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:09:03', '2025-10-19 01:09:03'),
(907, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:11:58', '2025-10-19 01:11:58'),
(908, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:12:02', '2025-10-19 01:12:02'),
(909, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:17:39', '2025-10-19 01:17:39'),
(910, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:17:45', '2025-10-19 01:17:45'),
(911, 'Kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-19 01:18:00', '2025-10-19 01:18:00'),
(912, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:22:31', '2025-10-19 01:22:31'),
(913, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:22:36', '2025-10-19 01:22:36'),
(914, 'Kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-19 01:22:57', '2025-10-19 01:22:57'),
(915, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:32:36', '2025-10-19 01:32:36'),
(916, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:32:40', '2025-10-19 01:32:40'),
(917, 'Kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-19 01:33:14', '2025-10-19 01:33:14'),
(918, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:37:46', '2025-10-19 01:37:46'),
(919, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 01:37:50', '2025-10-19 01:37:50'),
(920, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:37:51', '2025-10-19 01:37:51'),
(921, 'Kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-19 01:37:58', '2025-10-19 01:37:58'),
(922, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 01:48:11', '2025-10-19 01:48:11'),
(923, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 01:48:31', '2025-10-19 01:48:31'),
(924, 'Kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-19 01:48:37', '2025-10-19 01:48:37'),
(925, 'Kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-19 at 01:48:38', '2025-10-19 01:48:38'),
(926, 'Kindeo', 'Export PDF', 'User', 'Exported Inventory Report to PDF at 2025-10-19 01:48:42', '2025-10-19 01:48:42'),
(927, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:13:25', '2025-10-19 02:13:25'),
(928, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:13:34', '2025-10-19 02:13:34'),
(929, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-19 at 02:13:36', '2025-10-19 02:13:36'),
(930, 'Kindeo', 'Export PDF', 'User', 'Exported Expense Report to PDF at 2025-10-19 02:13:43', '2025-10-19 02:13:43'),
(931, 'Kindeo', 'View', 'Profit/Lost Report', 'Viewed Proft/Lost Report on 2025-10-19 at 02:13:45', '2025-10-19 02:13:45'),
(932, 'Kindeo', 'Export PDF', 'User', 'Exported Profit and Loss Report to PDF at 2025-10-19 02:13:50', '2025-10-19 02:13:50'),
(933, 'Kindeo', 'View', 'Customer Report', 'Viewed Customer Report on 2025-10-19 at 02:13:52', '2025-10-19 02:13:52'),
(934, 'Kindeo', 'Export PDF', 'User', 'Exported Customer Report to PDF at 2025-10-19 02:13:57', '2025-10-19 02:13:57'),
(935, 'Kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-19 at 02:13:59', '2025-10-19 02:13:59'),
(936, 'Kindeo', 'Export PDF', 'User', 'Exported Technician Report to PDF at 2025-10-19 02:14:07', '2025-10-19 02:14:07'),
(937, 'Kindeo', 'View', 'Delivery Report', 'Viewed Delivery Report on 2025-10-19 at 02:14:09', '2025-10-19 02:14:09'),
(938, 'Kindeo', 'Export PDF', 'User', 'Exported Delivery Report to PDF at 2025-10-19 02:14:13', '2025-10-19 02:14:13'),
(939, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-19 at 02:14:15', '2025-10-19 02:14:15'),
(940, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:14:41', '2025-10-19 02:14:41'),
(941, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:14:45', '2025-10-19 02:14:45'),
(942, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-19 at 02:14:46', '2025-10-19 02:14:46'),
(943, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 02:14:49', '2025-10-19 02:14:49'),
(944, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:16:39', '2025-10-19 02:16:39'),
(945, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:16:43', '2025-10-19 02:16:43'),
(946, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 02:16:44', '2025-10-19 02:16:44'),
(947, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:33:34', '2025-10-19 02:33:34'),
(948, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:33:38', '2025-10-19 02:33:38'),
(949, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-19 at 02:33:40', '2025-10-19 02:33:40'),
(950, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:35:09', '2025-10-19 02:35:09'),
(951, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:35:13', '2025-10-19 02:35:13'),
(952, 'Kindeo', 'View', 'Discount Report', 'Viewed Discount Report on 2025-10-19 at 02:35:14', '2025-10-19 02:35:14'),
(953, 'Kindeo', 'Export PDF', 'User', 'Exported Discount Report to PDF at 2025-10-19 02:35:19', '2025-10-19 02:35:19'),
(954, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:36:19', '2025-10-19 02:36:19'),
(955, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:36:23', '2025-10-19 02:36:23'),
(956, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 02:36:24', '2025-10-19 02:36:24'),
(957, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:39:32', '2025-10-19 02:39:32'),
(958, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:39:36', '2025-10-19 02:39:36'),
(959, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 02:39:37', '2025-10-19 02:39:37'),
(960, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:41:05', '2025-10-19 02:41:05'),
(961, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:41:09', '2025-10-19 02:41:09'),
(962, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 02:41:10', '2025-10-19 02:41:10'),
(963, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 02:41:25', '2025-10-19 02:41:25'),
(964, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 02:41:29', '2025-10-19 02:41:29'),
(965, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 02:41:31', '2025-10-19 02:41:31'),
(966, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 11:35:11', '2025-10-19 11:35:11'),
(967, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 11:44:28', '2025-10-19 11:44:28'),
(968, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 11:46:21', '2025-10-19 11:46:21'),
(969, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 11:50:36', '2025-10-19 11:50:36'),
(970, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 11:55:06', '2025-10-19 11:55:06'),
(971, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 11:56:19', '2025-10-19 11:56:19'),
(972, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 11:56:22', '2025-10-19 11:56:22'),
(973, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:56:35', '2025-10-19 11:56:35'),
(974, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 11:58:25', '2025-10-19 11:58:25'),
(975, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 11:58:31', '2025-10-19 11:58:31'),
(976, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 11:58:35', '2025-10-19 11:58:35'),
(977, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 11:58:36', '2025-10-19 11:58:36'),
(978, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:58:40', '2025-10-19 11:58:40'),
(979, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:58:43', '2025-10-19 11:58:43'),
(980, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:58:45', '2025-10-19 11:58:45'),
(981, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:59:14', '2025-10-19 11:59:14'),
(982, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:59:17', '2025-10-19 11:59:17'),
(983, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-19 at 11:59:20', '2025-10-19 11:59:20'),
(984, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Neutralizer\' for (test) on 2025-10-19 at 12:00:55', '2025-10-19 12:00:55'),
(985, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 12:01:47', '2025-10-19 12:01:47'),
(986, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'\' on 2025-10-19 at 12:01:59', '2025-10-19 12:01:59'),
(987, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 12:02:05', '2025-10-19 12:02:05'),
(988, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 12:02:16', '2025-10-19 12:02:16'),
(989, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 12:02:29', '2025-10-19 12:02:29'),
(990, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:06:29', '2025-10-19 12:06:29'),
(991, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 12:06:35', '2025-10-19 12:06:35'),
(992, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 12:06:41', '2025-10-19 12:06:41'),
(993, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 12:06:49', '2025-10-19 12:06:49'),
(994, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'test123 123 123\' on 2025-10-19 at 12:06:54', '2025-10-19 12:06:54'),
(995, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'test123 123 123\' on 2025-10-19 at 12:06:59', '2025-10-19 12:06:59'),
(996, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'test123 123 123\' on 2025-10-19 at 12:07:03', '2025-10-19 12:07:03'),
(997, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 12:07:08', '2025-10-19 12:07:08'),
(998, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 12:07:19', '2025-10-19 12:07:19'),
(999, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 12:07:21', '2025-10-19 12:07:21'),
(1000, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 12:07:21', '2025-10-19 12:07:21'),
(1001, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 12:07:24', '2025-10-19 12:07:24'),
(1002, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-19 at 12:08:55', '2025-10-19 12:08:55'),
(1003, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-19 at 12:09:53', '2025-10-19 12:09:53'),
(1004, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:10:33', '2025-10-19 12:10:33'),
(1005, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 12:10:47', '2025-10-19 12:10:47'),
(1006, 'Kindeo', 'Create', 'Service Price', 'Created service \'test\' with a price of ₱200 on 2025-10-19 at 12:10:58', '2025-10-19 12:10:58'),
(1007, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-19 at 12:11:14', '2025-10-19 12:11:14'),
(1008, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 12:11:55', '2025-10-19 12:11:55'),
(1009, 'Kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-19 at 12:11:59', '2025-10-19 12:11:59'),
(1010, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 12:12:18', '2025-10-19 12:12:18'),
(1011, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:15:30', '2025-10-19 12:15:30'),
(1012, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:18:14', '2025-10-19 12:18:14'),
(1013, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:19:52', '2025-10-19 12:19:52'),
(1014, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:27:04', '2025-10-19 12:27:04'),
(1015, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:27:40', '2025-10-19 12:27:40'),
(1016, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:31:08', '2025-10-19 12:31:08'),
(1017, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:42:03', '2025-10-19 12:42:03'),
(1018, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:42:33', '2025-10-19 12:42:33'),
(1019, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:46:13', '2025-10-19 12:46:13'),
(1020, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:50:02', '2025-10-19 12:50:02'),
(1021, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:50:52', '2025-10-19 12:50:52'),
(1022, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:51:33', '2025-10-19 12:51:33'),
(1023, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:54:34', '2025-10-19 12:54:34'),
(1024, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:56:26', '2025-10-19 12:56:26'),
(1025, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:57:07', '2025-10-19 12:57:07'),
(1026, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 12:59:13', '2025-10-19 12:59:13'),
(1027, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 13:01:33', '2025-10-19 13:01:33'),
(1028, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 13:02:29', '2025-10-19 13:02:29'),
(1029, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 13:03:38', '2025-10-19 13:03:38'),
(1030, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Senior/PWD\' with rate (12%) on 2025-10-19 at 13:04:21', '2025-10-19 13:04:21'),
(1031, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 13:07:04', '2025-10-19 13:07:04'),
(1032, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 13:07:30', '2025-10-19 13:07:30'),
(1033, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 13:07:31', '2025-10-19 13:07:31'),
(1034, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 13:07:41', '2025-10-19 13:07:41'),
(1035, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 13:07:48', '2025-10-19 13:07:48'),
(1036, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 13:07:49', '2025-10-19 13:07:49'),
(1037, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 14:55:01', '2025-10-19 14:55:01'),
(1038, 'Kindeo', 'Create', 'Manage User', 'Created new user for asd asd on 2025-10-19 at 14:55:59', '2025-10-19 14:55:59'),
(1039, 'Kindeo', 'View', 'Manage User', 'Viewed user asd asd on 2025-10-19 at 14:56:03', '2025-10-19 14:56:03'),
(1040, 'asd', 'Log In', 'User', 'Log In \'asd\'on 2025-10-19 at 15:27:00', '2025-10-19 15:27:00'),
(1041, 'asd', 'Log Out', 'User', 'Log Out \'asd\'on 2025-10-19 at 15:27:05', '2025-10-19 15:27:05'),
(1042, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 15:30:00', '2025-10-19 15:30:00'),
(1043, 'Kindeo', 'Create', 'Manage User', 'Created new user for Kindeo Neikdo on 2025-10-19 at 15:31:15', '2025-10-19 15:31:15'),
(1044, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-19 at 15:31:36', '2025-10-19 15:31:36'),
(1045, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 15:31:40', '2025-10-19 15:31:40'),
(1046, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-19 at 15:31:50', '2025-10-19 15:31:50'),
(1047, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 15:34:20', '2025-10-19 15:34:20'),
(1048, 'Kindeo', 'Update', 'Manage User', 'Updated user asd asd on 2025-10-19 at 15:34:45', '2025-10-19 15:34:45'),
(1049, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-19 at 15:34:56', '2025-10-19 15:34:56'),
(1050, 'asd', 'Log In', 'User', 'Log In \'asd\'on 2025-10-19 at 15:35:05', '2025-10-19 15:35:05'),
(1051, 'asd', 'Log Out', 'User', 'Log Out \'asd\'on 2025-10-19 at 15:35:09', '2025-10-19 15:35:09'),
(1052, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 15:49:23', '2025-10-19 15:49:23'),
(1053, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 17:47:20', '2025-10-19 17:47:20'),
(1054, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 17:47:25', '2025-10-19 17:47:25'),
(1055, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 17:48:51', '2025-10-19 17:48:51'),
(1056, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 17:48:56', '2025-10-19 17:48:56'),
(1057, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 17:54:53', '2025-10-19 17:54:53'),
(1058, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 17:54:56', '2025-10-19 17:54:56'),
(1059, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 18:02:17', '2025-10-19 18:02:17'),
(1060, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 18:04:02', '2025-10-19 18:04:02'),
(1061, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 18:38:47', '2025-10-19 18:38:47'),
(1062, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 18:38:51', '2025-10-19 18:38:51'),
(1063, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 18:39:47', '2025-10-19 18:39:47'),
(1064, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 18:39:49', '2025-10-19 18:39:49'),
(1065, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 18:40:43', '2025-10-19 18:40:43'),
(1066, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 18:40:49', '2025-10-19 18:40:49'),
(1067, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 18:40:50', '2025-10-19 18:40:50'),
(1068, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 18:41:24', '2025-10-19 18:41:24'),
(1069, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 18:41:27', '2025-10-19 18:41:27'),
(1070, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 18:41:28', '2025-10-19 18:41:28'),
(1071, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-19 at 18:49:45', '2025-10-19 18:49:45'),
(1072, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-19 at 19:11:18', '2025-10-19 19:11:18'),
(1073, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-19 at 19:11:36', '2025-10-19 19:11:36'),
(1074, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-19 at 19:11:42', '2025-10-19 19:11:42'),
(1075, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:30:45', '2025-10-19 19:30:45'),
(1076, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:35:00', '2025-10-19 19:35:00'),
(1077, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 19:35:03', '2025-10-19 19:35:03'),
(1078, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:36:45', '2025-10-19 19:36:45'),
(1079, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 19:36:47', '2025-10-19 19:36:47'),
(1080, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:41:13', '2025-10-19 19:41:13'),
(1081, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 19:41:19', '2025-10-19 19:41:19'),
(1082, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 19:41:51', '2025-10-19 19:41:51'),
(1083, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:43:30', '2025-10-19 19:43:30'),
(1084, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:43:41', '2025-10-19 19:43:41'),
(1085, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:48:47', '2025-10-19 19:48:47'),
(1086, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:48:51', '2025-10-19 19:48:51'),
(1087, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:52:46', '2025-10-19 19:52:46'),
(1088, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:52:49', '2025-10-19 19:52:49'),
(1089, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 19:52:50', '2025-10-19 19:52:50'),
(1090, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:52:54', '2025-10-19 19:52:54'),
(1091, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:53:33', '2025-10-19 19:53:33'),
(1092, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 19:53:37', '2025-10-19 19:53:37'),
(1093, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:53:44', '2025-10-19 19:53:44'),
(1094, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-19 at 19:53:53', '2025-10-19 19:53:53'),
(1095, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'test123 123 123\' on 2025-10-19 at 19:53:53', '2025-10-19 19:53:53'),
(1096, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 19:53:55', '2025-10-19 19:53:55'),
(1097, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:54:11', '2025-10-19 19:54:11'),
(1098, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:55:19', '2025-10-19 19:55:19'),
(1099, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:55:27', '2025-10-19 19:55:27'),
(1100, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 19:56:57', '2025-10-19 19:56:57'),
(1101, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 19:57:01', '2025-10-19 19:57:01'),
(1102, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-19 at 19:57:11', '2025-10-19 19:57:11'),
(1103, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'test123 123 123\' on 2025-10-19 at 19:57:11', '2025-10-19 19:57:11'),
(1104, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 19:57:15', '2025-10-19 19:57:15'),
(1105, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:05:21', '2025-10-19 20:05:21'),
(1106, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:05:24', '2025-10-19 20:05:24'),
(1107, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:05:29', '2025-10-19 20:05:29'),
(1108, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:06:20', '2025-10-19 20:06:20'),
(1109, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:06:22', '2025-10-19 20:06:22'),
(1110, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:08:12', '2025-10-19 20:08:12'),
(1111, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:08:15', '2025-10-19 20:08:15'),
(1112, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:08:35', '2025-10-19 20:08:35'),
(1113, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:08:38', '2025-10-19 20:08:38'),
(1114, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:11:20', '2025-10-19 20:11:20'),
(1115, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:11:26', '2025-10-19 20:11:26'),
(1116, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:12:07', '2025-10-19 20:12:07'),
(1117, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:12:11', '2025-10-19 20:12:11'),
(1118, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:15:19', '2025-10-19 20:15:19'),
(1119, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:15:25', '2025-10-19 20:15:25'),
(1120, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 20:18:39', '2025-10-19 20:18:39'),
(1121, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 20:18:39', '2025-10-19 20:18:39'),
(1122, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:26:05', '2025-10-19 20:26:05'),
(1123, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:26:44', '2025-10-19 20:26:44'),
(1124, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:30:16', '2025-10-19 20:30:16'),
(1125, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:30:59', '2025-10-19 20:30:59'),
(1126, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:31:34', '2025-10-19 20:31:34'),
(1127, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:37:10', '2025-10-19 20:37:10'),
(1128, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (15%) on 2025-10-19 at 20:37:38', '2025-10-19 20:37:38'),
(1129, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:43:25', '2025-10-19 20:43:25'),
(1130, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:45:30', '2025-10-19 20:45:30'),
(1131, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 20:45:52', '2025-10-19 20:45:52'),
(1132, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:49:47', '2025-10-19 20:49:47'),
(1133, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:50:42', '2025-10-19 20:50:42'),
(1134, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 20:50:47', '2025-10-19 20:50:47'),
(1135, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:51:48', '2025-10-19 20:51:48'),
(1136, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 20:53:05', '2025-10-19 20:53:05'),
(1137, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 20:53:08', '2025-10-19 20:53:08'),
(1138, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 20:53:10', '2025-10-19 20:53:10'),
(1139, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:36:12', '2025-10-19 21:36:12'),
(1140, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:36:59', '2025-10-19 21:36:59'),
(1141, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:41:04', '2025-10-19 21:41:04'),
(1142, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:42:16', '2025-10-19 21:42:16'),
(1143, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:43:17', '2025-10-19 21:43:17'),
(1144, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:44:32', '2025-10-19 21:44:32'),
(1145, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:52:20', '2025-10-19 21:52:20'),
(1146, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:53:14', '2025-10-19 21:53:14'),
(1147, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 21:54:16', '2025-10-19 21:54:16'),
(1148, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:01:14', '2025-10-19 22:01:14'),
(1149, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:02:27', '2025-10-19 22:02:27'),
(1150, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:03:53', '2025-10-19 22:03:53'),
(1151, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:04:42', '2025-10-19 22:04:42'),
(1152, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:05:26', '2025-10-19 22:05:26'),
(1153, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:05:51', '2025-10-19 22:05:51'),
(1154, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 22:05:54', '2025-10-19 22:05:54'),
(1155, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:09:15', '2025-10-19 22:09:15'),
(1156, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:10:53', '2025-10-19 22:10:53'),
(1157, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:14:42', '2025-10-19 22:14:42'),
(1158, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:15:37', '2025-10-19 22:15:37'),
(1159, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:18:56', '2025-10-19 22:18:56'),
(1160, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:20:58', '2025-10-19 22:20:58'),
(1161, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:22:45', '2025-10-19 22:22:45'),
(1162, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:27:03', '2025-10-19 22:27:03'),
(1163, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:30:39', '2025-10-19 22:30:39'),
(1164, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:32:15', '2025-10-19 22:32:15'),
(1165, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:35:20', '2025-10-19 22:35:20'),
(1166, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:35:39', '2025-10-19 22:35:39'),
(1167, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 22:37:21', '2025-10-19 22:37:21'),
(1168, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:43:40', '2025-10-19 22:43:40'),
(1169, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:45:28', '2025-10-19 22:45:28'),
(1170, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:47:35', '2025-10-19 22:47:35'),
(1171, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 22:48:24', '2025-10-19 22:48:24'),
(1172, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 22:52:38', '2025-10-19 22:52:38'),
(1173, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-19 at 22:53:00', '2025-10-19 22:53:00'),
(1174, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 23:20:48', '2025-10-19 23:20:48'),
(1175, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-19 at 23:21:00', '2025-10-19 23:21:00'),
(1176, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 23:21:23', '2025-10-19 23:21:23'),
(1177, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-19 at 23:21:45', '2025-10-19 23:21:45'),
(1178, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 23:22:30', '2025-10-19 23:22:30'),
(1179, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 23:22:34', '2025-10-19 23:22:34'),
(1180, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 23:22:45', '2025-10-19 23:22:45'),
(1181, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 23:22:45', '2025-10-19 23:22:45'),
(1182, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 23:22:46', '2025-10-19 23:22:46'),
(1183, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 23:22:54', '2025-10-19 23:22:54'),
(1184, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-19 at 23:23:09', '2025-10-19 23:23:09'),
(1185, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 23:23:09', '2025-10-19 23:23:09'),
(1186, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 23:23:31', '2025-10-19 23:23:31'),
(1187, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 23:23:49', '2025-10-19 23:23:49'),
(1188, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 23:48:42', '2025-10-19 23:48:42'),
(1189, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Hair Service\' on 2025-10-19 at 23:48:58', '2025-10-19 23:48:58'),
(1190, 'Kindeo', 'Create', 'Manage Sub-Categories', 'Created sub-category \'Hair treatment\' for (Hair treatment) on 2025-10-19 at 23:49:18', '2025-10-19 23:49:18'),
(1191, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Hair Color\' on 2025-10-19 at 23:50:15', '2025-10-19 23:50:15'),
(1192, 'Kindeo', 'Update', 'Manage Categories', 'Updated category \'Hair Treatment\' on 2025-10-19 at 23:50:40', '2025-10-19 23:50:40'),
(1193, 'Kindeo', 'Create', 'Manage Products', 'Created product \'Hair Color\' on 2025-10-19 at 23:51:09', '2025-10-19 23:51:09'),
(1194, 'Kindeo', 'Create', 'Manage Services', 'Created service \'Hair Color\' on 2025-10-19 at 23:51:32', '2025-10-19 23:51:32'),
(1195, 'Kindeo', 'Add', 'Manage Delivery', 'Added delivery for product \'\' (Qty: 10, Volume: 10000) on 2025-10-19 at 23:51:51', '2025-10-19 23:51:51'),
(1196, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-19 at 23:52:05', '2025-10-19 23:52:05'),
(1197, 'Kindeo', 'Create', 'Service Price', 'Created service \'Hair Color\' with a price of ₱100 on 2025-10-19 at 23:52:17', '2025-10-19 23:52:17'),
(1198, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 23:52:19', '2025-10-19 23:52:19'),
(1199, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-19 at 23:52:44', '2025-10-19 23:52:44'),
(1200, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-19 at 23:52:56', '2025-10-19 23:52:56'),
(1201, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 23:54:15', '2025-10-19 23:54:15'),
(1202, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-19 at 23:55:49', '2025-10-19 23:55:49'),
(1203, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-19 at 23:56:00', '2025-10-19 23:56:00'),
(1204, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 23:56:12', '2025-10-19 23:56:12'),
(1205, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Senior/PWD\' with rate (20%) on 2025-10-19 at 23:56:56', '2025-10-19 23:56:56'),
(1206, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-19 at 23:57:34', '2025-10-19 23:57:34'),
(1207, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-19 at 23:57:42', '2025-10-19 23:57:42'),
(1208, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-19 at 23:58:05', '2025-10-19 23:58:05'),
(1209, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 23:58:12', '2025-10-19 23:58:12'),
(1210, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 23:58:13', '2025-10-19 23:58:13'),
(1211, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-19 at 23:58:36', '2025-10-19 23:58:36'),
(1212, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-19 at 23:58:36', '2025-10-19 23:58:36'),
(1213, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-19 at 23:58:48', '2025-10-19 23:58:48'),
(1214, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-19 at 23:58:49', '2025-10-19 23:58:49'),
(1215, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-19 at 23:58:56', '2025-10-19 23:58:56'),
(1216, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-19 at 23:59:03', '2025-10-19 23:59:03'),
(1217, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:07:08', '2025-10-20 00:07:08'),
(1218, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 00:07:12', '2025-10-20 00:07:12'),
(1219, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (10%) on 2025-10-20 at 00:07:37', '2025-10-20 00:07:37'),
(1220, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:08:04', '2025-10-20 00:08:04'),
(1221, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-20 at 00:08:11', '2025-10-20 00:08:11'),
(1222, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:14:13', '2025-10-20 00:14:13'),
(1223, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:15:42', '2025-10-20 00:15:42'),
(1224, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:17:17', '2025-10-20 00:17:17'),
(1225, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:18:13', '2025-10-20 00:18:13'),
(1226, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:20:10', '2025-10-20 00:20:10'),
(1227, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:22:11', '2025-10-20 00:22:11'),
(1228, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:22:21', '2025-10-20 00:22:21'),
(1229, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:22:40', '2025-10-20 00:22:40'),
(1230, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:22:53', '2025-10-20 00:22:53'),
(1231, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:23:03', '2025-10-20 00:23:03'),
(1232, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 00:24:34', '2025-10-20 00:24:34'),
(1233, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:24:44', '2025-10-20 00:24:44'),
(1234, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:24:58', '2025-10-20 00:24:58'),
(1235, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:25:06', '2025-10-20 00:25:06'),
(1236, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (15%) on 2025-10-20 at 00:25:23', '2025-10-20 00:25:23'),
(1237, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:25:40', '2025-10-20 00:25:40'),
(1238, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:25:48', '2025-10-20 00:25:48'),
(1239, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:26:00', '2025-10-20 00:26:00'),
(1240, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:26:19', '2025-10-20 00:26:19'),
(1241, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 00:26:41', '2025-10-20 00:26:41'),
(1242, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-20 at 00:26:51', '2025-10-20 00:26:51'),
(1243, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-20 at 00:26:51', '2025-10-20 00:26:51'),
(1244, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 00:27:02', '2025-10-20 00:27:02'),
(1245, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 00:27:23', '2025-10-20 00:27:23'),
(1246, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 00:27:31', '2025-10-20 00:27:31'),
(1247, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 00:27:34', '2025-10-20 00:27:34'),
(1248, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 00:27:40', '2025-10-20 00:27:40'),
(1249, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-20 at 00:27:50', '2025-10-20 00:27:50'),
(1250, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-20 at 00:27:50', '2025-10-20 00:27:50'),
(1251, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 00:27:52', '2025-10-20 00:27:52'),
(1252, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 10:00:33', '2025-10-20 10:00:33'),
(1253, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 10:01:39', '2025-10-20 10:01:39'),
(1254, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-20 at 10:02:42', '2025-10-20 10:02:42'),
(1255, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:02:48', '2025-10-20 10:02:48'),
(1256, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-20 at 10:03:01', '2025-10-20 10:03:01'),
(1257, 'Kindeo', 'View', 'Profit/Lost Report', 'Viewed Proft/Lost Report on 2025-10-20 at 10:03:21', '2025-10-20 10:03:21'),
(1258, 'Kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-20 at 10:03:37', '2025-10-20 10:03:37'),
(1259, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 10:07:21', '2025-10-20 10:07:21'),
(1260, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:17:09', '2025-10-20 10:17:09'),
(1261, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (15%) on 2025-10-20 at 10:18:04', '2025-10-20 10:18:04'),
(1262, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (15%) on 2025-10-20 at 10:19:34', '2025-10-20 10:19:34'),
(1263, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (10%) on 2025-10-20 at 10:19:51', '2025-10-20 10:19:51'),
(1264, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 10:20:09', '2025-10-20 10:20:09'),
(1265, 'Kindeo', 'View', 'Manage User', 'Viewed user Kindeo Neikdo on 2025-10-20 at 10:21:17', '2025-10-20 10:21:17'),
(1266, 'Kindeo', 'Create', 'Manage Supplier', 'Created supplier \'sahud\' on 2025-10-20 at 10:22:29', '2025-10-20 10:22:29'),
(1267, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'Hair Service\' on 2025-10-20 at 10:23:27', '2025-10-20 10:23:27'),
(1268, 'Kindeo', 'Delete', 'Manage Categories', 'Deleted category \'Hair Treatment\' on 2025-10-20 at 10:23:33', '2025-10-20 10:23:33'),
(1269, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:25:25', '2025-10-20 10:25:25'),
(1270, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-20 at 10:25:27', '2025-10-20 10:25:27'),
(1271, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-20 at 10:26:14', '2025-10-20 10:26:14'),
(1272, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:26:15', '2025-10-20 10:26:15'),
(1273, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-20 at 10:26:31', '2025-10-20 10:26:31'),
(1274, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:26:33', '2025-10-20 10:26:33'),
(1275, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:26:44', '2025-10-20 10:26:44'),
(1276, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-20 at 10:27:08', '2025-10-20 10:27:08'),
(1277, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 10:27:52', '2025-10-20 10:27:52'),
(1278, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-20 at 10:27:56', '2025-10-20 10:27:56'),
(1279, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-20 at 10:27:57', '2025-10-20 10:27:57'),
(1280, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Mohaifa  Lakiman Malik\' to client \'\' on 2025-10-20 at 10:28:39', '2025-10-20 10:28:39'),
(1281, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 10:30:28', '2025-10-20 10:30:28'),
(1282, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 10:31:38', '2025-10-20 10:31:38'),
(1283, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 10:31:46', '2025-10-20 10:31:46'),
(1284, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-20 at 10:32:03', '2025-10-20 10:32:03'),
(1285, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-20 at 10:32:06', '2025-10-20 10:32:06'),
(1286, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 10:37:26', '2025-10-20 10:37:26'),
(1287, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-20 at 10:37:30', '2025-10-20 10:37:30'),
(1288, 'Kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-20 10:37:45', '2025-10-20 10:37:45'),
(1289, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 10:39:53', '2025-10-20 10:39:53'),
(1290, 'Kindeo', 'Update', 'Manage Customer', 'Updated customer \'Mariano Vincent\' on 2025-10-20 at 10:40:11', '2025-10-20 10:40:11'),
(1291, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 10:40:37', '2025-10-20 10:40:37'),
(1292, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 10:41:53', '2025-10-20 10:41:53'),
(1293, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 10:42:15', '2025-10-20 10:42:15'),
(1294, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 10:42:57', '2025-10-20 10:42:57'),
(1295, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 10:43:28', '2025-10-20 10:43:28'),
(1296, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 10:44:52', '2025-10-20 10:44:52'),
(1297, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 11:09:05', '2025-10-20 11:09:05'),
(1298, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 11:09:28', '2025-10-20 11:09:28'),
(1299, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 11:11:10', '2025-10-20 11:11:10'),
(1300, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 11:11:34', '2025-10-20 11:11:34'),
(1301, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 11:14:01', '2025-10-20 11:14:01'),
(1302, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-20 at 11:15:22', '2025-10-20 11:15:22'),
(1303, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 11:22:22', '2025-10-20 11:22:22'),
(1304, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 13:36:33', '2025-10-20 13:36:33'),
(1305, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-20 at 13:36:41', '2025-10-20 13:36:41'),
(1306, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 13:37:52', '2025-10-20 13:37:52'),
(1307, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-20 at 13:37:59', '2025-10-20 13:37:59'),
(1308, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 13:54:19', '2025-10-20 13:54:19'),
(1309, 'Kindeo', 'Create', 'Manage User', 'Created new user for Nissan  Malik on 2025-10-20 at 14:14:52', '2025-10-20 14:14:52'),
(1310, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-20 at 14:21:29', '2025-10-20 14:21:29'),
(1311, 'Kindeo', 'Update', 'Manage User', 'Updated user Kindeo Neikdo on 2025-10-20 at 14:22:00', '2025-10-20 14:22:00'),
(1312, 'Kindeo', 'Update', 'Manage User', 'Updated user Kindeo Neikdo on 2025-10-20 at 14:22:32', '2025-10-20 14:22:32'),
(1313, 'Kindeo', 'Update', 'Manage User', 'Updated user Kindeo Neikdo on 2025-10-20 at 14:22:44', '2025-10-20 14:22:44'),
(1314, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 00:21:19', '2025-10-21 00:21:19'),
(1315, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 02:21:04', '2025-10-21 02:21:04'),
(1316, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 02:29:19', '2025-10-21 02:29:19'),
(1317, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 02:30:19', '2025-10-21 02:30:19'),
(1318, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 02:48:58', '2025-10-21 02:48:58'),
(1319, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 02:55:03', '2025-10-21 02:55:03'),
(1320, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 03:02:35', '2025-10-21 03:02:35'),
(1321, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 03:05:43', '2025-10-21 03:05:43'),
(1322, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 03:49:38', '2025-10-21 03:49:38'),
(1323, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 04:03:24', '2025-10-21 04:03:24'),
(1324, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 04:49:18', '2025-10-21 04:49:18'),
(1325, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 04:53:22', '2025-10-21 04:53:22'),
(1326, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 04:53:47', '2025-10-21 04:53:47');
INSERT INTO `tbl_audit_trail` (`id`, `user`, `action`, `module`, `note`, `timestamp`) VALUES
(1327, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 04:54:30', '2025-10-21 04:54:30'),
(1328, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 04:54:32', '2025-10-21 04:54:32'),
(1329, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:05:16', '2025-10-21 05:05:16'),
(1330, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:12:14', '2025-10-21 05:12:14'),
(1331, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:14:15', '2025-10-21 05:14:15'),
(1332, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:18:50', '2025-10-21 05:18:50'),
(1333, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:24:35', '2025-10-21 05:24:35'),
(1334, 'Kindeo', 'Update', 'Manage Categories', 'Updated category \'Hair Treatment\' on 2025-10-21 at 05:25:00', '2025-10-21 05:25:00'),
(1335, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:27:59', '2025-10-21 05:27:59'),
(1336, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:32:01', '2025-10-21 05:32:01'),
(1337, 'Kindeo', 'Update', 'Manage Categories', 'Updated category \'Hair Service\' on 2025-10-21 at 05:32:24', '2025-10-21 05:32:24'),
(1338, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:33:26', '2025-10-21 05:33:26'),
(1339, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 05:49:01', '2025-10-21 05:49:01'),
(1340, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 17:57:06', '2025-10-21 17:57:06'),
(1341, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:03:03', '2025-10-21 18:03:03'),
(1342, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:04:59', '2025-10-21 18:04:59'),
(1343, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 18:05:10', '2025-10-21 18:05:10'),
(1344, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:06:58', '2025-10-21 18:06:58'),
(1345, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:39:59', '2025-10-21 18:39:59'),
(1346, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:43:13', '2025-10-21 18:43:13'),
(1347, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:48:24', '2025-10-21 18:48:24'),
(1348, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:52:27', '2025-10-21 18:52:27'),
(1349, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-21 at 18:52:31', '2025-10-21 18:52:31'),
(1350, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:56:56', '2025-10-21 18:56:56'),
(1351, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:58:05', '2025-10-21 18:58:05'),
(1352, 'Kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-21 at 18:58:50', '2025-10-21 18:58:50'),
(1353, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 18:59:51', '2025-10-21 18:59:51'),
(1354, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:21:26', '2025-10-21 19:21:26'),
(1355, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:31:11', '2025-10-21 19:31:11'),
(1356, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:32:52', '2025-10-21 19:32:52'),
(1357, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:34:49', '2025-10-21 19:34:49'),
(1358, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:36:17', '2025-10-21 19:36:17'),
(1359, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:40:27', '2025-10-21 19:40:27'),
(1360, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:43:53', '2025-10-21 19:43:53'),
(1361, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:45:22', '2025-10-21 19:45:22'),
(1362, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:46:31', '2025-10-21 19:46:31'),
(1363, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:47:07', '2025-10-21 19:47:07'),
(1364, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 19:48:23', '2025-10-21 19:48:23'),
(1365, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:22:18', '2025-10-21 20:22:18'),
(1366, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:29:15', '2025-10-21 20:29:15'),
(1367, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:29:59', '2025-10-21 20:29:59'),
(1368, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:31:01', '2025-10-21 20:31:01'),
(1369, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:33:30', '2025-10-21 20:33:30'),
(1370, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:36:33', '2025-10-21 20:36:33'),
(1371, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 20:37:21', '2025-10-21 20:37:21'),
(1372, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 20:37:22', '2025-10-21 20:37:22'),
(1373, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-21 at 20:37:25', '2025-10-21 20:37:25'),
(1374, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-21 at 20:37:26', '2025-10-21 20:37:26'),
(1375, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 20:37:46', '2025-10-21 20:37:46'),
(1376, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 20:37:54', '2025-10-21 20:37:54'),
(1377, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:38:59', '2025-10-21 20:38:59'),
(1378, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:39:31', '2025-10-21 20:39:31'),
(1379, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:41:56', '2025-10-21 20:41:56'),
(1380, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-21 at 20:42:01', '2025-10-21 20:42:01'),
(1381, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:47:26', '2025-10-21 20:47:26'),
(1382, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:49:55', '2025-10-21 20:49:55'),
(1383, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:51:55', '2025-10-21 20:51:55'),
(1384, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:53:36', '2025-10-21 20:53:36'),
(1385, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:55:05', '2025-10-21 20:55:05'),
(1386, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-21 at 20:55:20', '2025-10-21 20:55:20'),
(1387, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 20:59:16', '2025-10-21 20:59:16'),
(1388, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 20:59:34', '2025-10-21 20:59:34'),
(1389, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 20:59:35', '2025-10-21 20:59:35'),
(1390, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 20:59:41', '2025-10-21 20:59:41'),
(1391, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 21:03:23', '2025-10-21 21:03:23'),
(1392, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 21:03:24', '2025-10-21 21:03:24'),
(1393, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 21:03:26', '2025-10-21 21:03:26'),
(1394, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 21:03:28', '2025-10-21 21:03:28'),
(1395, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 21:03:34', '2025-10-21 21:03:34'),
(1396, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 21:03:34', '2025-10-21 21:03:34'),
(1397, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 21:03:37', '2025-10-21 21:03:37'),
(1398, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-21 at 21:03:53', '2025-10-21 21:03:53'),
(1399, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:41:58', '2025-10-21 21:41:58'),
(1400, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-21 at 21:42:28', '2025-10-21 21:42:28'),
(1401, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:43:48', '2025-10-21 21:43:48'),
(1402, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:44:24', '2025-10-21 21:44:24'),
(1403, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:44:57', '2025-10-21 21:44:57'),
(1404, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 21:45:01', '2025-10-21 21:45:01'),
(1405, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:46:13', '2025-10-21 21:46:13'),
(1406, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:46:43', '2025-10-21 21:46:43'),
(1407, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:47:28', '2025-10-21 21:47:28'),
(1408, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:49:52', '2025-10-21 21:49:52'),
(1409, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:51:00', '2025-10-21 21:51:00'),
(1410, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:51:39', '2025-10-21 21:51:39'),
(1411, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:52:11', '2025-10-21 21:52:11'),
(1412, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:52:52', '2025-10-21 21:52:52'),
(1413, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:54:05', '2025-10-21 21:54:05'),
(1414, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 21:58:58', '2025-10-21 21:58:58'),
(1415, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:02:21', '2025-10-21 22:02:21'),
(1416, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:05:46', '2025-10-21 22:05:46'),
(1417, 'Kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (10%) on 2025-10-21 at 22:06:18', '2025-10-21 22:06:18'),
(1418, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:06:21', '2025-10-21 22:06:21'),
(1419, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:07:47', '2025-10-21 22:07:47'),
(1420, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-21 at 22:07:50', '2025-10-21 22:07:50'),
(1421, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:08:28', '2025-10-21 22:08:28'),
(1422, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:10:39', '2025-10-21 22:10:39'),
(1423, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:11:46', '2025-10-21 22:11:46'),
(1424, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:14:05', '2025-10-21 22:14:05'),
(1425, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 22:14:47', '2025-10-21 22:14:47'),
(1426, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:14:47', '2025-10-21 22:14:47'),
(1427, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-21 at 22:15:12', '2025-10-21 22:15:12'),
(1428, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:19:13', '2025-10-21 22:19:13'),
(1429, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 22:19:17', '2025-10-21 22:19:17'),
(1430, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:19:20', '2025-10-21 22:19:20'),
(1431, 'Kindeo', 'Cancel Status', 'Appointment', 'Cancelled Status for client \'Mariano B Vincent\' on 2025-10-21 at 22:19:29', '2025-10-21 22:19:29'),
(1432, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:29:46', '2025-10-21 22:29:46'),
(1433, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:29:49', '2025-10-21 22:29:49'),
(1434, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:31:05', '2025-10-21 22:31:05'),
(1435, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:31:08', '2025-10-21 22:31:08'),
(1436, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-21 at 22:31:28', '2025-10-21 22:31:28'),
(1437, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:32:55', '2025-10-21 22:32:55'),
(1438, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-21 at 22:33:08', '2025-10-21 22:33:08'),
(1439, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-21 at 22:33:24', '2025-10-21 22:33:24'),
(1440, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-21 at 22:34:02', '2025-10-21 22:34:02'),
(1441, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:35:05', '2025-10-21 22:35:05'),
(1442, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:35:47', '2025-10-21 22:35:47'),
(1443, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:37:09', '2025-10-21 22:37:09'),
(1444, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 22:37:12', '2025-10-21 22:37:12'),
(1445, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:38:00', '2025-10-21 22:38:00'),
(1446, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:43:36', '2025-10-21 22:43:36'),
(1447, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:43:47', '2025-10-21 22:43:47'),
(1448, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-21 at 22:43:58', '2025-10-21 22:43:58'),
(1449, 'Kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-21 at 22:44:09', '2025-10-21 22:44:09'),
(1450, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:44:53', '2025-10-21 22:44:53'),
(1451, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:44:56', '2025-10-21 22:44:56'),
(1452, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-21 at 22:44:57', '2025-10-21 22:44:57'),
(1453, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 22:54:25', '2025-10-21 22:54:25'),
(1454, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:54:32', '2025-10-21 22:54:32'),
(1455, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 22:54:39', '2025-10-21 22:54:39'),
(1456, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:16:49', '2025-10-21 23:16:49'),
(1457, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 23:16:54', '2025-10-21 23:16:54'),
(1458, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:18:14', '2025-10-21 23:18:14'),
(1459, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:21:25', '2025-10-21 23:21:25'),
(1460, 'Kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (10%) on 2025-10-21 at 23:21:41', '2025-10-21 23:21:41'),
(1461, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:45:44', '2025-10-21 23:45:44'),
(1462, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-21 at 23:46:06', '2025-10-21 23:46:06'),
(1463, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 23:46:06', '2025-10-21 23:46:06'),
(1464, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:48:51', '2025-10-21 23:48:51'),
(1465, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:57:15', '2025-10-21 23:57:15'),
(1466, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-21 at 23:57:18', '2025-10-21 23:57:18'),
(1467, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-21 at 23:59:53', '2025-10-21 23:59:53'),
(1468, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-22 at 00:01:14', '2025-10-22 00:01:14'),
(1469, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-22 at 00:37:07', '2025-10-22 00:37:07'),
(1470, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-22 at 00:37:48', '2025-10-22 00:37:48'),
(1471, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-22 at 00:38:14', '2025-10-22 00:38:14'),
(1472, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-22 at 00:43:18', '2025-10-22 00:43:18'),
(1473, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-22 at 00:43:31', '2025-10-22 00:43:31'),
(1474, 'Kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-22 at 00:43:36', '2025-10-22 00:43:36'),
(1475, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 00:46:59', '2025-10-22 00:46:59'),
(1476, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-22 at 00:47:01', '2025-10-22 00:47:01'),
(1477, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 00:47:36', '2025-10-22 00:47:36'),
(1478, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 00:47:51', '2025-10-22 00:47:51'),
(1479, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-22 at 00:47:53', '2025-10-22 00:47:53'),
(1480, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 00:47:54', '2025-10-22 00:47:54'),
(1481, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 00:48:35', '2025-10-22 00:48:35'),
(1482, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-22 at 01:48:31', '2025-10-22 01:48:31'),
(1483, 'Kindeo', 'Log Out', 'User', 'Log Out \'Kindeo\'on 2025-10-22 at 01:48:36', '2025-10-22 01:48:36'),
(1484, 'Kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 01:57:36', '2025-10-22 01:57:36'),
(1485, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 02:00:20', '2025-10-22 02:00:20'),
(1486, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 02:02:19', '2025-10-22 02:02:19'),
(1487, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 02:06:08', '2025-10-22 02:06:08'),
(1488, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 02:30:47', '2025-10-22 02:30:47'),
(1489, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 02:33:06', '2025-10-22 02:33:06'),
(1490, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 02:33:10', '2025-10-22 02:33:10'),
(1491, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 02:34:57', '2025-10-22 02:34:57'),
(1492, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 12:26:29', '2025-10-22 12:26:29'),
(1493, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 12:27:18', '2025-10-22 12:27:18'),
(1494, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-28 at 12:28:00', '2025-10-28 12:28:00'),
(1495, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 12:56:00', '2025-10-22 12:56:00'),
(1496, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 12:56:09', '2025-10-22 12:56:09'),
(1497, 'kindeo', 'Log Out', 'User', 'Log Out \'kindeo\'on 2025-10-22 at 12:56:14', '2025-10-22 12:56:14'),
(1498, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 14:14:36', '2025-10-22 14:14:36'),
(1499, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 14:14:50', '2025-10-22 14:14:50'),
(1500, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 14:14:56', '2025-10-22 14:14:56'),
(1501, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 14:15:10', '2025-10-22 14:15:10'),
(1502, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 14:16:15', '2025-10-22 14:16:15'),
(1503, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 14:16:18', '2025-10-22 14:16:18'),
(1504, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 14:16:25', '2025-10-22 14:16:25'),
(1505, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 14:19:59', '2025-10-22 14:19:59'),
(1506, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 14:20:02', '2025-10-22 14:20:02'),
(1507, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 14:21:18', '2025-10-22 14:21:18'),
(1508, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 14:21:21', '2025-10-22 14:21:21'),
(1509, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 14:22:31', '2025-10-22 14:22:31'),
(1510, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 14:22:35', '2025-10-22 14:22:35'),
(1511, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-11-22 at 14:23:03', '2025-11-22 14:23:03'),
(1512, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-11-22 at 14:23:07', '2025-11-22 14:23:07'),
(1513, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-11-22 at 14:23:28', '2025-11-22 14:23:28'),
(1514, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-11-22 at 14:23:41', '2025-11-22 14:23:41'),
(1515, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-11-22 at 14:24:00', '2025-11-22 14:24:00'),
(1516, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 15:25:32', '2025-10-22 15:25:32'),
(1517, 'kindeo', 'Log Out', 'User', 'Log Out \'kindeo\'on 2025-10-22 at 15:26:18', '2025-10-22 15:26:18'),
(1518, 'kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-22 at 15:31:56', '2025-10-22 15:31:56'),
(1519, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 15:34:03', '2025-10-22 15:34:03'),
(1520, 'kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-22 at 15:35:06', '2025-10-22 15:35:06'),
(1521, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:38:23', '2025-10-22 15:38:23'),
(1522, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:40:45', '2025-10-22 15:40:45'),
(1523, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:41:00', '2025-10-22 15:41:00'),
(1524, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:45:24', '2025-10-22 15:45:24'),
(1525, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-22 at 15:46:36', '2025-10-22 15:46:36'),
(1526, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:46:38', '2025-10-22 15:46:38'),
(1527, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:48:17', '2025-10-22 15:48:17'),
(1528, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:48:40', '2025-10-22 15:48:40'),
(1529, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 15:48:50', '2025-10-22 15:48:50'),
(1530, 'kindeo', 'Deactivate', 'Manage User', 'Deactivated user Nissan  Malik on 2025-10-22 at 15:51:10', '2025-10-22 15:51:10'),
(1531, 'kindeo', 'Create', 'Manage Stylist', 'Created stylist kindeo neidko on 2025-10-22 at 15:56:16', '2025-10-22 15:56:16'),
(1532, 'kindeo', 'Update', 'Manage Stylist', 'Updated stylist kindeo neidko on 2025-10-22 at 15:56:28', '2025-10-22 15:56:28'),
(1533, 'kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo neidko on 2025-10-22 at 15:56:37', '2025-10-22 15:56:37'),
(1534, 'kindeo', 'Create', 'Manage Products', 'Created product \'straightener\' on 2025-10-22 at 16:10:23', '2025-10-22 16:10:23'),
(1535, 'kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-22 at 16:16:55', '2025-10-22 16:16:55'),
(1536, 'kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-22 at 16:17:12', '2025-10-22 16:17:12'),
(1537, 'kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-22 at 16:17:15', '2025-10-22 16:17:15'),
(1538, 'kindeo', 'Delete', 'Service Price', 'Deleted service \'\' with a price of ₱100 on 2025-10-22 at 16:18:13', '2025-10-22 16:18:13'),
(1539, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 16:18:36', '2025-10-22 16:18:36'),
(1540, 'kindeo', 'Create', 'Service Price', 'Created service \'Hair Color\' with a price of ₱200 on 2025-10-22 at 16:19:10', '2025-10-22 16:19:10'),
(1541, 'kindeo', 'Delete', 'Service Price', 'Deleted service \'Hair Color\' with a price of ₱200 on 2025-10-22 at 16:20:30', '2025-10-22 16:20:30'),
(1542, 'kindeo', 'Update', 'Manage Services', 'Updated service \'Hair Color\' on 2025-10-22 at 16:24:42', '2025-10-22 16:24:42'),
(1543, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 16:29:43', '2025-10-22 16:29:43'),
(1544, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 16:30:38', '2025-10-22 16:30:38'),
(1545, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 16:30:45', '2025-10-22 16:30:45'),
(1546, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 16:32:59', '2025-10-22 16:32:59'),
(1547, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 16:33:02', '2025-10-22 16:33:02'),
(1548, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-22 at 16:33:16', '2025-10-22 16:33:16'),
(1549, 'kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-22 at 16:38:32', '2025-10-22 16:38:32'),
(1550, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-22 at 16:38:41', '2025-10-22 16:38:41'),
(1551, 'kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-22 at 16:38:51', '2025-10-22 16:38:51'),
(1552, 'kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-22 at 16:38:53', '2025-10-22 16:38:53'),
(1553, 'kindeo', 'Export PDF', 'User', 'Exported Sales Report to PDF at 2025-10-22 16:39:07', '2025-10-22 16:39:07'),
(1554, 'kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-22 at 16:40:20', '2025-10-22 16:40:20'),
(1555, 'kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-22 at 16:40:23', '2025-10-22 16:40:23'),
(1556, 'kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-22 at 16:40:30', '2025-10-22 16:40:30'),
(1557, 'kindeo', 'View', 'Sales Report', 'Viewed Sales Report on 2025-10-22 at 16:40:40', '2025-10-22 16:40:40'),
(1558, 'kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-22 at 16:40:53', '2025-10-22 16:40:53'),
(1559, 'kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-22 at 16:40:53', '2025-10-22 16:40:53'),
(1560, 'kindeo', 'View', 'Profit/Lost Report', 'Viewed Proft/Lost Report on 2025-10-22 at 16:40:55', '2025-10-22 16:40:55'),
(1561, 'kindeo', 'View', 'Customer Report', 'Viewed Customer Report on 2025-10-22 at 16:40:57', '2025-10-22 16:40:57'),
(1562, 'kindeo', 'View', 'Technician Report', 'Viewed Technician Report on 2025-10-22 at 16:40:58', '2025-10-22 16:40:58'),
(1563, 'kindeo', 'View', 'Delivery Report', 'Viewed Delivery Report on 2025-10-22 at 16:40:59', '2025-10-22 16:40:59'),
(1564, 'kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-22 at 16:41:00', '2025-10-22 16:41:00'),
(1565, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 16:41:19', '2025-10-22 16:41:19'),
(1566, 'kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-22 at 16:42:40', '2025-10-22 16:42:40'),
(1567, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 16:43:10', '2025-10-22 16:43:10'),
(1568, 'kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-22 at 16:44:03', '2025-10-22 16:44:03'),
(1569, 'kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (20%) on 2025-10-22 at 16:48:21', '2025-10-22 16:48:21'),
(1570, 'kindeo', 'Delete', 'Manage Stylist', 'Deleted stylist kindeo neidko on 2025-10-22 at 16:50:02', '2025-10-22 16:50:02'),
(1571, 'kindeo', 'Log Out', 'User', 'Log Out \'kindeo\'on 2025-10-22 at 16:51:00', '2025-10-22 16:51:00'),
(1572, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 16:51:38', '2025-10-22 16:51:38'),
(1573, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-22 at 16:53:09', '2025-10-22 16:53:09'),
(1574, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-22 at 16:53:20', '2025-10-22 16:53:20'),
(1575, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-22 at 16:53:38', '2025-10-22 16:53:38'),
(1576, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-22 at 16:53:56', '2025-10-22 16:53:56'),
(1577, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 17:39:10', '2025-10-22 17:39:10'),
(1578, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 18:53:33', '2025-10-22 18:53:33'),
(1579, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-22 at 18:54:23', '2025-10-22 18:54:23'),
(1580, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-22 at 18:54:26', '2025-10-22 18:54:26'),
(1581, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-22 at 18:54:28', '2025-10-22 18:54:28'),
(1582, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 22:58:13', '2025-10-22 22:58:13'),
(1583, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:02:16', '2025-10-22 23:02:16'),
(1584, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:06:31', '2025-10-22 23:06:31'),
(1585, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:08:21', '2025-10-22 23:08:21'),
(1586, 'kindeo', 'Create', 'Manage User', 'Created new user for    kindeo neikdo on 2025-10-22 at 23:09:49', '2025-10-22 23:09:49'),
(1587, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:11:47', '2025-10-22 23:11:47'),
(1588, 'kindeo', 'Update', 'Manage User', 'Updated user    kindeo neikdo on 2025-10-22 at 23:11:53', '2025-10-22 23:11:53'),
(1589, 'kindeo', 'Update', 'Manage User', 'Updated user Kindeo       neikdo on 2025-10-22 at 23:12:01', '2025-10-22 23:12:01'),
(1590, 'kindeo', 'Update', 'Manage User', 'Updated user          Kindeo       neikdo on 2025-10-22 at 23:12:08', '2025-10-22 23:12:08'),
(1591, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:12:53', '2025-10-22 23:12:53'),
(1592, 'kindeo', 'Update', 'Manage User', 'Updated user          Kindeo       neikdo on 2025-10-22 at 23:12:59', '2025-10-22 23:12:59'),
(1593, 'kindeo', 'Update', 'Manage User', 'Updated user       Kindeo neikdo on 2025-10-22 at 23:13:03', '2025-10-22 23:13:03'),
(1594, 'kindeo', 'Update', 'Manage User', 'Updated user Kindei Neikdo neikdo on 2025-10-22 at 23:13:17', '2025-10-22 23:13:17'),
(1595, 'kindeo', 'Update', 'Manage User', 'Updated user Kindei Neikdo        neikdo on 2025-10-22 at 23:13:23', '2025-10-22 23:13:23'),
(1596, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:14:51', '2025-10-22 23:14:51'),
(1597, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:22:11', '2025-10-22 23:22:11'),
(1598, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:23:39', '2025-10-22 23:23:39'),
(1599, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:26:08', '2025-10-22 23:26:08'),
(1600, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:28:09', '2025-10-22 23:28:09'),
(1601, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:31:44', '2025-10-22 23:31:44'),
(1602, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:32:49', '2025-10-22 23:32:49'),
(1603, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:35:00', '2025-10-22 23:35:00'),
(1604, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:39:39', '2025-10-22 23:39:39'),
(1605, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:43:09', '2025-10-22 23:43:09'),
(1606, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:53:39', '2025-10-22 23:53:39'),
(1607, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:55:30', '2025-10-22 23:55:30'),
(1608, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:55:52', '2025-10-22 23:55:52'),
(1609, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:56:48', '2025-10-22 23:56:48'),
(1610, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:57:14', '2025-10-22 23:57:14'),
(1611, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-22 at 23:59:56', '2025-10-22 23:59:56'),
(1612, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:01:29', '2025-10-23 00:01:29'),
(1613, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:04:20', '2025-10-23 00:04:20'),
(1614, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:05:50', '2025-10-23 00:05:50'),
(1615, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:08:31', '2025-10-23 00:08:31'),
(1616, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:12:13', '2025-10-23 00:12:13'),
(1617, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:13:38', '2025-10-23 00:13:38'),
(1618, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:14:11', '2025-10-23 00:14:11'),
(1619, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:14:56', '2025-10-23 00:14:56'),
(1620, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:20:34', '2025-10-23 00:20:34'),
(1621, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:22:07', '2025-10-23 00:22:07'),
(1622, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:25:17', '2025-10-23 00:25:17'),
(1623, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:30:11', '2025-10-23 00:30:11'),
(1624, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:34:50', '2025-10-23 00:34:50'),
(1625, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:35:39', '2025-10-23 00:35:39'),
(1626, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:36:18', '2025-10-23 00:36:18'),
(1627, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:36:45', '2025-10-23 00:36:45'),
(1628, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:37:14', '2025-10-23 00:37:14'),
(1629, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:37:48', '2025-10-23 00:37:48'),
(1630, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:38:28', '2025-10-23 00:38:28'),
(1631, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:39:11', '2025-10-23 00:39:11'),
(1632, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:39:44', '2025-10-23 00:39:44'),
(1633, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:40:13', '2025-10-23 00:40:13'),
(1634, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:40:56', '2025-10-23 00:40:56'),
(1635, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:41:30', '2025-10-23 00:41:30'),
(1636, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:41:49', '2025-10-23 00:41:49'),
(1637, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:42:13', '2025-10-23 00:42:13'),
(1638, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:42:38', '2025-10-23 00:42:38'),
(1639, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:43:06', '2025-10-23 00:43:06'),
(1640, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:43:33', '2025-10-23 00:43:33'),
(1641, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:44:01', '2025-10-23 00:44:01'),
(1642, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:44:24', '2025-10-23 00:44:24'),
(1643, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:45:19', '2025-10-23 00:45:19'),
(1644, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:45:51', '2025-10-23 00:45:51'),
(1645, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:46:21', '2025-10-23 00:46:21'),
(1646, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:46:46', '2025-10-23 00:46:46'),
(1647, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:48:10', '2025-10-23 00:48:10'),
(1648, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:49:21', '2025-10-23 00:49:21'),
(1649, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 00:52:20', '2025-10-23 00:52:20'),
(1650, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 01:35:10', '2025-10-23 01:35:10'),
(1651, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 01:35:22', '2025-10-23 01:35:22'),
(1652, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 01:35:23', '2025-10-23 01:35:23'),
(1653, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 01:35:27', '2025-10-23 01:35:27'),
(1654, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 01:36:39', '2025-10-23 01:36:39'),
(1655, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 01:36:53', '2025-10-23 01:36:53'),
(1656, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:00:50', '2025-10-23 02:00:50'),
(1657, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:00:56', '2025-10-23 02:00:56'),
(1658, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:00:58', '2025-10-23 02:00:58'),
(1659, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:01:02', '2025-10-23 02:01:02'),
(1660, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:17:48', '2025-10-23 02:17:48'),
(1661, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:17:52', '2025-10-23 02:17:52'),
(1662, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:17:56', '2025-10-23 02:17:56'),
(1663, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:17:57', '2025-10-23 02:17:57'),
(1664, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:19:10', '2025-10-23 02:19:10'),
(1665, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:19:16', '2025-10-23 02:19:16'),
(1666, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:19:17', '2025-10-23 02:19:17'),
(1667, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-23 at 02:19:39', '2025-10-23 02:19:39'),
(1668, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 02:19:55', '2025-10-23 02:19:55'),
(1669, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:19:59', '2025-10-23 02:19:59'),
(1670, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:20:01', '2025-10-23 02:20:01'),
(1671, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:20:27', '2025-10-23 02:20:27'),
(1672, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:20:35', '2025-10-23 02:20:35'),
(1673, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:20:57', '2025-10-23 02:20:57'),
(1674, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:22:12', '2025-10-23 02:22:12'),
(1675, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:22:15', '2025-10-23 02:22:15'),
(1676, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:22:18', '2025-10-23 02:22:18'),
(1677, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:22:21', '2025-10-23 02:22:21'),
(1678, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:32:16', '2025-10-23 02:32:16'),
(1679, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:32:23', '2025-10-23 02:32:23'),
(1680, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:32:24', '2025-10-23 02:32:24'),
(1681, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-23 at 02:32:39', '2025-10-23 02:32:39'),
(1682, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:33:03', '2025-10-23 02:33:03'),
(1683, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:33:04', '2025-10-23 02:33:04'),
(1684, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:33:25', '2025-10-23 02:33:25'),
(1685, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:38:14', '2025-10-23 02:38:14'),
(1686, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:41:02', '2025-10-23 02:41:02'),
(1687, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:43:11', '2025-10-23 02:43:11'),
(1688, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:43:42', '2025-10-23 02:43:42'),
(1689, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 02:43:51', '2025-10-23 02:43:51'),
(1690, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:43:54', '2025-10-23 02:43:54'),
(1691, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:43:56', '2025-10-23 02:43:56'),
(1692, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:44:46', '2025-10-23 02:44:46'),
(1693, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:46:22', '2025-10-23 02:46:22'),
(1694, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:46:27', '2025-10-23 02:46:27'),
(1695, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:46:29', '2025-10-23 02:46:29'),
(1696, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 02:46:42', '2025-10-23 02:46:42'),
(1697, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:46:44', '2025-10-23 02:46:44'),
(1698, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:46:46', '2025-10-23 02:46:46'),
(1699, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:47:00', '2025-10-23 02:47:00'),
(1700, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:48:03', '2025-10-23 02:48:03'),
(1701, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 02:48:12', '2025-10-23 02:48:12'),
(1702, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:48:15', '2025-10-23 02:48:15'),
(1703, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:48:20', '2025-10-23 02:48:20'),
(1704, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:48:23', '2025-10-23 02:48:23'),
(1705, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:48:33', '2025-10-23 02:48:33'),
(1706, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:48:51', '2025-10-23 02:48:51'),
(1707, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:55:01', '2025-10-23 02:55:01'),
(1708, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:55:06', '2025-10-23 02:55:06'),
(1709, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 02:55:33', '2025-10-23 02:55:33'),
(1710, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:55:37', '2025-10-23 02:55:37'),
(1711, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 02:55:47', '2025-10-23 02:55:47'),
(1712, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 02:55:49', '2025-10-23 02:55:49'),
(1713, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 02:55:51', '2025-10-23 02:55:51'),
(1714, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 03:09:27', '2025-10-23 03:09:27'),
(1715, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 03:09:34', '2025-10-23 03:09:34'),
(1716, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 03:09:35', '2025-10-23 03:09:35'),
(1717, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-26 at 03:10:48', '2025-10-26 03:10:48'),
(1718, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-26 at 03:10:58', '2025-10-26 03:10:58'),
(1719, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:11:20', '2025-10-26 03:11:20'),
(1720, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-26 at 03:11:24', '2025-10-26 03:11:24'),
(1721, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-26 at 03:11:26', '2025-10-26 03:11:26'),
(1722, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-26 at 03:12:14', '2025-10-26 03:12:14'),
(1723, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:13:01', '2025-10-26 03:13:01'),
(1724, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-26 at 03:13:04', '2025-10-26 03:13:04'),
(1725, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-26 at 03:13:07', '2025-10-26 03:13:07'),
(1726, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-26 at 03:13:15', '2025-10-26 03:13:15'),
(1727, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:24:10', '2025-10-26 03:24:10'),
(1728, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-26 at 03:24:32', '2025-10-26 03:24:32'),
(1729, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:26:26', '2025-10-26 03:26:26'),
(1730, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:29:22', '2025-10-26 03:29:22'),
(1731, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-26 at 03:29:25', '2025-10-26 03:29:25'),
(1732, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:37:19', '2025-10-26 03:37:19'),
(1733, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:38:18', '2025-10-26 03:38:18'),
(1734, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:44:26', '2025-10-26 03:44:26'),
(1735, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-26 at 03:44:30', '2025-10-26 03:44:30'),
(1736, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:45:49', '2025-10-26 03:45:49'),
(1737, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:48:26', '2025-10-26 03:48:26'),
(1738, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:50:00', '2025-10-26 03:50:00'),
(1739, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-26 at 03:53:09', '2025-10-26 03:53:09'),
(1740, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-30 at 03:58:02', '2025-10-30 03:58:02'),
(1741, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 03:58:29', '2025-10-31 03:58:29'),
(1742, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:00:18', '2025-10-31 04:00:18'),
(1743, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:12:18', '2025-10-31 04:12:18'),
(1744, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-31 at 04:12:22', '2025-10-31 04:12:22'),
(1745, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:12:25', '2025-10-31 04:12:25'),
(1746, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:13:11', '2025-10-31 04:13:11'),
(1747, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:13:16', '2025-10-31 04:13:16'),
(1748, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-31 at 04:13:18', '2025-10-31 04:13:18'),
(1749, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-31 at 04:13:19', '2025-10-31 04:13:19'),
(1750, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:13:48', '2025-10-31 04:13:48'),
(1751, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:13:52', '2025-10-31 04:13:52'),
(1752, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:14:14', '2025-10-31 04:14:14'),
(1753, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:14:28', '2025-10-31 04:14:28'),
(1754, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:14:34', '2025-10-31 04:14:34'),
(1755, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:20:31', '2025-10-31 04:20:31'),
(1756, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:20:41', '2025-10-31 04:20:41'),
(1757, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:24:03', '2025-10-31 04:24:03'),
(1758, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:24:32', '2025-10-31 04:24:32'),
(1759, 'kindeo', 'Log Out', 'User', 'Log Out \'kindeo\'on 2025-10-31 at 04:24:38', '2025-10-31 04:24:38'),
(1760, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:24:50', '2025-10-31 04:24:50'),
(1761, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:25:25', '2025-10-31 04:25:25'),
(1762, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:27:47', '2025-10-31 04:27:47'),
(1763, 'kindeo', 'Log Out', 'User', 'Log Out \'kindeo\'on 2025-10-31 at 04:28:00', '2025-10-31 04:28:00'),
(1764, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:28:06', '2025-10-31 04:28:06'),
(1765, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:56:18', '2025-10-31 04:56:18'),
(1766, 'kindeo', 'Add', 'Manage Delivery', 'Added delivery for product \'\' (Qty: 20, Volume: 20000) on 2025-10-31 at 04:57:15', '2025-10-31 04:57:15'),
(1767, 'kindeo', 'View', 'Manage Delivery', 'Viewed delivery on 2025-10-31 at 04:57:17', '2025-10-31 04:57:17'),
(1768, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'straightener\' for (Hair Color) on 2025-10-31 at 04:57:44', '2025-10-31 04:57:44'),
(1769, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 04:57:53', '2025-10-31 04:57:53'),
(1770, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 04:57:58', '2025-10-31 04:57:58');
INSERT INTO `tbl_audit_trail` (`id`, `user`, `action`, `module`, `note`, `timestamp`) VALUES
(1771, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 04:58:00', '2025-10-31 04:58:00'),
(1772, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 04:58:45', '2025-10-31 04:58:45'),
(1773, 'kindeo', 'Create', 'Manage Services', 'Created service \'hair treatment\' on 2025-10-31 at 04:59:08', '2025-10-31 04:59:08'),
(1774, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 04:59:21', '2025-10-31 04:59:21'),
(1775, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:00:57', '2025-10-31 05:00:57'),
(1776, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:09:02', '2025-10-31 05:09:02'),
(1777, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:10:57', '2025-10-31 05:10:57'),
(1778, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:11:07', '2025-10-31 05:11:07'),
(1779, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:11:11', '2025-10-31 05:11:11'),
(1780, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:11:23', '2025-10-31 05:11:23'),
(1781, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:11:25', '2025-10-31 05:11:25'),
(1782, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:19:00', '2025-10-31 05:19:00'),
(1783, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:19:17', '2025-10-31 05:19:17'),
(1784, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:19:20', '2025-10-31 05:19:20'),
(1785, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:23:42', '2025-10-31 05:23:42'),
(1786, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:23:53', '2025-10-31 05:23:53'),
(1787, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:24:02', '2025-10-31 05:24:02'),
(1788, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:33:04', '2025-10-31 05:33:04'),
(1789, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:33:13', '2025-10-31 05:33:13'),
(1790, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:33:14', '2025-10-31 05:33:14'),
(1791, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (hair treatment) on 2025-10-31 at 05:33:26', '2025-10-31 05:33:26'),
(1792, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:33:37', '2025-10-31 05:33:37'),
(1793, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:33:49', '2025-10-31 05:33:49'),
(1794, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:33:52', '2025-10-31 05:33:52'),
(1795, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:34:06', '2025-10-31 05:34:06'),
(1796, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:34:07', '2025-10-31 05:34:07'),
(1797, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:34:09', '2025-10-31 05:34:09'),
(1798, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:34:26', '2025-10-31 05:34:26'),
(1799, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:34:29', '2025-10-31 05:34:29'),
(1800, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:35:59', '2025-10-31 05:35:59'),
(1801, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:36:08', '2025-10-31 05:36:08'),
(1802, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:36:11', '2025-10-31 05:36:11'),
(1803, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (Hair Color) on 2025-10-31 at 05:36:15', '2025-10-31 05:36:15'),
(1804, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:36:16', '2025-10-31 05:36:16'),
(1805, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:36:17', '2025-10-31 05:36:17'),
(1806, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:36:19', '2025-10-31 05:36:19'),
(1807, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:41:48', '2025-10-31 05:41:48'),
(1808, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:41:59', '2025-10-31 05:41:59'),
(1809, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:42:03', '2025-10-31 05:42:03'),
(1810, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:45:02', '2025-10-31 05:45:02'),
(1811, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-31 at 05:45:06', '2025-10-31 05:45:06'),
(1812, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (Hair Color) on 2025-10-31 at 05:45:23', '2025-10-31 05:45:23'),
(1813, 'kindeo', 'Delete', 'Manage Services, Product Usage', 'Deleted product usage \'\' for (Hair Color) on 2025-10-31 at 05:45:26', '2025-10-31 05:45:26'),
(1814, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:45:54', '2025-10-31 05:45:54'),
(1815, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 05:47:32', '2025-10-31 05:47:32'),
(1816, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'Hair Color\' for (hair treatment) on 2025-10-31 at 05:47:56', '2025-10-31 05:47:56'),
(1817, 'kindeo', 'Create', 'Manage Services, Product Usage', 'Created product usage \'straightener\' for (hair treatment) on 2025-10-31 at 05:48:01', '2025-10-31 05:48:01'),
(1818, 'kindeo', 'Create', 'Service Price', 'Created service \'hair treatment\' with a price of ₱250 on 2025-10-31 at 05:48:26', '2025-10-31 05:48:26'),
(1819, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-31 at 06:10:57', '2025-10-31 06:10:57'),
(1820, 'kindeo', 'Update', 'Manage Services, Product Usage', 'Updated product usage \'straightener\' for (hair treatment) on 2025-10-31 at 06:11:12', '2025-10-31 06:11:12'),
(1821, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-31 at 06:11:39', '2025-10-31 06:11:39'),
(1822, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-31 at 06:11:40', '2025-10-31 06:11:40'),
(1823, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:01:42', '2025-10-23 07:01:42'),
(1824, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:03:11', '2025-10-23 07:03:11'),
(1825, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:05:17', '2025-10-23 07:05:17'),
(1826, 'kindeo', 'View', 'Manage User', 'Viewed user Kindei Neikdo neikdo on 2025-10-23 at 07:05:21', '2025-10-23 07:05:21'),
(1827, 'kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Tuesday\' (Stylist: kindeo) on 2025-10-23 at 07:05:47', '2025-10-23 07:05:47'),
(1828, 'kindeo', 'Delete', 'Manage Stylist, Schedule', 'Deleted schedule for \'Tuesday\' (Stylist: kindeo) on 2025-10-23 at 07:05:55', '2025-10-23 07:05:55'),
(1829, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:08:18', '2025-10-23 07:08:18'),
(1830, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:10:13', '2025-10-23 07:10:13'),
(1831, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:11:52', '2025-10-23 07:11:52'),
(1832, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:15:07', '2025-10-23 07:15:07'),
(1833, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:15:49', '2025-10-23 07:15:49'),
(1834, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:18:30', '2025-10-23 07:18:30'),
(1835, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:21:05', '2025-10-23 07:21:05'),
(1836, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:21:46', '2025-10-23 07:21:46'),
(1837, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:26:43', '2025-10-23 07:26:43'),
(1838, 'kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Monday\' (Stylist: we) on 2025-10-23 at 07:27:08', '2025-10-23 07:27:08'),
(1839, 'kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:28:02', '2025-10-23 07:28:02'),
(1840, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:28:29', '2025-10-23 07:28:29'),
(1841, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:28:34', '2025-10-23 07:28:34'),
(1842, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:28:40', '2025-10-23 07:28:40'),
(1843, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:32:57', '2025-10-23 07:32:57'),
(1844, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:33:10', '2025-10-23 07:33:10'),
(1845, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:33:16', '2025-10-23 07:33:16'),
(1846, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:34:33', '2025-10-23 07:34:33'),
(1847, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:34:51', '2025-10-23 07:34:51'),
(1848, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:34:55', '2025-10-23 07:34:55'),
(1849, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:35:27', '2025-10-23 07:35:27'),
(1850, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:35:40', '2025-10-23 07:35:40'),
(1851, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:35:44', '2025-10-23 07:35:44'),
(1852, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:37:46', '2025-10-23 07:37:46'),
(1853, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:38:08', '2025-10-23 07:38:08'),
(1854, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:38:37', '2025-10-23 07:38:37'),
(1855, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:38:50', '2025-10-23 07:38:50'),
(1856, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:42:26', '2025-10-23 07:42:26'),
(1857, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'-- Select Day --\' (Stylist: kindeo123) on 2025-10-23 at 07:42:38', '2025-10-23 07:42:38'),
(1858, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'-- Select Day --\' (Stylist: kindeo123) on 2025-10-23 at 07:42:45', '2025-10-23 07:42:45'),
(1859, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'-- Select Day --\' (Stylist: kindeo123) on 2025-10-23 at 07:43:06', '2025-10-23 07:43:06'),
(1860, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:44:10', '2025-10-23 07:44:10'),
(1861, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:46:33', '2025-10-23 07:46:33'),
(1862, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 07:46:49', '2025-10-23 07:46:49'),
(1863, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:50:18', '2025-10-23 07:50:18'),
(1864, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:52:02', '2025-10-23 07:52:02'),
(1865, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:58:45', '2025-10-23 07:58:45'),
(1866, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 07:59:17', '2025-10-23 07:59:17'),
(1867, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:01:12', '2025-10-23 08:01:12'),
(1868, 'kindeo', 'Update', 'Manage Stylist, Schedule', 'Updated schedule for \'Tuesday\' (Stylist: we) on 2025-10-23 at 08:01:25', '2025-10-23 08:01:25'),
(1869, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:03:22', '2025-10-23 08:03:22'),
(1870, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'we\' (Reason: test) on 2025-10-23 at 08:04:06', '2025-10-23 08:04:06'),
(1871, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:06:10', '2025-10-23 08:06:10'),
(1872, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:08:40', '2025-10-23 08:08:40'),
(1873, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:12:00', '2025-10-23 08:12:00'),
(1874, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:13:40', '2025-10-23 08:13:40'),
(1875, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'we\' (Reason: test) on 2025-10-23 at 08:14:24', '2025-10-23 08:14:24'),
(1876, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'we\' (Reason: test) on 2025-10-23 at 08:14:26', '2025-10-23 08:14:26'),
(1877, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'we\' (Reason: test) on 2025-10-23 at 08:14:33', '2025-10-23 08:14:33'),
(1878, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'we\' (Reason: test) on 2025-10-23 at 08:14:44', '2025-10-23 08:14:44'),
(1879, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:16:02', '2025-10-23 08:16:02'),
(1880, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'sda\' (Reason: sdasdas) on 2025-10-23 at 08:16:20', '2025-10-23 08:16:20'),
(1881, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:18:56', '2025-10-23 08:18:56'),
(1882, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sick) on 2025-10-23 at 08:19:33', '2025-10-23 08:19:33'),
(1883, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'sda\' (Reason: sick) on 2025-10-23 at 08:19:43', '2025-10-23 08:19:43'),
(1884, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:36:18', '2025-10-23 08:36:18'),
(1885, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sick) on 2025-10-23 at 08:36:30', '2025-10-23 08:36:30'),
(1886, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sick) on 2025-10-23 at 08:36:33', '2025-10-23 08:36:33'),
(1887, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:38:23', '2025-10-23 08:38:23'),
(1888, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: wew) on 2025-10-23 at 08:38:34', '2025-10-23 08:38:34'),
(1889, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:41:35', '2025-10-23 08:41:35'),
(1890, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: tes) on 2025-10-23 at 08:41:58', '2025-10-23 08:41:58'),
(1891, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: tes) on 2025-10-23 at 08:42:08', '2025-10-23 08:42:08'),
(1892, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:42:34', '2025-10-23 08:42:34'),
(1893, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 213) on 2025-10-23 at 08:42:56', '2025-10-23 08:42:56'),
(1894, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:45:43', '2025-10-23 08:45:43'),
(1895, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: se) on 2025-10-23 at 08:45:52', '2025-10-23 08:45:52'),
(1896, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:54:00', '2025-10-23 08:54:00'),
(1897, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:54:45', '2025-10-23 08:54:45'),
(1898, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:56:15', '2025-10-23 08:56:15'),
(1899, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 08:56:55', '2025-10-23 08:56:55'),
(1900, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:00:05', '2025-10-23 09:00:05'),
(1901, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 123) on 2025-10-23 at 09:00:14', '2025-10-23 09:00:14'),
(1902, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 123) on 2025-10-23 at 09:00:31', '2025-10-23 09:00:31'),
(1903, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:03:33', '2025-10-23 09:03:33'),
(1904, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:44', '2025-10-23 09:03:44'),
(1905, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:49', '2025-10-23 09:03:49'),
(1906, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:49', '2025-10-23 09:03:49'),
(1907, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:49', '2025-10-23 09:03:49'),
(1908, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:50', '2025-10-23 09:03:50'),
(1909, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:50', '2025-10-23 09:03:50'),
(1910, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:51', '2025-10-23 09:03:51'),
(1911, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:52', '2025-10-23 09:03:52'),
(1912, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:52', '2025-10-23 09:03:52'),
(1913, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:53', '2025-10-23 09:03:53'),
(1914, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:54', '2025-10-23 09:03:54'),
(1915, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:55', '2025-10-23 09:03:55'),
(1916, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: 2) on 2025-10-23 at 09:03:56', '2025-10-23 09:03:56'),
(1917, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:16:44', '2025-10-23 09:16:44'),
(1918, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: dsa) on 2025-10-23 at 09:16:51', '2025-10-23 09:16:51'),
(1919, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: dsa) on 2025-10-23 at 09:16:53', '2025-10-23 09:16:53'),
(1920, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:20:13', '2025-10-23 09:20:13'),
(1921, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: dasd) on 2025-10-23 at 09:20:21', '2025-10-23 09:20:21'),
(1922, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: dasd) on 2025-10-23 at 09:20:22', '2025-10-23 09:20:22'),
(1923, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: dasd) on 2025-10-23 at 09:20:27', '2025-10-23 09:20:27'),
(1924, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:24:12', '2025-10-23 09:24:12'),
(1925, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:49:50', '2025-10-23 09:49:50'),
(1926, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sad) on 2025-10-23 at 09:50:07', '2025-10-23 09:50:07'),
(1927, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sad) on 2025-10-23 at 09:50:09', '2025-10-23 09:50:09'),
(1928, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sad) on 2025-10-23 at 09:50:11', '2025-10-23 09:50:11'),
(1929, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:52:26', '2025-10-23 09:52:26'),
(1930, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: dsa) on 2025-10-23 at 09:52:33', '2025-10-23 09:52:33'),
(1931, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 09:55:24', '2025-10-23 09:55:24'),
(1932, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: sad) on 2025-10-23 at 09:55:43', '2025-10-23 09:55:43'),
(1933, 'kindeo', 'Create', 'Manage Stylist, Schedule', 'Created schedule for \'Monday\' (Stylist: sda) on 2025-10-23 at 09:56:06', '2025-10-23 09:56:06'),
(1934, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 10:12:58', '2025-10-23 10:12:58'),
(1935, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 10:13:00', '2025-10-23 10:13:00'),
(1936, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 10:13:01', '2025-10-23 10:13:01'),
(1937, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 10:13:02', '2025-10-23 10:13:02'),
(1938, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 10:13:03', '2025-10-23 10:13:03'),
(1939, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 10:13:04', '2025-10-23 10:13:04'),
(1940, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 10:13:25', '2025-10-23 10:13:25'),
(1941, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 10:13:46', '2025-10-23 10:13:46'),
(1942, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 10:13:56', '2025-10-23 10:13:56'),
(1943, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 10:15:29', '2025-10-23 10:15:29'),
(1944, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-23 at 10:15:49', '2025-10-23 10:15:49'),
(1945, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 10:16:12', '2025-10-23 10:16:12'),
(1946, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 10:16:20', '2025-10-23 10:16:20'),
(1947, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 10:23:41', '2025-10-23 10:23:41'),
(1948, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 10:23:53', '2025-10-23 10:23:53'),
(1949, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 10:24:06', '2025-10-23 10:24:06'),
(1950, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 10:27:06', '2025-10-23 10:27:06'),
(1951, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-23 at 10:27:22', '2025-10-23 10:27:22'),
(1952, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 10:27:31', '2025-10-23 10:27:31'),
(1953, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 10:27:37', '2025-10-23 10:27:37'),
(1954, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 11:51:02', '2025-10-23 11:51:02'),
(1955, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 11:52:29', '2025-10-23 11:52:29'),
(1956, 'kindeo', 'Deactivate', 'Manage User', 'Deactivated user Kindei Neikdo neikdo on 2025-10-23 at 11:52:40', '2025-10-23 11:52:40'),
(1957, 'kindeo', 'View', 'Manage User', 'Viewed user Kindei Neikdo neikdo on 2025-10-23 at 11:52:47', '2025-10-23 11:52:47'),
(1958, 'kindeo', 'View', 'Manage User', 'Viewed user kindeo neikdo on 2025-10-23 at 11:52:49', '2025-10-23 11:52:49'),
(1959, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 12:03:30', '2025-10-23 12:03:30'),
(1960, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 12:03:34', '2025-10-23 12:03:34'),
(1961, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 12:05:35', '2025-10-23 12:05:35'),
(1962, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 12:05:37', '2025-10-23 12:05:37'),
(1963, 'kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (10%) on 2025-10-23 at 12:08:31', '2025-10-23 12:08:31'),
(1964, 'kindeo', 'Update', 'Vat/Discount', 'Updated discount \'Promo\' with rate (10%) on 2025-10-23 at 12:08:48', '2025-10-23 12:08:48'),
(1965, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-23 at 12:09:09', '2025-10-23 12:09:09'),
(1966, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 12:09:31', '2025-10-23 12:09:31'),
(1967, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 12:09:41', '2025-10-23 12:09:41'),
(1968, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-23 at 12:09:56', '2025-10-23 12:09:56'),
(1969, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 12:10:04', '2025-10-23 12:10:04'),
(1970, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-23 at 12:10:35', '2025-10-23 12:10:35'),
(1971, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 12:10:36', '2025-10-23 12:10:36'),
(1972, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 13:37:38', '2025-10-23 13:37:38'),
(1973, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 13:37:44', '2025-10-23 13:37:44'),
(1974, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 13:37:53', '2025-10-23 13:37:53'),
(1975, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 13:37:58', '2025-10-23 13:37:58'),
(1976, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 13:38:39', '2025-10-23 13:38:39'),
(1977, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 13:39:07', '2025-10-23 13:39:07'),
(1978, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 14:23:53', '2025-10-23 14:23:53'),
(1979, 'kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-23 at 14:24:06', '2025-10-23 14:24:06'),
(1980, 'kindeo', 'Generate Invoice', 'Appointment', 'Generated Invoice for client \'\' on 2025-10-23 at 14:24:09', '2025-10-23 14:24:09'),
(1981, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 22:37:53', '2025-10-23 22:37:53'),
(1982, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 22:55:48', '2025-10-23 22:55:48'),
(1983, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 22:57:36', '2025-10-23 22:57:36'),
(1984, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:10:33', '2025-10-23 23:10:33'),
(1985, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:12:19', '2025-10-23 23:12:19'),
(1986, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:15:44', '2025-10-23 23:15:44'),
(1987, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:22:29', '2025-10-23 23:22:29'),
(1988, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:23:33', '2025-10-23 23:23:33'),
(1989, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-23 at 23:23:37', '2025-10-23 23:23:37'),
(1990, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:31:25', '2025-10-23 23:31:25'),
(1991, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:34:43', '2025-10-23 23:34:43'),
(1992, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Kindeo  Neikdo\' on 2025-10-23 at 23:35:08', '2025-10-23 23:35:08'),
(1993, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-23 at 23:39:31', '2025-10-23 23:39:31'),
(1994, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-23 at 23:41:10', '2025-10-23 23:41:10'),
(1995, 'kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-23 at 23:41:19', '2025-10-23 23:41:19'),
(1996, 'kindeo', 'Delete', 'Manage Customer', 'Deleted customer \' \' on 2025-10-23 at 23:42:39', '2025-10-23 23:42:39'),
(1997, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 00:13:45', '2025-10-24 00:13:45'),
(1998, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 00:17:41', '2025-10-24 00:17:41'),
(1999, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 00:19:20', '2025-10-24 00:19:20'),
(2000, 'kindeo', 'Update', 'Manage Customer', 'Updated customer \'Kindeo Neikdo\' on 2025-10-24 at 00:19:30', '2025-10-24 00:19:30'),
(2001, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 00:19:54', '2025-10-24 00:19:54'),
(2002, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:10:32', '2025-10-24 01:10:32'),
(2003, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:12:21', '2025-10-24 01:12:21'),
(2004, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:15:13', '2025-10-24 01:15:13'),
(2005, 'kindeo', 'Create', 'Manage User', 'Created new user for dsadas dasd on 2025-10-24 at 01:16:47', '2025-10-24 01:16:47'),
(2006, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:19:04', '2025-10-24 01:19:04'),
(2007, 'kindeo', 'Create', 'Manage User', 'Created new user for test test on 2025-10-24 at 01:20:16', '2025-10-24 01:20:16'),
(2008, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:24:06', '2025-10-24 01:24:06'),
(2009, 'kindeo', 'Create', 'Manage User', 'Created new user for dasdas asdas on 2025-10-24 at 01:24:54', '2025-10-24 01:24:54'),
(2010, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:28:24', '2025-10-24 01:28:24'),
(2011, 'kindeo', 'Create', 'Manage User', 'Created new user for dsadas asdas on 2025-10-24 at 01:29:06', '2025-10-24 01:29:06'),
(2012, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:30:40', '2025-10-24 01:30:40'),
(2013, 'kindeo', 'Update', 'Manage User', 'Updated user nameonly asdas on 2025-10-24 at 01:31:00', '2025-10-24 01:31:00'),
(2014, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:34:06', '2025-10-24 01:34:06'),
(2015, 'kindeo', 'Update', 'Manage User', 'Updated user nameonly asdas on 2025-10-24 at 01:34:15', '2025-10-24 01:34:15'),
(2016, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 01:35:34', '2025-10-24 01:35:34'),
(2017, 'kindeo', 'Update', 'Manage User', 'Updated user nameonly test on 2025-10-24 at 01:35:48', '2025-10-24 01:35:48'),
(2018, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 02:03:33', '2025-10-24 02:03:33'),
(2019, 'kindeo', 'Update', 'Manage Customer', 'Updated customer \'Kindeo Neikdo\' on 2025-10-24 at 02:03:53', '2025-10-24 02:03:53'),
(2020, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 02:16:44', '2025-10-24 02:16:44'),
(2021, 'kindeo', 'Update', 'Manage Supplier', 'Updated supplier \'kindeo\' on 2025-10-24 at 02:17:14', '2025-10-24 02:17:14'),
(2022, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 11:33:21', '2025-10-24 11:33:21'),
(2023, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'15\' on 2025-10-24 at 11:33:34', '2025-10-24 11:33:34'),
(2024, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-24 at 11:33:37', '2025-10-24 11:33:37'),
(2025, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-24 at 11:33:42', '2025-10-24 11:33:42'),
(2026, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 11:53:16', '2025-10-24 11:53:16'),
(2027, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-24 at 11:53:19', '2025-10-24 11:53:19'),
(2028, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 12:05:28', '2025-10-24 12:05:28'),
(2029, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 12:29:45', '2025-10-24 12:29:45'),
(2030, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-24 at 12:29:54', '2025-10-24 12:29:54'),
(2031, 'kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-24 at 12:29:56', '2025-10-24 12:29:56'),
(2032, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 12:36:18', '2025-10-24 12:36:18'),
(2033, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-24 at 12:36:27', '2025-10-24 12:36:27'),
(2034, 'kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-24 at 12:36:37', '2025-10-24 12:36:37'),
(2035, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 12:44:54', '2025-10-24 12:44:54'),
(2036, 'kindeo', 'Create', 'Manage Products', 'Created product \'asd\' on 2025-10-24 at 12:45:11', '2025-10-24 12:45:11'),
(2037, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 12:55:10', '2025-10-24 12:55:10'),
(2038, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 12:55:35', '2025-10-24 12:55:35'),
(2039, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 13:00:23', '2025-10-24 13:00:23'),
(2040, 'kindeo', 'Create', 'Manage Categories', 'Created category \'testtest\' on 2025-10-24 at 13:00:34', '2025-10-24 13:00:34'),
(2041, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 13:01:57', '2025-10-24 13:01:57'),
(2042, 'kindeo', 'Delete', 'Manage Categories', 'Deleted category \'testtest\' on 2025-10-24 at 13:02:03', '2025-10-24 13:02:03'),
(2043, 'kindeo', 'Create', 'Manage Categories', 'Created category \'testest12\' on 2025-10-24 at 13:02:09', '2025-10-24 13:02:09'),
(2044, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 13:05:48', '2025-10-24 13:05:48'),
(2045, 'kindeo', 'Create', 'Manage Categories', 'Created category \'asdasdsa\' on 2025-10-24 at 13:05:55', '2025-10-24 13:05:55'),
(2046, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 13:07:58', '2025-10-24 13:07:58'),
(2047, 'kindeo', 'Create', 'Manage Categories', 'Created category \'adsadsadsad\' on 2025-10-24 at 13:08:06', '2025-10-24 13:08:06'),
(2048, 'kindeo', 'Create', 'Manage Categories', 'Created category \'woozie woozie\' on 2025-10-24 at 13:08:21', '2025-10-24 13:08:21'),
(2049, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 14:03:00', '2025-10-24 14:03:00'),
(2050, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-24 at 14:03:43', '2025-10-24 14:03:43'),
(2051, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 21:31:32', '2025-10-24 21:31:32'),
(2052, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 21:33:01', '2025-10-24 21:33:01'),
(2053, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 21:34:50', '2025-10-24 21:34:50'),
(2054, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 22:02:16', '2025-10-24 22:02:16'),
(2055, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 22:36:46', '2025-10-24 22:36:46'),
(2056, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 22:48:25', '2025-10-24 22:48:25'),
(2057, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 22:57:14', '2025-10-24 22:57:14'),
(2058, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:01:48', '2025-10-24 23:01:48'),
(2059, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:03:56', '2025-10-24 23:03:56'),
(2060, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:05:38', '2025-10-24 23:05:38'),
(2061, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:09:08', '2025-10-24 23:09:08'),
(2062, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:21:25', '2025-10-24 23:21:25'),
(2063, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:24:59', '2025-10-24 23:24:59'),
(2064, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:34:28', '2025-10-24 23:34:28'),
(2065, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:38:56', '2025-10-24 23:38:56'),
(2066, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:40:16', '2025-10-24 23:40:16'),
(2067, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:43:14', '2025-10-24 23:43:14'),
(2068, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-24 at 23:43:40', '2025-10-24 23:43:40'),
(2069, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-24 at 23:44:04', '2025-10-24 23:44:04'),
(2070, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:54:48', '2025-10-24 23:54:48'),
(2071, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:55:53', '2025-10-24 23:55:53'),
(2072, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-24 at 23:58:43', '2025-10-24 23:58:43'),
(2073, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:02:04', '2025-10-25 00:02:04'),
(2074, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:05:03', '2025-10-25 00:05:03'),
(2075, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:06:53', '2025-10-25 00:06:53'),
(2076, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:16:03', '2025-10-25 00:16:03'),
(2077, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:20:28', '2025-10-25 00:20:28'),
(2078, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:22:07', '2025-10-25 00:22:07'),
(2079, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:25:48', '2025-10-25 00:25:48'),
(2080, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:28:11', '2025-10-25 00:28:11'),
(2081, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:30:27', '2025-10-25 00:30:27'),
(2082, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:33:16', '2025-10-25 00:33:16'),
(2083, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:33:52', '2025-10-25 00:33:52'),
(2084, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:35:07', '2025-10-25 00:35:07'),
(2085, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:36:52', '2025-10-25 00:36:52'),
(2086, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:38:03', '2025-10-25 00:38:03'),
(2087, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:38:53', '2025-10-25 00:38:53'),
(2088, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:45:09', '2025-10-25 00:45:09'),
(2089, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:46:26', '2025-10-25 00:46:26'),
(2090, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:47:40', '2025-10-25 00:47:40'),
(2091, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 00:51:48', '2025-10-25 00:51:48'),
(2092, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:14:59', '2025-10-25 01:14:59'),
(2093, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: ) on 2025-10-25 at 01:15:29', '2025-10-25 01:15:29'),
(2094, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: ) on 2025-10-25 at 01:15:30', '2025-10-25 01:15:30'),
(2095, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: ) on 2025-10-25 at 01:15:31', '2025-10-25 01:15:31'),
(2096, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: ) on 2025-10-25 at 01:15:32', '2025-10-25 01:15:32'),
(2097, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'sda\' (Reason: ) on 2025-10-25 at 01:15:32', '2025-10-25 01:15:32'),
(2098, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'we\' (Reason: ) on 2025-10-25 at 01:15:41', '2025-10-25 01:15:41'),
(2099, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:16:41', '2025-10-25 01:16:41'),
(2100, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 01:16:45', '2025-10-25 01:16:45'),
(2101, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:17:14', '2025-10-25 01:17:14'),
(2102, 'kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 01:18:44', '2025-10-25 01:18:44'),
(2103, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:19:31', '2025-10-25 01:19:31'),
(2104, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:26:28', '2025-10-25 01:26:28'),
(2105, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:26:42', '2025-10-25 01:26:42'),
(2106, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:27:10', '2025-10-25 01:27:10'),
(2107, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:27:12', '2025-10-25 01:27:12'),
(2108, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:33:21', '2025-10-25 01:33:21'),
(2109, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:33:43', '2025-10-25 01:33:43'),
(2110, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:34:32', '2025-10-25 01:34:32'),
(2111, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:37:05', '2025-10-25 01:37:05'),
(2112, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:37:17', '2025-10-25 01:37:17'),
(2113, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:37:52', '2025-10-25 01:37:52'),
(2114, 'kindeo', 'Update', 'Manage Stylist, Exception Schedule', 'Updated exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:38:03', '2025-10-25 01:38:03'),
(2115, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: sick leave) on 2025-10-25 at 01:38:12', '2025-10-25 01:38:12'),
(2116, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:38:52', '2025-10-25 01:38:52'),
(2117, 'kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: sick) on 2025-10-25 at 01:39:10', '2025-10-25 01:39:10'),
(2118, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 01:41:40', '2025-10-25 01:41:40'),
(2119, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 02:21:01', '2025-10-25 02:21:01'),
(2120, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 02:21:05', '2025-10-25 02:21:05'),
(2121, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 02:23:55', '2025-10-25 02:23:55'),
(2122, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 02:23:58', '2025-10-25 02:23:58'),
(2123, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 02:25:45', '2025-10-25 02:25:45'),
(2124, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 02:25:50', '2025-10-25 02:25:50'),
(2125, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 02:35:55', '2025-10-25 02:35:55'),
(2126, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 02:35:58', '2025-10-25 02:35:58'),
(2127, 'kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-25 at 02:36:41', '2025-10-25 02:36:41'),
(2128, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 02:37:38', '2025-10-25 02:37:38'),
(2129, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 02:37:42', '2025-10-25 02:37:42'),
(2130, 'kindeo', 'View', 'Inventory Report', 'Viewed Inventory Report on 2025-10-25 at 02:37:53', '2025-10-25 02:37:53'),
(2131, 'kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-25 at 02:37:54', '2025-10-25 02:37:54'),
(2132, 'kindeo', 'View', 'Profit/Lost Report', 'Viewed Proft/Lost Report on 2025-10-25 at 02:38:28', '2025-10-25 02:38:28'),
(2133, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 02:39:25', '2025-10-25 02:39:25'),
(2134, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 02:39:29', '2025-10-25 02:39:29'),
(2135, 'kindeo', 'View', 'AuditReport', 'Viewed Aduit Report on 2025-10-25 at 02:39:31', '2025-10-25 02:39:31'),
(2136, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 03:59:44', '2025-10-25 03:59:44'),
(2137, 'kindeo', 'Delete', 'Manage Categories', 'Deleted category \'woozie woozie\' on 2025-10-25 at 03:59:53', '2025-10-25 03:59:53'),
(2138, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 04:50:51', '2025-10-25 04:50:51'),
(2139, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 04:51:04', '2025-10-25 04:51:04'),
(2140, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 04:51:11', '2025-10-25 04:51:11'),
(2141, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 04:51:12', '2025-10-25 04:51:12'),
(2142, 'kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 04:51:14', '2025-10-25 04:51:14'),
(2143, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 04:51:15', '2025-10-25 04:51:15'),
(2144, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 04:53:53', '2025-10-25 04:53:53'),
(2145, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 05:00:37', '2025-10-25 05:00:37'),
(2146, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 05:01:23', '2025-10-25 05:01:23'),
(2147, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 05:03:02', '2025-10-25 05:03:02'),
(2148, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 06:13:13', '2025-10-25 06:13:13'),
(2149, 'kindeo', 'Create', 'Manage Categories', 'Created category \'test\' on 2025-10-25 at 06:14:27', '2025-10-25 06:14:27'),
(2150, 'kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test\' on 2025-10-25 at 06:14:30', '2025-10-25 06:14:30'),
(2151, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 06:19:29', '2025-10-25 06:19:29'),
(2152, 'kindeo', 'Create', 'Manage Categories', 'Created category \'test1\' on 2025-10-25 at 06:19:38', '2025-10-25 06:19:38'),
(2153, 'kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test1\' on 2025-10-25 at 06:19:55', '2025-10-25 06:19:55'),
(2154, 'kindeo', 'Create', 'Manage Sub-Categories', 'Created sub-category \'sub1\' for (sub1) on 2025-10-25 at 06:42:44', '2025-10-25 06:42:44'),
(2155, 'kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test1\' on 2025-10-25 at 06:42:51', '2025-10-25 06:42:51'),
(2156, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 06:46:15', '2025-10-25 06:46:15'),
(2157, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 06:50:26', '2025-10-25 06:50:26'),
(2158, 'kindeo', 'Deactivate', 'Manage User', 'Deactivated user nameonly test on 2025-10-25 at 06:50:35', '2025-10-25 06:50:35'),
(2159, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 07:04:18', '2025-10-25 07:04:18'),
(2160, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 07:06:55', '2025-10-25 07:06:55'),
(2161, 'kindeo', 'Delete', 'Manage Supplier', 'Deleted supplier \'kindeo\' on 2025-10-25 at 07:07:06', '2025-10-25 07:07:06');
INSERT INTO `tbl_audit_trail` (`id`, `user`, `action`, `module`, `note`, `timestamp`) VALUES
(2162, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 07:50:00', '2025-10-25 07:50:00'),
(2163, 'kindeo', 'Delete', 'Manage Categories', 'Deleted category \'test1\' on 2025-10-25 at 07:50:15', '2025-10-25 07:50:15'),
(2164, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 07:51:35', '2025-10-25 07:51:35'),
(2165, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:03:58', '2025-10-25 08:03:58'),
(2166, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:07:39', '2025-10-25 08:07:39'),
(2167, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:10:26', '2025-10-25 08:10:26'),
(2168, 'kindeo', 'Create', 'Vat/Discount', 'Created discount \'Senior/PWD\' with rate (100%) on 2025-10-25 at 08:10:46', '2025-10-25 08:10:46'),
(2169, 'kindeo', 'Delete', 'Vat/Discount', 'Deleted discount \'Senior/PWD\' with rate (100.00%) on 2025-10-25 at 08:10:56', '2025-10-25 08:10:56'),
(2170, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:13:23', '2025-10-25 08:13:23'),
(2171, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:14:58', '2025-10-25 08:14:58'),
(2172, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:18:45', '2025-10-25 08:18:45'),
(2173, 'kindeo', 'Create', 'Vat/Discount', 'Created discount \'Senior/PWD\' with rate (10%) on 2025-10-25 at 08:19:07', '2025-10-25 08:19:07'),
(2174, 'kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (20%) on 2025-10-25 at 08:19:41', '2025-10-25 08:19:41'),
(2175, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:21:04', '2025-10-25 08:21:04'),
(2176, 'kindeo', 'Create', 'Vat/Discount', 'Created discount \'Promo\' with rate (12%) on 2025-10-25 at 08:21:17', '2025-10-25 08:21:17'),
(2177, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:21:49', '2025-10-25 08:21:49'),
(2178, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'20\' on 2025-10-25 at 08:22:12', '2025-10-25 08:22:12'),
(2179, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:25:27', '2025-10-25 08:25:27'),
(2180, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'15\' on 2025-10-25 at 08:25:40', '2025-10-25 08:25:40'),
(2181, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:27:35', '2025-10-25 08:27:35'),
(2182, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:27:58', '2025-10-25 08:27:58'),
(2183, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:28:13', '2025-10-25 08:28:13'),
(2184, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:31:30', '2025-10-25 08:31:30'),
(2185, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:31:37', '2025-10-25 08:31:37'),
(2186, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'0\' on 2025-10-25 at 08:31:47', '2025-10-25 08:31:47'),
(2187, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'15\' on 2025-10-25 at 08:31:52', '2025-10-25 08:31:52'),
(2188, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'0\' on 2025-10-25 at 08:32:00', '2025-10-25 08:32:00'),
(2189, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:32:06', '2025-10-25 08:32:06'),
(2190, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:32:15', '2025-10-25 08:32:15'),
(2191, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:39:42', '2025-10-25 08:39:42'),
(2192, 'kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 08:39:46', '2025-10-25 08:39:46'),
(2193, 'kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 08:39:48', '2025-10-25 08:39:48'),
(2194, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:41:17', '2025-10-25 08:41:17'),
(2195, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'15\' on 2025-10-25 at 08:41:29', '2025-10-25 08:41:29'),
(2196, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'15\' on 2025-10-25 at 08:41:47', '2025-10-25 08:41:47'),
(2197, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'13\' on 2025-10-25 at 08:41:51', '2025-10-25 08:41:51'),
(2198, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:42:23', '2025-10-25 08:42:23'),
(2199, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'15\' on 2025-10-25 at 08:42:31', '2025-10-25 08:42:31'),
(2200, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'20\' on 2025-10-25 at 08:42:35', '2025-10-25 08:42:35'),
(2201, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:42:41', '2025-10-25 08:42:41'),
(2202, 'kindeo', 'Update', 'Vat/Discount', 'Updated Vat with rate \'12\' on 2025-10-25 at 08:42:53', '2025-10-25 08:42:53'),
(2203, 'kindeo', 'Log In', 'User', 'Log In \'kindeo\'on 2025-10-25 at 08:44:19', '2025-10-25 08:44:19'),
(2204, 'Kindeo', 'Create', 'Vat/Discount', 'Created Vat with rate \'12\' on 2025-10-25 at 08:49:46', '2025-10-25 08:49:46'),
(2205, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 08:49:52', '2025-10-25 08:49:52'),
(2206, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 08:50:52', '2025-10-25 08:50:52'),
(2207, 'Kindeo', 'View', 'Expense Report', 'Viewed Expense Report on 2025-10-25 at 08:50:54', '2025-10-25 08:50:54'),
(2208, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 08:52:18', '2025-10-25 08:52:18'),
(2209, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 08:52:21', '2025-10-25 08:52:21'),
(2210, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:10:54', '2025-10-25 09:10:54'),
(2211, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:10:56', '2025-10-25 09:10:56'),
(2212, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:10:58', '2025-10-25 09:10:58'),
(2213, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:11:09', '2025-10-25 09:11:09'),
(2214, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:11:41', '2025-10-25 09:11:41'),
(2215, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:11:45', '2025-10-25 09:11:45'),
(2216, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:11:48', '2025-10-25 09:11:48'),
(2217, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:12:02', '2025-10-25 09:12:02'),
(2218, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:12:06', '2025-10-25 09:12:06'),
(2219, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:12:12', '2025-10-25 09:12:12'),
(2220, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:12:20', '2025-10-25 09:12:20'),
(2221, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:12:24', '2025-10-25 09:12:24'),
(2222, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:12:32', '2025-10-25 09:12:32'),
(2223, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:12:35', '2025-10-25 09:12:35'),
(2224, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:12:49', '2025-10-25 09:12:49'),
(2225, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:13:24', '2025-10-25 09:13:24'),
(2226, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:13:38', '2025-10-25 09:13:38'),
(2227, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:13:41', '2025-10-25 09:13:41'),
(2228, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:13:43', '2025-10-25 09:13:43'),
(2229, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:13:50', '2025-10-25 09:13:50'),
(2230, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:13:51', '2025-10-25 09:13:51'),
(2231, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:13:54', '2025-10-25 09:13:54'),
(2232, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:14:08', '2025-10-25 09:14:08'),
(2233, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:14:11', '2025-10-25 09:14:11'),
(2234, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:14:24', '2025-10-25 09:14:24'),
(2235, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:14:58', '2025-10-25 09:14:58'),
(2236, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:15:12', '2025-10-25 09:15:12'),
(2237, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:15:14', '2025-10-25 09:15:14'),
(2238, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:15:33', '2025-10-25 09:15:33'),
(2239, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:15:43', '2025-10-25 09:15:43'),
(2240, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:15:50', '2025-10-25 09:15:50'),
(2241, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 09:15:55', '2025-10-25 09:15:55'),
(2242, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:15:59', '2025-10-25 09:15:59'),
(2243, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:16:22', '2025-10-25 09:16:22'),
(2244, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:17:10', '2025-10-25 09:17:10'),
(2245, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:17:30', '2025-10-25 09:17:30'),
(2246, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:18:06', '2025-10-25 09:18:06'),
(2247, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:18:09', '2025-10-25 09:18:09'),
(2248, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:18:27', '2025-10-25 09:18:27'),
(2249, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:18:30', '2025-10-25 09:18:30'),
(2250, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:18:43', '2025-10-25 09:18:43'),
(2251, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:18:50', '2025-10-25 09:18:50'),
(2252, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:18:53', '2025-10-25 09:18:53'),
(2253, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:20:41', '2025-10-25 09:20:41'),
(2254, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:20:44', '2025-10-25 09:20:44'),
(2255, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:20:46', '2025-10-25 09:20:46'),
(2256, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:20:58', '2025-10-25 09:20:58'),
(2257, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:21:01', '2025-10-25 09:21:01'),
(2258, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:21:06', '2025-10-25 09:21:06'),
(2259, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:21:14', '2025-10-25 09:21:14'),
(2260, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:21:16', '2025-10-25 09:21:16'),
(2261, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:21:22', '2025-10-25 09:21:22'),
(2262, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:23:24', '2025-10-25 09:23:24'),
(2263, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:23:28', '2025-10-25 09:23:28'),
(2264, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 09:23:29', '2025-10-25 09:23:29'),
(2265, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 09:23:31', '2025-10-25 09:23:31'),
(2266, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:23:32', '2025-10-25 09:23:32'),
(2267, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:23:33', '2025-10-25 09:23:33'),
(2268, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:23:48', '2025-10-25 09:23:48'),
(2269, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:23:50', '2025-10-25 09:23:50'),
(2270, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:23:59', '2025-10-25 09:23:59'),
(2271, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:24:06', '2025-10-25 09:24:06'),
(2272, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:24:11', '2025-10-25 09:24:11'),
(2273, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:24:15', '2025-10-25 09:24:15'),
(2274, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:25:41', '2025-10-25 09:25:41'),
(2275, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:25:49', '2025-10-25 09:25:49'),
(2276, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:25:58', '2025-10-25 09:25:58'),
(2277, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:26:03', '2025-10-25 09:26:03'),
(2278, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:26:05', '2025-10-25 09:26:05'),
(2279, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:26:11', '2025-10-25 09:26:11'),
(2280, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:26:13', '2025-10-25 09:26:13'),
(2281, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:32:21', '2025-10-25 09:32:21'),
(2282, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:34:17', '2025-10-25 09:34:17'),
(2283, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:34:19', '2025-10-25 09:34:19'),
(2284, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:35:20', '2025-10-25 09:35:20'),
(2285, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:35:37', '2025-10-25 09:35:37'),
(2286, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:35:41', '2025-10-25 09:35:41'),
(2287, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:36:11', '2025-10-25 09:36:11'),
(2288, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:36:13', '2025-10-25 09:36:13'),
(2289, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 09:36:19', '2025-10-25 09:36:19'),
(2290, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:36:21', '2025-10-25 09:36:21'),
(2291, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:36:28', '2025-10-25 09:36:28'),
(2292, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:36:30', '2025-10-25 09:36:30'),
(2293, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:36:34', '2025-10-25 09:36:34'),
(2294, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 09:37:29', '2025-10-25 09:37:29'),
(2295, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:37:32', '2025-10-25 09:37:32'),
(2296, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:37:35', '2025-10-25 09:37:35'),
(2297, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:37:38', '2025-10-25 09:37:38'),
(2298, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 09:37:50', '2025-10-25 09:37:50'),
(2299, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:37:52', '2025-10-25 09:37:52'),
(2300, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 09:37:59', '2025-10-25 09:37:59'),
(2301, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 09:38:06', '2025-10-25 09:38:06'),
(2302, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 09:38:08', '2025-10-25 09:38:08'),
(2303, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 09:38:16', '2025-10-25 09:38:16'),
(2304, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 10:47:20', '2025-10-25 10:47:20'),
(2305, 'Kindeo', 'View', 'Manage User', 'Viewed user Kindeo Neikdo on 2025-10-25 at 10:47:28', '2025-10-25 10:47:28'),
(2306, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user dasdas asdas on 2025-10-25 at 10:47:38', '2025-10-25 10:47:38'),
(2307, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user dasdas asdas on 2025-10-25 at 10:47:38', '2025-10-25 10:47:38'),
(2308, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 10:49:55', '2025-10-25 10:49:55'),
(2309, 'Kindeo', 'Deactivate', 'Manage User', 'Deactivated user test test on 2025-10-25 at 10:50:01', '2025-10-25 10:50:01'),
(2310, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 10:50:09', '2025-10-25 10:50:09'),
(2311, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 10:50:48', '2025-10-25 10:50:48'),
(2312, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 10:51:08', '2025-10-25 10:51:08'),
(2313, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 10:51:12', '2025-10-25 10:51:12'),
(2314, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 10:51:15', '2025-10-25 10:51:15'),
(2315, 'Kindeo', 'Create', 'Manage Stylist, Exception Schedule', 'Created exception schedule for Stylist: \'Mohaifa \' (Reason: ) on 2025-10-25 at 10:51:41', '2025-10-25 10:51:41'),
(2316, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 10:54:50', '2025-10-25 10:54:50'),
(2317, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-25 at 10:55:00', '2025-10-25 10:55:00'),
(2318, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 10:55:49', '2025-10-25 10:55:49'),
(2319, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 10:56:12', '2025-10-25 10:56:12'),
(2320, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 10:56:48', '2025-10-25 10:56:48'),
(2321, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 10:56:52', '2025-10-25 10:56:52'),
(2322, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 10:57:15', '2025-10-25 10:57:15'),
(2323, 'Kindeo', 'View', 'Transaction History', 'Viewed Transaction History on 2025-10-25 at 10:57:45', '2025-10-25 10:57:45'),
(2324, 'Kindeo', 'Refund', 'Transaction History', 'Refunded services on 2025-10-25 at 10:58:04', '2025-10-25 10:58:04'),
(2325, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 10:58:06', '2025-10-25 10:58:06'),
(2326, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 10:58:15', '2025-10-25 10:58:15'),
(2327, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 10:58:21', '2025-10-25 10:58:21'),
(2328, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 10:59:03', '2025-10-25 10:59:03'),
(2329, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 10:59:46', '2025-10-25 10:59:46'),
(2330, 'Kindeo', 'Assign', 'Appointment', 'Assigned stylist \'Stylist not assigned yet\' to client \'\' on 2025-10-25 at 10:59:56', '2025-10-25 10:59:56'),
(2331, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 11:41:51', '2025-10-25 11:41:51'),
(2332, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 11:41:54', '2025-10-25 11:41:54'),
(2333, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 11:44:02', '2025-10-25 11:44:02'),
(2334, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 11:45:40', '2025-10-25 11:45:40'),
(2335, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 11:46:25', '2025-10-25 11:46:25'),
(2336, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 11:50:26', '2025-10-25 11:50:26'),
(2337, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 11:56:28', '2025-10-25 11:56:28'),
(2338, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 11:56:58', '2025-10-25 11:56:58'),
(2339, 'Kindeo', 'Process Payment', 'Appointment', 'Processed payment for client \'\' on 2025-10-25 at 11:57:28', '2025-10-25 11:57:28'),
(2340, 'Kindeo', 'View', 'Sales Report', 'Sales Report on 2025-10-25 at 11:57:45', '2025-10-25 11:57:45'),
(2341, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 11:57:46', '2025-10-25 11:57:46'),
(2342, 'Kindeo', 'View', 'Batch Inventory', 'Viewed batch inventory on 2025-10-25 at 11:57:48', '2025-10-25 11:57:48'),
(2343, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:06:17', '2025-10-25 14:06:17'),
(2344, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 14:10:24', '2025-10-25 14:10:24'),
(2345, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 14:11:03', '2025-10-25 14:11:03'),
(2346, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-25 at 14:11:32', '2025-10-25 14:11:32'),
(2347, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:23:14', '2025-10-25 14:23:14'),
(2348, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:25:43', '2025-10-25 14:25:43'),
(2349, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:27:03', '2025-10-25 14:27:03'),
(2350, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:35:41', '2025-10-25 14:35:41'),
(2351, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:38:06', '2025-10-25 14:38:06'),
(2352, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:40:58', '2025-10-25 14:40:58'),
(2353, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:46:39', '2025-10-25 14:46:39'),
(2354, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:47:42', '2025-10-25 14:47:42'),
(2355, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:51:30', '2025-10-25 14:51:30'),
(2356, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:52:20', '2025-10-25 14:52:20'),
(2357, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:53:24', '2025-10-25 14:53:24'),
(2358, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:55:25', '2025-10-25 14:55:25'),
(2359, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 14:56:38', '2025-10-25 14:56:38'),
(2360, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:01:38', '2025-10-25 15:01:38'),
(2361, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:03:47', '2025-10-25 15:03:47'),
(2362, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:10:30', '2025-10-25 15:10:30'),
(2363, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:11:56', '2025-10-25 15:11:56'),
(2364, 'Kindeo', 'Update', 'Appointment', 'Updated appointment for \'Mariano B Vincent\' on 2025-10-25 at 15:12:56', '2025-10-25 15:12:56'),
(2365, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:17:46', '2025-10-25 15:17:46'),
(2366, 'Kindeo', 'Create', 'Manage User', 'Created new user for Shara Sumadia on 2025-10-25 at 15:23:23', '2025-10-25 15:23:23'),
(2367, 'Kindeo', 'View', 'Manage User', 'Viewed user Shara Sumadia on 2025-10-25 at 15:23:37', '2025-10-25 15:23:37'),
(2368, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:33:04', '2025-10-25 15:33:04'),
(2369, 'Kindeo', 'Create', 'Manage Customer', 'Created customer \'kindeo neikdo\' on 2025-10-25 at 15:33:39', '2025-10-25 15:33:39'),
(2370, 'Kindeo', 'Create', 'Manage Customer', 'Created customer \'Shara Sumadia\' on 2025-10-25 at 15:36:19', '2025-10-25 15:36:19'),
(2371, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'Nail Service\' on 2025-10-25 at 15:38:22', '2025-10-25 15:38:22'),
(2372, 'Kindeo', 'Create', 'Manage Sub-Categories', 'Created sub-category \'Gel Polish\' for (Gel Polish) on 2025-10-25 at 15:39:41', '2025-10-25 15:39:41'),
(2373, 'Kindeo', 'Create', 'Manage Supplier', 'Created supplier \'Najiah\' on 2025-10-25 at 15:40:36', '2025-10-25 15:40:36'),
(2374, 'Kindeo', 'Update', 'Manage Supplier', 'Updated supplier \'Najiah\' on 2025-10-25 at 15:40:44', '2025-10-25 15:40:44'),
(2375, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:43:56', '2025-10-25 15:43:56'),
(2376, 'Kindeo', 'Delete', 'Manage Products', 'Deleted product \'Hair Color\' on 2025-10-25 at 15:44:46', '2025-10-25 15:44:46'),
(2377, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:48:50', '2025-10-25 15:48:50'),
(2378, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:48:51', '2025-10-25 15:48:51'),
(2379, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:48:52', '2025-10-25 15:48:52'),
(2380, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:48:52', '2025-10-25 15:48:52'),
(2381, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:48:53', '2025-10-25 15:48:53'),
(2382, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:19', '2025-10-25 15:51:19'),
(2383, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2384, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2385, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2386, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2387, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2388, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2389, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2390, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:51:32', '2025-10-25 15:51:32'),
(2391, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:53:30', '2025-10-25 15:53:30'),
(2392, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 15:54:01', '2025-10-25 15:54:01'),
(2393, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 15:54:24', '2025-10-25 15:54:24'),
(2394, 'Kindeo', 'View', 'Inventory', 'Viewed inventory on 2025-10-25 at 15:54:29', '2025-10-25 15:54:29'),
(2395, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'kindeo  neikdo\' on 2025-10-25 at 15:55:02', '2025-10-25 15:55:02'),
(2396, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:56:32', '2025-10-25 15:56:32'),
(2397, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 15:57:03', '2025-10-25 15:57:03'),
(2398, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 15:58:24', '2025-10-25 15:58:24'),
(2399, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 15:59:28', '2025-10-25 15:59:28'),
(2400, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 15:59:55', '2025-10-25 15:59:55'),
(2401, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:01:53', '2025-10-25 16:01:53'),
(2402, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:04:48', '2025-10-25 16:04:48'),
(2403, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'kindeo  neikdo\' on 2025-10-25 at 16:05:21', '2025-10-25 16:05:21'),
(2404, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:07:38', '2025-10-25 16:07:38'),
(2405, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Shara Calinog Sumadia\' on 2025-10-25 at 16:08:03', '2025-10-25 16:08:03'),
(2406, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 16:09:02', '2025-10-25 16:09:02'),
(2407, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano B Vincent\' on 2025-10-25 at 16:09:35', '2025-10-25 16:09:35'),
(2408, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:10:18', '2025-10-25 16:10:18'),
(2409, 'Kindeo', 'Update', 'Manage Customer', 'Updated customer \'Mariano Vincent\' on 2025-10-25 at 16:10:37', '2025-10-25 16:10:37'),
(2410, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:11:03', '2025-10-25 16:11:03'),
(2411, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:12:12', '2025-10-25 16:12:12'),
(2412, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:14:05', '2025-10-25 16:14:05'),
(2413, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:14:32', '2025-10-25 16:14:32'),
(2414, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:19:11', '2025-10-25 16:19:11'),
(2415, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'kindeo  neikdo\' on 2025-10-25 at 16:19:38', '2025-10-25 16:19:38'),
(2416, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:20:51', '2025-10-25 16:20:51'),
(2417, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:21:13', '2025-10-25 16:21:13'),
(2418, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:23:22', '2025-10-25 16:23:22'),
(2419, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:23:51', '2025-10-25 16:23:51'),
(2420, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:25:54', '2025-10-25 16:25:54'),
(2421, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:28:13', '2025-10-25 16:28:13'),
(2422, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:31:22', '2025-10-25 16:31:22'),
(2423, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:35:06', '2025-10-25 16:35:06'),
(2424, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:35:31', '2025-10-25 16:35:31'),
(2425, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:37:31', '2025-10-25 16:37:31'),
(2426, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:38:00', '2025-10-25 16:38:00'),
(2427, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 16:57:03', '2025-10-25 16:57:03'),
(2428, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:57:48', '2025-10-25 16:57:48'),
(2429, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 16:59:03', '2025-10-25 16:59:03'),
(2430, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 17:00:14', '2025-10-25 17:00:14'),
(2431, 'Kindeo', 'Create', 'Appointment', 'Created appointment for \'Mariano Beee Vincent\' on 2025-10-25 at 17:00:39', '2025-10-25 17:00:39'),
(2432, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 17:08:28', '2025-10-25 17:08:28'),
(2433, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'sdadasd\' on 2025-10-25 at 17:08:39', '2025-10-25 17:08:39'),
(2434, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 17:10:05', '2025-10-25 17:10:05'),
(2435, 'Kindeo', 'Update', 'Manage Categories', 'Updated category \'sdadas123\' on 2025-10-25 at 17:10:25', '2025-10-25 17:10:25'),
(2436, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'asda\' on 2025-10-25 at 17:10:34', '2025-10-25 17:10:34'),
(2437, 'Kindeo', 'Log In', 'User', 'Log In \'Kindeo\'on 2025-10-25 at 17:19:44', '2025-10-25 17:19:44'),
(2438, 'Kindeo', 'Create', 'Manage Categories', 'Created category \'asdsdasd\' on 2025-10-25 at 17:19:57', '2025-10-25 17:19:57');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_business_hours`
--

CREATE TABLE `tbl_business_hours` (
  `business_hours_id` int(11) NOT NULL,
  `day_of_week` varchar(45) NOT NULL,
  `open_time` time NOT NULL,
  `close_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_business_hours`
--

INSERT INTO `tbl_business_hours` (`business_hours_id`, `day_of_week`, `open_time`, `close_time`) VALUES
(1, 'Monday', '09:00:00', '21:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `category_id` int(11) NOT NULL,
  `categoryName` varchar(255) NOT NULL,
  `type` enum('Service','Product') NOT NULL,
  `status` enum('Active','Inactive') NOT NULL,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`category_id`, `categoryName`, `type`, `status`, `is_deleted`) VALUES
(92, 'Hair Service', 'Service', 'Active', 0),
(93, 'Hair Treatment', 'Product', 'Active', 0),
(94, 'testtest', 'Service', 'Active', 1),
(95, 'testest12', 'Service', 'Active', 0),
(96, 'asdasdsa', 'Product', 'Active', 0),
(97, 'adsadsadsad', 'Service', 'Active', 0),
(99, 'test', 'Service', 'Active', 0),
(100, 'test1', 'Service', 'Active', 0),
(101, 'Nail Service', 'Service', 'Active', 0),
(102, 'sdadas123', 'Service', 'Active', 0),
(103, 'asda', 'Service', 'Active', 0),
(104, 'asdsdasd', 'Service', 'Active', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_account`
--

CREATE TABLE `tbl_customer_account` (
  `customer_id` int(11) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `middleName` varchar(45) NOT NULL,
  `lastName` varchar(45) NOT NULL,
  `phoneNumber` varchar(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `gender` enum('Male','Female','Other') NOT NULL,
  `streetAddress` varchar(255) NOT NULL,
  `cityAddress` varchar(255) NOT NULL,
  `userName` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `status` varchar(45) DEFAULT NULL,
  `customer_type` varchar(45) NOT NULL,
  `reset_token` varchar(255) DEFAULT NULL,
  `token_expiry` datetime DEFAULT NULL,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_customer_account`
--

INSERT INTO `tbl_customer_account` (`customer_id`, `firstName`, `middleName`, `lastName`, `phoneNumber`, `email`, `gender`, `streetAddress`, `cityAddress`, `userName`, `password`, `status`, `customer_type`, `reset_token`, `token_expiry`, `is_deleted`) VALUES
(48, 'Mariano', 'Beee', 'Vincent', '09494475270', 'alexprada782@gmail.com', 'Male', '', '', '', '', NULL, 'Registered', NULL, NULL, 0),
(53, 'Kindeo', 'tesst', 'Neikdo', '1232131', '3213213', 'Male', '', '', '', '', NULL, 'Walk-In', NULL, NULL, 0),
(54, '', '', '', '', '', 'Male', '', '', '', '', 'Inactive', '', NULL, NULL, 1),
(55, 'kindeo', '', 'neikdo', '09494475271', 'alexprada72@gmail.com', 'Male', '', '', '', '', NULL, 'Registered', NULL, NULL, 0),
(56, 'Shara', 'Calinog', 'Sumadia', '09480859676', 'sharajanesumadia08212002@gmail.com', 'Male', '', '', '', '', NULL, 'Registered', NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_violations`
--

CREATE TABLE `tbl_customer_violations` (
  `customer_violations_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `violation_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_customer_violations`
--

INSERT INTO `tbl_customer_violations` (`customer_violations_id`, `customer_id`, `violation_id`) VALUES
(14, NULL, 17),
(15, NULL, 18),
(16, NULL, 19),
(17, NULL, 20),
(18, NULL, 21),
(19, NULL, 22),
(20, NULL, 23),
(21, NULL, 24),
(22, NULL, 25),
(23, NULL, 26),
(24, NULL, 27),
(25, NULL, 28),
(26, NULL, 29),
(27, NULL, 30),
(28, NULL, 31),
(29, NULL, 32),
(30, NULL, 33);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_deleted_records`
--

CREATE TABLE `tbl_deleted_records` (
  `deleted_id` int(11) NOT NULL,
  `record_id` int(11) NOT NULL,
  `module` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `deleted_by` varchar(255) NOT NULL,
  `deleted_on` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_deleted_records`
--

INSERT INTO `tbl_deleted_records` (`deleted_id`, `record_id`, `module`, `name`, `deleted_by`, `deleted_on`) VALUES
(39, 262, 'Manage User', 'Nissan ', 'kindeo', '2025-10-22 00:00:00'),
(43, 25, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(44, 27, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(45, 29, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(46, 28, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(47, 30, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(48, 32, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(49, 31, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(50, 36, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(51, 35, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(52, 34, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(53, 37, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(54, 40, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(55, 39, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(56, 38, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(57, 41, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(58, 42, 'Manage Services, Product Usage', 'Hair Color', 'kindeo', '2025-10-31 00:00:00'),
(59, 23, 'Manage Stylist, Schedule', 'Tuesday', 'kindeo', '2025-10-23 00:00:00'),
(60, 8, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(61, 39, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(62, 40, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(63, 41, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(64, 42, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(65, 43, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(66, 44, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(67, 45, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(68, 46, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(69, 47, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(70, 48, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-23 00:00:00'),
(71, 278, 'Manage User', 'Kindei Neikdo', 'kindeo', '2025-10-23 00:00:00'),
(72, 54, 'Manage Customer', ' ', 'kindeo', '2025-10-23 00:00:00'),
(73, 94, 'Category', 'testtest', 'kindeo', '2025-10-24 00:00:00'),
(74, 60, 'Manage Stylist, Exception Schedule', 'sda(10/24/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(75, 59, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(76, 58, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(77, 57, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(78, 56, 'Manage Stylist, Exception Schedule', 'sda(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(79, 38, 'Manage Stylist, Exception Schedule', 'we(10/23/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(80, 61, 'Manage Stylist, Exception Schedule', 'Mohaifa (10/25/2025 12:00:00 AM)', 'kindeo', '2025-10-25 00:00:00'),
(82, 99, 'Category', 'test', 'kindeo', '2025-10-25 00:00:00'),
(85, 282, 'Manage User', 'nameonly', 'kindeo', '2025-10-25 00:00:00'),
(86, 6, 'Manage Supplier', 'kindeo', 'kindeo', '2025-10-25 00:00:00'),
(88, 33, 'Vat/Discount', 'Senior/PWD ', 'kindeo', '2025-10-25 00:00:00'),
(89, 281, 'Manage User', 'dasdas', 'Kindeo', '2025-10-25 00:00:00'),
(90, 281, 'Manage User', 'dasdas', 'Kindeo', '2025-10-25 00:00:00'),
(91, 280, 'Manage User', 'test', 'Kindeo', '2025-10-25 00:00:00'),
(92, 65, 'Manage Stylist, Exception Schedule', 'Mohaifa (10/25/2025 12:00:00 AM)', 'Kindeo', '2025-10-25 00:00:00'),
(93, 21, 'Manage Products', 'Hair Color', 'Kindeo', '2025-10-25 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery`
--

CREATE TABLE `tbl_delivery` (
  `delivery_id` int(11) NOT NULL,
  `supplier_id` int(11) DEFAULT NULL,
  `date` date NOT NULL,
  `invoice` varchar(255) NOT NULL,
  `received_by` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_delivery`
--

INSERT INTO `tbl_delivery` (`delivery_id`, `supplier_id`, `date`, `invoice`, `received_by`) VALUES
(48, 6, '2025-10-19', '123', 'Kindeo'),
(50, 6, '2025-10-21', '123', 'Kindeo'),
(51, 6, '2025-10-21', '123', 'Kindeo'),
(52, 6, '2025-10-31', '567', 'kindeo');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery_items`
--

CREATE TABLE `tbl_delivery_items` (
  `delivery_item_id` int(11) NOT NULL,
  `delivery_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `qty` int(11) NOT NULL,
  `unit_price` decimal(10,2) NOT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `expiry_date` datetime NOT NULL,
  `notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_delivery_items`
--

INSERT INTO `tbl_delivery_items` (`delivery_item_id`, `delivery_id`, `product_id`, `qty`, `unit_price`, `total_price`, `expiry_date`, `notes`) VALUES
(40, 48, 21, 10, 200.00, 2000.00, '2025-10-25 00:00:00', ''),
(41, 52, 22, 20, 200.00, 4000.00, '2026-10-31 00:00:00', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_discount`
--

CREATE TABLE `tbl_discount` (
  `discount_id` int(11) NOT NULL,
  `discount_type` varchar(50) NOT NULL,
  `promo_code` varchar(50) DEFAULT NULL,
  `discount_rate` decimal(5,2) NOT NULL,
  `expiry_date` date DEFAULT NULL,
  `status` enum('Active','Expiring Soon','Expired') NOT NULL DEFAULT 'Active',
  `vat_exempt` tinyint(1) NOT NULL DEFAULT 0,
  `max_usage` int(2) NOT NULL DEFAULT 0,
  `per_customer_limit` int(11) NOT NULL DEFAULT 0,
  `notif_on_create` tinyint(1) NOT NULL DEFAULT 0,
  `notif_on_expired` tinyint(1) NOT NULL DEFAULT 0,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_discount`
--

INSERT INTO `tbl_discount` (`discount_id`, `discount_type`, `promo_code`, `discount_rate`, `expiry_date`, `status`, `vat_exempt`, `max_usage`, `per_customer_limit`, `notif_on_create`, `notif_on_expired`, `is_deleted`) VALUES
(28, 'Senior/PWD', '', 20.00, NULL, 'Active', 1, 0, 0, 1, 0, 0),
(29, 'Promo', 'summer10', 10.00, '2025-10-31', 'Active', 0, 0, 0, 0, 0, 0),
(30, 'Promo', 'summer15', 15.00, '2025-10-22', 'Expiring Soon', 0, 0, 1, 0, 0, 0),
(31, 'Promo', 'sum10', 10.00, '2025-10-30', 'Expiring Soon', 0, 0, 1, 0, 0, 0),
(32, 'Promo', 'promo20', 20.00, '2025-10-31', '', 0, 0, 1, 1, 0, 0),
(33, 'Senior/PWD', '', 100.00, NULL, 'Active', 0, 0, 0, 0, 0, 1),
(34, 'Senior/PWD', '', 10.00, NULL, 'Active', 0, 0, 0, 0, 0, 0),
(35, 'Promo', 'sum20', 20.00, '2025-10-25', 'Expiring Soon', 0, 0, 0, 0, 0, 0),
(36, 'Promo', 'sum12', 12.00, '2025-10-25', 'Expiring Soon', 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_discount_notification`
--

CREATE TABLE `tbl_discount_notification` (
  `notif_id` int(11) NOT NULL,
  `discount_id` int(11) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `channel` enum('SMS','Email') DEFAULT NULL,
  `status` enum('Pending','Sent','Failed') DEFAULT NULL,
  `scheduled_on` datetime DEFAULT NULL,
  `sent_on` datetime DEFAULT NULL,
  `error_message` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_discount_notification`
--

INSERT INTO `tbl_discount_notification` (`notif_id`, `discount_id`, `customer_id`, `channel`, `status`, `scheduled_on`, `sent_on`, `error_message`) VALUES
(55, 32, 48, NULL, 'Sent', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_discount_usage`
--

CREATE TABLE `tbl_discount_usage` (
  `usage_id` int(11) NOT NULL,
  `discount_id` int(11) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `appointment_id` int(11) DEFAULT NULL,
  `used_on` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_discount_usage`
--

INSERT INTO `tbl_discount_usage` (`usage_id`, `discount_id`, `customer_id`, `appointment_id`, `used_on`) VALUES
(18, 28, 48, NULL, '2025-10-21 00:00:00'),
(19, 31, 48, NULL, '2025-10-21 00:00:00'),
(20, 32, 48, NULL, '2025-10-22 00:00:00'),
(21, 28, 48, NULL, '2025-10-23 00:00:00'),
(22, 28, 48, NULL, '2025-10-23 00:00:00'),
(23, 28, 48, NULL, '2025-10-23 00:00:00'),
(24, 29, 48, NULL, '2025-10-23 00:00:00'),
(25, 29, 48, NULL, '2025-10-23 00:00:00'),
(26, 28, 48, NULL, '2025-10-23 00:00:00'),
(27, 28, 48, NULL, '2025-10-25 00:00:00'),
(28, 28, 48, NULL, '2025-10-25 00:00:00'),
(29, 28, 48, NULL, '2025-10-25 00:00:00'),
(30, 28, 48, NULL, '2025-10-25 00:00:00'),
(31, 28, 48, NULL, '2025-10-25 00:00:00'),
(32, 28, 48, NULL, '2025-10-25 00:00:00'),
(33, 28, 48, NULL, '2025-10-25 00:00:00'),
(34, 28, 48, NULL, '2025-10-25 00:00:00'),
(35, 28, 48, NULL, '2025-10-25 00:00:00'),
(36, 28, 48, NULL, '2025-10-25 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_exception_schedules`
--

CREATE TABLE `tbl_exception_schedules` (
  `id` int(11) NOT NULL,
  `stylist_id` int(11) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `start_time` time DEFAULT NULL,
  `end_time` time DEFAULT NULL,
  `is_available` tinyint(1) NOT NULL,
  `reason` varchar(255) NOT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_exception_schedules`
--

INSERT INTO `tbl_exception_schedules` (`id`, `stylist_id`, `date`, `start_time`, `end_time`, `is_available`, `reason`, `is_deleted`) VALUES
(65, 20, '2025-10-25 00:00:00', NULL, NULL, 1, 'sick', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_expenses`
--

CREATE TABLE `tbl_expenses` (
  `id` int(11) NOT NULL,
  `category` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `paid_by` varchar(255) NOT NULL,
  `notes` text NOT NULL,
  `timestamp` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_expenses`
--

INSERT INTO `tbl_expenses` (`id`, `category`, `description`, `amount`, `paid_by`, `notes`, `timestamp`) VALUES
(1, 'Inventory Purchase', ' restock (25 units)', 2500, 'staff', '', '2025-10-03 07:56:54'),
(2, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(3, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(4, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(5, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(6, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(7, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(8, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(9, 'Inventory Purchase', '', 2000, 'Kindeo', '', '2025-10-10 04:30:25'),
(10, 'Inventory Purchase', '', 4000, 'Kindeo', '', '2025-10-10 19:44:36'),
(11, 'Inventory Purchase', ' restock (12 units)', 144, 'Kindeo', '', '2025-10-13 03:05:44'),
(12, 'Inventory Purchase', '', 4000, 'Kindeo', '', '2025-10-13 10:23:01'),
(13, 'Inventory Purchase', '', 3000, 'Kindeo', '', '2025-10-13 10:23:01'),
(14, 'Inventory Purchase', '', 2000, 'Kindeo', '', '2025-10-19 23:51:51'),
(15, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(16, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(17, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(18, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(19, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(20, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(21, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(22, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02'),
(23, 'Inventory Purchase', '', 4000, 'kindeo', '', '2025-10-31 04:57:15'),
(24, 'Utilities', 'Updated Monthly Rent & Bills', 10199, 'Kindeo', '', '2025-10-25 08:52:02');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory`
--

CREATE TABLE `tbl_inventory` (
  `inventory_id` int(11) NOT NULL,
  `product_id` int(11) DEFAULT NULL,
  `unit` float NOT NULL DEFAULT 0,
  `volume_per_unit` double DEFAULT 0,
  `volume` int(11) NOT NULL DEFAULT 0,
  `critical_level` int(11) NOT NULL DEFAULT 5000,
  `status` enum('In Stock','Low Stock','Out of Stock') DEFAULT NULL,
  `expiry_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_inventory`
--

INSERT INTO `tbl_inventory` (`inventory_id`, `product_id`, `unit`, `volume_per_unit`, `volume`, `critical_level`, `status`, `expiry_date`) VALUES
(22, 21, 0, 1000, 820, 20000, 'Low Stock', '0001-01-01 00:00:00'),
(23, 22, 0, 1000, 925, 5000, 'Low Stock', '0001-01-01 00:00:00');

--
-- Triggers `tbl_inventory`
--
DELIMITER $$
CREATE TRIGGER `before_inventory_insert` BEFORE INSERT ON `tbl_inventory` FOR EACH ROW IF NEW.volume = 0 THEN
    SET NEW.status = 'Out of Stock';
ELSEIF NEW.volume <= NEW.critical_level THEN
    SET NEW.status = 'Low Stock';
ELSE
    SET NEW.status = 'In Stock';
END IF
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `before_inventory_update` BEFORE UPDATE ON `tbl_inventory` FOR EACH ROW BEGIN
    IF NEW.volume = 0 THEN
        SET NEW.status = 'Out of Stock';
    ELSEIF NEW.volume <= NEW.critical_level THEN
        SET NEW.status = 'Low Stock';
    ELSE
        SET NEW.status = 'In Stock';
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_insert_unit` BEFORE INSERT ON `tbl_inventory` FOR EACH ROW BEGIN
  SET NEW.unit = FLOOR(NEW.volume / NEW.volume_per_unit);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_update_unit` BEFORE UPDATE ON `tbl_inventory` FOR EACH ROW BEGIN
  SET NEW.unit = FLOOR(NEW.volume / NEW.volume_per_unit);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory_batch`
--

CREATE TABLE `tbl_inventory_batch` (
  `batch_id` int(11) NOT NULL,
  `delivery_item_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `unit` int(11) NOT NULL,
  `used_unit` int(11) NOT NULL DEFAULT 0,
  `volume_per_unit` double NOT NULL,
  `used_volume` double NOT NULL DEFAULT 0,
  `volume` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `notes` varchar(255) NOT NULL,
  `delivered_date` datetime NOT NULL,
  `expiry_date` datetime NOT NULL,
  `is_expired_processed` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_inventory_batch`
--

INSERT INTO `tbl_inventory_batch` (`batch_id`, `delivery_item_id`, `product_id`, `unit`, `used_unit`, `volume_per_unit`, `used_volume`, `volume`, `price`, `notes`, `delivered_date`, `expiry_date`, `is_expired_processed`) VALUES
(13, 40, 21, 10, 0, 1000, 204, 10000, 200.00, '', '2025-10-19 00:00:00', '2025-10-25 00:00:00', 1),
(14, 41, 22, 20, 0, 1000, 810, 20000, 200.00, '', '2025-10-31 00:00:00', '2026-10-31 00:00:00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login_history`
--

CREATE TABLE `tbl_login_history` (
  `login_id` int(11) NOT NULL,
  `login_Time` datetime NOT NULL DEFAULT current_timestamp(),
  `logout_Time` datetime DEFAULT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_overhead`
--

CREATE TABLE `tbl_overhead` (
  `over_head_id` int(11) NOT NULL,
  `monthly_rent` decimal(10,0) NOT NULL,
  `electricity_bill` decimal(10,0) NOT NULL,
  `water_bill` decimal(10,0) NOT NULL,
  `internet_bill` decimal(10,0) NOT NULL,
  `other_bill` decimal(10,0) NOT NULL,
  `notes` text NOT NULL,
  `utilities_amount` decimal(10,0) NOT NULL,
  `total_over_head` decimal(10,0) NOT NULL,
  `total_working_hours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_overhead`
--

INSERT INTO `tbl_overhead` (`over_head_id`, `monthly_rent`, `electricity_bill`, `water_bill`, `internet_bill`, `other_bill`, `notes`, `utilities_amount`, `total_over_head`, `total_working_hours`) VALUES
(12, 8000, 600, 400, 999, 200, '', 0, 10199, 224);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_payment`
--

CREATE TABLE `tbl_payment` (
  `payment_id` int(11) NOT NULL,
  `appointment_id` int(11) DEFAULT NULL,
  `discount_type` varchar(255) NOT NULL,
  `discount_amount` decimal(10,0) NOT NULL,
  `vat_amount` decimal(10,0) NOT NULL,
  `amount_paid` decimal(10,0) NOT NULL,
  `total_amount` decimal(10,0) NOT NULL,
  `change_amount` decimal(10,0) NOT NULL,
  `payment_method` varchar(100) NOT NULL,
  `reference_no` varchar(255) NOT NULL,
  `paid_at` datetime NOT NULL,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_payment`
--

INSERT INTO `tbl_payment` (`payment_id`, `appointment_id`, `discount_type`, `discount_amount`, `vat_amount`, `amount_paid`, `total_amount`, `change_amount`, `payment_method`, `reference_no`, `paid_at`, `user_id`) VALUES
(105, NULL, 'Senior/PWD ', 45, 0, 200, 179, 21, 'Cash', 'N/A', '2025-10-23 10:16:11', NULL),
(106, NULL, 'N/A', 0, 27, 300, 250, 50, 'Cash', 'N/A', '2025-10-23 10:23:52', NULL),
(107, NULL, 'Senior/PWD ', 80, 0, 500, 321, 179, 'Cash', 'N/A', '2025-10-23 10:27:30', NULL),
(108, NULL, 'Promo summer10', 20, 21, 200, 180, 20, 'Cash', 'N/A', '2025-10-23 12:09:41', NULL),
(109, NULL, 'Promo summer10', 25, 27, 300, 225, 75, 'Cash', 'N/A', '2025-10-23 12:10:03', NULL),
(110, NULL, 'N/A', 0, 27, 300, 250, 50, 'Cash', 'N/A', '2025-10-23 13:37:52', NULL),
(111, NULL, 'Senior/PWD ', 45, 0, 200, 179, 21, 'Cash', 'N/A', '2025-10-23 14:24:05', NULL),
(112, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:11:40', NULL),
(113, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:13:37', NULL),
(114, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:15:12', NULL),
(115, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:18:26', NULL),
(116, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:20:58', NULL),
(117, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:23:47', NULL),
(118, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:25:57', NULL),
(119, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:36:10', NULL),
(120, NULL, 'Senior/PWD ', 36, 0, 200, 143, 57, 'Cash', 'N/A', '2025-10-25 09:37:49', NULL),
(121, NULL, 'Senior/PWD ', 80, 0, 321, 321, 0, 'Gcash', '312', '2025-10-25 10:56:47', NULL),
(122, NULL, 'N/A', 0, 21, 500, 200, 300, 'Cash', 'N/A', '2025-10-25 11:57:27', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_products`
--

CREATE TABLE `tbl_products` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `brand` varchar(255) NOT NULL,
  `category_id` int(11) DEFAULT NULL,
  `unit_type` enum('ml','g','pc','kg','L','pack','box') DEFAULT NULL,
  `usage_type` enum('Pump','Scoop','Spray','Drop','Direct') DEFAULT NULL,
  `unit_volume` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_products`
--

INSERT INTO `tbl_products` (`product_id`, `product_name`, `brand`, `category_id`, `unit_type`, `usage_type`, `unit_volume`, `quantity`, `is_deleted`) VALUES
(21, 'Hair Color', 'Evon', 93, 'ml', 'Scoop', 1000, 0, 1),
(22, 'straightener', 'revlon', 93, 'ml', 'Spray', 1000, 0, 0),
(23, 'asd', 'asd', 93, 'ml', 'Pump', 33, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_refund`
--

CREATE TABLE `tbl_refund` (
  `refund_id` int(11) NOT NULL,
  `transaction_id` int(11) DEFAULT NULL,
  `appointment_id` int(11) DEFAULT NULL,
  `refund_amount` decimal(10,0) NOT NULL,
  `refund_method` varchar(55) NOT NULL,
  `refund_reason` text NOT NULL,
  `refunded_by` varchar(100) NOT NULL,
  `refund_timestamp` datetime NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Processed'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_refund`
--

INSERT INTO `tbl_refund` (`refund_id`, `transaction_id`, `appointment_id`, `refund_amount`, `refund_method`, `refund_reason`, `refunded_by`, `refund_timestamp`, `status`) VALUES
(21, NULL, NULL, 71, 'Cash', 'cancel', 'Kindeo', '2025-10-21 22:31:27', 'Processed'),
(22, NULL, NULL, 200, 'Cash', 'cancel', 'kindeo', '2025-10-22 16:42:39', 'Processed'),
(23, NULL, NULL, 180, 'Cash', 'cancel', 'kindeo', '2025-10-22 16:44:02', 'Processed'),
(24, 58, NULL, 179, 'Cash', 'cancel', 'kindeo', '2025-10-24 12:36:36', 'Processed'),
(25, 59, NULL, 143, 'Cash', 'cancel', 'Kindeo', '2025-10-25 09:12:32', 'Processed'),
(26, 60, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:14:07', 'Processed'),
(27, 61, NULL, 143, 'Cash', '200', 'Kindeo', '2025-10-25 09:15:49', 'Processed'),
(28, 62, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:18:49', 'Processed'),
(29, 63, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:21:14', 'Processed'),
(30, 64, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:24:05', 'Processed'),
(31, 65, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:26:10', 'Processed'),
(32, 66, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:36:27', 'Processed'),
(33, 67, NULL, 143, 'Cash', '143', 'Kindeo', '2025-10-25 09:38:05', 'Processed'),
(34, 68, NULL, 321, 'Gcash', 'cancel', 'Kindeo', '2025-10-25 10:58:03', 'Processed');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_servicesname`
--

CREATE TABLE `tbl_servicesname` (
  `serviceName_id` int(11) NOT NULL,
  `subCategory_id` int(11) DEFAULT NULL,
  `serviceName` varchar(255) NOT NULL,
  `servicePrice` decimal(10,2) NOT NULL,
  `duration` int(11) NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 0,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_servicesname`
--

INSERT INTO `tbl_servicesname` (`serviceName_id`, `subCategory_id`, `serviceName`, `servicePrice`, `duration`, `status`, `is_deleted`) VALUES
(96, 144, 'Hair Color', 0.00, 25, 0, 0),
(97, 144, 'hair treatment', 0.00, 45, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_service_price`
--

CREATE TABLE `tbl_service_price` (
  `pricing_id` int(11) NOT NULL,
  `service_product_id` int(11) DEFAULT NULL,
  `product_cost` decimal(10,0) NOT NULL,
  `stylist_cost` decimal(10,0) NOT NULL,
  `overhead_cost` decimal(10,0) NOT NULL,
  `total_cost` decimal(10,0) NOT NULL,
  `selling_price` decimal(10,0) NOT NULL,
  `vat_amount` decimal(10,0) NOT NULL,
  `net_price` decimal(10,0) NOT NULL,
  `net_profit` decimal(10,0) NOT NULL,
  `gross_profit` decimal(10,0) NOT NULL,
  `profit_percent` decimal(10,0) NOT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_service_price`
--

INSERT INTO `tbl_service_price` (`pricing_id`, `service_product_id`, `product_cost`, `stylist_cost`, `overhead_cost`, `total_cost`, `selling_price`, `vat_amount`, `net_price`, `net_profit`, `gross_profit`, `profit_percent`, `is_deleted`) VALUES
(12, 24, 4, 24, 20, 47, 200, 21, 179, 131, 153, 76, 0),
(13, 43, 45, 35, 29, 110, 250, 27, 223, 113, 140, 56, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_service_product`
--

CREATE TABLE `tbl_service_product` (
  `service_product_id` int(11) NOT NULL,
  `service_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `usage_amount` double NOT NULL,
  `unit_per_volume` double NOT NULL,
  `total_usage_amount` double NOT NULL,
  `total_cost` decimal(10,0) NOT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_service_product`
--

INSERT INTO `tbl_service_product` (`service_product_id`, `service_id`, `product_id`, `usage_amount`, `unit_per_volume`, `total_usage_amount`, `total_cost`, `is_deleted`) VALUES
(24, 96, 21, 3, 3, 9, 2, 0),
(26, 96, 22, 5, 15, 75, 15, 0),
(42, 96, 21, 3, 3, 9, 2, 1),
(43, 97, 21, 3, 3, 9, 2, 0),
(44, 97, 22, 3, 15, 45, 9, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_settings`
--

CREATE TABLE `tbl_settings` (
  `settings_id` int(11) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `phone` varchar(11) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `opening` varchar(255) DEFAULT NULL,
  `closing` varchar(255) DEFAULT NULL,
  `cleanUp` varchar(255) DEFAULT NULL,
  `available_Slots` int(11) NOT NULL DEFAULT 0,
  `available_Time_Slot` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_settings`
--

INSERT INTO `tbl_settings` (`settings_id`, `email`, `phone`, `address`, `opening`, `closing`, `cleanUp`, `available_Slots`, `available_Time_Slot`) VALUES
(9, NULL, NULL, NULL, '9:00', '21:00', NULL, 3, 4);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_social_media`
--

CREATE TABLE `tbl_social_media` (
  `social_media_id` int(11) NOT NULL,
  `platformName` varchar(255) NOT NULL,
  `platformLink` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_specialist`
--

CREATE TABLE `tbl_specialist` (
  `specialist_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_specialist`
--

INSERT INTO `tbl_specialist` (`specialist_id`, `name`) VALUES
(1, 'hair specialist'),
(2, 'nail specialist');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stylists`
--

CREATE TABLE `tbl_stylists` (
  `stylist_id` int(11) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `middleName` varchar(25) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `birth_date` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `image` varchar(255) NOT NULL,
  `contactNumber` varchar(11) NOT NULL,
  `address` varchar(255) NOT NULL,
  `specialists` varchar(255) NOT NULL,
  `daily_wage` decimal(10,0) NOT NULL DEFAULT 0,
  `status` varchar(45) NOT NULL DEFAULT ' Active',
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_stylists`
--

INSERT INTO `tbl_stylists` (`stylist_id`, `firstName`, `middleName`, `lastName`, `birth_date`, `email`, `image`, `contactNumber`, `address`, `specialists`, `daily_wage`, `status`, `is_deleted`) VALUES
(19, 'sda', 'dsad', 'sad', '2025-09-15', 'asd', '', 'asd', 'asdas', '', 500, ' Active', 1),
(20, 'Mohaifa ', 'Lakiman', 'Malik', '2000-06-22 00:00:00', 'malikmohaif@gmail.com', '', '123213123', 'Blk - 31 Lot - 19 Lanao Del Norte Maharlik Vill. Taguig City', '', 600, ' Active', 0),
(22, 'test123', 'test', 'test', '2025-09-30 00:19:40.653422', 'test', '', 'test', 'test', '', 500, ' Active', 0),
(23, 'we', 'w', 'w', '2025-10-03 02:31:12.318118', 'w', '', 'w', 'w', '', 0, ' Active', 0),
(24, 'kindeo123', 'neikdo', 'ken', '2025-06-03 00:00:00', 'tesst@gmail.com', '', '4124124', 'test', '', 300, 'Active', 0),
(25, 'kindeo', 'nek', 'neidko', '1999-05-11 00:00:00', 'alexprada782@gmail.com', '', '09494475270', 'taguig city', '', 360, 'Active', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stylist_schedules`
--

CREATE TABLE `tbl_stylist_schedules` (
  `id` int(11) NOT NULL,
  `stylist_id` int(11) DEFAULT NULL,
  `day_of_week` varchar(255) DEFAULT NULL,
  `start_time` time DEFAULT NULL,
  `end_time` time DEFAULT NULL,
  `is_working` tinyint(1) NOT NULL,
  `notes` varchar(255) DEFAULT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_stylist_schedules`
--

INSERT INTO `tbl_stylist_schedules` (`id`, `stylist_id`, `day_of_week`, `start_time`, `end_time`, `is_working`, `notes`, `is_deleted`) VALUES
(10, 20, 'Tuesday', '09:00:14', '21:00:14', 1, '', 0),
(16, 20, 'monday', '09:00:00', '21:00:00', 1, NULL, 0),
(17, 24, '-- Select Day --', '09:00:59', '21:00:59', 1, NULL, 0),
(18, 20, 'Wednesday', '09:00:20', '21:00:20', 1, NULL, 0),
(19, 20, 'Thursday', '09:00:00', '21:00:00', 1, NULL, 0),
(20, 20, 'Friday', '09:00:00', '21:00:00', 1, NULL, 0),
(21, 20, 'Saturday', '09:00:00', '21:00:00', 1, NULL, 0),
(22, 20, 'Sunday', '09:00:00', '21:00:00', 1, NULL, 0),
(23, 25, 'Tuesday', '07:05:26', '21:05:26', 1, NULL, 1),
(24, 23, 'Monday', '00:00:00', '12:00:00', 1, NULL, 0),
(25, 23, 'Tuesday', '09:00:00', '21:00:00', 1, NULL, 0),
(26, 19, 'Monday', '09:00:00', '21:00:00', 1, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stylist_specialists`
--

CREATE TABLE `tbl_stylist_specialists` (
  `stylist_special_id` int(11) NOT NULL,
  `specialist_id` int(11) DEFAULT NULL,
  `stylist_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_stylist_specialists`
--

INSERT INTO `tbl_stylist_specialists` (`stylist_special_id`, `specialist_id`, `stylist_id`) VALUES
(26, 1, 19),
(27, 1, 20);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_subcategory`
--

CREATE TABLE `tbl_subcategory` (
  `subCategory_id` int(11) NOT NULL,
  `category_id` int(11) DEFAULT NULL,
  `servicePicture` varchar(255) DEFAULT NULL,
  `subCategoryName` varchar(255) DEFAULT NULL,
  `status` enum('Active','Inactive') NOT NULL,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_subcategory`
--

INSERT INTO `tbl_subcategory` (`subCategory_id`, `category_id`, `servicePicture`, `subCategoryName`, `status`, `is_deleted`) VALUES
(144, 92, NULL, 'Hair treatment', 'Active', 0),
(145, 100, NULL, 'sub1', 'Active', 0),
(146, 101, NULL, 'Gel Polish', 'Active', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `status` varchar(45) NOT NULL DEFAULT 'Active',
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`supplier_id`, `supplier_name`, `address`, `email`, `contact`, `status`, `is_deleted`) VALUES
(6, 'kindeo', 'taguig city', 'test@gmail.com', '09123123313', 'Inactive', 1),
(7, 'sahud', 'taguigcity', 'sahudibad@gmai.com', '91231912391', 'Active', 0),
(8, 'Najiah', 'Bulacan', 'najiahbua@gmail.com', '09203101161', 'Active', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tax`
--

CREATE TABLE `tbl_tax` (
  `tax_id` int(11) NOT NULL,
  `tax` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_tax`
--

INSERT INTO `tbl_tax` (`tax_id`, `tax`) VALUES
(11, 12);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `transaction_id` int(11) NOT NULL,
  `appointment_id` int(11) DEFAULT NULL,
  `sub_total` decimal(10,0) NOT NULL,
  `vat_amount` decimal(10,0) NOT NULL,
  `discount_amount` decimal(10,0) NOT NULL,
  `amount_paid` decimal(10,0) NOT NULL,
  `payment_method` varchar(255) NOT NULL,
  `payment_status` varchar(255) NOT NULL,
  `timestamp` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_transaction`
--

INSERT INTO `tbl_transaction` (`transaction_id`, `appointment_id`, `sub_total`, `vat_amount`, `discount_amount`, `amount_paid`, `payment_method`, `payment_status`, `timestamp`) VALUES
(52, NULL, 250, 0, 45, 179, 'Cash', 'Paid', '2025-10-23 10:16:11'),
(53, NULL, 250, 27, 0, 250, 'Cash', 'Paid', '2025-10-23 10:23:52'),
(54, NULL, 450, 0, 80, 321, 'Cash', 'Paid', '2025-10-23 10:27:30'),
(55, NULL, 200, 21, 20, 180, 'Cash', 'Paid', '2025-10-23 12:09:41'),
(56, NULL, 250, 27, 25, 225, 'Cash', 'Paid', '2025-10-23 12:10:03'),
(57, NULL, 250, 27, 0, 250, 'Cash', 'Paid', '2025-10-23 13:37:52'),
(58, NULL, 250, 0, 45, 179, 'Cash', 'Refunded', '2025-10-23 14:24:05'),
(59, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:11:40'),
(60, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:13:37'),
(61, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:15:12'),
(62, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:18:26'),
(63, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:20:58'),
(64, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:23:47'),
(65, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:25:58'),
(66, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:36:10'),
(67, NULL, 200, 0, 36, 143, 'Cash', 'Refunded', '2025-10-25 09:37:49'),
(68, NULL, 450, 0, 80, 321, 'Gcash', 'Refunded', '2025-10-25 10:56:47'),
(69, NULL, 200, 21, 0, 200, 'Cash', 'Paid', '2025-10-25 11:57:27');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_unit_type`
--

CREATE TABLE `tbl_unit_type` (
  `unit_type_id` int(11) NOT NULL,
  `unit_type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_unit_type`
--

INSERT INTO `tbl_unit_type` (`unit_type_id`, `unit_type`) VALUES
(1, 'ml'),
(2, 'grams');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE `tbl_users` (
  `user_id` int(11) NOT NULL,
  `first_Name` varchar(50) NOT NULL,
  `middle_Name` varchar(50) DEFAULT NULL,
  `last_Name` varchar(50) NOT NULL,
  `birth_date` datetime NOT NULL,
  `phone_Number` varchar(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `userName` varchar(20) NOT NULL,
  `userPassword` varchar(255) NOT NULL,
  `Position` enum('Admin','Staff') NOT NULL,
  `status` enum('Active','Inactive') NOT NULL,
  `is_deactivate` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`user_id`, `first_Name`, `middle_Name`, `last_Name`, `birth_date`, `phone_Number`, `email`, `address`, `userName`, `userPassword`, `Position`, `status`, `is_deactivate`) VALUES
(257, 'Kindeo', 'Ken', 'Neikdo', '2025-10-09 00:00:00', '09945489867', 'alexprada420@gmail.com', 'taguig city', 'ken11', '$2a$11$1q5BQc.nf9mAMxr9vPFP5uCOxxqd3syNhcvQoT1yNeUp70JDgEBqi', 'Staff', 'Active', 0),
(262, 'Nissan ', 'Lakiman', 'Malik', '2000-06-22 00:00:00', '09203101161', 'malikmohaifa@gmail.com', 'Bulacan', 'Nissan', '$2a$11$Dam2tAk.ZeF4h8jErwfOYe4dqERFt2w2P5l1fJETjeqCq5UFOktLa', 'Staff', 'Inactive', 1),
(278, 'Kindei Neikdo', 'ken', 'neikdo', '1999-05-11 00:00:00', '09494475273', 'test12@gmail.com', 'taguig city', 'woozie', '$2a$11$qK1DE1Tp1BonKBynjSHBpuHUQlok8UCLjaiHFqkRPcBkbj3bEZX2u', 'Staff', 'Inactive', 1),
(279, 'dsadas', '', 'dasd', '1999-05-11 00:00:00', '09123127382', 'test@gmail.com', 'sdsadasd', 'test123456', '$2a$11$6pm1JRZyxFhHTzpN620Bce52L3AK1ZOzwyiMyPs7iOFL90rgwKb3G', 'Staff', 'Active', 0),
(280, 'test', '', 'test', '2007-01-01 00:00:00', '09213323213', 'test123@gmail.com', 'test12345', 'test123', '$2a$11$8S1G1IF/OuO8Ts6n4LrEV.E8LSfSzcwT0vYUNGteybTGd9ocdm6oq', 'Staff', 'Inactive', 1),
(281, 'dasdas', '', 'asdas', '1999-05-11 00:00:00', '09123213123', 'test@123gmail.com', 'asdsad', 'test123123', '$2a$11$EID5423QmjTgXgcBQIsvyuSj8XUnDX7T8gqLCnbiFTdCNOd1q2tIO', 'Staff', 'Inactive', 1),
(282, 'nameonly', '', 'test', '2000-01-01 00:00:00', '09321312512', 'test123123@gmail.com', 'dasdasd', 'woozie123', '$2a$11$wOQHs11QQR.5OoU73Q66FubzfVKSu.iWHztR4t6vQmHRvY6A5dm7.', 'Staff', 'Inactive', 1),
(283, 'Kindeo', '', 'Neikdo', '1999-05-11 08:48:34', '09494475270', 'alexprada782@gmail.com', 'taguig city', 'admin', '$2a$11$WyJmuVvKLu.rXhhC2peYveXLafRNe8edH1zsj.C9mIJxg5TyVmr9.', 'Admin', 'Active', 0),
(284, 'Shara', 'Calinog', 'Sumadia', '2002-08-21 00:00:00', '09480859676', 'sharajanesumadia08212002@gmail.com', 'Bulacan', 'Shara', '$2a$11$TxsazDg5Cyv0mcyfo01Eu.OGjNK.WbkeSlaJDI.OTutSYIUrlRLvW', 'Staff', 'Active', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_login`
--

CREATE TABLE `tbl_user_login` (
  `login_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user_login`
--

INSERT INTO `tbl_user_login` (`login_id`, `user_id`, `customer_id`) VALUES
(75, NULL, NULL),
(76, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_utility`
--

CREATE TABLE `tbl_utility` (
  `util_id` int(11) NOT NULL,
  `util_name` varchar(255) NOT NULL,
  `util_text` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_utility`
--

INSERT INTO `tbl_utility` (`util_id`, `util_name`, `util_text`) VALUES
(1, 'internet', 999),
(2, 'water bill', 200),
(3, 'test', 100),
(6, 'test', 123),
(7, 'test', 123),
(12, 'tesst', 300),
(13, 'test', 599);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_violations`
--

CREATE TABLE `tbl_violations` (
  `violation_id` int(11) NOT NULL,
  `violations` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_violations`
--

INSERT INTO `tbl_violations` (`violation_id`, `violations`) VALUES
(17, 'Frequent No-Shows or Last-Minute Cancellations'),
(18, 'Frequent No-Shows or Last-Minute Cancellations'),
(19, 'Frequent No-Shows or Last-Minute Cancellations'),
(20, 'Frequent No-Shows or Last-Minute Cancellations'),
(21, 'Frequent No-Shows or Last-Minute Cancellations'),
(22, 'Frequent No-Shows or Last-Minute Cancellations'),
(23, 'Frequent No-Shows or Last-Minute Cancellations'),
(24, 'test'),
(25, 'test'),
(26, 'test'),
(27, 'Frequent No-Shows or Last-Minute Cancellations'),
(28, 'Frequent No-Shows or Last-Minute Cancellations'),
(29, 'Frequent No-Shows or Last-Minute Cancellations'),
(30, 'Frequent No-Shows or Last-Minute Cancellations'),
(31, 'Frequent No-Shows or Last-Minute Cancellations'),
(32, 'Frequent No-Shows or Last-Minute Cancellations'),
(33, 'Frequent No-Shows or Last-Minute Cancellations');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_appointment`
--
ALTER TABLE `tbl_appointment`
  ADD PRIMARY KEY (`appointment_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `tbl_appointment_ibfk_3` (`stylist_id`);

--
-- Indexes for table `tbl_appointment_archive`
--
ALTER TABLE `tbl_appointment_archive`
  ADD PRIMARY KEY (`appointment_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `tbl_appointment_ibfk_3` (`stylist_id`);

--
-- Indexes for table `tbl_appointment_services`
--
ALTER TABLE `tbl_appointment_services`
  ADD PRIMARY KEY (`appointment_service_id`),
  ADD KEY `appointment_id` (`appointment_id`),
  ADD KEY `serviceName_id` (`serviceName_id`);

--
-- Indexes for table `tbl_appointment_services_archive`
--
ALTER TABLE `tbl_appointment_services_archive`
  ADD PRIMARY KEY (`appointment_service_id`),
  ADD KEY `appointment_id` (`appointment_id`),
  ADD KEY `serviceName_id` (`serviceName_id`) USING BTREE;

--
-- Indexes for table `tbl_audit_trail`
--
ALTER TABLE `tbl_audit_trail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_business_hours`
--
ALTER TABLE `tbl_business_hours`
  ADD PRIMARY KEY (`business_hours_id`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `tbl_customer_account`
--
ALTER TABLE `tbl_customer_account`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `tbl_customer_violations`
--
ALTER TABLE `tbl_customer_violations`
  ADD PRIMARY KEY (`customer_violations_id`),
  ADD KEY `fk_violation_id` (`violation_id`),
  ADD KEY `fk_customer_id` (`customer_id`);

--
-- Indexes for table `tbl_deleted_records`
--
ALTER TABLE `tbl_deleted_records`
  ADD PRIMARY KEY (`deleted_id`);

--
-- Indexes for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD PRIMARY KEY (`delivery_id`),
  ADD KEY `fk_delivery_supplier_id` (`supplier_id`);

--
-- Indexes for table `tbl_delivery_items`
--
ALTER TABLE `tbl_delivery_items`
  ADD PRIMARY KEY (`delivery_item_id`),
  ADD KEY `fk_delivery_item_delivery_d` (`delivery_id`),
  ADD KEY `fk_delivery_item_product_id` (`product_id`);

--
-- Indexes for table `tbl_discount`
--
ALTER TABLE `tbl_discount`
  ADD PRIMARY KEY (`discount_id`);

--
-- Indexes for table `tbl_discount_notification`
--
ALTER TABLE `tbl_discount_notification`
  ADD PRIMARY KEY (`notif_id`),
  ADD KEY `fk_notif_discount_id` (`discount_id`),
  ADD KEY `fk_notif_customer_id` (`customer_id`);

--
-- Indexes for table `tbl_discount_usage`
--
ALTER TABLE `tbl_discount_usage`
  ADD PRIMARY KEY (`usage_id`),
  ADD KEY `fk_usage_customer_id` (`customer_id`),
  ADD KEY `fk_usage_discount_id` (`discount_id`),
  ADD KEY `fk_usage_appointment_id` (`appointment_id`);

--
-- Indexes for table `tbl_exception_schedules`
--
ALTER TABLE `tbl_exception_schedules`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_exception_schedule_id` (`stylist_id`);

--
-- Indexes for table `tbl_expenses`
--
ALTER TABLE `tbl_expenses`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  ADD PRIMARY KEY (`inventory_id`),
  ADD KEY `fk_inventory_product_id` (`product_id`);

--
-- Indexes for table `tbl_inventory_batch`
--
ALTER TABLE `tbl_inventory_batch`
  ADD PRIMARY KEY (`batch_id`),
  ADD KEY `fk_batch_product_id` (`product_id`),
  ADD KEY `fk_batch_delivery_item_id` (`delivery_item_id`);

--
-- Indexes for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  ADD PRIMARY KEY (`login_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tbl_overhead`
--
ALTER TABLE `tbl_overhead`
  ADD PRIMARY KEY (`over_head_id`);

--
-- Indexes for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `fk_appointment_id` (`appointment_id`),
  ADD KEY `fk_user_id` (`user_id`);

--
-- Indexes for table `tbl_products`
--
ALTER TABLE `tbl_products`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `fk_product_category_id` (`category_id`);

--
-- Indexes for table `tbl_refund`
--
ALTER TABLE `tbl_refund`
  ADD PRIMARY KEY (`refund_id`),
  ADD KEY `fk_refund_transaction_id` (`transaction_id`),
  ADD KEY `fk_refund_appointment_id` (`appointment_id`);

--
-- Indexes for table `tbl_servicesname`
--
ALTER TABLE `tbl_servicesname`
  ADD PRIMARY KEY (`serviceName_id`),
  ADD KEY `subCategory_id` (`subCategory_id`);

--
-- Indexes for table `tbl_service_price`
--
ALTER TABLE `tbl_service_price`
  ADD PRIMARY KEY (`pricing_id`),
  ADD KEY `fk_service_price_serviceProduct_id` (`service_product_id`);

--
-- Indexes for table `tbl_service_product`
--
ALTER TABLE `tbl_service_product`
  ADD PRIMARY KEY (`service_product_id`),
  ADD KEY `fk_service_product_id` (`product_id`),
  ADD KEY `fk_product_service_id` (`service_id`);

--
-- Indexes for table `tbl_settings`
--
ALTER TABLE `tbl_settings`
  ADD PRIMARY KEY (`settings_id`);

--
-- Indexes for table `tbl_social_media`
--
ALTER TABLE `tbl_social_media`
  ADD PRIMARY KEY (`social_media_id`);

--
-- Indexes for table `tbl_specialist`
--
ALTER TABLE `tbl_specialist`
  ADD PRIMARY KEY (`specialist_id`);

--
-- Indexes for table `tbl_stylists`
--
ALTER TABLE `tbl_stylists`
  ADD PRIMARY KEY (`stylist_id`);

--
-- Indexes for table `tbl_stylist_schedules`
--
ALTER TABLE `tbl_stylist_schedules`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_stylist_schedules_id` (`stylist_id`);

--
-- Indexes for table `tbl_stylist_specialists`
--
ALTER TABLE `tbl_stylist_specialists`
  ADD PRIMARY KEY (`stylist_special_id`),
  ADD KEY `fk_specialist_id` (`specialist_id`),
  ADD KEY `fk_stylist_special_id` (`stylist_id`);

--
-- Indexes for table `tbl_subcategory`
--
ALTER TABLE `tbl_subcategory`
  ADD PRIMARY KEY (`subCategory_id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `tbl_tax`
--
ALTER TABLE `tbl_tax`
  ADD PRIMARY KEY (`tax_id`);

--
-- Indexes for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `fk_transaction_app_id` (`appointment_id`);

--
-- Indexes for table `tbl_unit_type`
--
ALTER TABLE `tbl_unit_type`
  ADD PRIMARY KEY (`unit_type_id`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `tbl_user_login`
--
ALTER TABLE `tbl_user_login`
  ADD PRIMARY KEY (`login_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `tbl_utility`
--
ALTER TABLE `tbl_utility`
  ADD PRIMARY KEY (`util_id`);

--
-- Indexes for table `tbl_violations`
--
ALTER TABLE `tbl_violations`
  ADD PRIMARY KEY (`violation_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_appointment`
--
ALTER TABLE `tbl_appointment`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=887;

--
-- AUTO_INCREMENT for table `tbl_appointment_archive`
--
ALTER TABLE `tbl_appointment_archive`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_appointment_services`
--
ALTER TABLE `tbl_appointment_services`
  MODIFY `appointment_service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=943;

--
-- AUTO_INCREMENT for table `tbl_appointment_services_archive`
--
ALTER TABLE `tbl_appointment_services_archive`
  MODIFY `appointment_service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=750;

--
-- AUTO_INCREMENT for table `tbl_audit_trail`
--
ALTER TABLE `tbl_audit_trail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2439;

--
-- AUTO_INCREMENT for table `tbl_business_hours`
--
ALTER TABLE `tbl_business_hours`
  MODIFY `business_hours_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=105;

--
-- AUTO_INCREMENT for table `tbl_customer_account`
--
ALTER TABLE `tbl_customer_account`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `tbl_customer_violations`
--
ALTER TABLE `tbl_customer_violations`
  MODIFY `customer_violations_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `tbl_deleted_records`
--
ALTER TABLE `tbl_deleted_records`
  MODIFY `deleted_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=94;

--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `delivery_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT for table `tbl_delivery_items`
--
ALTER TABLE `tbl_delivery_items`
  MODIFY `delivery_item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `tbl_discount`
--
ALTER TABLE `tbl_discount`
  MODIFY `discount_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tbl_discount_notification`
--
ALTER TABLE `tbl_discount_notification`
  MODIFY `notif_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `tbl_discount_usage`
--
ALTER TABLE `tbl_discount_usage`
  MODIFY `usage_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tbl_exception_schedules`
--
ALTER TABLE `tbl_exception_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `tbl_expenses`
--
ALTER TABLE `tbl_expenses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  MODIFY `inventory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tbl_inventory_batch`
--
ALTER TABLE `tbl_inventory_batch`
  MODIFY `batch_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=289;

--
-- AUTO_INCREMENT for table `tbl_overhead`
--
ALTER TABLE `tbl_overhead`
  MODIFY `over_head_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123;

--
-- AUTO_INCREMENT for table `tbl_products`
--
ALTER TABLE `tbl_products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tbl_refund`
--
ALTER TABLE `tbl_refund`
  MODIFY `refund_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `tbl_servicesname`
--
ALTER TABLE `tbl_servicesname`
  MODIFY `serviceName_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT for table `tbl_service_price`
--
ALTER TABLE `tbl_service_price`
  MODIFY `pricing_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_service_product`
--
ALTER TABLE `tbl_service_product`
  MODIFY `service_product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `tbl_settings`
--
ALTER TABLE `tbl_settings`
  MODIFY `settings_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_social_media`
--
ALTER TABLE `tbl_social_media`
  MODIFY `social_media_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tbl_specialist`
--
ALTER TABLE `tbl_specialist`
  MODIFY `specialist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_stylists`
--
ALTER TABLE `tbl_stylists`
  MODIFY `stylist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `tbl_stylist_schedules`
--
ALTER TABLE `tbl_stylist_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tbl_stylist_specialists`
--
ALTER TABLE `tbl_stylist_specialists`
  MODIFY `stylist_special_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tbl_subcategory`
--
ALTER TABLE `tbl_subcategory`
  MODIFY `subCategory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=147;

--
-- AUTO_INCREMENT for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_tax`
--
ALTER TABLE `tbl_tax`
  MODIFY `tax_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;

--
-- AUTO_INCREMENT for table `tbl_unit_type`
--
ALTER TABLE `tbl_unit_type`
  MODIFY `unit_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=285;

--
-- AUTO_INCREMENT for table `tbl_user_login`
--
ALTER TABLE `tbl_user_login`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `tbl_utility`
--
ALTER TABLE `tbl_utility`
  MODIFY `util_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_violations`
--
ALTER TABLE `tbl_violations`
  MODIFY `violation_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_appointment`
--
ALTER TABLE `tbl_appointment`
  ADD CONSTRAINT `tbl_appointment_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer_account` (`customer_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_appointment_ibfk_3` FOREIGN KEY (`stylist_id`) REFERENCES `tbl_stylists` (`stylist_id`) ON UPDATE CASCADE;

--
-- Constraints for table `tbl_appointment_services`
--
ALTER TABLE `tbl_appointment_services`
  ADD CONSTRAINT `tbl_appointment_services_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `tbl_appointment` (`appointment_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_appointment_services_ibfk_2` FOREIGN KEY (`serviceName_id`) REFERENCES `tbl_servicesname` (`serviceName_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_customer_violations`
--
ALTER TABLE `tbl_customer_violations`
  ADD CONSTRAINT `tbl_customer_violations_ibfk_1` FOREIGN KEY (`violation_id`) REFERENCES `tbl_violations` (`violation_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_customer_violations_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer_account` (`customer_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD CONSTRAINT `fk_delivery_supplier_id` FOREIGN KEY (`supplier_id`) REFERENCES `tbl_supplier` (`supplier_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_delivery_items`
--
ALTER TABLE `tbl_delivery_items`
  ADD CONSTRAINT `fk_delivery_item_delivery_d` FOREIGN KEY (`delivery_id`) REFERENCES `tbl_delivery` (`delivery_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_delivery_item_product_id` FOREIGN KEY (`product_id`) REFERENCES `tbl_products` (`product_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_discount_notification`
--
ALTER TABLE `tbl_discount_notification`
  ADD CONSTRAINT `fk_notif_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer_account` (`customer_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_notif_discount_id` FOREIGN KEY (`discount_id`) REFERENCES `tbl_discount` (`discount_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_discount_usage`
--
ALTER TABLE `tbl_discount_usage`
  ADD CONSTRAINT `fk_usage_appointment_id` FOREIGN KEY (`appointment_id`) REFERENCES `tbl_appointment` (`appointment_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_usage_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer_account` (`customer_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_usage_discount_id` FOREIGN KEY (`discount_id`) REFERENCES `tbl_discount` (`discount_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_exception_schedules`
--
ALTER TABLE `tbl_exception_schedules`
  ADD CONSTRAINT `fk_exception_schedule_id` FOREIGN KEY (`stylist_id`) REFERENCES `tbl_stylists` (`stylist_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  ADD CONSTRAINT `fk_inventory_product_id` FOREIGN KEY (`product_id`) REFERENCES `tbl_products` (`product_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_inventory_batch`
--
ALTER TABLE `tbl_inventory_batch`
  ADD CONSTRAINT `fk_batch_delivery_item_id` FOREIGN KEY (`delivery_item_id`) REFERENCES `tbl_delivery_items` (`delivery_item_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_batch_product_id` FOREIGN KEY (`product_id`) REFERENCES `tbl_products` (`product_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  ADD CONSTRAINT `tbl_login_history_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbl_users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  ADD CONSTRAINT `fk_appointment_id` FOREIGN KEY (`appointment_id`) REFERENCES `tbl_appointment` (`appointment_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `tbl_users` (`user_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_products`
--
ALTER TABLE `tbl_products`
  ADD CONSTRAINT `fk_product_category_id` FOREIGN KEY (`category_id`) REFERENCES `tbl_category` (`category_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_refund`
--
ALTER TABLE `tbl_refund`
  ADD CONSTRAINT `fk_refund_appointment_id` FOREIGN KEY (`appointment_id`) REFERENCES `tbl_appointment` (`appointment_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_refund_transaction_id` FOREIGN KEY (`transaction_id`) REFERENCES `tbl_transaction` (`transaction_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_servicesname`
--
ALTER TABLE `tbl_servicesname`
  ADD CONSTRAINT `tbl_servicesname_ibfk_1` FOREIGN KEY (`subCategory_id`) REFERENCES `tbl_subcategory` (`subCategory_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_service_price`
--
ALTER TABLE `tbl_service_price`
  ADD CONSTRAINT `fk_service_price_serviceProduct_id` FOREIGN KEY (`service_product_id`) REFERENCES `tbl_service_product` (`service_product_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_service_product`
--
ALTER TABLE `tbl_service_product`
  ADD CONSTRAINT `fk_product_service_id` FOREIGN KEY (`service_id`) REFERENCES `tbl_servicesname` (`serviceName_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_service_product_id` FOREIGN KEY (`product_id`) REFERENCES `tbl_products` (`product_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_stylist_schedules`
--
ALTER TABLE `tbl_stylist_schedules`
  ADD CONSTRAINT `fk_stylist_schedules_id` FOREIGN KEY (`stylist_id`) REFERENCES `tbl_stylists` (`stylist_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_stylist_specialists`
--
ALTER TABLE `tbl_stylist_specialists`
  ADD CONSTRAINT `fk_specialist_id` FOREIGN KEY (`specialist_id`) REFERENCES `tbl_specialist` (`specialist_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_stylist_special_id` FOREIGN KEY (`stylist_id`) REFERENCES `tbl_stylists` (`stylist_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_subcategory`
--
ALTER TABLE `tbl_subcategory`
  ADD CONSTRAINT `tbl_subcategory_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `tbl_category` (`category_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD CONSTRAINT `fk_transaction_app_id` FOREIGN KEY (`appointment_id`) REFERENCES `tbl_appointment` (`appointment_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tbl_user_login`
--
ALTER TABLE `tbl_user_login`
  ADD CONSTRAINT `tbl_user_login_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbl_users` (`user_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_user_login_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer_account` (`customer_id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
