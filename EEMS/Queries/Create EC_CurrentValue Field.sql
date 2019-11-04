use EEMS

ALTER TABLE Registration drop column initialcountervalue
--Alter table ECOUNTER drop DF__ECounter__curren__308E3499
--ALTER TABLE ECounter drop column currentvalue

IF NOT EXISTS(
  SELECT *
  FROM INFORMATION_SCHEMA.COLUMNS
  WHERE 
    TABLE_NAME = 'ECounter'
    AND COLUMN_NAME = 'currentvalue')
BEGIN
    ALTER TABLE ECounter
    ADD currentvalue INT DEFAULT 0
END;

GO 

UPDATE ECounter SET currentvalue = 0 

Declare @ECID varchar(50)
Declare MYCURSOR Cursor LOCAL STATIC READ_ONLY FORWARD_ONLY

FOR
SELECT DISTINCT ID FROM ECounter

OPEN MYCURSOR FETCH NEXT FROM MYCURSOR INTO @ECID

WHILE @@FETCH_STATUS = 0
BEGIN


FETCH NEXT FROM MYCURSOR INTO @ECID

UPDATE ECounter SET currentvalue = 
(Select ISNULL(Max(ch.currentvalue),0) FROM CounterHistory ch JOIN Registration r ON ch.regid=r.ID RIGHT JOIN ECounter ec ON r.counterid = ec.ID where ec.ID = @ECID)
WHERE ID = @ECID

END
CLOSE MYCURSOR

DEALLOCATE MYCURSOR

ALTER TABLE ECounter ALTER COLUMN currentvalue int NOT NULL; 