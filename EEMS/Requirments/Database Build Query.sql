use EEMS

alter table EngineWorkingHours drop constraint fk_EngineWorkingHours;
alter table ElectricBox drop constraint fk_ElectricBoxEngine;
alter table ElectricBox drop constraint fk_ElectricBoxCollector;
alter table ECounter drop constraint fk_ECounterElectricBox;
alter table Registration drop constraint fk_RegistrationECounter;
alter table Registration drop constraint fk_RegistrationPackage;
alter table Registration drop constraint fk_RegistrationClient;
alter table CounterHistory drop constraint fk_CounterHistoryRegistration;
alter table CounterHistory drop constraint fk_CounterHistoryArabicMonth;
alter table Payment drop constraint fk_PaymentCounterHistory;


drop table ArabicMonth;
drop table Client;
drop table Collector;
drop table CounterHistory;
drop table ECounter;
drop table ElectricBox;
drop table EngineWorkingHours;
drop table Engine;
drop table Expenditure;
drop table Package;
drop table Payment;
drop table Registration;
drop table Notes;

create table ArabicMonth (ID INT primary key, caption varchar(50) not null);
create table Client (ID INT IDENtity(1,1) primary key,clientname varchar(255) not null,clientnickname varchar(255),clientmothername varchar(255),caddress varchar(255),phone varchar(50),mobile varchar(50));
create table Collector (ID INT IDENtity(1,1) primary key,fullname varchar(255) not null,caddress varchar(255),phone varchar(50),mobile varchar(50),notes varchar(1000));
create table CounterHistory (ID INT IDENtity(1,1) primary key,cmonth int not null,cyear int not null,regid int default 0,monthlyfee int default 0,kilowattprice int default 0,previousvalue int default 0,currentvalue int default 0,roundvalue int default 0,discount int default 0,total as [monthlyfee]+([kilowattprice]*([currentvalue]-[previousvalue]))+[roundvalue]-[discount],notes varchar(1000));
create table ECounter (ID INT IDENtity(1,1) primary key,serial varchar(255) not null,code varchar(5),boxid int not null default 0,active bit default 0,notes varchar(1000));
create table ElectricBox (ID INT IDENtity(1,1) primary key,code varchar(10) not null,location varchar(255),collectorid int not null,engineid int not null,notes varchar(1000));
create table Engine (ID INT IDENtity(1,1) primary key,ename varchar(255) not null,location varchar(255),epower varchar(255),company varchar(255),contactphone varchar(255),repairparty varchar(255),notes varchar(1000));
create table EngineWorkingHours (engineid int not null,cmonth int not null,cyear int not null,workinghours int default 0,notes varchar(255), primary key(engineid,cmonth,cyear));
create table Expenditure (ID INT IDENtity(1,1) primary key,expdate date not null,title varchar(255),amount int default 0,party varchar(255),detail varchar(1000));
create table Package (ID INT IDENtity(1,1) primary key,ampere decimal not null,fee int not null,insurance int not null,kilowattprice int not null,notes varchar(1000));
create table Payment (ID INT IDENtity(1,1) primary key,counterhistoryid int not null,pdate datetime not null,pvalue int not null,notes varchar(1000),collector varchar(50));
create table Registration (ID INT IDENtity(1,1) primary key,clientid int not null,registrationdate date not null,packageid int not null,counterid int not null,active bit default 0,initialcountervalue int not null,enddate date,insurance int default 0,notes varchar(1000));
create table Notes(ID int IDENTITY(1,1) NOT NULL primary key,ExpiryDate date NOT NULL,ExpiryTime time NOT NULL,nStatus varchar(255) NULL,NoteDetail varchar(1000) NULL)

alter table EngineWorkingHours add constraint fk_EngineWorkingHours foreign key (engineid) references Engine(ID);
alter table ElectricBox add constraint fk_ElectricBoxEngine foreign key (engineid) references Engine(ID);
alter table ElectricBox add constraint fk_ElectricBoxCollector foreign key (collectorid) references Collector(ID);
alter table ECounter add constraint fk_ECounterElectricBox foreign key (boxid) references ElectricBox(ID);
alter table Registration add constraint fk_RegistrationECounter foreign key (counterid) references ECounter(ID);
alter table Registration add constraint fk_RegistrationPackage foreign key (packageid) references Package(ID);
alter table Registration add constraint fk_RegistrationClient foreign key (clientid) references Client(ID);
alter table CounterHistory add constraint fk_CounterHistoryRegistration foreign key (regid) references Registration(ID);
alter table CounterHistory add constraint fk_CounterHistoryArabicMonth foreign key (cmonth) references ArabicMonth(ID);
alter table Payment add constraint fk_PaymentCounterHistory foreign key (counterhistoryid) references CounterHistory(ID);


insert into ArabicMonth(ID,caption) values(1,'ك2');
insert into ArabicMonth(ID,caption) values(2,'شباط');
insert into ArabicMonth(ID,caption) values(3,'أذار');
insert into ArabicMonth(ID,caption) values(4,'نيسان');
insert into ArabicMonth(ID,caption) values(5,'أيّار');
insert into ArabicMonth(ID,caption) values(6,'حزيران');
insert into ArabicMonth(ID,caption) values(7,'تموز');
insert into ArabicMonth(ID,caption) values(8,'آب');
insert into ArabicMonth(ID,caption) values(9,'أيلول');
insert into ArabicMonth(ID,caption) values(10,'ت1');
insert into ArabicMonth(ID,caption) values(11,'ت2');
insert into ArabicMonth(ID,caption) values(12,'ك1');