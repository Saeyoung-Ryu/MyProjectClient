DROP PROCEDURE IF EXISTS spGetLogMatchHistoryList;
CREATE DEFINER=`ysy9514`@`%` PROCEDURE `spGetLogMatchHistoryList`()
BEGIN
    SELECT * FROM tblLogMatchHistory ORDER BY seq DESC LIMIT 100;
END