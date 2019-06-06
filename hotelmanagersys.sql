/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 50721
 Source Host           : localhost:3306
 Source Schema         : hotelmanagersys

 Target Server Type    : MySQL
 Target Server Version : 50721
 File Encoding         : 65001

 Date: 06/06/2019 15:43:45
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `ygxh` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ygmm` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('admin', '21232F297A57A5A743894A0E4A801F');

-- ----------------------------
-- Table structure for dishlist
-- ----------------------------
DROP TABLE IF EXISTS `dishlist`;
CREATE TABLE `dishlist`  (
  `DishId` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `DishName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Unit` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `Price` decimal(10, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`DishId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dishlist
-- ----------------------------
INSERT INTO `dishlist` VALUES ('1', '方便面', '桶', 10.00);
INSERT INTO `dishlist` VALUES ('2', '炒饭', '份', 20.00);
INSERT INTO `dishlist` VALUES ('3', '咖啡', '杯', 50.00);
INSERT INTO `dishlist` VALUES ('4', '炸鸡', '份', 40.00);
INSERT INTO `dishlist` VALUES ('5', '啤酒', '听', 8.00);
INSERT INTO `dishlist` VALUES ('6', '鲜炸果汁', '杯', 20.00);
INSERT INTO `dishlist` VALUES ('7', '冷热牛奶', '盒', 15.00);

-- ----------------------------
-- Table structure for guestrecord
-- ----------------------------
DROP TABLE IF EXISTS `guestrecord`;
CREATE TABLE `guestrecord`  (
  `lsh` varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `khxm` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `khxb` varchar(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sfzmhm` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `lxdh` varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `fjbh` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `rzzt` int(11) NULL DEFAULT NULL,
  `rzrq` datetime(0) NULL DEFAULT NULL,
  `rzts` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `rzyj` decimal(10, 2) NULL DEFAULT NULL,
  `qtxf` decimal(10, 2) NULL DEFAULT NULL,
  `zjxf` decimal(10, 2) NULL DEFAULT NULL,
  `ldrq` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`lsh`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of guestrecord
-- ----------------------------
INSERT INTO `guestrecord` VALUES ('1', 'xxy', '0', '654321199707090011', '17683089779', '1001', 2, '2019-05-16 11:44:00', '533818352', 100.00, 360.00, 360.00, '2019-05-18 21:01:14');
INSERT INTO `guestrecord` VALUES ('1190526412136', '1', '0', '1', '1', '1002', 0, '2019-05-26 16:40:27', '1', 1.00, NULL, NULL, '2019-05-27 16:40:27');
INSERT INTO `guestrecord` VALUES ('1190526626061', '1', '0', '1', '1', '1002', 0, '2019-05-26 16:39:24', '1', 1.00, NULL, NULL, '2019-05-27 16:39:24');
INSERT INTO `guestrecord` VALUES ('1190528728274', 'yyl', '0', '654321199707090016', '17683089779', '1001', 0, '2019-05-28 14:21:48', '2', 100.00, NULL, NULL, '2019-05-30 14:21:48');
INSERT INTO `guestrecord` VALUES ('1190529400376', '噢噢噢噢', '0', '1', '1', '1001', 0, '2019-05-29 13:28:23', '1', 1.00, NULL, NULL, '2019-05-30 13:28:23');
INSERT INTO `guestrecord` VALUES ('2', '肖旭阳', '0', '6543211111111111', '1231321321', '1002', 2, '2019-05-16 13:30:46', '1557905233', 100.00, 220.00, 360.00, '2019-05-16 16:41:00');
INSERT INTO `guestrecord` VALUES ('4', 'yyl', '0', '654222119702030015', '17683089999', '1003', 2, '2019-05-16 15:42:36', '2006572359', 200.00, 240.00, 0.00, '2019-05-16 15:52:09');

-- ----------------------------
-- Table structure for residestate
-- ----------------------------
DROP TABLE IF EXISTS `residestate`;
CREATE TABLE `residestate`  (
  `ResideId` int(11) NOT NULL AUTO_INCREMENT,
  `ResideName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ResideId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for room
-- ----------------------------
DROP TABLE IF EXISTS `room`;
CREATE TABLE `room`  (
  `fjbh` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `fjlx` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `fjzt` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `bz` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`fjbh`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of room
-- ----------------------------
INSERT INTO `room` VALUES ('1001', '1', '2', '商务单间');
INSERT INTO `room` VALUES ('1002', '2', '2', '豪华单间');
INSERT INTO `room` VALUES ('1003', '3', '2', '11');
INSERT INTO `room` VALUES ('1004', '1', '2', '11');

-- ----------------------------
-- Table structure for roomstate
-- ----------------------------
DROP TABLE IF EXISTS `roomstate`;
CREATE TABLE `roomstate`  (
  `RoomStateId` int(11) NOT NULL AUTO_INCREMENT,
  `RoomStateName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`RoomStateId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of roomstate
-- ----------------------------
INSERT INTO `roomstate` VALUES (1, '入住');
INSERT INTO `roomstate` VALUES (2, '空闲');
INSERT INTO `roomstate` VALUES (3, '维修');

-- ----------------------------
-- Table structure for roomtype
-- ----------------------------
DROP TABLE IF EXISTS `roomtype`;
CREATE TABLE `roomtype`  (
  `TypeId` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TypeName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `TypePrice` decimal(10, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`TypeId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of roomtype
-- ----------------------------
INSERT INTO `roomtype` VALUES ('1', '商务单人间', 180.00);
INSERT INTO `roomtype` VALUES ('2', '豪华单人间', 220.00);
INSERT INTO `roomtype` VALUES ('3', '商务标准间', 240.00);

-- ----------------------------
-- Table structure for syscode
-- ----------------------------
DROP TABLE IF EXISTS `syscode`;
CREATE TABLE `syscode`  (
  `dmlb` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `dmz` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `dmsm1` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `dmsm2` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `dmsm3` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `zt` varchar(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `bz` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of syscode
-- ----------------------------
INSERT INTO `syscode` VALUES ('1001', '1', '商务单人间', '180', NULL, '1', 'dmz：房间类型id，dmsm1：房间类型名称，dmsm2：入住一晚单价');
INSERT INTO `syscode` VALUES ('1001', '2', '豪华单人间', '200', NULL, '1', 'dmz：房间类型id，dmsm1：房间类型名称，dmsm2：入住一晚单价');
INSERT INTO `syscode` VALUES ('1002', '1', '入住', NULL, NULL, '1', NULL);
INSERT INTO `syscode` VALUES ('1002', '2', '空闲', NULL, NULL, '1', NULL);
INSERT INTO `syscode` VALUES ('1002', '3', '维修', NULL, NULL, '1', NULL);
INSERT INTO `syscode` VALUES ('1001', '3', '豪华双人间', '220', '', '1', 'dmz：房间类型id，dmsm1：房间类型名称，dmsm2：入住一晚单价');
INSERT INTO `syscode` VALUES ('1001', '4', '总统套房', '600', '', '1', 'dmz：房间类型id，dmsm1：房间类型名称，dmsm2：入住一晚单价');

-- ----------------------------
-- Table structure for usp_dishprice
-- ----------------------------
DROP TABLE IF EXISTS `usp_dishprice`;
CREATE TABLE `usp_dishprice`  (
  `year` int(255) NULL DEFAULT NULL,
  `month` int(255) NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for usp_money
-- ----------------------------
DROP TABLE IF EXISTS `usp_money`;
CREATE TABLE `usp_money`  (
  `year` int(255) NULL DEFAULT NULL,
  `month` int(255) NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Procedure structure for Addroom
-- ----------------------------
DROP PROCEDURE IF EXISTS `Addroom`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Addroom`(IN `roomid` VARCHAR(10),IN `roomtype` INT,IN `roomstate` INT,IN `describe` VARCHAR(20),IN `bednum` INT)
BEGIN
	INSERT into room(RoomId,RoomTypeId,RoomStateId,Description,BedNum) VALUES(`roomid`,`roomtype`,`roomstate`,`describe`,`bednum`);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for AddRoomType
-- ----------------------------
DROP PROCEDURE IF EXISTS `AddRoomType`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddRoomType`(IN `lxbh` VARCHAR(10),IN `lxmc` VARCHAR(10),IN `rzdj` VARCHAR(10))
BEGIN
	#Routine body goes here...
	insert into syscode(dmlb,dmz,dmsm1,dmsm2,dmsm3,zt,bz) 
	values('1001',`lxbh`,`lxmc`,`rzdj`,'','1','dmz：房间类型id，dmsm1：房间类型名称，dmsm2：入住一晚单价');
END
;;
delimiter ;

-- ----------------------------
-- Function structure for GetCodeMean
-- ----------------------------
DROP FUNCTION IF EXISTS `GetCodeMean`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetCodeMean`(`LB` VARCHAR(20),`DM` VARCHAR(20)) RETURNS varchar(50) CHARSET utf8
BEGIN
	DECLARE mean VARCHAR(50);
	SELECT dmsm1 FROM syscode WHERE dmz=`DM` AND dmlb=`LB` INTO MEAN;
	RETURN mean;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for GetFreeRoom
-- ----------------------------
DROP PROCEDURE IF EXISTS `GetFreeRoom`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetFreeRoom`()
BEGIN
	select t.fjlx lxbh,GetCodeMean('1001', t.fjlx) fjlx,COUNT(*)sl from room t where t.fjzt='2' GROUP BY lxbh;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Getroomcount
-- ----------------------------
DROP PROCEDURE IF EXISTS `Getroomcount`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Getroomcount`(IN `fjlx` INT)
BEGIN
	IF `fjlx`<>'0'	THEN
		SELECT count(*) sl from room t where t.fjlx=`fjlx`;
	ELSE
		SELECT count(*) sl from room t;
	END IF;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for GetRoomInfo
-- ----------------------------
DROP PROCEDURE IF EXISTS `GetRoomInfo`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRoomInfo`()
BEGIN
		select fjbh,GetCodeMean('1002',fjzt) fjzt,GetCodeMean('1001',fjlx) fjlx,bz from room;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for GetRoomInfoWithFjbh
-- ----------------------------
DROP PROCEDURE IF EXISTS `GetRoomInfoWithFjbh`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRoomInfoWithFjbh`(IN `roomid` VARCHAR(20))
BEGIN
	select fjbh,GetCodeMean('1002',fjzt) fjzt,GetCodeMean('1001',fjlx) fjlx,bz from room where fjbh=`roomid`;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for GetRoomStateCount
-- ----------------------------
DROP PROCEDURE IF EXISTS `GetRoomStateCount`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRoomStateCount`(IN `fjzt` VARCHAR(10),IN `fjlx` VARCHAR(10))
BEGIN
	IF `fjlx`='0' THEN
		select count(*) sl from Room where fjzt=`fjzt`;
	ELSE
		select count(*) sl from Room where fjzt=`fjzt` and fjbh=`fjlx`;
	END IF;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for InsertPrice
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertPrice`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertPrice`(IN `Price` int,IN `RoomId` INT)
BEGIN
	UPDATE guestrecord set DishPrice=DishPrice+`Price`where ResideId=1 and RoomId=`RoomId`;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Login
-- ----------------------------
DROP PROCEDURE IF EXISTS `Login`;
delimiter ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Login`(IN `ygxh` VARCHAR(20),IN `ygmm` varchar(50))
BEGIN
	select count(*) sl from Admin t where t.ygxh=`ygxh` and t.ygmm=`ygmm`;

END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
