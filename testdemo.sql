
CREATE DATABASE testdemo;


use testdemo;


SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for apploginlogs
-- ----------------------------
DROP TABLE IF EXISTS `apploginlogs`;
CREATE TABLE `apploginlogs`  (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `UserId` bigint(20) NOT NULL,
  `UserIP` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CreationTime` datetime NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

SET FOREIGN_KEY_CHECKS = 1;
