-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 09, 2025 at 05:16 PM
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
  `Status` enum('Scheduled','No Show','Completed','Cancelled') NOT NULL,
  `payment_status` varchar(45) NOT NULL,
  `booking_type` varchar(255) NOT NULL,
  `cancel_Request` enum('None','Requested','Approved','Denied') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_appointment`
--

INSERT INTO `tbl_appointment` (`appointment_id`, `customer_id`, `stylist_id`, `Date`, `Time`, `start_time`, `end_time`, `Status`, `payment_status`, `booking_type`, `cancel_Request`) VALUES
(778, 51, 19, '2025-10-02 00:00:00', '', '09:00:00', '00:00:00', 'Scheduled', 'Paid', 'Walk-In', 'None'),
(779, 51, NULL, '2025-10-02 00:00:00', '', '10:00:00', '00:00:00', 'No Show', 'Unpaid', 'Phone Call', 'None'),
(780, 51, NULL, '2025-10-08 00:00:00', '', '09:00:00', '09:15:00', 'Completed', 'Unpaid', 'Walk-In', 'None'),
(781, 48, NULL, '2025-10-08 00:00:00', '', '21:00:00', '21:15:00', 'Scheduled', 'Unpaid', 'Walk-In', 'None'),
(782, 48, NULL, '2025-10-08 00:00:00', '', '10:00:00', '10:15:00', 'Cancelled', 'Unpaid', 'Online', 'None'),
(783, 51, NULL, '2025-10-09 00:00:00', '', '10:00:00', '10:15:00', 'Scheduled', 'Unpaid', 'Online', 'None');

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
(814, 778, 88),
(815, 779, 91),
(816, 780, 90),
(817, 781, 90),
(818, 782, 90),
(819, 783, 90);

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
  `audit_Trail_id` int(11) NOT NULL,
  `user` varchar(255) NOT NULL,
  `position` varchar(255) NOT NULL,
  `action` varchar(255) NOT NULL,
  `details` varchar(255) NOT NULL,
  `audit_Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_audit_trail`
--

INSERT INTO `tbl_audit_trail` (`audit_Trail_id`, `user`, `position`, `action`, `details`, `audit_Date`) VALUES
(1, 'Kindeo ', 'Admin', 'Created', 'a user account', '2024-12-21 13:50:26'),
(2, 'Kindeo ', 'Admin', 'Edited', 'a user account', '2024-12-21 16:19:41'),
(3, 'Kindeo ', 'Admin', 'Edited', 'a user account', '2024-12-21 16:22:35'),
(4, 'Kindeo ', 'Admin', 'Edited', 'a user account', '2024-12-21 16:22:49'),
(5, 'Kindeo ', 'Admin', 'Edited', 'a user account', '2024-12-21 16:22:58'),
(6, 'Kindeo ', 'Admin', 'Deleted', 'a user account', '2024-12-21 16:24:43'),
(7, 'Kindeo ', 'Admin', 'Created', 'a user account', '2024-12-21 16:28:17'),
(8, 'Kindeo ', 'Admin', 'Deleted', 'a user account', '2024-12-21 16:29:07'),
(9, 'Kindeo ', 'Admin', 'Created', 'a user account', '2024-12-21 16:29:22'),
(10, 'Kindeo ', 'Admin', 'Created', 'a user account', '2024-12-21 16:38:41'),
(11, 'Kindeo ', 'Admin', 'Deleted', 'a user account', '2024-12-21 16:38:55'),
(12, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 20:59:08'),
(13, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:01:08'),
(14, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:02:48'),
(15, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:02:57'),
(16, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:03:07'),
(17, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:03:45'),
(18, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:24:49'),
(19, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:30:22'),
(20, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:32:16'),
(21, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:32:32'),
(22, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:35:35'),
(23, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:39:16'),
(24, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:44:56'),
(25, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:53:15'),
(26, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:54:06'),
(27, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:55:32'),
(28, 'Kindeo ', 'Admin', 'Disapproved', 'the cusomter cancellation request', '2024-12-21 21:56:31'),
(29, 'Kindeo ', 'Admin', 'Added', 'a new stylist', '2024-12-28 20:53:16'),
(30, 'Kindeo ', 'Admin', 'Edited', 'the stylist', '2024-12-28 21:04:43'),
(31, 'Kindeo ', 'Admin', 'Edited', 'the stylist', '2024-12-28 21:04:54'),
(32, 'Kindeo ', 'Admin', 'Edited', 'a user account', '2024-12-28 21:08:55');

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
(72, 'test', 'Service', 'Active', 1),
(73, 'Hair Services', 'Service', 'Active', 1),
(74, 'Others', 'Product', 'Active', 0),
(75, 'wew', 'Product', 'Active', 1),
(76, 'sad', 'Service', 'Active', 0),
(84, 'test', 'Product', 'Active', 0),
(85, 'tesst', 'Product', 'Active', 0);

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
  `reset_token` varchar(255) DEFAULT NULL,
  `token_expiry` datetime DEFAULT NULL,
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_customer_account`
--

INSERT INTO `tbl_customer_account` (`customer_id`, `firstName`, `middleName`, `lastName`, `phoneNumber`, `email`, `gender`, `streetAddress`, `cityAddress`, `userName`, `password`, `status`, `reset_token`, `token_expiry`, `is_deleted`) VALUES
(48, 'Mariano', 'B', 'Vincent', '09945489867', 'alexprada782@gmail.com', 'Male', '', '', '', '', NULL, NULL, NULL, 0),
(50, 'test123', '123', '123', '123', '123', 'Male', '', '', '', '', NULL, NULL, NULL, 0),
(51, 'test123', '123', '123', '123', '123', 'Male', '', '', '', '', NULL, NULL, NULL, 0);

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
(40, 1, '2025-09-30', '123', 'test'),
(41, 3, '2025-10-01', '123', '231'),
(42, 1, '2025-10-03', '123', 'admin'),
(43, 3, '2025-10-03', '123', 'staff');

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
(32, 40, 12, 100, 100.00, 10000.00, '2025-09-30 00:00:00', ''),
(33, 41, 14, 20, 200.00, 4000.00, '2025-10-01 00:00:00', 'tesst'),
(34, 43, 13, 25, 100.00, 2500.00, '2025-10-03 00:00:00', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_discount`
--

CREATE TABLE `tbl_discount` (
  `discount_id` int(11) NOT NULL,
  `discount_type` varchar(255) NOT NULL,
  `promo_code` varchar(255) DEFAULT NULL,
  `discount_rate` decimal(10,0) NOT NULL,
  `expiry_date` date DEFAULT NULL,
  `status` enum('Active','Expiring Soon','Expired') NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_discount`
--

INSERT INTO `tbl_discount` (`discount_id`, `discount_type`, `promo_code`, `discount_rate`, `expiry_date`, `status`) VALUES
(1, 'Senior/PWD', NULL, 20, NULL, 'Active'),
(6, 'Promo', '123', 15, NULL, 'Active'),
(7, 'Senior/PWD', 'N/A', 20, NULL, 'Active'),
(8, 'Senior/PWD', 'N/A', 20, NULL, 'Active'),
(9, 'Senior/PWD', 'N/A', 20, NULL, 'Active'),
(11, 'Senior/PWD', '', 20, NULL, 'Active'),
(12, 'Promo', 'dis10', 10, '2025-10-31', 'Active'),
(13, 'Promo', 'dis10', 20, '2025-10-09', 'Expired');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_exception_schedules`
--

CREATE TABLE `tbl_exception_schedules` (
  `id` int(11) NOT NULL,
  `stylist_id` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `start_time` time DEFAULT NULL,
  `end_time` time DEFAULT NULL,
  `is_available` tinyint(1) NOT NULL,
  `reason` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_exception_schedules`
--

INSERT INTO `tbl_exception_schedules` (`id`, `stylist_id`, `date`, `start_time`, `end_time`, `is_available`, `reason`) VALUES
(8, 19, '2025-10-03', '02:02:33', '02:02:33', 0, ''),
(32, 20, '2025-10-09', '03:58:31', '15:58:31', 1, 'dsa'),
(33, 20, '2025-10-09', '03:58:31', '15:58:31', 1, 'dsa'),
(34, 20, '2025-10-09', '04:06:53', '04:06:53', 1, 'das'),
(36, 20, '2025-10-09', '04:19:29', '04:19:29', 1, 'dsaddas');

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
(2, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42'),
(3, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42'),
(4, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42'),
(5, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42'),
(6, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42'),
(7, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42'),
(8, 'Utilities', 'Updated Monthly Rent & Bills', 9099, 'Kindeo', '', '2025-10-08 14:56:42');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory`
--

CREATE TABLE `tbl_inventory` (
  `inventory_id` int(11) NOT NULL,
  `product_id` int(11) DEFAULT NULL,
  `unit` int(45) NOT NULL DEFAULT 0,
  `volume_per_unit` double DEFAULT 0,
  `volume` int(11) NOT NULL DEFAULT 0,
  `critical_level` int(11) NOT NULL DEFAULT 10,
  `status` enum('In Stock','Low Stock','Out of Stock') DEFAULT NULL,
  `expiry_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_inventory`
--

INSERT INTO `tbl_inventory` (`inventory_id`, `product_id`, `unit`, `volume_per_unit`, `volume`, `critical_level`, `status`, `expiry_date`) VALUES
(15, 12, 91, 100, 8920, 10000, 'Low Stock', '0001-01-01 00:00:00'),
(16, 14, 20, 1000, 20000, 10, 'In Stock', '0001-01-01 00:00:00'),
(17, 13, 45, 500, 22500, 10, 'In Stock', '0001-01-01 00:00:00');

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

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory_batch`
--

CREATE TABLE `tbl_inventory_batch` (
  `batch_id` int(11) NOT NULL,
  `delivery_item_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `unit` int(11) NOT NULL,
  `volume_per_unit` double NOT NULL,
  `volume` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `notes` varchar(255) NOT NULL,
  `delivered_date` datetime NOT NULL,
  `expiry_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_inventory_batch`
--

INSERT INTO `tbl_inventory_batch` (`batch_id`, `delivery_item_id`, `product_id`, `unit`, `volume_per_unit`, `volume`, `price`, `notes`, `delivered_date`, `expiry_date`) VALUES
(5, 32, 12, 100, 1000, 10000, 500.00, '', '2025-09-30 00:00:00', '2025-09-30 00:00:00'),
(6, 33, 14, 20, 1000, 20000, 200.00, 'tesst', '2025-10-01 00:00:00', '2025-10-01 00:00:00'),
(7, 34, 13, 25, 500, 12500, 100.00, 'test', '2025-10-03 00:00:00', '2025-10-03 00:00:00');

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

--
-- Dumping data for table `tbl_login_history`
--

INSERT INTO `tbl_login_history` (`login_id`, `login_Time`, `logout_Time`, `user_id`) VALUES
(282, '2024-12-03 14:44:42', '2024-12-03 14:47:53', 239),
(283, '2024-12-21 13:12:11', '2024-12-28 21:05:31', 239),
(284, '2024-12-21 20:58:42', '2024-12-28 21:05:31', 239),
(285, '2024-12-28 19:58:17', '2024-12-28 21:05:31', 239),
(286, '2024-12-28 21:08:40', '2024-12-28 21:09:02', 239),
(287, '2024-12-28 21:09:10', '2024-12-28 21:09:35', 239),
(288, '2025-01-03 15:26:47', '2025-01-03 16:24:27', 239);

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
(3, 7000, 500, 400, 999, 200, '', 2099, 9099, 224);

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
(32, NULL, 'N/A', 0, 11, 1000, 100, 900, 'Cash', 'N/A', '2025-09-27 16:25:45', NULL),
(40, NULL, 'Senior/PWD', 12, 9, 100, 88, 12, 'Cash', '123', '2025-09-27 18:24:03', NULL),
(41, NULL, 'Senior/PWD', 12, 9, 100, 88, 12, 'Cash', '123', '2025-09-27 18:43:40', NULL),
(42, NULL, 'Senior/PWD', 12, 9, 88, 88, 0, 'Gcash', '123', '2025-09-27 18:56:58', NULL),
(43, NULL, 'Senior/PWD', 24, 19, 200, 176, 24, 'Cash', 'N/A', '2025-09-27 18:59:44', NULL),
(44, NULL, 'N/A', 0, 17, 1000, 100, 900, 'Cash', 'N/A', '2025-10-01 02:50:54', NULL),
(45, NULL, 'Senior/PWD', 20, 13, 100, 80, 20, 'Gcash', '123', '2025-10-01 02:51:28', NULL),
(46, NULL, 'Senior/PWD', 20, 13, 100, 80, 20, 'Cash', 'N/A', '2025-10-01 03:29:42', NULL),
(47, NULL, 'N/A', 0, 17, 100, 100, 0, 'Cash', 'N/A', '2025-10-01 11:17:40', NULL),
(48, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 11:47:33', NULL),
(49, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 11:49:44', NULL),
(50, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 11:59:03', NULL),
(51, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 12:01:10', NULL),
(52, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 12:07:06', NULL),
(53, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 13:51:17', NULL),
(54, 778, 'Senior/PWD', 40, 0, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 13:54:45', NULL),
(55, 778, 'Senior/PWD', 40, 33, 200, 160, 40, 'Cash', 'N/A', '2025-10-02 13:58:01', NULL),
(56, 778, 'Promo', 30, 33, 500, 170, 330, 'Cash', 'N/A', '2025-10-02 18:07:40', NULL);

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
(12, 'test', 'test', 74, 'ml', 'Scoop', 100, 0, 0),
(13, 'uwu', 'uwu', 73, 'g', 'Scoop', 500, 0, 0),
(14, 'wala', 'wala', 76, 'kg', 'Pump', 1000, 0, 0);

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
(87, 133, 'test', 100.00, 20, 0, 1),
(88, 134, 'tesst', 100.00, 15, 1, 0),
(90, 134, 'test', 0.00, 15, 0, 0),
(91, 133, 'test123', 0.00, 15, 0, 0);

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
  `profit_percent` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_service_price`
--

INSERT INTO `tbl_service_price` (`pricing_id`, `service_product_id`, `product_cost`, `stylist_cost`, `overhead_cost`, `total_cost`, `selling_price`, `vat_amount`, `net_price`, `net_profit`, `gross_profit`, `profit_percent`) VALUES
(3, 7, 80, 17, 13, 110, 200, 33, 167, 57, 90, 45),
(5, 13, 50, 12, 10, 72, 300, 50, 250, 178, 228, 76);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_service_product`
--

CREATE TABLE `tbl_service_product` (
  `service_product_id` int(11) NOT NULL,
  `service_id` int(11) DEFAULT NULL,
  `product_id` int(11) DEFAULT NULL,
  `usage_amount` double NOT NULL,
  `unit_per_volume` int(11) NOT NULL,
  `total_usage_amount` double NOT NULL,
  `total_cost` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_service_product`
--

INSERT INTO `tbl_service_product` (`service_product_id`, `service_id`, `product_id`, `usage_amount`, `unit_per_volume`, `total_usage_amount`, `total_cost`) VALUES
(7, 88, 12, 3, 40, 120, 60),
(11, 88, 13, 5, 10, 50, 10),
(13, 91, 14, 5, 50, 250, 50);

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
  `is_deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_stylists`
--

INSERT INTO `tbl_stylists` (`stylist_id`, `firstName`, `middleName`, `lastName`, `birth_date`, `email`, `image`, `contactNumber`, `address`, `specialists`, `daily_wage`, `is_deleted`) VALUES
(19, 'sda', 'dsad', 'sad', '2025-09-15', 'asd', '', 'asd', 'asdas', '', 500, 1),
(20, 'Mohaifa ', 'Lakiman', 'Malik', '2000-06-22 00:00:00', 'malikmohaif@gmail.com', '', '123213123', 'Blk - 31 Lot - 19 Lanao Del Norte Maharlik Vill. Taguig City', '', 600, 0),
(22, 'test123', 'test', 'test', '2025-09-30 00:19:40.653422', 'test', '', 'test', 'test', '', 500, 0),
(23, 'we', 'w', 'w', '2025-10-03 02:31:12.318118', 'w', '', 'w', 'w', '', 0, 0),
(24, 'kindeo123', 'neikdo', 'ken', '2025-06-03 00:00:00', 'tesst@gmail.com', '', '4124124', 'test', '', 300, 0);

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
  `notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_stylist_schedules`
--

INSERT INTO `tbl_stylist_schedules` (`id`, `stylist_id`, `day_of_week`, `start_time`, `end_time`, `is_working`, `notes`) VALUES
(8, 20, 'monday', '10:19:00', '10:19:00', 0, 'test'),
(9, 19, '', '02:01:19', '02:01:19', 0, ''),
(10, 20, 'Tuesday', '09:00:14', '21:00:14', 1, ''),
(13, 20, 'monday', '10:31:28', '12:31:28', 1, NULL),
(14, 20, 'monday', '09:00:00', '21:00:00', 1, NULL),
(15, 20, 'monday', '09:00:00', '21:00:00', 1, NULL);

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
(133, 72, NULL, 'test', 'Active', 1),
(134, 74, NULL, 'makeup', 'Active', 0),
(135, 74, NULL, 'other', 'Active', 0),
(136, 76, NULL, 'other', 'Active', 0),
(138, 72, NULL, 'test', 'Active', 0),
(139, 73, NULL, 'test', 'Active', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `contact` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`supplier_id`, `supplier_name`, `address`, `email`, `contact`) VALUES
(1, 'test', 'test', 'test', 'test'),
(3, 'test123', 'test', 'test123', 'test'),
(5, '', '', '', ''),
(6, 'kindeo', 'asdasdsad', 'test@gmail.com', '3123213321');

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
(2, 12);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `transaction_id` int(11) NOT NULL,
  `appointment_id` int(11) DEFAULT NULL,
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

INSERT INTO `tbl_transaction` (`transaction_id`, `appointment_id`, `vat_amount`, `discount_amount`, `amount_paid`, `payment_method`, `payment_status`, `timestamp`) VALUES
(1, 778, 0, 40, 200, 'Cash', 'Paid', '2025-10-02 13:54:45'),
(2, 778, 33, 40, 160, 'Cash', 'Paid', '2025-10-02 13:58:01'),
(3, 778, 33, 30, 170, 'Cash', 'Paid', '2025-10-02 18:07:40');

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
  `first_Name` varchar(255) NOT NULL,
  `middle_Name` varchar(255) DEFAULT NULL,
  `last_Name` varchar(255) NOT NULL,
  `birth_date` datetime NOT NULL,
  `phone_Number` varchar(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` text NOT NULL,
  `userName` varchar(255) NOT NULL,
  `userPassword` varchar(255) NOT NULL,
  `Position` enum('Admin','Staff') NOT NULL,
  `status` enum('Active','Inactive') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`user_id`, `first_Name`, `middle_Name`, `last_Name`, `birth_date`, `phone_Number`, `email`, `address`, `userName`, `userPassword`, `Position`, `status`) VALUES
(239, 'Kindeo', 'Kenn', 'Neikdo', '2025-09-01 23:01:02', '11111111111', 'test', '0', 'admin', 'admin123', 'Admin', 'Active'),
(248, '123', 'test', 'test', '2025-10-01 20:44:48', 'test', 'test', 'test', 'test123', 'test', 'Staff', 'Active'),
(249, 'asd', 'asd', 'dasd', '2025-10-08 00:00:00', '09494475270', 'alexprada782@gmail.com', 'asd', 'testuser', 'test123456', 'Staff', 'Active'),
(250, 'asd', 'asd', 'dasd', '2025-10-08 00:00:00', '09494475273', 'alexprada72@gmail.com', 'asd', 'asd', '12345678', 'Staff', 'Active'),
(251, 'sad', 'sad', 'd', '2025-10-08 00:00:00', '09494475271', 'alexprada2@gmail.com', 'asd', 'das', '12345678', 'Staff', 'Active'),
(252, 'dsad', 'sadsa', 'as', '2025-10-08 00:00:00', '083289442', 'test@gmail.com', 'asd', 'as', '12345678', 'Staff', 'Active'),
(253, 'dsad', 'sad', 'sad', '2025-10-08 00:00:00', '12345678', 'aexas@gmail.com', 'dasd', '123123', '12345678', 'Staff', 'Active'),
(254, 'test', 'test', 'test', '2025-10-08 00:00:00', '12312321', 'testtest@gmail.com', 'test', 'Kindeo', '12345678', 'Staff', 'Active'),
(255, 'test', 'test', 'test', '2025-10-08 00:00:00', '213124214', 'dsad123@gmail.com', 'test', 'test123', '12345678', 'Staff', 'Active'),
(256, 'sad', 'asd', 'asdsa', '2025-10-08 00:00:00', '123213125', 'dsadsada@gmail.com', 'asd', 'test123123123', '12345678', 'Staff', 'Active');

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
(75, 239, NULL),
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
  ADD PRIMARY KEY (`audit_Trail_id`);

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
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=784;

--
-- AUTO_INCREMENT for table `tbl_appointment_archive`
--
ALTER TABLE `tbl_appointment_archive`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_appointment_services`
--
ALTER TABLE `tbl_appointment_services`
  MODIFY `appointment_service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=820;

--
-- AUTO_INCREMENT for table `tbl_appointment_services_archive`
--
ALTER TABLE `tbl_appointment_services_archive`
  MODIFY `appointment_service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=750;

--
-- AUTO_INCREMENT for table `tbl_audit_trail`
--
ALTER TABLE `tbl_audit_trail`
  MODIFY `audit_Trail_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `tbl_business_hours`
--
ALTER TABLE `tbl_business_hours`
  MODIFY `business_hours_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- AUTO_INCREMENT for table `tbl_customer_account`
--
ALTER TABLE `tbl_customer_account`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `tbl_customer_violations`
--
ALTER TABLE `tbl_customer_violations`
  MODIFY `customer_violations_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `delivery_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `tbl_delivery_items`
--
ALTER TABLE `tbl_delivery_items`
  MODIFY `delivery_item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `tbl_discount`
--
ALTER TABLE `tbl_discount`
  MODIFY `discount_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_exception_schedules`
--
ALTER TABLE `tbl_exception_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `tbl_expenses`
--
ALTER TABLE `tbl_expenses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  MODIFY `inventory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbl_inventory_batch`
--
ALTER TABLE `tbl_inventory_batch`
  MODIFY `batch_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=289;

--
-- AUTO_INCREMENT for table `tbl_overhead`
--
ALTER TABLE `tbl_overhead`
  MODIFY `over_head_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `tbl_products`
--
ALTER TABLE `tbl_products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tbl_servicesname`
--
ALTER TABLE `tbl_servicesname`
  MODIFY `serviceName_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;

--
-- AUTO_INCREMENT for table `tbl_service_price`
--
ALTER TABLE `tbl_service_price`
  MODIFY `pricing_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_service_product`
--
ALTER TABLE `tbl_service_product`
  MODIFY `service_product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

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
  MODIFY `stylist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `tbl_stylist_schedules`
--
ALTER TABLE `tbl_stylist_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbl_stylist_specialists`
--
ALTER TABLE `tbl_stylist_specialists`
  MODIFY `stylist_special_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tbl_subcategory`
--
ALTER TABLE `tbl_subcategory`
  MODIFY `subCategory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=140;

--
-- AUTO_INCREMENT for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_tax`
--
ALTER TABLE `tbl_tax`
  MODIFY `tax_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_unit_type`
--
ALTER TABLE `tbl_unit_type`
  MODIFY `unit_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=257;

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
  ADD CONSTRAINT `tbl_subcategory_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `tbl_category` (`category_id`) ON DELETE SET NULL ON UPDATE CASCADE;

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
