-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 16-03-2018 a las 16:24:39
-- Versión del servidor: 5.6.38
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `g1s2am_FarmaDAM`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Active_Principles`
--

CREATE TABLE `Active_Principles` (
  `Id` int(10) NOT NULL,
  `Sanitary_Register_Number` varchar(8) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Chronic`
--

CREATE TABLE `Chronic` (
  `id_stock` int(6) NOT NULL,
  `id_client` int(11) NOT NULL,
  `description` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Clients`
--

CREATE TABLE `Clients` (
  `id` int(6) NOT NULL,
  `Name` varchar(50) CHARACTER SET latin1 NOT NULL,
  `lastName1` varchar(50) CHARACTER SET latin1 NOT NULL,
  `lastName2` varchar(50) CHARACTER SET latin1 NOT NULL,
  `address1` varchar(255) CHARACTER SET latin1 NOT NULL,
  `DNI` varchar(9) CHARACTER SET latin1 NOT NULL,
  `NTS` varchar(15) CHARACTER SET latin1 NOT NULL,
  `Type_NTS` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Drugs`
--

CREATE TABLE `Drugs` (
  `id` int(8) NOT NULL,
  `Register_Number` int(11) NOT NULL,
  `Sanitary_Register_Num` varchar(150) NOT NULL,
  `CommercialName` varchar(100) NOT NULL,
  `ActivePrincipleID` int(10) NOT NULL,
  `Content` varchar(100) NOT NULL,
  `LabId` int(11) NOT NULL,
  `Price` double NOT NULL,
  `IVAId` int(11) NOT NULL,
  `Replaceable` tinyint(1) NOT NULL,
  `IsGeneric` tinyint(1) NOT NULL,
  `NeedsRecipe` tinyint(1) NOT NULL,
  `Documentation` varchar(255) NOT NULL,
  `Prospectus` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `IVA`
--

CREATE TABLE `IVA` (
  `id` int(2) NOT NULL,
  `value` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Laboratories`
--

CREATE TABLE `Laboratories` (
  `id` int(8) NOT NULL,
  `LabName` varchar(100) CHARACTER SET latin1 COLLATE latin1_spanish_ci NOT NULL,
  `Address` varchar(300) NOT NULL,
  `cp` varchar(20) NOT NULL,
  `Location` varchar(100) NOT NULL,
  `CIF` varchar(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


--
-- Estructura de tabla para la tabla `Order_Content`
--

CREATE TABLE `Order_Content` (
  `Id_Header` int(10) NOT NULL,
  `Id_Content` int(10) NOT NULL,
  `Id_Drug` int(8) NOT NULL,
  `Quantity` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Order_Header`
--

CREATE TABLE `Order_Header` (
  `Id_Client` int(6) NOT NULL,
  `Id_Header` int(10) NOT NULL,
  `Id_Seller` int(8) NOT NULL,
  `Date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Seller`
--

CREATE TABLE `Seller` (
  `firstName` varchar(30) NOT NULL,
  `lastName1` varchar(30) NOT NULL,
  `lastName2` varchar(30) NOT NULL,
  `dni` varchar(9) NOT NULL,
  `email` varchar(50) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `rol` tinyint(1) NOT NULL,
  `id` int(8) NOT NULL,
  `comission` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Estructura de tabla para la tabla `Stock`
--

CREATE TABLE `Stock` (
  `Id_lab` int(8) NOT NULL,
  `Quantity` int(5) NOT NULL,
  `ID_Drug` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Type_NTS`
--

CREATE TABLE `Type_NTS` (
  `Id` int(2) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Active_Principles`
--
ALTER TABLE `Active_Principles`
  ADD PRIMARY KEY (`Id`) USING BTREE,
  ADD UNIQUE KEY `Sanitary_Register_Number` (`Sanitary_Register_Number`);

--
-- Indices de la tabla `Chronic`
--
ALTER TABLE `Chronic`
  ADD PRIMARY KEY (`id_stock`,`id_client`),
  ADD KEY `fk_client` (`id_client`);

--
-- Indices de la tabla `Clients`
--
ALTER TABLE `Clients`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `DNI` (`DNI`),
  ADD UNIQUE KEY `NTS` (`NTS`),
  ADD KEY `fk_Type_NTS` (`Type_NTS`);

--
-- Indices de la tabla `Drugs`
--
ALTER TABLE `Drugs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Register_Number` (`id`),
  ADD KEY `fk_IVA` (`IVAId`),
  ADD KEY `fk_principle` (`ActivePrincipleID`);

--
-- Indices de la tabla `IVA`
--
ALTER TABLE `IVA`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indices de la tabla `Laboratories`
--
ALTER TABLE `Laboratories`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `Order_Content`
--
ALTER TABLE `Order_Content`
  ADD PRIMARY KEY (`Id_Header`,`Id_Content`),
  ADD UNIQUE KEY `Id_Content` (`Id_Content`),
  ADD KEY `fk_drug_order` (`Id_Drug`),
  ADD KEY `fk_header_order` (`Id_Header`);

--
-- Indices de la tabla `Order_Header`
--
ALTER TABLE `Order_Header`
  ADD PRIMARY KEY (`Id_Header`),
  ADD KEY `fk_seller_order` (`Id_Seller`),
  ADD KEY `fk_client_order` (`Id_Client`);

--
-- Indices de la tabla `Seller`
--
ALTER TABLE `Seller`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `dni` (`dni`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indices de la tabla `Stock`
--
ALTER TABLE `Stock`
  ADD PRIMARY KEY (`Id_lab`,`ID_Drug`),
  ADD KEY `fk_meds` (`ID_Drug`);

--
-- Indices de la tabla `Type_NTS`
--
ALTER TABLE `Type_NTS`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Clients`
--
ALTER TABLE `Clients`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT de la tabla `Drugs`
--
ALTER TABLE `Drugs`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT de la tabla `IVA`
--
ALTER TABLE `IVA`
  MODIFY `id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `Order_Content`
--
ALTER TABLE `Order_Content`
  MODIFY `Id_Content` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=89;

--
-- AUTO_INCREMENT de la tabla `Order_Header`
--
ALTER TABLE `Order_Header`
  MODIFY `Id_Header` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de la tabla `Seller`
--
ALTER TABLE `Seller`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `Clients`
--
ALTER TABLE `Clients`
  ADD CONSTRAINT `fk_Type_NTS` FOREIGN KEY (`Type_NTS`) REFERENCES `Type_NTS` (`Id`);

--
-- Filtros para la tabla `Drugs`
--
ALTER TABLE `Drugs`
  ADD CONSTRAINT `fk_IVA` FOREIGN KEY (`IVAId`) REFERENCES `IVA` (`id`),
  ADD CONSTRAINT `fk_principle` FOREIGN KEY (`ActivePrincipleID`) REFERENCES `Active_Principles` (`Id`);

--
-- Filtros para la tabla `Order_Content`
--
ALTER TABLE `Order_Content`
  ADD CONSTRAINT `Order_Content_ibfk_1` FOREIGN KEY (`Id_Header`) REFERENCES `Order_Header` (`Id_Header`),
  ADD CONSTRAINT `Order_Content_ibfk_2` FOREIGN KEY (`Id_Drug`) REFERENCES `Drugs` (`id`);

--
-- Filtros para la tabla `Order_Header`
--
ALTER TABLE `Order_Header`
  ADD CONSTRAINT `Order_Header_ibfk_1` FOREIGN KEY (`Id_Seller`) REFERENCES `Seller` (`id`),
  ADD CONSTRAINT `fk_client_order` FOREIGN KEY (`Id_Client`) REFERENCES `Clients` (`id`);

--
-- Filtros para la tabla `Stock`
--
ALTER TABLE `Stock`
  ADD CONSTRAINT `fk_lab` FOREIGN KEY (`Id_lab`) REFERENCES `Laboratories` (`id`),
  ADD CONSTRAINT `fk_meds` FOREIGN KEY (`ID_Drug`) REFERENCES `Drugs` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
