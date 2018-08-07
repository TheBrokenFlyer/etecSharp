use master;
drop database firstClass;
create database firstClass;
use firstClass;


create table tbVoter (
	idVoter int NOT NULL primary key identity(0,1),
	voterName varchar(32) NOT NULL,
	voterRn int NOT NULL unique,
	voterAddress varchar(64) NOT NULL,
	voterPhone varchar(16) NOT NULL,
	voterGuardian varchar(32),
);

create table tbCandidate (
	idCandidate int NOT NULL primary key identity(0,1),
	candidateRn int NOT NULL unique references tbVoter(voterRn),
);

create table tbVotes (
	voterRn int NOT NULL unique foreign key references tbVoter(voterRn),
	candidateRn int NOT NULL unique foreign key references tbCandidate(candidateRn),
);

insert into tbVoter(voterName, voterRn, voterAddress, voterPhone, voterGuardian) values
	('First Voter', 33244, 'Street Somehwere', '+12482642', NULL),
	('Second Voter', 33245, 'Street Somewhere Else', '+3513231', NULL);

select * from tbVoter;
select * from tbCandidate;
