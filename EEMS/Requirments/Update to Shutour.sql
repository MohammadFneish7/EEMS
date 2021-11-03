use [EEMS-Majdal]
ALTER TABLE CounterHistory ADD priceRule varchar(255);
UPDATE CounterHistory SET priceRule =  CONCAT('À«» :', kilowattprice)

ALTER TABLE CounterHistory DROP COLUMN total

DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.CounterHistory')
AND col_name(parent_object_id, parent_column_id) = 'kilowattprice';
IF @var0 IS NOT NULL EXECUTE('ALTER TABLE [dbo].[CounterHistory] DROP CONSTRAINT [' + @var0 + ']')

ALTER TABLE CounterHistory ALTER COLUMN kilowattprice bigInt 

UPDATE CounterHistory SET kilowattprice = ((currentvalue-previousvalue)*kilowattprice)

ALTER TABLE CounterHistory ADD total AS [monthlyfee]+[kilowattprice]+[roundvalue]-[discount]

ALTER TABLE Package ADD priceRule varchar(255);
UPDATE Package SET priceRule =  CONCAT('À«» :', kilowattprice)
ALTER TABLE Package DROP COLUMN kilowattprice