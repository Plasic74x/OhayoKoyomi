--use master
--go
--drop database if exists scui8_Lab1
--go

--if exists (select [name] from sysdatabases where [name] = 'scui8_Lab1')
--	drop database scui8_Lab1
--go



--create database scui8_Lab1
--go

use scui8_lab1
go

drop table if exists TripLeg
go

drop table if exists TripPlans
go

drop table if exists TransitLines
go

drop table if exists Stations
go

create table Stations
(
Station			nvarchar(50)			not null,
StreetAddress	nvarchar(30)			not null,
City			nvarchar(30)            not null default('Edmonton'),
Province		nchar(2)				not null default('AB') ,
PostalCode		nchar(7)				null,
constraint postalCode check (PostalCode like '[A-Z][0-9][A-Z] [0-9][A-Z][0-9]'),
constraint PK_Stations_Station primary key clustered (Station),
)
go


create table TransitLines
(
TransitLine		nvarchar(50)				not null,
IntervalMins	int							not null,
constraint CK_TransitLines_IntervalMins check (IntervalMins > 0),
constraint PK_TransitLines_TransitLine primary key clustered (TransitLine),
)
go

create table TripPlans
(
TripPlanId		int					not null identity(1,1),
PlanGenerated	datetime					not null default(getdate()),
constraint PK_TripPlans_TripPlanId primary key clustered (TripPlanId),
)

go

create table TripLeg
(

TripPlanId		int						not null,
TransitLine		nvarchar(50)			not null,

StartStation	nvarchar(50)			not null,
FinishStation	nvarchar(50)			not null,
StartDeparture	datetime				not null,
FinishArrival	datetime				not null,
Duration	as	datediff(minute,StartDeparture,FinishArrival),
		constraint FK_TripLeg_StartStation
						foreign key (StartStation)
						References Stations(Station),
		constraint FK_TripLeg_FinishStation
						foreign key (FinishStation)
						References Stations(Station),
		constraint FK_TripLeg_TripPlanId
						foreign key (TripPlanId)
						References TripPlans(TripPlanId),
		constraint FK_TripLeg_TransitLine
						foreign key (TransitLine)
						References TransitLines(TransitLine),
		constraint PK_TripPlanId primary key clustered (TripPlanId,TransitLine),
)
go