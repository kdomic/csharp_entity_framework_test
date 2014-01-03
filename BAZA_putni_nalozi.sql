USE [putni_nalozi];

CREATE TABLE Prometne_dozvole (
  idPrometne INT  NOT NULL   IDENTITY ,
  broj_dozvole INT    ,
  registracija INT    ,
  datum_registracije INT    ,
  dozvolu_izdao INT      ,
PRIMARY KEY(idPrometne));
GO

CREATE TABLE Vozacke_dozvole (
  idVozacke_dozvole INT  NOT NULL   IDENTITY ,
  broj_vozacke INT    ,
  broj_registra INT    ,
  izdao INT    ,
  datum_izdavanja INT    ,
  vriejdi_do INT    ,
  A1 BIT   DEFAULT 0 ,
  A2 BIT   DEFAULT 0 ,
  A BIT   DEFAULT 0 ,
  B BIT   DEFAULT 0 ,
  BE BIT   DEFAULT 0 ,
  C1 BIT   DEFAULT 0 ,
  C1E BIT   DEFAULT 0 ,
  C BIT   DEFAULT 0 ,
  CE BIT   DEFAULT 0 ,
  D BIT   DEFAULT 0 ,
  DE BIT   DEFAULT 0 ,
  F BIT   DEFAULT 0 ,
  G BIT   DEFAULT 0 ,
  H BIT   DEFAULT 0 ,
  M BIT   DEFAULT 0 ,
  napomena TEXT      ,
PRIMARY KEY(idVozacke_dozvole));
GO

CREATE TABLE Osobe (
  idOsobe INT  NOT NULL   IDENTITY ,
  ime VARCHAR(45)  NOT NULL  ,
  prezime VARCHAR(45)  NOT NULL  ,
  oib VARCHAR(11)  NOT NULL  ,
  rodjenje_datum DATE  NOT NULL  ,
  rodjenje_mjesto VARCHAR(45)  NOT NULL  ,
  prebivaliste_adresa VARCHAR(45)  NOT NULL  ,
  prebivaliste_mjesto VARCHAR(45)  NOT NULL    ,
PRIMARY KEY(idOsobe));
GO

CREATE TABLE Vozila (
  idVozila INT  NOT NULL   IDENTITY ,
  ime_vlasnika VARCHAR(45)    ,
  adresa_vlasnika VARCHAR(45)    ,
  vrsta_vozila VARCHAR(45)    ,
  marka_vozila VARCHAR(45)    ,
  tip_vozila VARCHAR(45)    ,
  model_vozila VARCHAR(45)    ,
  boja_vozila VARCHAR(45)    ,
  broj_sasije VARCHAR(45)    ,
  oblik_karoserija VARCHAR(45)    ,
  osnovna_namjena VARCHAR(45)    ,
  proizvodjac VARCHAR(45)    ,
  drzava_podrjetla VARCHAR(45)    ,
  godina_proizvodnje VARCHAR(4)    ,
  datum_prve_registracije DATE    ,
  mjesta_za_sjedenje INT    ,
  mjesta_za_stajanje INT    ,
  mjesta_za_lezanje INT    ,
  dopustena_nosivost INT    ,
  masa_praznog_vozila INT    ,
  najvece_dopustena_masa INT    ,
  maksimalna_brzina INT    ,
  broj_osovina INT    ,
  broj_pogonskih_osovina INT    ,
  vrsta_motora VARCHAR(45)    ,
  snaga_motora INT    ,
  broj_okretaja INT    ,
  radni_obujam INT    ,
  mjere_duzina INT    ,
  mjere_sirina INT    ,
  mjere_obujam INT    ,
  broj_kotaca INT    ,
  gume_prednje VARCHAR(45)    ,
  gume_srednje VARCHAR(45)    ,
  gume_straznje VARCHAR(45)    ,
  vrsta_kocnica VARCHAR(45)    ,
  koka BIT    ,
  vitlo BIT      ,
PRIMARY KEY(idVozila));
GO

CREATE TABLE Tehnicki_pregled (
  idTehnicki_pregled INT  NOT NULL   IDENTITY ,
  Prometne_dozvole_idPrometne INT  NOT NULL  ,
  vrijedi_od DATE  NOT NULL  ,
  vrijedi_do DATE  NOT NULL    ,
PRIMARY KEY(idTehnicki_pregled)  ,
  FOREIGN KEY(Prometne_dozvole_idPrometne)
    REFERENCES Prometne_dozvole(idPrometne));
GO

CREATE INDEX Tehnicki_pregled_FKIndex1 ON Tehnicki_pregled (Prometne_dozvole_idPrometne);
GO

CREATE INDEX IFK_Rel_03 ON Tehnicki_pregled (Prometne_dozvole_idPrometne);
GO

CREATE TABLE Vozila_has_Prometne_dozvole (
  Vozila_idVozila INT  NOT NULL  ,
  Prometne_dozvole_idPrometne INT  NOT NULL    ,
PRIMARY KEY(Vozila_idVozila, Prometne_dozvole_idPrometne)    ,
  FOREIGN KEY(Vozila_idVozila)
    REFERENCES Vozila(idVozila),
  FOREIGN KEY(Prometne_dozvole_idPrometne)
    REFERENCES Prometne_dozvole(idPrometne));
GO

CREATE INDEX Vozila_has_Prometne_dozvole_FKIndex1 ON Vozila_has_Prometne_dozvole (Vozila_idVozila);
GO
CREATE INDEX Vozila_has_Prometne_dozvole_FKIndex2 ON Vozila_has_Prometne_dozvole (Prometne_dozvole_idPrometne);
GO

CREATE INDEX IFK_Rel_07 ON Vozila_has_Prometne_dozvole (Vozila_idVozila);
GO
CREATE INDEX IFK_Rel_08 ON Vozila_has_Prometne_dozvole (Prometne_dozvole_idPrometne);
GO

CREATE TABLE Osobe_has_Vozacke_dozvole (
  Osobe_idOsobe INT  NOT NULL  ,
  Vozacke_dozvole_idVozacke_dozvole INT  NOT NULL    ,
PRIMARY KEY(Osobe_idOsobe, Vozacke_dozvole_idVozacke_dozvole)    ,
  FOREIGN KEY(Osobe_idOsobe)
    REFERENCES Osobe(idOsobe),
  FOREIGN KEY(Vozacke_dozvole_idVozacke_dozvole)
    REFERENCES Vozacke_dozvole(idVozacke_dozvole));
GO

CREATE INDEX Osobe_has_Vozacke_dozvole_FKIndex1 ON Osobe_has_Vozacke_dozvole (Osobe_idOsobe);
GO
CREATE INDEX Osobe_has_Vozacke_dozvole_FKIndex2 ON Osobe_has_Vozacke_dozvole (Vozacke_dozvole_idVozacke_dozvole);
GO

CREATE INDEX IFK_Rel_09 ON Osobe_has_Vozacke_dozvole (Osobe_idOsobe);
GO
CREATE INDEX IFK_Rel_10 ON Osobe_has_Vozacke_dozvole (Vozacke_dozvole_idVozacke_dozvole);
GO

CREATE TABLE Putni_nalozi (
  idPutni_nalozi INT  NOT NULL   IDENTITY ,
  Vozila_idVozila INT  NOT NULL  ,
  Osobe_idOsobe INT  NOT NULL  ,
  datum_start DATETIME    ,
  datum_end DATETIME    ,
  adresa_puta VARCHAR(45)    ,
  mjesto_puta VARCHAR(45)    ,
  radno_mjesto VARCHAR(45)    ,
  zadaca VARCHAR(255)    ,
  idVozila INT    ,
  trosak_puta FLOAT ,
  predujam FLOAT    ,
  datum_kreiranja DATETIME  NOT NULL  ,
  idKreatora INT  NOT NULL  ,
  napomena TEXT      ,
PRIMARY KEY(idPutni_nalozi)    ,
  FOREIGN KEY(Osobe_idOsobe)
    REFERENCES Osobe(idOsobe),
  FOREIGN KEY(Vozila_idVozila)
    REFERENCES Vozila(idVozila));
GO

CREATE INDEX Putni_nalozi_FKIndex1 ON Putni_nalozi (Osobe_idOsobe);
GO
CREATE INDEX Putni_nalozi_FKIndex2 ON Putni_nalozi (Vozila_idVozila);
GO

CREATE INDEX IFK_Rel_06 ON Putni_nalozi (Osobe_idOsobe);
GO
CREATE INDEX IFK_Rel_07 ON Putni_nalozi (Vozila_idVozila);
GO

CREATE TABLE Putni_racun (
  idPutni_racun INT  NOT NULL   IDENTITY ,
  Putni_nalozi_idPutni_nalozi INT  NOT NULL  ,
  vrijeme_dolaska DATETIME    ,
  vrijeme_dolaska_2 DATETIME    ,
  trosak_puta FLOAT    ,
  racuni_gorivo TEXT    ,
  racuni_ostalo TEXT    ,
  prijedjeno_kilometara INT    ,
  potroseno_goriva INT      ,
PRIMARY KEY(idPutni_racun)  ,
  FOREIGN KEY(Putni_nalozi_idPutni_nalozi)
    REFERENCES Putni_nalozi(idPutni_nalozi));
GO

CREATE INDEX Putni_racun_FKIndex1 ON Putni_racun (Putni_nalozi_idPutni_nalozi);
GO

CREATE INDEX IFK_Rel_08 ON Putni_racun (Putni_nalozi_idPutni_nalozi);
GO
