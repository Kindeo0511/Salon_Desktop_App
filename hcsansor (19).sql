-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 26, 2025 at 07:09 PM
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

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_violations`
--

CREATE TABLE `tbl_customer_violations` (
  `customer_violations_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `violation_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  `is_available` tinyint(1) NOT NULL DEFAULT 0,
  `reason` varchar(255) NOT NULL,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
(26, 1, NULL),
(27, 1, NULL);

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

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tax`
--

CREATE TABLE `tbl_tax` (
  `tax_id` int(11) NOT NULL,
  `tax` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_login`
--

CREATE TABLE `tbl_user_login` (
  `login_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=902;

--
-- AUTO_INCREMENT for table `tbl_appointment_archive`
--
ALTER TABLE `tbl_appointment_archive`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_appointment_services`
--
ALTER TABLE `tbl_appointment_services`
  MODIFY `appointment_service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=961;

--
-- AUTO_INCREMENT for table `tbl_appointment_services_archive`
--
ALTER TABLE `tbl_appointment_services_archive`
  MODIFY `appointment_service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=750;

--
-- AUTO_INCREMENT for table `tbl_audit_trail`
--
ALTER TABLE `tbl_audit_trail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_business_hours`
--
ALTER TABLE `tbl_business_hours`
  MODIFY `business_hours_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=108;

--
-- AUTO_INCREMENT for table `tbl_customer_account`
--
ALTER TABLE `tbl_customer_account`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `tbl_customer_violations`
--
ALTER TABLE `tbl_customer_violations`
  MODIFY `customer_violations_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `tbl_deleted_records`
--
ALTER TABLE `tbl_deleted_records`
  MODIFY `deleted_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `delivery_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `tbl_delivery_items`
--
ALTER TABLE `tbl_delivery_items`
  MODIFY `delivery_item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `tbl_discount`
--
ALTER TABLE `tbl_discount`
  MODIFY `discount_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `tbl_discount_notification`
--
ALTER TABLE `tbl_discount_notification`
  MODIFY `notif_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `tbl_discount_usage`
--
ALTER TABLE `tbl_discount_usage`
  MODIFY `usage_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `tbl_exception_schedules`
--
ALTER TABLE `tbl_exception_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `tbl_expenses`
--
ALTER TABLE `tbl_expenses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  MODIFY `inventory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tbl_inventory_batch`
--
ALTER TABLE `tbl_inventory_batch`
  MODIFY `batch_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=289;

--
-- AUTO_INCREMENT for table `tbl_overhead`
--
ALTER TABLE `tbl_overhead`
  MODIFY `over_head_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_products`
--
ALTER TABLE `tbl_products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tbl_refund`
--
ALTER TABLE `tbl_refund`
  MODIFY `refund_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tbl_servicesname`
--
ALTER TABLE `tbl_servicesname`
  MODIFY `serviceName_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;

--
-- AUTO_INCREMENT for table `tbl_service_price`
--
ALTER TABLE `tbl_service_price`
  MODIFY `pricing_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tbl_service_product`
--
ALTER TABLE `tbl_service_product`
  MODIFY `service_product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

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
  MODIFY `stylist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `tbl_stylist_schedules`
--
ALTER TABLE `tbl_stylist_schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `tbl_stylist_specialists`
--
ALTER TABLE `tbl_stylist_specialists`
  MODIFY `stylist_special_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tbl_subcategory`
--
ALTER TABLE `tbl_subcategory`
  MODIFY `subCategory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=148;

--
-- AUTO_INCREMENT for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_tax`
--
ALTER TABLE `tbl_tax`
  MODIFY `tax_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `tbl_unit_type`
--
ALTER TABLE `tbl_unit_type`
  MODIFY `unit_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=287;

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
