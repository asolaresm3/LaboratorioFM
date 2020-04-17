CREATE DATABASE  IF NOT EXISTS `mydb2` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb2`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb2
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `autor`
--

DROP TABLE IF EXISTS `autor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autor` (
  `pkidautor` int NOT NULL,
  `nombre` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidautor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autor`
--

LOCK TABLES `autor` WRITE;
/*!40000 ALTER TABLE `autor` DISABLE KEYS */;
/*!40000 ALTER TABLE `autor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `pkidcategoria` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidcategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `pkidcliente` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `fkidmembresia` int DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`pkidcliente`),
  KEY `fk_cliente_membresia1_idx` (`fkidmembresia`),
  CONSTRAINT `fk_cliente_membresia1` FOREIGN KEY (`fkidmembresia`) REFERENCES `membresia` (`pkidmembresia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concepto_membresia`
--

DROP TABLE IF EXISTS `concepto_membresia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `concepto_membresia` (
  `pkcodlinea` int NOT NULL AUTO_INCREMENT,
  `pkidmembresia` int DEFAULT NULL,
  `pkidconcepto` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`pkcodlinea`),
  KEY `fk_concepto_membresia_conceptos1_idx` (`pkidconcepto`),
  KEY `fk_concepto_membresia_membresia1_idx` (`pkidmembresia`),
  CONSTRAINT `fk_concepto_membresia_conceptos1` FOREIGN KEY (`pkidconcepto`) REFERENCES `conceptos` (`pkidconcepto`),
  CONSTRAINT `fk_concepto_membresia_membresia1` FOREIGN KEY (`pkidmembresia`) REFERENCES `membresia` (`pkidmembresia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concepto_membresia`
--

LOCK TABLES `concepto_membresia` WRITE;
/*!40000 ALTER TABLE `concepto_membresia` DISABLE KEYS */;
/*!40000 ALTER TABLE `concepto_membresia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conceptos`
--

DROP TABLE IF EXISTS `conceptos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conceptos` (
  `pkidconcepto` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `valor` varchar(45) DEFAULT NULL,
  `tipo_operacion` tinyint DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `conceptoscol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidconcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conceptos`
--

LOCK TABLES `conceptos` WRITE;
/*!40000 ALTER TABLE `conceptos` DISABLE KEYS */;
/*!40000 ALTER TABLE `conceptos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `membresia`
--

DROP TABLE IF EXISTS `membresia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `membresia` (
  `pkidmembresia` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `fecha_emision` date DEFAULT NULL,
  `fecha_caducidad` date DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidmembresia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `membresia`
--

LOCK TABLES `membresia` WRITE;
/*!40000 ALTER TABLE `membresia` DISABLE KEYS */;
/*!40000 ALTER TABLE `membresia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `pkidproducto` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `fkidcategoria` int DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  `fkidtipoproducto` int DEFAULT NULL,
  `fkidautor` int DEFAULT NULL,
  `fkidproveedor` int DEFAULT NULL,
  PRIMARY KEY (`pkidproducto`),
  KEY `fk_productos_tipo_producto_idx` (`fkidtipoproducto`),
  KEY `fk_productos_autor1_idx` (`fkidautor`),
  KEY `fk_productos_categoria1_idx` (`fkidcategoria`),
  KEY `fk_productos_proveedor1_idx` (`fkidproveedor`),
  CONSTRAINT `fk_productos_autor1` FOREIGN KEY (`fkidautor`) REFERENCES `autor` (`pkidautor`),
  CONSTRAINT `fk_productos_categoria1` FOREIGN KEY (`fkidcategoria`) REFERENCES `categoria` (`pkidcategoria`),
  CONSTRAINT `fk_productos_proveedor1` FOREIGN KEY (`fkidproveedor`) REFERENCES `proveedor` (`pkidproveedor`),
  CONSTRAINT `fk_productos_tipo_producto` FOREIGN KEY (`fkidtipoproducto`) REFERENCES `tipo_producto` (`pkidtipoproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `pkidproveedor` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidproveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `renta_detalle`
--

DROP TABLE IF EXISTS `renta_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `renta_detalle` (
  `pkcodlinea` int NOT NULL AUTO_INCREMENT,
  `fkidrentaencabezado` int NOT NULL,
  `fkidproducto` int DEFAULT NULL,
  `subtotal` double DEFAULT NULL,
  PRIMARY KEY (`pkcodlinea`,`fkidrentaencabezado`),
  KEY `fk_renta_detalle_renta_encabezado1_idx` (`fkidrentaencabezado`),
  KEY `fk_renta_detalle_productos1_idx` (`fkidproducto`),
  CONSTRAINT `fk_renta_detalle_productos1` FOREIGN KEY (`fkidproducto`) REFERENCES `productos` (`pkidproducto`),
  CONSTRAINT `fk_renta_detalle_renta_encabezado1` FOREIGN KEY (`fkidrentaencabezado`) REFERENCES `renta_encabezado` (`pkidrentaencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `renta_detalle`
--

LOCK TABLES `renta_detalle` WRITE;
/*!40000 ALTER TABLE `renta_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `renta_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `renta_encabezado`
--

DROP TABLE IF EXISTS `renta_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `renta_encabezado` (
  `pkidrentaencabezado` int NOT NULL,
  `pkidmembresia` int DEFAULT NULL,
  `fecha_alquiler` date DEFAULT NULL,
  `fecha_entrega` date DEFAULT NULL,
  `fkidscucursal` int DEFAULT NULL,
  `total` int DEFAULT NULL,
  PRIMARY KEY (`pkidrentaencabezado`),
  KEY `fk_renta_membresia1_idx` (`pkidmembresia`),
  KEY `fk_renta_sucursal1_idx` (`fkidscucursal`),
  CONSTRAINT `fk_renta_membresia1` FOREIGN KEY (`pkidmembresia`) REFERENCES `membresia` (`pkidmembresia`),
  CONSTRAINT `fk_renta_sucursal1` FOREIGN KEY (`fkidscucursal`) REFERENCES `sucursal` (`pkidsucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `renta_encabezado`
--

LOCK TABLES `renta_encabezado` WRITE;
/*!40000 ALTER TABLE `renta_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `renta_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursal` (
  `pkidsucursal` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidsucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_producto`
--

DROP TABLE IF EXISTS `tipo_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_producto` (
  `pkidtipoproducto` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT NULL,
  PRIMARY KEY (`pkidtipoproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_producto`
--

LOCK TABLES `tipo_producto` WRITE;
/*!40000 ALTER TABLE `tipo_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb2'
--

--
-- Dumping routines for database 'mydb2'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-17 10:24:51
