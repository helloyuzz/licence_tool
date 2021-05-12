/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : localhost:3306
 Source Schema         : keycode

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 12/05/2021 14:15:02
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `department` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `role` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'admin=管理员,yw=运维',
  `ding_id` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '关联钉钉ID',
  `reg_time` datetime(0) NULL DEFAULT NULL COMMENT '注册日期',
  `login_time` datetime(0) NULL DEFAULT NULL COMMENT '最近登录',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 14 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES (1, '杨畅', '技术部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (2, '向振华', '运维部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (3, '敖宇阳', '总经办', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (4, '瞿前', '市场部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (5, '庞毅', '市场一部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (6, '曹茂霖', '信息中心', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (7, '杨畅', '质量部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (8, '刘益平', '客服部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (9, '邱超枫', '采购部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (10, '沈阳', '设计部', NULL, NULL, NULL, NULL);
INSERT INTO `employee` VALUES (11, '刘春', '产品部', NULL, NULL, NULL, NULL);

-- ----------------------------
-- Table structure for hibernate_sequence
-- ----------------------------
DROP TABLE IF EXISTS `hibernate_sequence`;
CREATE TABLE `hibernate_sequence`  (
  `next_val` bigint(0) NULL DEFAULT NULL
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Fixed;

-- ----------------------------
-- Records of hibernate_sequence
-- ----------------------------
INSERT INTO `hibernate_sequence` VALUES (2);

-- ----------------------------
-- Table structure for project
-- ----------------------------
DROP TABLE IF EXISTS `project`;
CREATE TABLE `project`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `project_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '项目名称',
  `fk_employee_id` int(0) NULL DEFAULT NULL COMMENT '实施负责员工Id',
  `sign_date` date NULL DEFAULT NULL COMMENT '合同签订日期',
  `finish_date` date NULL DEFAULT NULL COMMENT '预计完工日期',
  `step_index` int(0) NULL DEFAULT NULL COMMENT '当前进度',
  `unique_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '唯一业务代码',
  `project_desc` varchar(400) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '备注',
  `reg_date` date NULL DEFAULT NULL COMMENT '初次注册日期',
  `licence_date` date NULL DEFAULT NULL COMMENT '授权日期',
  `licence_day` int(0) NULL DEFAULT NULL COMMENT '授权可用天数',
  `hardware_info` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '硬件信息',
  `licence_code` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '授权码',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 17 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of project
-- ----------------------------
INSERT INTO `project` VALUES (1, '四川省中医', 1, '2020-01-13', '2020-01-13', 1, '7fbc0d98', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (2, '重医附一', 2, '2020-01-13', '2020-01-13', 1, 'E583A3C', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (3, 'aa', 11, '2020-01-13', '2020-01-13', 1, 'f005d34F', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (4, 'aaa', 1, '2020-01-13', '2020-01-13', 1, '9EfEeE1C', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (5, 'sadfasdf', 11, '2020-01-13', '2020-01-13', 1, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (6, 'asdfasf', 11, '2020-01-13', '2020-01-13', 1, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (7, 'asdfasdf', 11, '2020-01-13', '2020-01-13', 1, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (8, 'sdfasdf', 11, '2020-01-13', '2020-01-19', 1, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (9, 'sdfasdf', 11, '2020-01-13', '2020-01-19', 2, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (10, 'asdfadsf', 11, '2020-01-13', '2020-01-13', 2, '7fbc0d98', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (14, 'aa', 11, '2020-01-13', '2020-01-13', 2, '73bF04e1', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (15, 'aa', 11, '2020-01-12', '2020-01-12', 3, '61d42934', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (16, 'aa', 1, '2020-01-12', '2020-01-12', 3, '926Be376', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `project` VALUES (17, 'aa', 11, '2020-01-12', '2020-12-30', 3, '145BeB3C', '', NULL, NULL, NULL, NULL, NULL);

-- ----------------------------
-- Table structure for project_step
-- ----------------------------
DROP TABLE IF EXISTS `project_step`;
CREATE TABLE `project_step`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `step_index` int(0) NULL DEFAULT NULL,
  `step_content` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `step_thumb` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of project_step
-- ----------------------------
INSERT INTO `project_step` VALUES (1, 1, '新签', 'Icon_PaddingCode.png');
INSERT INTO `project_step` VALUES (2, 2, '待授权', 'Icon_New.png');
INSERT INTO `project_step` VALUES (9, 3, '实施', 'Icon_Default.png');
INSERT INTO `project_step` VALUES (14, 5, '售后', 'Icon_Default.png');

-- ----------------------------
-- Table structure for system_log
-- ----------------------------
DROP TABLE IF EXISTS `system_log`;
CREATE TABLE `system_log`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `fk_employee_id` int(0) NULL DEFAULT NULL COMMENT '员工Id',
  `type` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '日志类型，login=系统登陆,code=授权记录',
  `log_time` datetime(0) NULL DEFAULT NULL COMMENT '时间',
  `content` varchar(400) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '内容',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
