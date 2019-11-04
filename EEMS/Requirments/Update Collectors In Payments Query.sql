Declare @collectorname varchar(50)
Declare MYCURSOR Cursor LOCAL STATIC READ_ONLY FORWARD_ONLY

FOR
SELECT DISTINCT fullname FROM collector

OPEN MYCURSOR FETCH NEXT FROM MYCURSOR INTO @collectorname

WHILE @@FETCH_STATUS = 0
BEGIN


FETCH NEXT FROM MYCURSOR INTO @collectorname

UPDATE payment set collector = @collectorname from counterhistory ch,Registration r,ECounter ec,ElectricBox b,Collector c where payment.counterhistoryid=ch.id AND ch.regid=r.ID and r.counterid=ec.id and ec.boxid=b.id and b.collectorid=c.id and c.fullname= @collectorname;

END
CLOSE MYCURSOR

DEALLOCATE MYCURSOR