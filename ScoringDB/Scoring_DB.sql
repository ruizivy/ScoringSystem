CREATE DATABASE  IF NOT EXISTS `scoring_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `scoring_db`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: scoring_db
-- ------------------------------------------------------
-- Server version	5.6.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary table structure for view `get_details`
--

DROP TABLE IF EXISTS `get_details`;
/*!50001 DROP VIEW IF EXISTS `get_details`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `get_details` (
  `JudgeID` tinyint NOT NULL,
  `username` tinyint NOT NULL,
  `userpassword` tinyint NOT NULL,
  `UserType` tinyint NOT NULL,
  `JudgeFName` tinyint NOT NULL,
  `Details` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tblcontestant`
--

DROP TABLE IF EXISTS `tblcontestant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcontestant` (
  `ContestantID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ContestantNo` int(11) DEFAULT NULL,
  `Fullname` varchar(500) DEFAULT NULL,
  `Details` varchar(1000) DEFAULT NULL,
  `PhotoPath` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`ContestantID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcontestant`
--

LOCK TABLES `tblcontestant` WRITE;
/*!40000 ALTER TABLE `tblcontestant` DISABLE KEYS */;
INSERT INTO `tblcontestant` VALUES (5,1,'Kim Taehyung','From Bighit Entertainment. One of the member of BTS.','C:\\Users\\Ruiz\\Documents\\Visual Studio 2012\\Projects\\ScoringSystemRuizIvyrose\\ScoringSystemRuizIvyrose\\bin\\Debug\\Picture\\\\4.png'),(6,2,'Jeon Jungkook','Maknae of BTS (Bangtan Boys).','C:\\Users\\Ruiz\\Documents\\Visual Studio 2012\\Projects\\ScoringSystemRuizIvyrose\\ScoringSystemRuizIvyrose\\bin\\Debug\\Picture\\\\jungkook.jpg'),(7,3,'Kim Seok Jin','Vocalist of the group..','C:\\Users\\Ruiz\\Documents\\Visual Studio 2012\\Projects\\ScoringSystemRuizIvyrose\\ScoringSystemRuizIvyrose\\bin\\Debug\\Picture\\\\jin.jpg'),(9,5,'Jae Bum','From JYP Entertainment.','C:\\Users\\Ruiz\\documents\\visual studio 2012\\Projects\\ScoringSystemRuizIvyrose\\ScoringSystemRuizIvyrose\\bin\\Debug\\Picture\\\\JB.jpg');
/*!40000 ALTER TABLE `tblcontestant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcriteria`
--

DROP TABLE IF EXISTS `tblcriteria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcriteria` (
  `CriteriaID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CriteriaName` varchar(200) NOT NULL,
  `Percentage` double NOT NULL,
  PRIMARY KEY (`CriteriaID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcriteria`
--

LOCK TABLES `tblcriteria` WRITE;
/*!40000 ALTER TABLE `tblcriteria` DISABLE KEYS */;
INSERT INTO `tblcriteria` VALUES (1,'Audience Impact',0.2),(2,'Costume',0.3),(3,'Choreography',0.2),(4,'Originality',0.3);
/*!40000 ALTER TABLE `tblcriteria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbljudge`
--

DROP TABLE IF EXISTS `tbljudge`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbljudge` (
  `JudgeID` bigint(20) NOT NULL AUTO_INCREMENT,
  `JudgeFName` varchar(200) DEFAULT NULL,
  `Details` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`JudgeID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbljudge`
--

LOCK TABLES `tbljudge` WRITE;
/*!40000 ALTER TABLE `tbljudge` DISABLE KEYS */;
INSERT INTO `tbljudge` VALUES (1,'Sehunnie Oh','From Seoul, South Korea.\r\nExo Member.'),(2,'Enchong Dee','From San Rafael Village.'),(3,'Sehun Oh','Seoul South Korea.'),(4,'Yeah210','Magtataho Sa Umaga Bartender Sa Gabi');
/*!40000 ALTER TABLE `tbljudge` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbllogs`
--

DROP TABLE IF EXISTS `tbllogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllogs` (
  `LogID` bigint(20) NOT NULL AUTO_INCREMENT,
  `UserID` bigint(20) DEFAULT NULL,
  `ActionName` text,
  `Remarks` varchar(500) DEFAULT NULL,
  `DateUpdated` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`LogID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbllogs`
--

LOCK TABLES `tbllogs` WRITE;
/*!40000 ALTER TABLE `tbllogs` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbllogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblscoring`
--

DROP TABLE IF EXISTS `tblscoring`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblscoring` (
  `ScoringID` bigint(20) NOT NULL AUTO_INCREMENT,
  `JudgeID` bigint(20) DEFAULT NULL,
  `CriteriaID` bigint(20) DEFAULT NULL,
  `ContestantID` bigint(20) DEFAULT NULL,
  `Score` double DEFAULT NULL,
  `CriteriaAverage` double DEFAULT NULL,
  PRIMARY KEY (`ScoringID`),
  KEY `JudgeID_idx` (`JudgeID`),
  KEY `CriteriaID_idx` (`CriteriaID`),
  KEY `ContestantID_idx` (`ContestantID`),
  CONSTRAINT `ContestantID` FOREIGN KEY (`ContestantID`) REFERENCES `tblcontestant` (`ContestantID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `CriteriaID` FOREIGN KEY (`CriteriaID`) REFERENCES `tblcriteria` (`CriteriaID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `JID` FOREIGN KEY (`JudgeID`) REFERENCES `tbljudge` (`JudgeID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblscoring`
--

LOCK TABLES `tblscoring` WRITE;
/*!40000 ALTER TABLE `tblscoring` DISABLE KEYS */;
INSERT INTO `tblscoring` VALUES (1,1,1,5,70,14),(2,1,2,5,80,24),(3,1,3,5,90,18),(4,1,4,5,80,24),(5,2,1,5,75,15),(6,2,2,5,80,24),(7,2,3,5,70,14),(8,2,4,5,85,25.5),(9,3,1,5,90,18),(10,3,2,5,85,25.5),(11,3,3,5,80,16),(12,3,4,5,75,22.5),(13,1,1,6,90,18),(14,1,2,6,95,28.5),(15,1,3,6,80,16),(16,1,4,6,85,25.5),(17,1,1,7,80,16),(18,1,2,7,85,25.5),(19,1,3,7,90,18),(20,1,4,7,75,22.5),(21,1,1,9,90,18),(22,1,2,9,80,24),(23,1,3,9,85,17),(24,1,4,9,88,26.4),(25,4,1,5,90,18),(26,4,2,5,80,24),(27,4,3,5,70,14),(28,4,4,5,80,24),(29,4,1,9,80,16),(30,4,2,9,70,21),(31,4,3,9,90,18),(32,4,4,9,86,25.8);
/*!40000 ALTER TABLE `tblscoring` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbluser` (
  `userid` bigint(20) NOT NULL AUTO_INCREMENT,
  `username` varchar(200) DEFAULT NULL,
  `userpassword` varchar(200) DEFAULT NULL,
  `UserType` varchar(200) DEFAULT NULL,
  `judgeid` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`userid`),
  KEY `judgeid_idx` (`judgeid`),
  CONSTRAINT `JudgeID` FOREIGN KEY (`judgeid`) REFERENCES `tbljudge` (`JudgeID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbluser`
--

LOCK TABLES `tbluser` WRITE;
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` VALUES (1,'admin','admin','admin',NULL),(2,'sehun','oh','judge',1),(3,'adrian','adrian','judge',2),(4,'ivy','ruiz','admin',NULL),(5,'luhan','oh','judge',3),(6,'poolpo','yeah','judge',4);
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'scoring_db'
--
/*!50003 DROP PROCEDURE IF EXISTS `insert_contestant` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_contestant`(ConNum INT(11),
									  fullname varchar(500),
                                      details varchar(1000),
                                      photopath varchar(500),
									  ctype varchar(100),
                                      conid bigint)
BEGIN
CASE
	WHEN ctype = "Insert" THEN INSERT INTO tblcontestant(ContestantNo,Fullname,Details,PhotoPath) 
											VALUES(ConNum , fullname , details , photopath);
	WHEN ctype = "Update" THEN UPDATE tblcontestant SET ContestantNo = ConNum, Fullname = fullname,
								Details = details, PhotoPath = photopath WHERE ContestantID = conid;
                                
END CASE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_criteria` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_criteria`(criteria_name VARCHAR(200),
									percentage DOUBLE,
                                    isinsert VARCHAR(100),
                                    criteria_ID bigint)
BEGIN
CASE
	WHEN isinsert = "1" THEN INSERT INTO tblcriteria(CriteriaName,Percentage) 
							VALUES (criteria_name,percentage);
	WHEN isinsert = "0" THEN UPDATE tblcriteria SET CriteriaName = criteria_name,
												  Percentage = percentage
											   WHERE CriteriaID = criteria_ID;
END CASE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_judge` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_judge`(judgeFname varchar(200),
								 details varchar(200),
                                 jtype varchar(45),
                                 judgeid1 BIGINT)
BEGIN
CASE 
	WHEN jtype = "Insert" THEN INSERT INTO tbljudge (JudgeFName , Details) VALUES(judgeFname,details);
    WHEN jtype = "Update" THEN UPDATE tbljudge SET JudgeFName = judgeFname, Details = details
								WHERE JudgeID = judgeid1;
END CASE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_user` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_user`(user VARCHAR(200),
								pass VARCHAR(200),
                                usertype VARCHAR(200),
                                judgeid1 bigint,
								 utype varchar(100),
                                userid1 bigint)
BEGIN
CASE 
	WHEN utype = "Insert" THEN INSERT INTO tbluser(username, userpassword, UserType, judgeid) VALUES(user , pass, usertype ,if(judgeid1 = 0,null,judgeid1));
    WHEN utype = "Update" THEN UPDATE tbluser SET username = user, userpassword = pass,
 												  UserType = usertype, judgeid = judgeid1 WHERE userid = userid1;
END CASE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `get_details`
--

/*!50001 DROP TABLE IF EXISTS `get_details`*/;
/*!50001 DROP VIEW IF EXISTS `get_details`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `get_details` AS select `j`.`JudgeID` AS `JudgeID`,`u`.`username` AS `username`,`u`.`userpassword` AS `userpassword`,`u`.`UserType` AS `UserType`,`j`.`JudgeFName` AS `JudgeFName`,`j`.`Details` AS `Details` from (`tbluser` `u` join `tbljudge` `j` on((`u`.`judgeid` = `j`.`JudgeID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-03-26 21:17:57
