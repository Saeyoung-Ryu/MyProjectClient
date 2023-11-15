/*
 Navicat MySQL Data Transfer

 Source Server         : local
 Source Server Type    : MySQL
 Source Server Version : 80033
 Source Host           : localhost:3306
 Source Schema         : Test

 Target Server Type    : MySQL
 Target Server Version : 80033
 File Encoding         : 65001

 Date: 15/11/2023 17:11:02
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for dumpLog
-- ----------------------------
DROP TABLE IF EXISTS `dumpLog`;
CREATE TABLE `dumpLog` (
  `seq` int NOT NULL AUTO_INCREMENT,
  `connectionString` varchar(255) NOT NULL,
  `tableName` varchar(60) NOT NULL,
  `time` datetime NOT NULL,
  PRIMARY KEY (`seq`)
) ENGINE=InnoDB AUTO_INCREMENT=644 DEFAULT CHARSET=utf8mb3;

-- ----------------------------
-- Records of dumpLog
-- ----------------------------
BEGIN;
INSERT INTO `dumpLog` VALUES (629, 'server=10.0.3.33', 'tblArtifactLevel', '2023-11-01 14:03:20');
INSERT INTO `dumpLog` VALUES (630, 'server=10.0.3.33', 'tblPackageSchedule', '2023-11-02 12:21:44');
INSERT INTO `dumpLog` VALUES (631, 'server=10.0.3.33', 'tblNotification', '2023-11-02 12:21:44');
INSERT INTO `dumpLog` VALUES (632, 'server=10.0.3.33', 'tblPackageBasic', '2023-11-08 12:37:02');
INSERT INTO `dumpLog` VALUES (633, 'server=10.0.3.33', 'tblPackageSchedule', '2023-11-08 12:37:02');
INSERT INTO `dumpLog` VALUES (634, 'server=10.0.3.33', 'tblTournamentParticipateBatter', '2023-11-08 17:49:35');
INSERT INTO `dumpLog` VALUES (635, 'server=10.0.3.33', 'tblTournamentBasic', '2023-11-08 17:49:35');
INSERT INTO `dumpLog` VALUES (636, 'server=10.0.3.33', 'tblTournament', '2023-11-08 17:49:35');
INSERT INTO `dumpLog` VALUES (637, 'server=10.0.3.33', 'tblTournamentStarReward', '2023-11-08 17:49:35');
INSERT INTO `dumpLog` VALUES (638, 'server=10.0.3.33', 'tblRockPaperScissorsBasic', '2023-11-09 11:36:12');
INSERT INTO `dumpLog` VALUES (639, 'server=10.0.3.33', 'tblNotification', '2023-11-10 19:05:18');
INSERT INTO `dumpLog` VALUES (640, 'server=10.0.3.33', 'tblCardReward', '2023-11-13 11:01:26');
INSERT INTO `dumpLog` VALUES (641, 'server=10.0.3.33', 'tblCardRewardClassGrade', '2023-11-13 11:01:26');
INSERT INTO `dumpLog` VALUES (642, 'server=10.0.3.33', 'tblCardRewardStadiumGrade', '2023-11-13 11:01:26');
INSERT INTO `dumpLog` VALUES (643, 'server=10.0.3.33', 'tblHomerunEventSchedule', '2023-11-14 11:48:07');
COMMIT;

-- ----------------------------
-- Table structure for major
-- ----------------------------
DROP TABLE IF EXISTS `major`;
CREATE TABLE `major` (
  `seq` int NOT NULL AUTO_INCREMENT,
  `championBasicId` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `nameKR` varchar(255) DEFAULT NULL,
  `line` varchar(255) NOT NULL,
  PRIMARY KEY (`seq`),
  UNIQUE KEY `ChampBaiscId` (`championBasicId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=172 DEFAULT CHARSET=utf8mb3;

-- ----------------------------
-- Records of major
-- ----------------------------
BEGIN;
INSERT INTO `major` VALUES (10, 266, 'Aatrox', '아트록스', '5,3');
INSERT INTO `major` VALUES (11, 103, 'Ahri', '아리', '3');
INSERT INTO `major` VALUES (12, 84, 'Akali', '아칼리', '5,3');
INSERT INTO `major` VALUES (13, 166, 'Akshan', '아크샨', '5,3');
INSERT INTO `major` VALUES (14, 12, 'Alistar', '알리스타', '1');
INSERT INTO `major` VALUES (15, 32, 'Amumu', '아무무', '4,1');
INSERT INTO `major` VALUES (16, 34, 'Anivia', '애니비아', '3');
INSERT INTO `major` VALUES (17, 1, 'Annie', '애니', '3');
INSERT INTO `major` VALUES (18, 523, 'Aphelios', '아펠리오스', '2');
INSERT INTO `major` VALUES (19, 22, 'Ashe', '애쉬', '2');
INSERT INTO `major` VALUES (20, 136, 'Aurelion Sol', '아우렐리온 솔', '3');
INSERT INTO `major` VALUES (21, 268, 'Azir', '아지르', '3');
INSERT INTO `major` VALUES (22, 432, 'Bard', '바드', '1');
INSERT INTO `major` VALUES (23, 200, 'Bel\'Veth', '벨베스', '4');
INSERT INTO `major` VALUES (24, 53, 'Blitzcrank', '블리츠크랭크', '1');
INSERT INTO `major` VALUES (25, 63, 'Brand', '브랜드', '3,1');
INSERT INTO `major` VALUES (26, 201, 'Braum', '브라움', '1');
INSERT INTO `major` VALUES (27, 51, 'Caitlyn', '케이틀린', '2');
INSERT INTO `major` VALUES (28, 164, 'Camille', '카밀', '5,4');
INSERT INTO `major` VALUES (29, 69, 'Cassiopeia', '카시오페아', '5,3,2');
INSERT INTO `major` VALUES (30, 31, 'Cho\'Gath', '초가스', '5');
INSERT INTO `major` VALUES (31, 42, 'Corki', '코르키', '2');
INSERT INTO `major` VALUES (32, 122, 'Darius', '다리우스', '5');
INSERT INTO `major` VALUES (33, 131, 'Diana', '다이애나', '4,3');
INSERT INTO `major` VALUES (34, 119, 'Draven', '드레이븐', '2');
INSERT INTO `major` VALUES (35, 36, 'Dr. Mundo', '문도', '5,4');
INSERT INTO `major` VALUES (36, 245, 'Ekko', '에코', '4,3');
INSERT INTO `major` VALUES (37, 60, 'Elise', '엘리스', '4');
INSERT INTO `major` VALUES (38, 28, 'Evelynn', '이블린', '4');
INSERT INTO `major` VALUES (39, 81, 'Ezreal', '이즈리얼', '2');
INSERT INTO `major` VALUES (40, 9, 'Fiddlesticks', '피들스틱', '4');
INSERT INTO `major` VALUES (41, 114, 'Fiora', '피오라', '5');
INSERT INTO `major` VALUES (42, 105, 'Fizz', '피즈', '3');
INSERT INTO `major` VALUES (43, 3, 'Galio', '갈리오', '3,1');
INSERT INTO `major` VALUES (44, 41, 'Gangplank', '갱플랭크', '5');
INSERT INTO `major` VALUES (45, 86, 'Garen', '가렌', '5');
INSERT INTO `major` VALUES (46, 150, 'Gnar', '나르', '5');
INSERT INTO `major` VALUES (47, 79, 'Gragas', '그라가스', '5,4,3,1');
INSERT INTO `major` VALUES (48, 104, 'Graves', '그레이브즈', '5,4');
INSERT INTO `major` VALUES (49, 887, 'Gwen', '그웬', '5,4');
INSERT INTO `major` VALUES (50, 120, 'Hecarim', '헤카림', '5,4');
INSERT INTO `major` VALUES (51, 74, 'Heimerdinger', '하이머딩거', '5,1');
INSERT INTO `major` VALUES (52, 420, 'Illaoi', '일라오이', '5');
INSERT INTO `major` VALUES (53, 39, 'Irelia', '이렐리아', '5,3');
INSERT INTO `major` VALUES (54, 427, 'Ivern', '아이번', '4,1');
INSERT INTO `major` VALUES (55, 40, 'Janna', '잔나', '1');
INSERT INTO `major` VALUES (56, 59, 'Jarvan IV', '자르반 4세', '4');
INSERT INTO `major` VALUES (57, 24, 'Jax', '잭스', '5,4');
INSERT INTO `major` VALUES (58, 126, 'Jayce', '제이스', '5');
INSERT INTO `major` VALUES (59, 202, 'Jhin', '진', '2');
INSERT INTO `major` VALUES (60, 222, 'Jinx', '징크스', '2');
INSERT INTO `major` VALUES (61, 145, 'Kai\'Sa', '카이사', '2');
INSERT INTO `major` VALUES (62, 429, 'Kalista', '칼리스타', '5,2');
INSERT INTO `major` VALUES (63, 43, 'Karma', '카르마', '3,1');
INSERT INTO `major` VALUES (64, 30, 'Karthus', '카서스', '4,3');
INSERT INTO `major` VALUES (65, 38, 'Kassadin', '카사딘', '3');
INSERT INTO `major` VALUES (66, 55, 'Katarina', '카타리나', '3');
INSERT INTO `major` VALUES (67, 10, 'Kayle', '케일', '5');
INSERT INTO `major` VALUES (68, 141, 'Kayn', '케인', '4');
INSERT INTO `major` VALUES (69, 85, 'Kennen', '케넨', '5');
INSERT INTO `major` VALUES (70, 121, 'Kha\'Zix', '카직스', '4');
INSERT INTO `major` VALUES (71, 203, 'Kindred', '킨드레드', '4');
INSERT INTO `major` VALUES (72, 240, 'Kled', '클레드', '5');
INSERT INTO `major` VALUES (73, 96, 'Kog\'Maw', '코그모', '2');
INSERT INTO `major` VALUES (74, 897, 'K\'Sante', '크샨테', '5');
INSERT INTO `major` VALUES (75, 7, 'LeBlanc', '르블랑', '3');
INSERT INTO `major` VALUES (76, 64, 'Lee Sin', '리신', '5,4');
INSERT INTO `major` VALUES (77, 89, 'Leona', '레오나', '1');
INSERT INTO `major` VALUES (78, 876, 'Lillia', '릴리아', '5,4');
INSERT INTO `major` VALUES (79, 127, 'Lissandra', '리산드라', '3');
INSERT INTO `major` VALUES (80, 236, 'Lucian', '루시안', '3,2');
INSERT INTO `major` VALUES (81, 117, 'Lulu', '룰루', '5');
INSERT INTO `major` VALUES (82, 99, 'Lux', '럭스', '3,1');
INSERT INTO `major` VALUES (83, 54, 'Malphite', '말파이트', '5');
INSERT INTO `major` VALUES (84, 90, 'Malzahar', '말자하', '3');
INSERT INTO `major` VALUES (85, 57, 'Maokai', '마오카이', '5,4,1');
INSERT INTO `major` VALUES (86, 11, 'Master Yi', '마스터 이', '4');
INSERT INTO `major` VALUES (87, 21, 'Miss Fortune', '미스포츈', '2,1');
INSERT INTO `major` VALUES (88, 62, 'Wukong', '오공', '5,4');
INSERT INTO `major` VALUES (89, 82, 'Mordekaiser', '모데카이저', '5,4');
INSERT INTO `major` VALUES (90, 25, 'Morgana', '모르가나', '3,1');
INSERT INTO `major` VALUES (91, 267, 'Nami', '나미', '1');
INSERT INTO `major` VALUES (92, 75, 'Nasus', '나서스', '5,4');
INSERT INTO `major` VALUES (93, 111, 'Nautilus', '노틸러스', '1');
INSERT INTO `major` VALUES (94, 518, 'Neeko', '니코', '3,1');
INSERT INTO `major` VALUES (95, 76, 'Nidalee', '니달리', '4');
INSERT INTO `major` VALUES (96, 895, 'Nilah', '닐라', '2');
INSERT INTO `major` VALUES (97, 56, 'Nocturne', '녹턴', '5,4');
INSERT INTO `major` VALUES (98, 20, 'Nunu & Willump', '누누', '4');
INSERT INTO `major` VALUES (99, 2, 'Olaf', '올라프', '5,4');
INSERT INTO `major` VALUES (100, 61, 'Orianna', '오리아나', '3');
INSERT INTO `major` VALUES (101, 516, 'Ornn', '오른', '5');
INSERT INTO `major` VALUES (102, 80, 'Pantheon', '판테온', '5,3,1');
INSERT INTO `major` VALUES (103, 78, 'Poppy', '뽀삐', '5,4');
INSERT INTO `major` VALUES (104, 555, 'Pyke', '파이크', '1');
INSERT INTO `major` VALUES (105, 246, 'Qiyana', '키아나', '4,3');
INSERT INTO `major` VALUES (106, 133, 'Quinn', '퀸', '5');
INSERT INTO `major` VALUES (107, 497, 'Rakan', '라칸', '1');
INSERT INTO `major` VALUES (108, 33, 'Rammus', '람머스', '4');
INSERT INTO `major` VALUES (109, 421, 'Rek\'Sai', '렉사이', '4');
INSERT INTO `major` VALUES (110, 526, 'Rell', '렐', '1');
INSERT INTO `major` VALUES (111, 888, 'Renata Glasc', '레나크 글라스크', '1');
INSERT INTO `major` VALUES (112, 58, 'Renekton', '레넥톤', '5');
INSERT INTO `major` VALUES (113, 107, 'Rengar', '렝가', '5,4');
INSERT INTO `major` VALUES (114, 92, 'Riven', '리븐', '5');
INSERT INTO `major` VALUES (115, 68, 'Rumble', '럼블', '5,4,3');
INSERT INTO `major` VALUES (116, 13, 'Ryze', '라이즈', '5,3');
INSERT INTO `major` VALUES (117, 360, 'Samira', '사미라', '2');
INSERT INTO `major` VALUES (118, 113, 'Sejuani', '세주아니', '5,4');
INSERT INTO `major` VALUES (119, 235, 'Senna', '세나', '2,1');
INSERT INTO `major` VALUES (120, 147, 'Seraphine', '세라핀', '1');
INSERT INTO `major` VALUES (121, 875, 'Sett', '세트', '5,1');
INSERT INTO `major` VALUES (122, 35, 'Shaco', '샤코', '4,1');
INSERT INTO `major` VALUES (123, 98, 'Shen', '쉔', '5');
INSERT INTO `major` VALUES (124, 102, 'Shyvana', '쉬바나', '5,4');
INSERT INTO `major` VALUES (125, 27, 'Singed', '신지드', '5,3');
INSERT INTO `major` VALUES (126, 14, 'Sion', '사이온', '5');
INSERT INTO `major` VALUES (127, 15, 'Sivir', '시비르', '2');
INSERT INTO `major` VALUES (128, 72, 'Skarner', '스카너', '4');
INSERT INTO `major` VALUES (129, 37, 'Sona', '소나', '1');
INSERT INTO `major` VALUES (130, 16, 'Soraka', '소라카', '1');
INSERT INTO `major` VALUES (131, 50, 'Swain', '스웨인', '3,2,1');
INSERT INTO `major` VALUES (132, 517, 'Sylas', '사일러스', '5,4,3');
INSERT INTO `major` VALUES (133, 134, 'Syndra', '신드라', '3');
INSERT INTO `major` VALUES (134, 223, 'Tahm Kench', '탐켄치', '5,1');
INSERT INTO `major` VALUES (135, 163, 'Taliyah', '탈리아', '4,3');
INSERT INTO `major` VALUES (136, 91, 'Talon', '탈론', '4,3');
INSERT INTO `major` VALUES (137, 44, 'Taric', '타릭', '1');
INSERT INTO `major` VALUES (138, 17, 'Teemo', '티모', '2');
INSERT INTO `major` VALUES (139, 412, 'Thresh', '쓰레쉬', '1');
INSERT INTO `major` VALUES (140, 18, 'Tristana', '트리스타나', '2');
INSERT INTO `major` VALUES (141, 48, 'Trundle', '트런들', '5,4');
INSERT INTO `major` VALUES (142, 23, 'Tryndamere', '트린다미어', '5');
INSERT INTO `major` VALUES (143, 4, 'Twisted Fate', '트위스티드 페이트', '3');
INSERT INTO `major` VALUES (144, 29, 'Twitch', '트위치', '2');
INSERT INTO `major` VALUES (145, 77, 'Udyr', '우디르', '4');
INSERT INTO `major` VALUES (146, 6, 'Urgot', '우르곳', '5');
INSERT INTO `major` VALUES (147, 110, 'Varus', '바루스', '2');
INSERT INTO `major` VALUES (148, 67, 'Vayne', '베인', '5,2');
INSERT INTO `major` VALUES (149, 45, 'Veigar', '베이가', '3');
INSERT INTO `major` VALUES (150, 161, 'Vel\'Koz', '벨코즈', '3,1');
INSERT INTO `major` VALUES (151, 711, 'Vex', '백스', '3');
INSERT INTO `major` VALUES (152, 254, 'Vi', '바이', '4');
INSERT INTO `major` VALUES (153, 234, 'Viego', '비에고', '4');
INSERT INTO `major` VALUES (154, 112, 'Viktor', '빅토르', '3');
INSERT INTO `major` VALUES (155, 8, 'Vladimir', '블라디미르', '5,3');
INSERT INTO `major` VALUES (156, 106, 'Volibear', '볼리베어', '5,4');
INSERT INTO `major` VALUES (157, 19, 'Warwick', '워윅', '5,4');
INSERT INTO `major` VALUES (158, 498, 'Xayah', '자야', '2');
INSERT INTO `major` VALUES (159, 101, 'Xerath', '제라스', '3,1');
INSERT INTO `major` VALUES (160, 5, 'Xin Zhao', '신짜오', '4');
INSERT INTO `major` VALUES (161, 157, 'Yasuo', '야스오', '5,3,2');
INSERT INTO `major` VALUES (162, 777, 'Yone', '요네', '5,3');
INSERT INTO `major` VALUES (163, 83, 'Yorick', '요릭', '5');
INSERT INTO `major` VALUES (164, 350, 'Yuumi', '유미', '1');
INSERT INTO `major` VALUES (165, 154, 'Zac', '자크', '5,4,1');
INSERT INTO `major` VALUES (166, 238, 'Zed', '제드', '4,3');
INSERT INTO `major` VALUES (167, 221, 'Zeri', '제리', '2');
INSERT INTO `major` VALUES (168, 115, 'Ziggs', '직스', '3,2');
INSERT INTO `major` VALUES (169, 26, 'Zilean', '질리언', '1');
INSERT INTO `major` VALUES (170, 142, 'Zoe', '조이', '3');
INSERT INTO `major` VALUES (171, 143, 'Zyra', '자이라', '1');
COMMIT;

-- ----------------------------
-- Table structure for tblLogMatchHistory
-- ----------------------------
DROP TABLE IF EXISTS `tblLogMatchHistory`;
CREATE TABLE `tblLogMatchHistory` (
  `seq` int NOT NULL AUTO_INCREMENT,
  `team1Data` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `team2Data` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `time` datetime NOT NULL,
  `team1Win` int NOT NULL DEFAULT '-1',
  `team2WIn` int NOT NULL DEFAULT '-1',
  PRIMARY KEY (`seq`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of tblLogMatchHistory
-- ----------------------------
BEGIN;
INSERT INTO `tblLogMatchHistory` VALUES (1, 'w, r, t, qwerr, u', 'e, i, p, o, y', '2023-11-09 18:47:38', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (2, 'e, i, p, o, y', 'w, r, t, qwerr, u', '2023-11-09 18:47:38', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (3, 'w, r, t, qwerr, u', 'e, i, p, o, y', '2023-11-09 18:47:38', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (4, 'e, i, p, o, y', 'w, r, t, qwerr, u', '2023-11-09 18:47:39', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (5, 'w, r, t, qwerr, u', 'e, i, p, o, y', '2023-11-09 18:47:39', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (6, 'e, i, p, o, y', 'w, r, t, qwerr, u', '2023-11-09 18:47:39', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (7, 'w, r, t, qwerr, u', 'e, i, p, o, y', '2023-11-09 18:47:39', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (8, 'e, i, p, o, y', 'w, r, t, qwerr, u', '2023-11-09 18:47:39', -1, -1);
INSERT INTO `tblLogMatchHistory` VALUES (9, 'w, r, t, qwerr, u', 'e, i, p, o, y', '2023-11-09 18:47:39', 1, -1);
COMMIT;

-- ----------------------------
-- Table structure for tblRankHistory
-- ----------------------------
DROP TABLE IF EXISTS `tblRankHistory`;
CREATE TABLE `tblRankHistory` (
  `seq` int NOT NULL AUTO_INCREMENT,
  `userSeq` int NOT NULL,
  `time` datetime NOT NULL,
  `ranking` int NOT NULL,
  `winRate` decimal(11,2) NOT NULL,
  PRIMARY KEY (`seq`),
  UNIQUE KEY `userNameTimeIdx` (`userSeq`,`time`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of tblRankHistory
-- ----------------------------
BEGIN;
INSERT INTO `tblRankHistory` VALUES (12, 79, '2023-11-09 09:28:12', 1, 55.30);
INSERT INTO `tblRankHistory` VALUES (13, 81, '2023-11-09 09:28:12', 2, 55.30);
INSERT INTO `tblRankHistory` VALUES (14, 82, '2023-11-09 09:28:12', 3, 55.30);
INSERT INTO `tblRankHistory` VALUES (15, 85, '2023-11-09 09:28:12', 4, 55.30);
INSERT INTO `tblRankHistory` VALUES (16, 86, '2023-11-09 09:28:12', 5, 55.30);
INSERT INTO `tblRankHistory` VALUES (17, 77, '2023-11-09 09:28:12', 6, 44.70);
INSERT INTO `tblRankHistory` VALUES (18, 78, '2023-11-09 09:28:12', 7, 44.70);
INSERT INTO `tblRankHistory` VALUES (19, 80, '2023-11-09 09:28:12', 8, 44.70);
INSERT INTO `tblRankHistory` VALUES (20, 83, '2023-11-09 09:28:12', 9, 44.70);
INSERT INTO `tblRankHistory` VALUES (21, 84, '2023-11-09 09:28:12', 10, 44.70);
INSERT INTO `tblRankHistory` VALUES (22, 80, '2023-11-09 09:38:22', 1, 100.00);
INSERT INTO `tblRankHistory` VALUES (23, 81, '2023-11-09 09:38:22', 2, 100.00);
INSERT INTO `tblRankHistory` VALUES (24, 83, '2023-11-09 09:38:22', 3, 100.00);
INSERT INTO `tblRankHistory` VALUES (25, 85, '2023-11-09 09:38:22', 4, 100.00);
INSERT INTO `tblRankHistory` VALUES (26, 86, '2023-11-09 09:38:22', 5, 100.00);
INSERT INTO `tblRankHistory` VALUES (27, 77, '2023-11-09 09:38:22', 6, 0.00);
INSERT INTO `tblRankHistory` VALUES (28, 78, '2023-11-09 09:38:22', 7, 0.00);
INSERT INTO `tblRankHistory` VALUES (29, 79, '2023-11-09 09:38:22', 8, 0.00);
INSERT INTO `tblRankHistory` VALUES (30, 82, '2023-11-09 09:38:22', 9, 0.00);
INSERT INTO `tblRankHistory` VALUES (31, 84, '2023-11-09 09:38:22', 10, 0.00);
INSERT INTO `tblRankHistory` VALUES (32, 79, '2023-11-09 09:39:21', 1, 100.00);
INSERT INTO `tblRankHistory` VALUES (33, 82, '2023-11-09 09:39:21', 2, 100.00);
INSERT INTO `tblRankHistory` VALUES (34, 83, '2023-11-09 09:39:21', 3, 100.00);
INSERT INTO `tblRankHistory` VALUES (35, 84, '2023-11-09 09:39:21', 4, 100.00);
INSERT INTO `tblRankHistory` VALUES (36, 86, '2023-11-09 09:39:21', 5, 100.00);
INSERT INTO `tblRankHistory` VALUES (37, 77, '2023-11-09 09:39:21', 6, 0.00);
INSERT INTO `tblRankHistory` VALUES (38, 78, '2023-11-09 09:39:21', 7, 0.00);
INSERT INTO `tblRankHistory` VALUES (39, 80, '2023-11-09 09:39:21', 8, 0.00);
INSERT INTO `tblRankHistory` VALUES (40, 81, '2023-11-09 09:39:21', 9, 0.00);
INSERT INTO `tblRankHistory` VALUES (41, 85, '2023-11-09 09:39:21', 10, 0.00);
INSERT INTO `tblRankHistory` VALUES (42, 81, '2023-11-09 09:40:55', 1, 100.00);
INSERT INTO `tblRankHistory` VALUES (43, 82, '2023-11-09 09:40:55', 2, 100.00);
INSERT INTO `tblRankHistory` VALUES (44, 83, '2023-11-09 09:40:55', 3, 100.00);
INSERT INTO `tblRankHistory` VALUES (45, 84, '2023-11-09 09:40:55', 4, 100.00);
INSERT INTO `tblRankHistory` VALUES (46, 85, '2023-11-09 09:40:55', 5, 100.00);
INSERT INTO `tblRankHistory` VALUES (47, 77, '2023-11-09 09:40:55', 6, 0.00);
INSERT INTO `tblRankHistory` VALUES (48, 78, '2023-11-09 09:40:55', 7, 0.00);
INSERT INTO `tblRankHistory` VALUES (49, 79, '2023-11-09 09:40:55', 8, 0.00);
INSERT INTO `tblRankHistory` VALUES (50, 80, '2023-11-09 09:40:55', 9, 0.00);
INSERT INTO `tblRankHistory` VALUES (51, 86, '2023-11-09 09:40:55', 10, 0.00);
INSERT INTO `tblRankHistory` VALUES (52, 77, '2023-11-09 09:43:33', 1, 100.00);
INSERT INTO `tblRankHistory` VALUES (53, 79, '2023-11-09 09:43:33', 2, 100.00);
INSERT INTO `tblRankHistory` VALUES (54, 80, '2023-11-09 09:43:33', 3, 100.00);
INSERT INTO `tblRankHistory` VALUES (55, 82, '2023-11-09 09:43:33', 4, 100.00);
INSERT INTO `tblRankHistory` VALUES (56, 83, '2023-11-09 09:43:33', 5, 100.00);
INSERT INTO `tblRankHistory` VALUES (57, 78, '2023-11-09 09:43:33', 6, 0.00);
INSERT INTO `tblRankHistory` VALUES (58, 81, '2023-11-09 09:43:33', 7, 0.00);
INSERT INTO `tblRankHistory` VALUES (59, 84, '2023-11-09 09:43:33', 8, 0.00);
INSERT INTO `tblRankHistory` VALUES (60, 85, '2023-11-09 09:43:33', 9, 0.00);
INSERT INTO `tblRankHistory` VALUES (61, 86, '2023-11-09 09:43:33', 10, 0.00);
INSERT INTO `tblRankHistory` VALUES (62, 77, '2023-11-09 09:47:02', 1, 100.00);
INSERT INTO `tblRankHistory` VALUES (63, 82, '2023-11-09 09:47:02', 2, 100.00);
INSERT INTO `tblRankHistory` VALUES (64, 83, '2023-11-09 09:47:02', 3, 100.00);
INSERT INTO `tblRankHistory` VALUES (65, 85, '2023-11-09 09:47:02', 4, 100.00);
INSERT INTO `tblRankHistory` VALUES (66, 86, '2023-11-09 09:47:02', 5, 100.00);
INSERT INTO `tblRankHistory` VALUES (67, 78, '2023-11-09 09:47:02', 6, 0.00);
INSERT INTO `tblRankHistory` VALUES (68, 79, '2023-11-09 09:47:02', 7, 0.00);
INSERT INTO `tblRankHistory` VALUES (69, 80, '2023-11-09 09:47:02', 8, 0.00);
INSERT INTO `tblRankHistory` VALUES (70, 81, '2023-11-09 09:47:02', 9, 0.00);
INSERT INTO `tblRankHistory` VALUES (71, 84, '2023-11-09 09:47:02', 10, 0.00);
COMMIT;

-- ----------------------------
-- Table structure for tblUserInfo
-- ----------------------------
DROP TABLE IF EXISTS `tblUserInfo`;
CREATE TABLE `tblUserInfo` (
  `seq` int NOT NULL AUTO_INCREMENT,
  `userName` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `createTime` datetime NOT NULL,
  PRIMARY KEY (`seq`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of tblUserInfo
-- ----------------------------
BEGIN;
INSERT INTO `tblUserInfo` VALUES (76, '코스피4000가즈아앗', '2023-06-15 11:19:53');
INSERT INTO `tblUserInfo` VALUES (77, 'qwerr', '2023-06-15 11:30:13');
INSERT INTO `tblUserInfo` VALUES (78, 'w', '2023-06-15 11:30:15');
INSERT INTO `tblUserInfo` VALUES (79, 'e', '2023-06-15 11:30:16');
INSERT INTO `tblUserInfo` VALUES (80, 'r', '2023-06-15 11:30:18');
INSERT INTO `tblUserInfo` VALUES (81, 't', '2023-06-15 11:30:21');
INSERT INTO `tblUserInfo` VALUES (82, 'y', '2023-06-15 11:30:23');
INSERT INTO `tblUserInfo` VALUES (83, 'u', '2023-06-15 11:30:24');
INSERT INTO `tblUserInfo` VALUES (84, 'i', '2023-06-15 11:30:27');
INSERT INTO `tblUserInfo` VALUES (85, 'o', '2023-06-15 11:30:29');
INSERT INTO `tblUserInfo` VALUES (86, 'p', '2023-06-15 11:30:31');
INSERT INTO `tblUserInfo` VALUES (87, 'blasion', '2023-11-01 15:00:01');
COMMIT;

-- ----------------------------
-- Table structure for tblUserWinnrateHistory
-- ----------------------------
DROP TABLE IF EXISTS `tblUserWinnrateHistory`;
CREATE TABLE `tblUserWinnrateHistory` (
  `userSeq` int NOT NULL,
  `lineType` int NOT NULL,
  `winCount` int NOT NULL,
  `loseCount` int NOT NULL,
  UNIQUE KEY `IdxUserSeqLinType` (`userSeq`,`lineType`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ----------------------------
-- Records of tblUserWinnrateHistory
-- ----------------------------
BEGIN;
INSERT INTO `tblUserWinnrateHistory` VALUES (76, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (76, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (76, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (76, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (76, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (76, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (77, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (77, 2, 1, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (77, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (77, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (77, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (77, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (78, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (78, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (78, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (78, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (78, 5, 1, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (78, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (79, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (79, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (79, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (79, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (79, 5, 0, 1);
INSERT INTO `tblUserWinnrateHistory` VALUES (79, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (80, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (80, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (80, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (80, 4, 1, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (80, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (80, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (81, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (81, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (81, 3, 1, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (81, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (81, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (81, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (82, 1, 0, 1);
INSERT INTO `tblUserWinnrateHistory` VALUES (82, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (82, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (82, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (82, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (82, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (83, 1, 1, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (83, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (83, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (83, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (83, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (83, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (84, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (84, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (84, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (84, 4, 0, 1);
INSERT INTO `tblUserWinnrateHistory` VALUES (84, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (84, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (85, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (85, 2, 0, 1);
INSERT INTO `tblUserWinnrateHistory` VALUES (85, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (85, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (85, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (85, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (86, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (86, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (86, 3, 0, 1);
INSERT INTO `tblUserWinnrateHistory` VALUES (86, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (86, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (86, 6, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (87, 1, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (87, 2, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (87, 3, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (87, 4, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (87, 5, 0, 0);
INSERT INTO `tblUserWinnrateHistory` VALUES (87, 6, 0, 0);
COMMIT;

-- ----------------------------
-- Procedure structure for spGetLogMatchHistoryList
-- ----------------------------
DROP PROCEDURE IF EXISTS `spGetLogMatchHistoryList`;
delimiter ;;
CREATE PROCEDURE `spGetLogMatchHistoryList`()
BEGIN
    SELECT * FROM tblLogMatchHistory ORDER BY seq DESC LIMIT 100;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spGetUserInfo
-- ----------------------------
DROP PROCEDURE IF EXISTS `spGetUserInfo`;
delimiter ;;
CREATE PROCEDURE `spGetUserInfo`(_userName VARCHAR(255))
BEGIN
    SELECT * FROM tblUserInfo 
    WHERE userName LIKE CONCAT(_userName, '%') 
    ORDER BY LENGTH(userName), userName
    LIMIT 1;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spGetUserWinRateHistory
-- ----------------------------
DROP PROCEDURE IF EXISTS `spGetUserWinRateHistory`;
delimiter ;;
CREATE PROCEDURE `spGetUserWinRateHistory`(_userSeq int)
BEGIN
    select * from tblUserWinnrateHistory where userSeq = _userSeq;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spInsertLogMatchHistory
-- ----------------------------
DROP PROCEDURE IF EXISTS `spInsertLogMatchHistory`;
delimiter ;;
CREATE PROCEDURE `spInsertLogMatchHistory`(_team1Data varchar(255), _team2Data varchar(255), _team1Win int, _team2Win int)
BEGIN
    INSERT INTO tblLogMatchHistory (team1Data, team2Data, time, team1Win, team2Win)
    VALUES (_team1Data, _team2Data, NOW(), _team1Win, _team2Win);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spInsertUserInfo
-- ----------------------------
DROP PROCEDURE IF EXISTS `spInsertUserInfo`;
delimiter ;;
CREATE PROCEDURE `spInsertUserInfo`(_userName VARCHAR(255))
BEGIN
    INSERT INTO tblUserInfo (userName, createTime)
    VALUES (_userName, NOW());
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spInsertUserWinnrateHistory
-- ----------------------------
DROP PROCEDURE IF EXISTS `spInsertUserWinnrateHistory`;
delimiter ;;
CREATE PROCEDURE `spInsertUserWinnrateHistory`(_userSeq int, _lineType int, _winCount int, _loseCount int)
BEGIN
    INSERT INTO tblUserWinnrateHistory (userSeq, lineType, winCount, loseCount)
    VALUES (_userSeq, _lineType, _winCount, _loseCount)
		on duplicate key update
		`winCount` = _winCount,
		`loseCount` = _loseCount;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spResetRank
-- ----------------------------
DROP PROCEDURE IF EXISTS `spResetRank`;
delimiter ;;
CREATE PROCEDURE `spResetRank`()
BEGIN
    truncate tblLogMatchHistory;
    update tblUserWinnrateHistory set winCount = 0, loseCount = 0 where winCount > 0 or loseCount > 0;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spSetLogMatchHistory
-- ----------------------------
DROP PROCEDURE IF EXISTS `spSetLogMatchHistory`;
delimiter ;;
CREATE PROCEDURE `spSetLogMatchHistory`(IN _time datetime, IN _team1Win int, IN _team2Win int, IN _seq int)
BEGIN
    UPDATE `tblLogMatchHistory` SET `team1Win` = `_team1Win`, `team2Win` = `_team2Win` WHERE `time` = `_time` and `seq` = `_seq`;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spSetRankHistory
-- ----------------------------
DROP PROCEDURE IF EXISTS `spSetRankHistory`;
delimiter ;;
CREATE PROCEDURE `spSetRankHistory`(IN _userSeq int, IN _time datetime, IN _ranking int, IN _winRate decimal(11,2))
BEGIN
    INSERT INTO tblRankHistory (userSeq, time, ranking, winRate) VALUES (_userSeq, _time, _ranking, _winRate);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for spUpdateUserInfo
-- ----------------------------
DROP PROCEDURE IF EXISTS `spUpdateUserInfo`;
delimiter ;;
CREATE PROCEDURE `spUpdateUserInfo`(_userName VARCHAR(255), _userSeq int)
BEGIN
    UPDATE `tblUserInfo` SET userName = _userName WHERE `seq` = _userSeq;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
