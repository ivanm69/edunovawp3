use master;
go
drop database if exists tvrtka;
go
-- ovo je komentar
create database tvrtka collate Croatian_CI_AS;
go

use tvrtka;


create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datum_rodenja date,
placa int,
invalid bit
);

create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int not null,
redni_broj int not null,
putanja varchar(100) not null,

);


alter table slike add foreign key (zaposlenik) references zaposlenici(sifra);


select * from zaposlenici;
insert into zaposlenici(ime,prezime,datum_rodenja,placa,invalid)
values('Slaven','Poznić','2023-11-10','560',1),
('Karla','Kraljik','2023-11-10','560',0),
('Dino','Sabljić','2023-11-10','660',0),
('Luka','Crljić','2023-11-10','800',1),
('Mario','Baliban','2023-11-10','752',1);

select * from slike;
insert into slike(zaposlenik,redni_broj,putanja)
values(1,1,'(C:)/Zaposlenici/Slike/1.png'),
(2,2,'(C:)/Zaposlenici/Slike/5.png'),
(3,3,'(C:)/Zaposlenici/Slike/2.png'),
(4,4,'(C:)/Zaposlenici/Slike/3.png'),
(5,5,'(C:)/Zaposlenici/Slike/4.png');