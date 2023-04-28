DROP PROCEDURE IF EXISTS spUpdateUserInfo;
CREATE DEFINER=`root`@`%` PROCEDURE `spUpdateUserInfo`(_userName VARCHAR(255), _userSeq int)
BEGIN
    UPDATE `tblUserInfo` SET userName = _userName WHERE `seq` = _userSeq;
END

DROP PROCEDURE IF EXISTS spGetUserInfo;
CREATE DEFINER=`root`@`%` PROCEDURE `spGetUserInfo`(_userName VARCHAR(255))
BEGIN
    SELECT * FROM tblUserInfo 
    WHERE userName LIKE CONCAT(_userName, '%') 
    ORDER BY LENGTH(userName), userName
    LIMIT 1;
END