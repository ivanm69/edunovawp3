use master;
go 
drop database if exists zaposlenici;
create database zaposlenici;
use zaposlenici;
create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(50)not null,
prezime varchar(50)not null,
oib char(11),
nadredeni int,
odjel int
);
create table odjeli(
sifra int not null primary key identity(1,1),
naziv varchar(5)not null,
voditelj int not null

);

alter table zaposlenici add foreign key (nadredeni) references zaposlenici(sifra);
alter table zaposlenici add foreign key(odjel)references odjeli(sifra);
alter table odjeli add foreign key(voditelj)references zaposlenici(sifra)