use master;
drop database firstClass;
create database firstClass;
use firstClass;

create table tbCandidate (
	idCandidate int NOT NULL primary key identity(0,1),
	candidateRm int NOT NULL
)

create table tbVoter (
	idVoter int NOT NULL primary key identity(0,1),
	voterName varchar(32) NOT NULL,
	voterRn int NOT NULL,
	voterAddress varchar(64) NOT NULL,
	voterPhone varchar(16) NOT NULL,
	voterGuardian varchar(32),
)

insert into tbVoter(voterName, voterRn) values
	('First Voter', 33244),
	('Second Voter', 33245);

select * from tbVoter;
select * from tbCandidate;
