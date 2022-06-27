USE EEMS

GO
ALTER TABLE EngineWorkingHours DROP CONSTRAINT fk_EngineWorkingHours;
ALTER TABLE ElectricBox DROP CONSTRAINT fk_ElectricBoxEngine;
ALTER TABLE ElectricBox DROP CONSTRAINT fk_ElectricBoxCollector;
ALTER TABLE ECounter DROP CONSTRAINT fk_ECounterElectricBox;
ALTER TABLE Registration DROP CONSTRAINT fk_RegistrationECounter;
ALTER TABLE Registration DROP CONSTRAINT fk_RegistrationPackage;
ALTER TABLE Registration DROP CONSTRAINT fk_RegistrationClient;
ALTER TABLE CounterHistory DROP CONSTRAINT fk_CounterHistoryRegistration;
ALTER TABLE CounterHistory DROP CONSTRAINT fk_CounterHistoryArabicMonth;
ALTER TABLE Payment DROP CONSTRAINT fk_PaymentCounterHistory;
ALTER TABLE UserRoles DROP CONSTRAINT fk_UserRolesUsers;
ALTER TABLE UserRoles DROP CONSTRAINT fk_UserRolesRoles;
ALTER TABLE Purchases DROP CONSTRAINT fk_PurchasesItems;
ALTER TABLE Consumption DROP CONSTRAINT fk_ConsumptionItems;
ALTER TABLE FuelPurchases DROP CONSTRAINT fk_FuelPurchasesFuelTank;
ALTER TABLE FuelConsumption DROP CONSTRAINT fk_FuelConsumptionFuelTank;
ALTER TABLE FuelConsumption DROP CONSTRAINT fk_FuelConsumptionEngine;
ALTER TABLE Maintenance DROP CONSTRAINT fk_Maintenance;
GO

GO
DROP TABLE ArabicMonth;
DROP TABLE Client;
DROP TABLE Collector;
DROP TABLE CounterHistory;
DROP TABLE ECounter;
DROP TABLE ElectricBox;
DROP TABLE EngineWorkingHours;
DROP TABLE Engine;
DROP TABLE Expenditure;
DROP TABLE Package;
DROP TABLE Payment;
DROP TABLE Registration;
DROP TABLE Notes;
DROP TABLE DefinedKeys;
DROP TABLE Users;
DROP TABLE Roles;
DROP TABLE UserRoles;
GO

GO
CREATE TABLE ArabicMonth (ID INT PRIMARY KEY, caption VARCHAR(50) NOT NULL);
CREATE TABLE Client (ID INT IDENtity(1,1) PRIMARY KEY,clientname VARCHAR(50) NOT NULL,clientnickname VARCHAR(50),clientmothername VARCHAR(50),caddress VARCHAR(50),phone VARCHAR(50),mobile VARCHAR(50));
CREATE TABLE Collector (ID INT IDENtity(1,1) PRIMARY KEY,fullname VARCHAR(50) NOT NULL,caddress VARCHAR(50),phone VARCHAR(50),mobile VARCHAR(50),notes VARCHAR(255));
CREATE TABLE CounterHistory (ID INT IDENtity(1,1) PRIMARY KEY,cmonth INT NOT NULL,cyear INT NOT NULL,regid INT DEFAULT 0 NOT NULL,monthlyfee INT DEFAULT 0,kilowattprice INT DEFAULT 0,previousvalue INT DEFAULT 0,currentvalue INT DEFAULT 0,roundvalue INT DEFAULT 0,dollarprice INT DEFAULT 0,discount INT DEFAULT 0,total as [monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))+[roundvalue]-[discount],totaldollar AS CAST(CAST(([monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))+[roundvalue]-[discount]) AS FLOAT)/CAST([dollarprice] AS FLOAT) AS FLOAT),notes VARCHAR(255);
CREATE TABLE ECounter (ID INT IDENtity(1,1) PRIMARY KEY,serial VARCHAR(50) NOT NULL,code VARCHAR(10),boxid INT NOT NULL DEFAULT 0,active BIT DEFAULT 0,currentvalue INT NOT NULL DEFAULT 0,notes VARCHAR(255));
CREATE TABLE ElectricBox (ID INT IDENtity(1,1) PRIMARY KEY,code VARCHAR(10) NOT NULL,location VARCHAR(50),collectorid INT NOT NULL,engineid INT NOT NULL,notes VARCHAR(255));
CREATE TABLE Engine (ID INT IDENtity(1,1) PRIMARY KEY,label VARCHAR(20) NOT NULL,ename VARCHAR(50) NOT NULL,location VARCHAR(50),epower int,company VARCHAR(50),contactphone VARCHAR(50),repairparty VARCHAR(50),notes VARCHAR(255));
CREATE TABLE EngineWorkingHours (engineid INT NOT NULL,cmonth INT NOT NULL,cyear INT NOT NULL,workinghours INT DEFAULT 0,notes VARCHAR(255), PRIMARY KEY(engineid,cmonth,cyear));
CREATE TABLE Expenditure (ID INT IDENtity(1,1) PRIMARY KEY,expdate date NOT NULL,title VARCHAR(50),amount INT DEFAULT 0,party VARCHAR(50),detail VARCHAR(255),paymentRef VARCHAR(50));
CREATE TABLE Package (ID INT IDENtity(1,1) PRIMARY KEY,ampere INT NOT NULL,title VARCHAR(50) NOT NULL,fee INT NOT NULL,insurance INT NOT NULL,kilowattprice INT NOT NULL,notes VARCHAR(255));
CREATE TABLE Payment (ID INT IDENtity(1,1) PRIMARY KEY,counterhistoryid INT NOT NULL,pdate DATETIME NOT NULL,pvalue INT NOT NULL,notes VARCHAR(255),collector VARCHAR(50));
CREATE TABLE Registration (ID INT IDENtity(1,1) PRIMARY KEY,clientid INT NOT NULL,registrationdate date NOT NULL,packageid INT NOT NULL,counterid INT NOT NULL,active BIT DEFAULT 0,enddate date,insurance INT DEFAULT 0,notes VARCHAR(255));
CREATE TABLE Notes(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,ExpiryDate date NOT NULL,ExpiryTime time NOT NULL,nStatus VARCHAR(50) NOT NULL,NoteDetail VARCHAR(255) NOT NULL,username VARCHAR(50) NOT NULL);
CREATE TABLE DefinedKeys(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,title VARCHAR(50),dkey VARCHAR(255) NOT NULL,reference VARCHAR(50) NOT NULL);
CREATE TABLE Users (username VARCHAR(25) PRIMARY KEY NOT NULL, pass VARCHAR(50) NOT NULL);
CREATE TABLE Roles (rolename VARCHAR(55) PRIMARY KEY NOT NULL, caption VARCHAR(55) NOT NULL);
CREATE TABLE UserRoles (ID INT IDENtity(1,1) PRIMARY KEY, username VARCHAR(25) NOT NULL, rolename VARCHAR(55) NOT NULL);


CREATE TABLE Items(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,itemname VARCHAR(50) NOT NULL,unit VARCHAR(20) NOT NULL,quantityThreshold INT NOT NULL,properties VARCHAR(255) NOT NULL,notes VARCHAR(255));
CREATE TABLE Purchases(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,indate DATETIME NOT NULL,itemid INT NOT NULL,location VARCHAR(50),quantity INT NOT NULL,pricetotal INT NOT NULL,partyname VARCHAR(50),partyPhone VARCHAR(50),notes VARCHAR(255));
CREATE TABLE Consumption(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,outdate DATETIME NOT NULL,itemid INT NOT NULL,quantity INT NOT NULL,detioration BIT DEFAULT 0,partyname VARCHAR(50),partyPhone VARCHAR(50),notes VARCHAR(255));
CREATE TABLE FuelTank(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,tankName VARCHAR(50) NOT NULL,location VARCHAR(50),capacity INT NOT NULL,notes VARCHAR(255));
CREATE TABLE FuelPurchases(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,indate DATETIME NOT NULL,brand VARCHAR(50),quantity INT NOT NULL,pricetotal INT NOT NULL,partyname VARCHAR(50),partyPhone VARCHAR(50),tankid INT NOT NULL,notes VARCHAR(255));
CREATE TABLE FuelConsumption(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,outdate DATETIME NOT NULL,tankid INT NOT NULL,quantity INT NOT NULL,detioration BIT DEFAULT 0, engineid INT NOT NULL,partyname VARCHAR(50),partyPhone VARCHAR(50),notes VARCHAR(255));
CREATE TABLE Maintenance(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,indate DATETIME NOT NULL,mainaction VARCHAR(10) NOT NULL,engineid INT NOT NULL,actiondetails VARCHAR(255) NOT NULL,bycontract BIT DEFAULT 0,pricetotal INT NOT NULL,partyname VARCHAR(50),partyPhone VARCHAR(50),notes VARCHAR(255));
CREATE TABLE LogSet(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,indate DATETIME DEFAULT (GETDATE()),querystr VARCHAR(1000) NOT NULL,actiontype VARCHAR(1) NOT NULL,username VARCHAR(50));
CREATE TABLE ChangeLog(LogId INT IDENTITY(1,1) NOT NULL,DatabaseName VARCHAR(256) NOT NULL,EventType VARCHAR(50) NOT NULL,ObjectName VARCHAR(256) NOT NULL,ObjectType VARCHAR(25) NOT NULL,SqlCommand VARCHAR(MAX) NOT NULL,EventDate DATETIME DEFAULT (GETDATE()),LoginName VARCHAR(256) NOT NULL);

GO

GO
ALTER TABLE EngineWorkingHours ADD CONSTRAINT fk_EngineWorkingHours FOREIGN KEY (engineid) REFERENCES Engine(ID);
ALTER TABLE ElectricBox ADD CONSTRAINT fk_ElectricBoxEngine FOREIGN KEY (engineid) REFERENCES Engine(ID);
ALTER TABLE ElectricBox ADD CONSTRAINT fk_ElectricBoxCollector FOREIGN KEY (collectorid) REFERENCES Collector(ID);
ALTER TABLE ECounter ADD CONSTRAINT fk_ECounterElectricBox FOREIGN KEY (boxid) REFERENCES ElectricBox(ID);
ALTER TABLE Registration ADD CONSTRAINT fk_RegistrationECounter FOREIGN KEY (counterid) REFERENCES ECounter(ID);
ALTER TABLE Registration ADD CONSTRAINT fk_RegistrationPackage FOREIGN KEY (packageid) REFERENCES Package(ID);
ALTER TABLE Registration ADD CONSTRAINT fk_RegistrationClient FOREIGN KEY (clientid) REFERENCES Client(ID);
ALTER TABLE CounterHistory ADD CONSTRAINT fk_CounterHistoryRegistration FOREIGN KEY (regid) REFERENCES Registration(ID);
ALTER TABLE CounterHistory ADD CONSTRAINT fk_CounterHistoryArabicMonth FOREIGN KEY (cmonth) REFERENCES ArabicMonth(ID);
ALTER TABLE Payment ADD CONSTRAINT fk_PaymentCounterHistory FOREIGN KEY (counterhistoryid) REFERENCES CounterHistory(ID);
ALTER TABLE UserRoles ADD CONSTRAINT fk_UserRolesUsers FOREIGN KEY (username) REFERENCES Users(username);
ALTER TABLE UserRoles ADD CONSTRAINT fk_UserRolesRoles FOREIGN KEY (rolename) REFERENCES Roles(rolename);
ALTER TABLE Purchases ADD CONSTRAINT fk_PurchasesItems FOREIGN KEY (itemid) REFERENCES Items(ID);
ALTER TABLE Consumption ADD CONSTRAINT fk_ConsumptionItems FOREIGN KEY (itemid) REFERENCES Items(ID);
ALTER TABLE FuelPurchases ADD CONSTRAINT fk_FuelPurchasesFuelTank FOREIGN KEY (tankid) REFERENCES FuelTank(ID);
ALTER TABLE FuelConsumption ADD CONSTRAINT fk_FuelConsumptionFuelTank FOREIGN KEY (tankid) REFERENCES FuelTank(ID);
ALTER TABLE FuelConsumption ADD CONSTRAINT fk_FuelConsumptionEngine FOREIGN KEY (engineid) REFERENCES Engine(ID);
ALTER TABLE Maintenance ADD CONSTRAINT fk_Maintenance FOREIGN KEY (engineid) REFERENCES Engine(ID);

GO

GO
INSERT INTO ArabicMonth(ID,caption) VALUES(1,'ك2');
INSERT INTO ArabicMonth(ID,caption) VALUES(2,'شباط');
INSERT INTO ArabicMonth(ID,caption) VALUES(3,'أذار');
INSERT INTO ArabicMonth(ID,caption) VALUES(4,'نيسان');
INSERT INTO ArabicMonth(ID,caption) VALUES(5,'أيّار');
INSERT INTO ArabicMonth(ID,caption) VALUES(6,'حزيران');
INSERT INTO ArabicMonth(ID,caption) VALUES(7,'تموز');
INSERT INTO ArabicMonth(ID,caption) VALUES(8,'آب');
INSERT INTO ArabicMonth(ID,caption) VALUES(9,'أيلول');
INSERT INTO ArabicMonth(ID,caption) VALUES(10,'ت1');
INSERT INTO ArabicMonth(ID,caption) VALUES(11,'ت2');
INSERT INTO ArabicMonth(ID,caption) VALUES(12,'ك1');

INSERT INTO Users VALUES ('admin','25F9E794323B453885F5181F1B624D0B')
INSERT INTO Roles VALUES ('engines','ادارة المولدات'),('eboxs','ادارة العلب'),('ecounters','ادارة العدادات'),('collectors','ادارة الجباة'),
('packages','ادارة انواع الاشتراكات'),('clients','ادارة الزبائن'),('registrations','ادارة الاشتراكات'),('workinghours','ادخال ساعات التغذية'),
('countershistory','ادخال العدّادات'),('invoicesview','كشف الفواتير'),('invoicesprint','طباعة الفواتير'),('addpayment','اضافة دفعة'),('adddiscount','اضافة حسم'),('deletepayment','حذف دفعة'),
('counterhistoryedit','تعديل قيمة العدّاد'),('ledger','ادارة حساب المؤسّسة'),('ledgerrecorddelete','حذف من حساب المؤسّسة'),('reportview','استعراض الكشوفات'),('dataexport','تصدير وطباعة البيانات'),
('clientreport','كشف الزبائن'),('backup','ادارة النسخة الاحتياطيّة'),('packagePriceEdit','تعديل سعر الكيلو بعد الادخال'),('correctRoundvalue','تصحيح كسر الألف'),('inventoryManagement','ادارة مخزن الأصناف'),('FuelManagement','ادارة المحروقات'),('MaintenanceManagement','ادارة الصيانة'),('deleteMaintenance','حذف عمل صيانة'),('itemsManagment','ادارة الأصناف'),('itemsPurchaseManagment','شراء أصناف'),('itemsConsumeManagment','استهلاك أصناف'),('deleteitemsPurchase','حذف شراء صنف'),('FuelTanksManagement','ادارة خزانات المحروقات'),('FuelPurchaseManagement','شراء محروقات'),('FuelConsumeManagement','استهلاك محروقات'),('deleteFuelPurchase','حذف شراء محروقات')
GO

-----------------------------------------------------
----------------- Database Index  -------------------
-----------------------------------------------------

GO
CREATE NONCLUSTERED INDEX [IX_Payment_counterhistoryid]
ON [dbo].[Payment] ([counterhistoryid])
INCLUDE ([pvalue])
GO

-----------------------------------------------------
-------------- Database Log Trigger -----------------
-----------------------------------------------------

GO
CREATE TRIGGER [backup_objects]
ON DATABASE
FOR CREATE_PROCEDURE, 
    ALTER_PROCEDURE, 
    DROP_PROCEDURE,
    CREATE_TABLE, 
    ALTER_TABLE, 
    DROP_TABLE,
    CREATE_FUNCTION, 
    ALTER_FUNCTION, 
    DROP_FUNCTION,
    CREATE_VIEW,
    ALTER_VIEW,
    DROP_VIEW
AS
 
SET NOCOUNT ON
 
DECLARE @data XML
SET @data = EVENTDATA()
 
INSERT INTO changelog(databasename, eventtype, 
    objectname, objecttype, sqlcommand, loginname)
VALUES(
@data.value('(/EVENT_INSTANCE/DatabaseName)[1]', 'varchar(256)'),
@data.value('(/EVENT_INSTANCE/EventType)[1]', 'varchar(50)'), 
@data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'varchar(256)'), 
@data.value('(/EVENT_INSTANCE/ObjectType)[1]', 'varchar(25)'), 
@data.value('(/EVENT_INSTANCE/TSQLCommand)[1]', 'varchar(max)'), 
@data.value('(/EVENT_INSTANCE/LoginName)[1]', 'varchar(256)')
)
GO
 
ENABLE TRIGGER [backup_objects] ON DATABASE
GO