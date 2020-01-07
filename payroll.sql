/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50173
Source Host           : localhost:3306
Source Database       : payroll

Target Server Type    : MYSQL
Target Server Version : 50173
File Encoding         : 65001

Date: 2020-01-07 20:09:32
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
  `eid` int(11) NOT NULL,
  `etype` varchar(255) NOT NULL,
  `paytype` varchar(255) DEFAULT NULL,
  `salary` decimal(10,0) DEFAULT NULL,
  `ename` varchar(30) DEFAULT NULL,
  `accountnum` varchar(30) DEFAULT NULL,
  `address` varchar(30) DEFAULT NULL,
  `startdate` date DEFAULT NULL,
  PRIMARY KEY (`eid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for payrecord
-- ----------------------------
DROP TABLE IF EXISTS `payrecord`;
CREATE TABLE `payrecord` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date DEFAULT NULL,
  `eid` int(11) NOT NULL,
  `money` decimal(10,0) DEFAULT NULL,
  `paytype` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for record
-- ----------------------------
DROP TABLE IF EXISTS `record`;
CREATE TABLE `record` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `eid` int(11) NOT NULL,
  `date` date DEFAULT NULL,
  `count` int(11) DEFAULT NULL,
  `payed` int(11) DEFAULT '0',
  `paytype` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for timecard
-- ----------------------------
DROP TABLE IF EXISTS `timecard`;
CREATE TABLE `timecard` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `eid` int(11) NOT NULL,
  `hour` int(11) DEFAULT NULL,
  `payed` int(11) DEFAULT '0',
  `date` date DEFAULT NULL,
  `paytype` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
