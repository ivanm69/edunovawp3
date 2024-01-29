select * from smjerovi;

update smjerovi set naziv='C# programiranje'
where sifra=1;

update smjerovi set trajanje=300,cijena=2000
where sifra=2;

update smjerovi set naziv='Serviser',trajanje=120,cijena=1500
where sifra=3

update smjerovi set cijena=cijena*1.2;

update smjerovi set cijena=cijena*0.8;

update smjerovi set cijena=cijena-100;


select * from polaznici;

update polaznici set oib='33520034464',brojugovora='12/2023'
where sifra=18;

update polaznici set oib='null',brojugovora='null'
where sifra=18;

select * from grupe;

update grupe set smjer=10
where sifra=1;

insert into clanovi values(1,56);

