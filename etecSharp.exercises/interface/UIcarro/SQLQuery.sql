use master
go
drop database dtb
create database dtb
go
use dtb
go

create table tbfabricante (
	idfabricante int not null primary key identity(0,1),
	fabricantenome varchar(16) not null unique
)

create table tbcarro (
	idcarro int not null primary key identity(0,1),
	carronome varchar(16) not null,
	carrofabricante varchar(16) not null foreign key references tbfabricante(fabricantenome),
	carroano decimal(4,0) not null default CONVERT(int,SUBSTRING(GETDATE(),0,4))
)

go
insert into tbfabricante(fabricantenome) values
('nissin'),('nisass'),('E')

go
use master
