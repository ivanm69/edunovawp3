use master;
go
drop database if exists slike;
go

create database slike;
go
use slike;

create table galerije(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null,
kreator varchar(50),
datum datetime
);
create table slike(
sifra int not null primary key identity(1,1),
putanja varchar(50) not null,
galerija int not null,
datum datetime
);
alter table slike add foreign key (galerija)references galerije(sifra);