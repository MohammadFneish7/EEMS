update Electricbox set code = b.code
from Electricbox eb, (select id,code from (VALUES
(1,'A-1'),
(2,'A-2'),
(3,'A-3'),
(4,'A-4'),
(5,'A-5'),
(6,'A-6'),
(7,'A-7'),
(8,'A-8'),
(9,'A-9')) as t(id,code)) as b
where b.id = eb.id