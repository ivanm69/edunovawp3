--create database uhljebari;

use uhljebari;

create table zupanija(
sifra int,
naziv varchar(50),
zupan varchar(50)
);

create table zupan(
sifra int,
ime varchar(50),
prezime varchar(50)
);

create table opcina(
sifra int,
zupanija varchar(50),
naziv varchar(50),
);

create table mjesto(
sifra int,
opcina varchar(50),
naziv varchar(50),
);

