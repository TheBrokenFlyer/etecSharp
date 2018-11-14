use master
go
drop database dtb
create database dtb
go
use dtb

create table tbDept (
	idDept varchar(4) unique
)

create table tbCred (
	idCred int primary key identity(0,1),
	idDept varchar(4) foreign key references tbDept(idDept),
	credUsr varchar(8) unique,
	credPass varchar(32)
)

insert into tbDept(idDept) values
	('adm'),
	('ctb')

insert into tbCred(idDept,credUsr,credPass) values
	('adm','usr0','00'),
	('adm','usr1','01'),
	('ctb','usr2','02'),
	('ctb','usr3','03')
go

use master
