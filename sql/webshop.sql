use master;
go
drop database if exists webshop;
go

create database webshop collate Croatian_CI_AS;
go

use webshop;

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
datum_nabave datetime null, 
cijena decimal(18,2), 
aktivan bit
);

create table stavke(
	
racun	 int	not null,
proizvod int			not null,
kolicina int,
cijena decimal (18,2)
);


create table racuni(
sifra int not null primary key identity(1,1),
datum date not null,
kupac int,
status_ varchar(50)
);

create table kupci(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
ulica varchar(100) not null,
mjesto varchar(50)
);




alter table racuni add foreign key (kupac) references kupci(sifra);
alter table stavke add foreign key (racun) references racuni(sifra);

alter table stavke add foreign key (racun) references racuni(sifra);
alter table stavke add foreign key (proizvod) references proizvodi(sifra);




select * from kupci;

insert into kupci(ime,prezime,ulica,mjesto) 
values('Ivan','Horvat',' Trg bana Jelačića 1',' Zagreb'),
('Ana','Kovač',' Ilica 10',' Split'),
('Marko','Novak',' Riva 5',' Rijeka'),
('Marija','Jurić',' Gundulićeva 20',' Osijek'),
(' Petar',' Kralj',' Zrinsko-Frankopanska 15','Zadar');


select * from proizvodi;

insert into proizvodi(naziv,datum_nabave,cijena,aktivan)
values('Laptop', '2023-01-01', 5000.00, 0),
('Slušalice', '2023-02-01', 200.00, 1),
('Miš', '2023-03-01', 150.00, 0),
('Tipkovnica', '2023-04-01', 300.00, 1),
('Monitor', '2023-05-01', 1200.00, 0);


select * from racuni;

insert into racuni(datum,kupac,status_)
values('2023-01-01', 1, 'Plaćeno'),
('2023-02-01', 2, 'Nije plaćeno'),
('2023-03-01', 3, 'Plaćeno'),
('2023-04-01', 4, 'Nije plaćeno'),
('2023-05-01', 5, 'Plaćeno');


select * from stavke;

insert into stavke(racun,proizvod,kolicina,cijena)
values(1, 1, 2, 100.00),
(2, 2, 1, 200.00),
(3, 3, 3, 300.00),
(4, 4, 4, 400.00),
(5, 5, 5, 500.00); 




