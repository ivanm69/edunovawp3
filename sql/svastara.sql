select top 10 sifra,ime,prezime from kupci;

select * from kupci
where ime= 'Ivan';

select * from Artikli 
where cijena between 130 and 260
and kratkinaziv like '%BUŠILICA%'
and kratkinaziv like '%BOSCH%';


select count(*) from artikli;
update artikli set cijena =cijena/7.53450;

select count(*)from primke;

select max(datum)from primke;

select top 10 * from primke;
update ArtikliNaPrimci set cijena = cijena/7.53450;
select d.naziv as dobavljac,
c.kratkiNaziv,b.cijena,b.kolicina,c.cijena-b.cijena as razlika
from Primke a
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
inner join Dobavljaci d on a.dobavljac=d.sifra
where a.redniBroj='7/2008';