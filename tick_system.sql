-- --------------------------------------------------------
-- 主機:                           127.0.0.1
-- 伺服器版本:                        10.5.0-MariaDB - mariadb.org binary distribution
-- 伺服器操作系統:                      Win64
-- HeidiSQL 版本:                  10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- 傾印 tick_system 的資料庫結構
CREATE DATABASE IF NOT EXISTS `tick_system` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `tick_system`;

-- 傾印  表格 tick_system.bug_report 結構
CREATE TABLE IF NOT EXISTS `bug_report` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `name` varchar(100) NOT NULL COMMENT 'BUG名稱',
  `state` int(11) NOT NULL DEFAULT 0 COMMENT '處理狀態(0:未處理、1:已處理)',
  `priority` int(11) NOT NULL DEFAULT 0 COMMENT '優先度(0:普通、1:嚴重)',
  `finish` varchar(20) DEFAULT NULL COMMENT '處理人員',
  `add_user` varchar(20) NOT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() COMMENT '新增時間',
  `edit_user` varchar(20) DEFAULT NULL COMMENT '修改者',
  `edit_time` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp() COMMENT '修改時間',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COMMENT='BGU資料主表';

-- 正在傾印表格  tick_system.bug_report 的資料：~0 rows (約數)
DELETE FROM `bug_report`;
/*!40000 ALTER TABLE `bug_report` DISABLE KEYS */;
INSERT INTO `bug_report` (`id`, `name`, `state`, `priority`, `finish`, `add_user`, `add_time`, `edit_user`, `edit_time`) VALUES
	(2, 'BUG1', 0, 0, NULL, 'QA', '2021-12-05 18:02:52', NULL, NULL);
/*!40000 ALTER TABLE `bug_report` ENABLE KEYS */;

-- 傾印  表格 tick_system.bug_report_detail 結構
CREATE TABLE IF NOT EXISTS `bug_report_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `bug_report_id` int(11) NOT NULL COMMENT '對應bug_report的ID',
  `describe` varchar(1000) NOT NULL COMMENT '說明',
  `add_user` varchar(20) NOT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() COMMENT '新增時間',
  `edit_user` varchar(20) DEFAULT NULL COMMENT '修改者',
  `edit_time` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp() COMMENT '修改時間',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COMMENT='BGU資料明細表';

-- 正在傾印表格  tick_system.bug_report_detail 的資料：~0 rows (約數)
DELETE FROM `bug_report_detail`;
/*!40000 ALTER TABLE `bug_report_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `bug_report_detail` ENABLE KEYS */;

-- 傾印  表格 tick_system.permission 結構
CREATE TABLE IF NOT EXISTS `permission` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `name` varchar(20) NOT NULL COMMENT 'QA、SA...等',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 COMMENT='權限';

-- 正在傾印表格  tick_system.permission 的資料：~0 rows (約數)
DELETE FROM `permission`;
/*!40000 ALTER TABLE `permission` DISABLE KEYS */;
INSERT INTO `permission` (`id`, `name`) VALUES
	(1, 'QA'),
	(2, 'RD'),
	(3, 'PM'),
	(4, 'Admin');
/*!40000 ALTER TABLE `permission` ENABLE KEYS */;

-- 傾印  表格 tick_system.require 結構
CREATE TABLE IF NOT EXISTS `require` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `name` varchar(100) NOT NULL COMMENT '案例名稱',
  `state` int(11) NOT NULL DEFAULT 0 COMMENT '處理狀態(0:未處理、1:已處理)',
  `finish` varchar(20) DEFAULT NULL COMMENT '處理人員',
  `add_user` varchar(20) NOT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() COMMENT '新增時間',
  `edit_user` varchar(20) DEFAULT NULL COMMENT '修改者',
  `edit_time` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp() COMMENT '修改時間',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COMMENT='功能要求主表';

-- 正在傾印表格  tick_system.require 的資料：~1 rows (約數)
DELETE FROM `require`;
/*!40000 ALTER TABLE `require` DISABLE KEYS */;
INSERT INTO `require` (`id`, `name`, `state`, `finish`, `add_user`, `add_time`, `edit_user`, `edit_time`) VALUES
	(2, 'QA', 0, 'RD', 'Admin', '2021-12-05 13:44:02', '', NULL);
/*!40000 ALTER TABLE `require` ENABLE KEYS */;

-- 傾印  表格 tick_system.require_detail 結構
CREATE TABLE IF NOT EXISTS `require_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `require_id` int(11) NOT NULL COMMENT '對應use_case的ID',
  `describe` varchar(1000) NOT NULL COMMENT '說明',
  `finish` varchar(20) DEFAULT NULL COMMENT '處理人員',
  `add_user` varchar(20) DEFAULT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() COMMENT '新增時間',
  `edit_user` varchar(20) DEFAULT NULL COMMENT '修改者',
  `edit_time` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp() COMMENT '修改時間',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COMMENT='功能要求明細表';

-- 正在傾印表格  tick_system.require_detail 的資料：~0 rows (約數)
DELETE FROM `require_detail`;
/*!40000 ALTER TABLE `require_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `require_detail` ENABLE KEYS */;

-- 傾印  表格 tick_system.user 結構
CREATE TABLE IF NOT EXISTS `user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `account` varchar(20) NOT NULL COMMENT '帳號',
  `password` varchar(20) NOT NULL COMMENT '密碼',
  `permission_id` int(11) NOT NULL COMMENT '權限(對應permission表ID)',
  `add_user` varchar(20) NOT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() COMMENT '新增時間',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 COMMENT='帳號';

-- 正在傾印表格  tick_system.user 的資料：~0 rows (約數)
DELETE FROM `user`;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`Id`, `account`, `password`, `permission_id`, `add_user`, `add_time`) VALUES
	(1, 'QA', 'QA', 1, 'Admin', '2021-12-05 13:51:08'),
	(2, 'RD', 'RD', 2, 'Admin', '2021-12-05 13:52:19'),
	(3, 'PM', 'PM', 3, 'Admin', '2021-12-05 13:52:43'),
	(4, 'Admin', 'Admin', 4, 'Admin', '2021-12-05 13:53:06');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

-- 傾印  表格 tick_system.use_case 結構
CREATE TABLE IF NOT EXISTS `use_case` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '流水號',
  `name` varchar(100) NOT NULL COMMENT '案例名稱',
  `state` int(11) NOT NULL DEFAULT 0 COMMENT '處理狀態(0:未處理、1:已處理)',
  `finish` varchar(20) DEFAULT NULL COMMENT '處理人員',
  `add_user` varchar(20) NOT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp() COMMENT '新增時間',
  `edit_user` varchar(20) DEFAULT NULL COMMENT '修改者',
  `edit_time` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp() COMMENT '修改時間',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COMMENT='使用案例資料主表';

-- 正在傾印表格  tick_system.use_case 的資料：~0 rows (約數)
DELETE FROM `use_case`;
/*!40000 ALTER TABLE `use_case` DISABLE KEYS */;
/*!40000 ALTER TABLE `use_case` ENABLE KEYS */;

-- 傾印  表格 tick_system.use_case_detail 結構
CREATE TABLE IF NOT EXISTS `use_case_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `use_case_id` int(11) NOT NULL COMMENT '對應use_case的ID',
  `describe` varchar(1000) NOT NULL COMMENT '說明',
  `add_user` varchar(20) NOT NULL COMMENT '新增者',
  `add_time` timestamp NOT NULL DEFAULT current_timestamp() COMMENT '新增時間',
  `edit_user` varchar(20) DEFAULT NULL COMMENT '修改者',
  `edit_time` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp() COMMENT '修改時間',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 COMMENT='使用案例資料明細表';

-- 正在傾印表格  tick_system.use_case_detail 的資料：~0 rows (約數)
DELETE FROM `use_case_detail`;
/*!40000 ALTER TABLE `use_case_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `use_case_detail` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
