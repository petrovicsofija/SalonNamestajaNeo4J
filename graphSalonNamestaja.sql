
CREATE (SpavacaSoba:Soba {tipProstorije:'Spavaca Soba'})
CREATE (DecijaSoba:Soba {tipProstorije:'Decija Soba'})
CREATE (DnevnaSoba:Soba {tipProstorije:'Dnevna Soba'})
CREATE (Kuhinja:Soba {tipProstorije:'Kuhinja'})
CREATE (Trpezarija:Soba {tipProstorije:'Trpezarija'})
CREATE (RadnaSoba:Soba {tipProstorije:'Radna Soba'})
CREATE (Hodnik:Soba {tipProstorije:'Hodnik'})
CREATE (Kupatilo:Soba {tipProstorije:'Kupatilo'})

CREATE (Mahagoni: Materijal {tipMaterijala: 'mahagoni', boja: 'tamno braon', klasa: 'A'})
CREATE (Iverica: Materijal {tipMaterijala: 'iverica', boja: 'boja peska', klasa: 'C'})
CREATE (Medijapan: Materijal {tipMaterijala: 'medijapan', boja: 'bela', klasa: 'B'})
CREATE (Hrast: Materijal {tipMaterijala: 'hrast', boja: 'braon', klasa: 'A'})
CREATE (CrvenaPlastika: Materijal {tipMaterijala: 'crvena plastika', boja: 'crvena', klasa: 'D'})
CREATE (PlavaPlastika: Materijal {tipMaterijala: 'plava plastika', boja: 'plava', klasa: 'D'})
CREATE (CrnaPlastika: Materijal {tipMaterijala: 'crna plastika', boja: 'crna', klasa: 'D'})
CREATE (BelaPlastika: Materijal {tipMaterijala: 'bela plastika', boja: 'bela', klasa: 'D'})
CREATE (Aluminijum: Materijal {tipMaterijala: 'aluminijum', boja: 'siva', klasa: 'B'})
CREATE (SiviStof: Materijal {tipMaterijala: 'sivi stof', boja: 'siva', klasa: 'B'})
CREATE (BordoStof: Materijal {tipMaterijala: 'bordo stof', boja: 'bordo', klasa: 'B'})
CREATE (CrnaKoza: Materijal {tipMaterijala: 'crna koza', boja: 'crna', klasa: 'A'})
CREATE (BraonKoza: Materijal {tipMaterijala: 'braon koza', boja: 'braon', klasa: 'A'})
CREATE (Staklo: Materijal {tipMaterijala: 'staklo'})
CREATE (Vuna: Materijal {tipMaterijala: 'vuna', boja: 'svetlo braon',klasa: 'A'})
CREATE (ZutiPamuk: Materijal {tipMaterijala: 'zuti pamuk', boja: 'zuta', klasa: 'B'})
CREATE (NarandzastiPamuk: Materijal {tipMaterijala: ' naranzdzasti pamuk', boja: 'narandzasta', klasa: 'B'})
CREATE (Polipropilen : Materijal {tipMaterijala: 'polipropilen', boja: 'bela', klasa: 'D'})

CREATE (KrevetNEIDEN:Namestaj {ime:'KrevetNEIDEN',opis:'Bracni krevet', dimenzija:'140x200cm',cena:60.00,stanjeNaLageru:5})
CREATE (KrevetBRIMNES:Namestaj {ime:'KrevetNEIDEN',opis:'Bracni krevet sa okvirom za odlaganje', dimenzija:'140x200cm',cena:90.00,stanjeNaLageru:5})
CREATE (KrevetGVARV:Namestaj {ime:'KrevetGVARV',opis:'Otoman bracni lezaj', dimenzija:'180x200cm',cena:750.00,stanjeNaLageru:5})
CREATE (KrevetNORDLI:Namestaj {ime:'KrevetNORDLI',opis:'Francuski lezaj sa uzglavljem', dimenzija:'180x200cm',cena:590.00,stanjeNaLageru:5})
CREATE (DecijiKrevetTUFFING:Namestaj {ime:'DecijiKrevetTUFFING',opis:'Krevet na sprat', dimenzija:'90x200cm',cena:140.00,stanjeNaLageru:5})
CREATE (DecijiKrevetKRITTER:Namestaj {ime:'DecijiKrevetKRITTER',opis:'Krevet sa letvicastom osnovom', dimenzija:'70x160cm',cena:79.99,stanjeNaLageru:5})
CREATE (DecijiKrevetSTUVA:Namestaj {ime:'DecijiKrevetSTUVA',opis:'Izdignuti krevet sa fiokama', dimenzija:'207x99x182',cena:450.99,stanjeNaLageru:5})
CREATE (KrevetacSNIGLAR:Namestaj {ime:'KrevetacSNIGLAR',opis:'Krevetac za bebe', dimenzija:'60x120',cena:59.99,stanjeNaLageru:5})
CREATE (SofaGRIMHULT:Namestaj {ime:'SofaGRIMHULT',opis:'Trosed lezaj na razvlacenje', dimenzija:'90x200',cena:490.99,stanjeNaLageru:5})
CREATE (SofaHEMNES:Namestaj {ime:'SofaHEMNES',opis:'Dnevni lezaj sa 3 fioke i dva duseka', dimenzija:'90x200',cena:460.99,stanjeNaLageru:5})

CREATE (NocniStocicHEMNES:Namestaj {ime:'NocniStocicHEMNES',opis:'Nocni stocic sa dve fioke',dimenzija:'75x75cm',cena:50.00,stanjeNaLageru:5})
CREATE (NocniStocicKNARREVIK:Namestaj {ime:'NocniStocicKNARREVIK',opis:'Nocni stocic bez fioke',dimenzija:'60x60cm',cena:29.95,stanjeNaLageru:5})
CREATE (TrpezarijskiStoMELLTORP :Namestaj {ime:'TrpezarijskiStoMELLTORP',opis:'Trpezarijski sto od hrastovine za 4 osobe',dimenzija:'120x100cm',cena:500.95,stanjeNaLageru:5})
CREATE (TrpezarijskiStoSKOGSTA :Namestaj {ime:'TrpezarijskiStoSKOGSTA',opis:'Trpezarijski sto od mahagonija sa staklom za 6 osoba',dimenzija:'235x100cm',cena:950.00,stanjeNaLageru:5})
CREATE (RadniStoBRUSALI:Namestaj {ime:'RadniStoBRUSALI',opis:'Pisaci sto',dimenzija:'90x52cm',cena:90.95,stanjeNaLageru:5})
CREATE (RadniStoLINNMON :Namestaj {ime:'RadniStoLINNMON',opis:'Sto od hrastovine',dimenzija:'150x75cm',cena:110.95,stanjeNaLageru:5})
CREATE (ToaletniStoHEMNES:Namestaj {ime:'ToaletniStoHEMNES',opis:'Toaletni sto s ogledalom',dimenzija:'100x50cm',cena:300.00,stanjeNaLageru:5})
CREATE (ToaletniStoMALM:Namestaj {ime:'ToaletniStoMALM',opis:'Toaletni sto',dimenzija:'120x41',cena:110.20,stanjeNaLageru:5})
CREATE (BarskiStoNORBERG:Namestaj {ime:'BarskiStoNORBERG',opis:'Zidni preklopni sto', dimenzija:'74x60cm',cena:80.00,stanjeNaLageru:5})
CREATE (BarskiStoTOMMARYD:Namestaj {ime:'BarskiStoTOMMARYD',opis:'Minimalisticki sto pogodan za kafice', dimenzija:'70x130/105cm',cena:80.00,stanjeNaLageru:5})

CREATE (FoteljaNOLMYRA: Namestaj {ime: 'FoteljaNOLMYRA',opis:'Fotelja bez rukohvata', dimenzija:'64x64x75cm',cena: 59.00,stanjeNaLageru:5})
CREATE (KancelarijskaStolicaMARKUS: Namestaj {ime: 'KancelarijskaStolicaMARKUS',opis:'Podesiva multifunkcionalna stolica', dimenzija:'62x69cm',cena: 119.00,stanjeNaLageru:5})
CREATE (StolicaINGOLF: Namestaj {ime: 'StolicaINGOLF',opis:'Trpezarijska stolica od punog drveta hrasta', dimenzija:'43x52x91cm',cena: 39.00,stanjeNaLageru:5})
CREATE (FoteljaMUREN: Namestaj {ime: 'FoteljaMUREN',opis:'Fotelja sa podnozjem', dimenzija:'85x94x81cm',cena: 159.00,stanjeNaLageru:5})
CREATE (StolicaPRAKTIK: Namestaj {ime: 'StolicaPRAKTIK',opis:'Sklopiva plasticna stolica', dimenzija:'85x92x90cm',cena: 11.00,stanjeNaLageru:5})
CREATE (StolicaSTIG: Namestaj {ime: 'StolicaSTIG',opis:'Barska stolica sa naslonom od aluminijuma', dimenzija:'60x50x100cm',cena: 115.00,stanjeNaLageru:5})
CREATE (FoteljaLUXELLE: Namestaj {ime: 'FoteljaLUXELLE',opis:'Fotelja na razvlacenje od stofa', dimenzija:'100x87x60cm',cena: 200.00,stanjeNaLageru:5})
CREATE (KrevetSOLARIS: Namestaj {ime: 'KrevetSOLARIS',opis:'Sivi lenjivac za popodnevni odmor', dimenzija:'93x151x83cm',cena: 320.00,stanjeNaLageru:5})
CREATE (SofaNAP: Namestaj {ime: 'SofaNAP',opis:'Udobna sofa u roze boji', dimenzija:'230x90x90cm',cena: 359.00,stanjeNaLageru:5})
CREATE (SofaFRIHTEN: Namestaj {ime: 'SofaFRIHTEN',opis:'Kozna ugaona sofa lezaj na razvlacenje', dimenzija:'150x220x90cm',cena: 599.00,stanjeNaLageru:5})

CREATE (OrmarBLUE: Namestaj {ime: 'OrmarBLUE',opis:'Dvokrilni ormar od medijapana', dimenzija:'200x90x200cm',cena: 589.00,stanjeNaLageru:5})
CREATE (OrmarPAX: Namestaj {ime: 'OrmarPAX',opis:'Ormar sa kliznim vratima od punog drveta', dimenzija:'180x80x180cm',cena: 630.00,stanjeNaLageru:5})
CREATE (OrmarRIMENS: Namestaj {ime: 'OrmarRIMENS',opis:'Jednokrilni ormar sa ogledalom', dimenzija:'120x90x120',cena: 330.00,stanjeNaLageru:5})
CREATE (VitrinaBILLY: Namestaj {ime: 'VitrinaBILLY',opis:'Bela biblioteka sa staklenim vratima', dimenzija:'180x55x120cm',cena: 129.00,stanjeNaLageru:5})
CREATE (CipelarnikHEMNES: Namestaj {ime: 'CipelarnikHEMNES',opis:'Klupa za odlaganje obuce od aluminijuma', dimenzija:'60x80x90cm',cena: 50.00,stanjeNaLageru:5})
CREATE (CipelarnikJOHNAS: Namestaj {ime: 'CipelarnikJOHNAS',opis:'Cipelarnik sa tri odeljka', dimenzija:'160x150x90cm',cena: 229.00,stanjeNaLageru:5})
CREATE (StalakEKRAR: Namestaj {ime: 'StalakEKRAR',opis:'Stalak za sesire, kapute i kisobrane', dimenzija:'160cm',cena: 99.00,stanjeNaLageru:5})
CREATE (KuhinjskiElementMAXIU: Namestaj {ime: 'KuhinjskiElementMAXIU',opis:'Prljavo-beli zidni kuhinjski ormaric', dimenzija:'90x38x40cm',cena: 89.00,stanjeNaLageru:5})
CREATE (KuhinjskiElementMAXID: Namestaj {ime: 'KuhinjskiElementMAXID',opis:'Prljavo-beli podni kuhinjski ormaric', dimenzija:'90x38x90cm',cena: 79.00,stanjeNaLageru:5})

CREATE (PlafonskaRasvetaKRUSNING:Rasveta {ime:'PlafonskaRasvetaKRUSNING',tipRasvete:'luster',opis:'Elegantna visilica bele boje',cena:15.54,EnergetskiRazred:'A+',stanjeNaLageru:5})
CREATE (PlafonskaRasvetaMELODI:Rasveta {ime:'PlafonskaRasvetaMELODI',tipRasvete:'luster',opis:'Minimalisticka visilica crne boje',cena:17.54,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (PlafonskaRasvetaTROSS:Rasveta {ime:'PlafonskaRasvetaTROSS',tipRasvete:'luster',opis:'Plafonski nosac sa 3 mala reflektora',cena:9.99,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (PlafonskaRasvetaGOTHEM:Rasveta {ime:'PlafonskaRasvetaGOTHEM',tipRasvete:'luster',opis:'Moderna visilica 35 cm',cena:40.50,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (StonaLampaINGARED:Rasveta {ime:'StonaLampaINGARED',tipRasvete:'stona lampa',opis:'Stona lampa bele boje klasik 30 cm',cena:7.50,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (StonaLampaKNUBIG:Rasveta {ime:'StonaLampaKNUBIG',tipRasvete:'stona lampa',opis:'Dizajnirana stona lampa bele boje sa cvetovima',cena:27.50,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (StonaLampaKLABB:Rasveta {ime:'StonaLampaKLABB',tipRasvete:'stona lampa',opis:'Modernisticka stona lampa bele ili crne boje',cena:49.50,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (StonaLampaHONVAS:Rasveta {ime:'StonaLampaHONVAS',tipRasvete:'stona lampa',opis:'Dekorativna stona lampa bele boje u obliku cveta',cena:89.50,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (ZidnaLampaSVALLIS:Rasveta {ime:'ZidnaLampaSVALLIS',tipRasvete:'zidna lampa',opis:'Led lampa',cena:10.50,EnergetskiRazred:'od A++ do A',stanjeNaLageru:5})
CREATE (ZidnaLampaMALIK:Rasveta {ime:'ZidnaLampaMALIK',tipRasvete:'zidna lampa',opis:'Led lampa sarena svetla',cena:25.50,EnergetskiRazred:'od A++ do A',stanjeNaLageru:5})
CREATE (ZidnaLampaGODMORGON:Rasveta {ime:'ZidnaLampaGODMORGON',tipRasvete:'zidna lampa',opis:'Rasveta za ormaric',cena:15.50,EnergetskiRazred:'od A++ do A',stanjeNaLageru:5})

CREATE (TepihLily: Dekoracija {ime: 'TepihLily',tipDekoracije:'Vuneni tepih boje lavande',dimenzija: '200x150cm',cena: 119.00,stanjeNaLageru:5})
CREATE (ProstirkaVINDUM: Dekoracija {ime:'ProstirkaVINDUM',tipDekoracije:'Pamucna prostirka tkanja predjom u raznim smerovima',dimenzija: '130x150cm',cena: 109.0,stanjeNaLageru:5})
CREATE (OgledaloEKNE: Dekoracija{ime: 'OgledaloEKNE',tipDekoracije:'Ukrasno ogledalo sa ramom od drveta',dimenzija:'120x60cm', cena: 200.00,stanjeNaLageru:5})
CREATE (OgledaloHUNDIG: Dekoracija{ime: 'OgledaloHUNDIG',tipDekoracije:'Ogledalo sa osvetljenjem za kupatilo',dimenzija: '110x66cm',cena: 89.00,stanjeNaLageru:5})
CREATE (VazaGRADVIS: Dekoracija {ime: 'VazaGRADVIS',tipDekoracije:'Visoka kristalna vaza',cena: 20.00,stanjeNaLageru:5})
CREATE (SvecnjakGRAND: Dekoracija {ime: 'SvecnjakGRAND',tipDekoracije:'Svecnjak od duvanog stakla',cena: 30.00,stanjeNaLageru:5})
CREATE (SveceOASIS: Dekoracija {ime: 'SveceOASIS',tipDekoracije:'Mirisne svece u casi',cena: 19.00,stanjeNaLageru:5})
CREATE (FICUS: Dekoracija {ime: 'FICUS',tipDekoracije:'Biljka u saksiji, fikus',cena: 29.00,stanjeNaLageru:5})
CREATE (AQUATICA: Dekoracija {ime: 'AQUATICA',tipDekoracije:'Zasadjena biljka, vodeni keste',cena: 39.00,stanjeNaLageru:5})
CREATE (CasovnikCLOCK: Dekoracija {ime: 'CasovnikCLOCK',tipDekoracije:'Digitalni sat koji meri i temperaturu prostorije',dimenzija: '25cm',cena: 19.00,stanjeNaLageru:5})
CREATE (CasovnikWIND: Dekoracija {ime: 'CasovnikWIND',tipDekoracije:'Starinski sat od drveta',dimenzija: '30cm',cena: 49.00,stanjeNaLageru:5})

CREATE (FriziderTILREDA:Tehnika {ime:'FriziderTILREDA',opis:'Frizider bele boje',cena:150.50,EnergetskiRazred:'A+',stanjeNaLageru:5})
CREATE (FriziderLAGAN:Tehnika {ime:'FriziderLAGAN',opis:'Frizider zamrzivac bele boje',cena:300.50,EnergetskiRazred:'A+',stanjeNaLageru:5})
CREATE (FriziderKYLSLAGEN:Tehnika {ime:'FriziderKYLSLAGEN',opis:'Frizider zamrzivac mat',cena:1000.00,EnergetskiRazred:'A+++',stanjeNaLageru:5})
CREATE (GrejnaPlocaLAGAN:Tehnika {ime:'GrejnaPlocaLAGAN',opis:'Ugradna staklokeramicka ploca',dimenzija:'59x52cm',cena:250.00,stanjeNaLageru:5})
CREATE (GrejnaPlocaSMAKOKA:Tehnika {ime:'GrejnaPlocaSMAKOKA',opis:'Plinska grejna ploca',dimenzija:'59x55cm',cena:150.00,stanjeNaLageru:5})
CREATE (GrejnaPlocaNAR:Tehnika {ime:'GrejnaPlocaNAR',opis:'Indukcijska ploca',dimenzija:'59cm',cena:450.00,stanjeNaLageru:5})
CREATE (VesMasinaTVATAD:Tehnika {ime:'VesMasinaTVATAD',opis:'Ugradna ves masina',dimenzija:'60cm',cena:369.00,EnergetskiRazred:'A+++',stanjeNaLageru:5})
CREATE (VesMasinaKLAS:Tehnika {ime:'VesMasinaKLAS',opis:'Ves masina bele boje klasik',dimenzija:'60cm',cena:150.00,EnergetskiRazred:'A+',stanjeNaLageru:5})
CREATE (SudoMasinaKRAG:Tehnika {ime:'SudoMasinaKRAG',opis:'Ugradna masina za sudove mat',dimenzija:'60cm',cena:250.00,EnergetskiRazred:'A++',stanjeNaLageru:5})
CREATE (SudoMasinaUNDERVERK:Tehnika {ime:'SudoMasinaUNDERVERK',opis:'Ugradna masina za sudove bele boje sa 6 moda rada',dimenzija:'60cm',cena:600.00,EnergetskiRazred:'A+++',stanjeNaLageru:5})
CREATE (AspiratorUNDERVERK:Tehnika {ime:'AspiratorUNDERVERK',opis:'Ugradni aspirator sivi',dimenzija:'60cm',cena:59.00,EnergetskiRazred:'D',stanjeNaLageru:5})
CREATE (AspiratorLAGAN:Tehnika {ime:'AspiratorLAGAN',opis:'Ugradni aspirator crn',dimenzija:'60cm',cena:100.00,EnergetskiRazred:'A',stanjeNaLageru:5})
CREATE (PecnicaLAGAN:Tehnika {ime:'PecnicaLAGAN',opis:'Ugradnapecnica sa vrelim vazduhom',cena:350.00,EnergetskiRazred:'A+',stanjeNaLageru:5})
CREATE (PecnicaMAKARE:Tehnika {ime:'PecnicaMAKARE',opis:'Pecnica sa vrelim vazduhom na paru',cena:450.00,EnergetskiRazred:'A+',stanjeNaLageru:5})

CREATE (Zaposleni1: Osoba {ime: 'Admin1', sifra: '12345'})
CREATE (Zaposleni2: Osoba {ime: 'Admin2', sifra: '13579'})


CREATE (KrevetNEIDEN)-[:SACINJEN_OD]->(Medijapan)
CREATE (KrevetNEIDEN)-[:JE_DEO {uloga:['bracni krevet']}]->(SpavacaSoba)
CREATE(KrevetBRIMNES)-[:SACINJEN_OD]->(Hrast)
CREATE(KrevetBRIMNES)-[:JE_DEO {uloga:['bracni krevet']}]->(SpavacaSoba)
CREATE(KrevetGVARV)-[:SACINJEN_OD]->(Medijapan)
CREATE(KrevetGVARV)-[:JE_DEO {uloga:['otoman']}]->(SpavacaSoba)
CREATE(KrevetNORDLI)-[:SACINJEN_OD]->(Hrast)
CREATE(KrevetNORDLI)-[:JE_DEO {uloga:['francuski lezaj']}]->(SpavacaSoba)
CREATE(DecijiKrevetTUFFING)-[:SACINJEN_OD]->(Medijapan)
CREATE (DecijiKrevetTUFFING)-[:JE_DEO {uloga:['krevet na sprat']}]->(DecijaSoba)
CREATE(DecijiKrevetKRITTER)-[:SACINJEN_OD]->(Medijapan)
CREATE(DecijiKrevetKRITTER)-[:JE_DEO {uloga:['deciji krevet']}]->(DecijaSoba)
CREATE(DecijiKrevetSTUVA)-[:SACINJEN_OD]->(Medijapan)
CREATE(DecijiKrevetSTUVA)-[:JE_DEO {uloga:['krevet na sprat']}]->(DecijaSoba)
CREATE(KrevetacSNIGLAR)-[:SACINJEN_OD]->(Medijapan)
CREATE(KrevetacSNIGLAR)-[:JE_DEO {uloga:['krevetac']}]->(DecijaSoba)
CREATE(SofaGRIMHULT)-[:SACINJEN_OD]->(Hrast)
CREATE(SofaGRIMHULT)-[:JE_DEO {uloga:['trosed lezaj']}]->(DnevnaSoba)	  
CREATE(SofaHEMNES)-[:SACINJEN_OD]->(Mahagoni)
CREATE(SofaHEMNES)-[:JE_DEO {uloga:['dvosed lezaj']}]->(DnevnaSoba)
CREATE(NocniStocicHEMNES)-[:SACINJEN_OD]->(Medijapan)
CREATE (NocniStocicHEMNES)-[:JE_DEO {uloga:['nocni stocic']}]->(SpavacaSoba)
CREATE(NocniStocicKNARREVIK)-[:SACINJEN_OD]->(Hrast)
CREATE(NocniStocicKNARREVIK)-[:JE_DEO {uloga:['nocni stocic']}]->(SpavacaSoba)
CREATE(TrpezarijskiStoMELLTORP)-[:SACINJEN_OD]->(Hrast)
CREATE (TrpezarijskiStoMELLTORP)-[:JE_DEO {uloga:['trpezarijski sto']}]->(Trpezarija)
CREATE(TrpezarijskiStoSKOGSTA)-[:SACINJEN_OD]->(Mahagoni)
CREATE (TrpezarijskiStoSKOGSTA)-[:JE_DEO {uloga:['trpezarijski sto']}]->(Trpezarija)
CREATE(RadniStoBRUSALI)-[:SACINJEN_OD]->(Iverica)
CREATE(RadniStoBRUSALI)-[:JE_DEO {uloga:['radni sto']}]->(RadnaSoba)
CREATE(RadniStoLINNMON)-[:SACINJEN_OD]->(Hrast)
CREATE(RadniStoLINNMON)-[:JE_DEO {uloga:['radni sto']}]->(RadnaSoba)
CREATE(ToaletniStoHEMNES)-[:SACINJEN_OD]->(Iverica)
CREATE(ToaletniStoHEMNES)-[:JE_DEO {uloga:['toaletni sto']}]->(SpavacaSoba)
CREATE(ToaletniStoMALM)-[:SACINJEN_OD]->(Medijapan)
CREATE(ToaletniStoMALM)-[:JE_DEO {uloga:['toaletni sto']}]->(SpavacaSoba)
CREATE(BarskiStoNORBERG)-[:SACINJEN_OD]->(Medijapan)
CREATE(BarskiStoNORBERG)-[:JE_DEO {uloga:['barski sto']}]->(Kuhinja)	  
CREATE(BarskiStoTOMMARYD)-[:SACINJEN_OD]->(Medijapan)
CREATE(BarskiStoTOMMARYD)-[:JE_DEO {uloga:['barski sto']}]->(Kuhinja)
CREATE(PlafonskaRasvetaKRUSNING)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaKRUSNING)-[:SACINJEN_OD]->(Aluminijum)
CREATE(PlafonskaRasvetaKRUSNING)-[:JE_DEO {uloga:['luster']}]->(SpavacaSoba)
CREATE(PlafonskaRasvetaKRUSNING)-[:JE_DEO {uloga:['luster']}]->(DnevnaSoba)
CREATE(PlafonskaRasvetaKRUSNING)-[:JE_DEO {uloga:['luster']}]->(Trpezarija)
CREATE(PlafonskaRasvetaMELODI)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaMELODI)-[:SACINJEN_OD]->(Mahagoni)
CREATE(PlafonskaRasvetaMELODI)-[:JE_DEO {uloga:['luster']}]->(Trpezarija)
CREATE(PlafonskaRasvetaMELODI)-[:JE_DEO {uloga:['luster']}]->(DnevnaSoba)
CREATE(PlafonskaRasvetaMELODI)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaMELODI)-[:SACINJEN_OD]->(Mahagoni)
CREATE(PlafonskaRasvetaMELODI)-[:JE_DEO {uloga:['luster']}]->(SpavacaSoba)
CREATE(PlafonskaRasvetaTROSS)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaTROSS)-[:SACINJEN_OD]->(Aluminijum)
CREATE(PlafonskaRasvetaTROSS)-[:JE_DEO {uloga:['luster']}]->(Trpezarija)
CREATE(PlafonskaRasvetaTROSS)-[:JE_DEO {uloga:['luster']}]->(DnevnaSoba)
CREATE(PlafonskaRasvetaTROSS)-[:JE_DEO {uloga:['luster']}]->(SpavacaSoba)
CREATE(PlafonskaRasvetaTROSS)-[:JE_DEO {uloga:['luster']}]->(DecijaSoba)
CREATE(PlafonskaRasvetaTROSS)-[:JE_DEO {uloga:['luster']}]->(Kuhinja)
CREATE(PlafonskaRasvetaTROSS)-[:JE_DEO {uloga:['luster']}]->(Hodnik)
CREATE(PlafonskaRasvetaGOTHEM)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaGOTHEM)-[:SACINJEN_OD]->(Aluminijum)
CREATE(PlafonskaRasvetaGOTHEM)-[:JE_DEO {uloga:['luster']}]->(Trpezarija)
CREATE(PlafonskaRasvetaGOTHEM)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaGOTHEM)-[:SACINJEN_OD]->(Aluminijum)
CREATE(PlafonskaRasvetaGOTHEM)-[:JE_DEO {uloga:['luster']}]->(DnevnaSoba)
CREATE(PlafonskaRasvetaGOTHEM)-[:SACINJEN_OD]->(Staklo)
CREATE(PlafonskaRasvetaGOTHEM)-[:SACINJEN_OD]->(Aluminijum)
CREATE(PlafonskaRasvetaGOTHEM)-[:JE_DEO {uloga:['luster']}]->(SpavacaSoba)
CREATE(PlafonskaRasvetaGOTHEM)-[:JE_DEO {uloga:['luster']}]->(DecijaSoba)
CREATE(PlafonskaRasvetaGOTHEM)-[:JE_DEO {uloga:['luster']}]->(Kuhinja)
CREATE(PlafonskaRasvetaGOTHEM)-[:JE_DEO {uloga:['luster']}]->(Hodnik)
CREATE(StonaLampaINGARED)-[:SACINJEN_OD]->(Staklo)
CREATE(StonaLampaINGARED)-[:SACINJEN_OD]->(Aluminijum)
CREATE(StonaLampaINGARED)-[:JE_DEO {uloga:['stona lampa']}]->(Hodnik)
CREATE(StonaLampaINGARED)-[:JE_DEO {uloga:['stona lampa']}]->(SpavacaSoba)
CREATE(StonaLampaINGARED)-[:JE_DEO {uloga:['stona lampa']}]->(DecijaSoba)
CREATE(StonaLampaINGARED)-[:JE_DEO {uloga:['stona lampa']}]->(DnevnaSoba)
CREATE(StonaLampaINGARED)-[:JE_DEO {uloga:['stona lampa']}]->(RadnaSoba)
CREATE(StonaLampaKNUBIG)-[:SACINJEN_OD]->(Staklo)
CREATE(StonaLampaKNUBIG)-[:SACINJEN_OD]->(Mahagoni)
CREATE(StonaLampaKNUBIG)-[:JE_DEO {uloga:['stona lampa']}]->(Hodnik)
CREATE(StonaLampaKNUBIG)-[:JE_DEO {uloga:['stona lampa']}]->(SpavacaSoba)
CREATE(StonaLampaKNUBIG)-[:JE_DEO {uloga:['stona lampa']}]->(DnevnaSoba)
CREATE(StonaLampaKNUBIG)-[:JE_DEO {uloga:['stona lampa']}]->(RadnaSoba)
CREATE(StonaLampaHONVAS)-[:SACINJEN_OD]->(Staklo)
CREATE(StonaLampaHONVAS)-[:SACINJEN_OD]->(Mahagoni)
CREATE(StonaLampaHONVAS)-[:JE_DEO {uloga:['stona lampa']}]->(Hodnik)
CREATE(StonaLampaHONVAS)-[:JE_DEO {uloga:['stona lampa']}]->(SpavacaSoba)
CREATE(StonaLampaHONVAS)-[:JE_DEO {uloga:['stona lampa']}]->(DnevnaSoba)
CREATE(StonaLampaHONVAS)-[:JE_DEO {uloga:['stona lampa']}]->(RadnaSoba)
CREATE(StonaLampaKLABB)-[:SACINJEN_OD]->(Staklo)
CREATE(StonaLampaKLABB)-[:SACINJEN_OD]->(CrnaPlastika)
CREATE(StonaLampaKLABB)-[:JE_DEO {uloga:['stona lampa']}]->(Hodnik)
CREATE(StonaLampaKLABB)-[:JE_DEO {uloga:['stona lampa']}]->(SpavacaSoba)
CREATE(StonaLampaKLABB)-[:JE_DEO {uloga:['stona lampa']}]->(DnevnaSoba)
CREATE(StonaLampaKLABB)-[:JE_DEO {uloga:['stona lampa']}]->(RadnaSoba)
CREATE(ZidnaLampaSVALLIS)-[:SACINJEN_OD]->(Staklo)
CREATE(ZidnaLampaSVALLIS)-[:SACINJEN_OD]->(CrnaPlastika)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(Hodnik)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(SpavacaSoba)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(DnevnaSoba)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(RadnaSoba)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(Trpezarija)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(Kuhinja)
CREATE(ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(Kupatilo)
CREATE (ZidnaLampaSVALLIS)-[:JE_DEO {uloga:['zidna lampa']}]->(DecijaSoba)
CREATE(ZidnaLampaMALIK)-[:SACINJEN_OD]->(Staklo)
CREATE(ZidnaLampaMALIK)-[:SACINJEN_OD]->(Aluminijum)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(Hodnik)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(SpavacaSoba)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(DnevnaSoba)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(RadnaSoba)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(Trpezarija)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(Kuhinja)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(Kupatilo)
CREATE(ZidnaLampaMALIK)-[:JE_DEO {uloga:['zidna lampa']}]->(DecijaSoba)
CREATE(ZidnaLampaGODMORGON)-[:SACINJEN_OD]->(Staklo)
CREATE(ZidnaLampaGODMORGON)-[:SACINJEN_OD]->(Aluminijum)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(Hodnik)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(SpavacaSoba)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(DnevnaSoba)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(RadnaSoba)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(Trpezarija)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(Kuhinja)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(Kupatilo)
CREATE(ZidnaLampaGODMORGON)-[:JE_DEO {uloga:['zidna lampa']}]->(DecijaSoba)
CREATE(FriziderTILREDA)-[:SACINJEN_OD]->(Aluminijum)
CREATE(FriziderTILREDA)-[:JE_DEO {uloga:['frizider']}]->(Kuhinja)
CREATE(FriziderLAGAN)-[:SACINJEN_OD]->(Aluminijum)
CREATE(FriziderLAGAN)-[:JE_DEO {uloga:['frizider']}]->(Kuhinja)
CREATE(FriziderKYLSLAGEN)-[:SACINJEN_OD]->(Aluminijum)
CREATE(FriziderKYLSLAGEN)-[:JE_DEO {uloga:['frizider']}]->(Kuhinja)
CREATE(GrejnaPlocaLAGAN)-[:JE_DEO {uloga:['grejna ploca']}]->(Kuhinja)
CREATE(GrejnaPlocaSMAKOKA)-[:JE_DEO {uloga:['grejna ploca']}]->(Kuhinja)
CREATE(GrejnaPlocaNAR)-[:JE_DEO {uloga:['grejna ploca']}]->(Kuhinja)
CREATE(VesMasinaTVATAD)-[:JE_DEO {uloga:['ves masina']}]->(Kupatilo)
CREATE(VesMasinaKLAS)-[:JE_DEO {uloga:['ves masina']}]->(Kupatilo)
CREATE(SudoMasinaKRAG)-[:JE_DEO {uloga:['sudo masina']}]->(Kuhinja)
CREATE(SudoMasinaUNDERVERK)-[:JE_DEO {uloga:['sudo masina']}]->(Kuhinja)
CREATE(AspiratorUNDERVERK)-[:SACINJEN_OD]->(Aluminijum)
CREATE(AspiratorUNDERVERK)-[:JE_DEO {uloga:['aspirator']}]->(Kuhinja)
CREATE(AspiratorLAGAN)-[:SACINJEN_OD]->(Aluminijum)
CREATE(AspiratorLAGAN)-[:JE_DEO {uloga:['aspirator']}]->(Kuhinja)
CREATE(PecnicaLAGAN)-[:JE_DEO {uloga:['pecnica']}]->(Kuhinja)
CREATE(PecnicaMAKARE)-[:JE_DEO {uloga:['pecnica']}]->(Kuhinja)
CREATE(FoteljaNOLMYRA)-[:SACINJEN_OD]->(SiviStof)
CREATE(FoteljaNOLMYRA)-[:JE_DEO {uloga:['fotelja']}]->(DnevnaSoba)
CREATE(FoteljaNOLMYRA)-[:JE_DEO {uloga:['fotelja']}]->(SpavacaSoba)
CREATE(KancelarijskaStolicaMARKUS)-[:JE_DEO {uloga:['kancelarijska stolica']}]->(RadnaSoba)
CREATE(KancelarijskaStolicaMARKUS)-[:SACINJEN_OD]->(CrnaKoza)
CREATE(StolicaINGOLF)-[:SACINJEN_OD]->(Mahagoni)
CREATE(StolicaINGOLF)-[:JE_DEO {uloga:['trpezarijska stolica']}]->(Trpezarija)
CREATE(FoteljaMUREN)-[:SACINJEN_OD]->(BraonKoza)
CREATE(FoteljaMUREN)-[:JE_DEO {uloga:['fotelja']}]->(DnevnaSoba)
CREATE(StolicaPRAKTIK)-[:SACINJEN_OD]->(BelaPlastika)
CREATE(StolicaPRAKTIK)-[:JE_DEO {uloga:['stolica']}]->(DnevnaSoba)
CREATE(StolicaPRAKTIK)-[:JE_DEO {uloga:['stolica']}]->(Trpezarija)
CREATE(StolicaPRAKTIK)-[:JE_DEO {uloga:['stolica']}]->(DecijaSoba)
CREATE(StolicaSTIG)-[:SACINJEN_OD]->(Aluminijum)
CREATE(StolicaSTIG)-[:JE_DEO {uloga:['barska stolica']}]->(DnevnaSoba)
CREATE(StolicaSTIG)-[:JE_DEO {uloga:['barska stolica']}]->(Trpezarija)
CREATE(FoteljaLUXELLE)-[:JE_DEO {uloga:['fotelja na razvlacenje']}]->(SpavacaSoba)
CREATE(FoteljaLUXELLE)-[:JE_DEO {uloga:['barska stolica']}]->(DecijaSoba)
CREATE(FoteljaLUXELLE)-[:SACINJEN_OD]->(BordoStof)
CREATE(KrevetSOLARIS)-[:JE_DEO {uloga:['lenjivac']}]->(DecijaSoba)
CREATE(KrevetSOLARIS)-[:SACINJEN_OD]->(BordoStof)
CREATE(SofaNAP)-[:JE_DEO {uloga:['sofa']}]->(DnevnaSoba)
CREATE(SofaNAP)-[:SACINJEN_OD]->(BraonKoza)
CREATE(SofaFRIHTEN)-[:JE_DEO {uloga:['ugaona sofa']}]->(DnevnaSoba)
CREATE(SofaFRIHTEN)-[:SACINJEN_OD]->(CrnaKoza)
CREATE(OrmarBLUE)-[:JE_DEO {uloga:['ormar']}]->(SpavacaSoba)
CREATE(OrmarBLUE)-[:JE_DEO {uloga:['ormar']}]->(DecijaSoba)
CREATE(OrmarBLUE)-[:SACINJEN_OD]->(Medijapan)
CREATE(OrmarPAX)-[:JE_DEO {uloga:['ormar']}]->(SpavacaSoba)
CREATE(OrmarPAX)-[:SACINJEN_OD]->(Mahagoni)
CREATE(OrmarRIMENS)-[:JE_DEO {uloga:['ormar']}]->(SpavacaSoba)
CREATE(OrmarRIMENS)-[:SACINJEN_OD]->(Mahagoni)
CREATE(VitrinaBILLY)-[:JE_DEO {uloga:['vitrina']}]->(Trpezarija)
CREATE(VitrinaBILLY)-[:SACINJEN_OD]->(Mahagoni)
CREATE(VitrinaBILLY)-[:JE_DEO {uloga:['vitrina']}]->(DnevnaSoba)
CREATE(CipelarnikHEMNES)-[:JE_DEO {uloga:['cipelarnik']}]->(Hodnik)
CREATE(CipelarnikHEMNES)-[:SACINJEN_OD]->(Aluminijum)
CREATE(CipelarnikJOHNAS)-[:JE_DEO {uloga:['cipelarnik']}]->(Hodnik)
CREATE(CipelarnikJOHNAS)-[:SACINJEN_OD]->(Iverica)
CREATE(StalakEKRAR)-[:JE_DEO {uloga:['civiluk']}]->(Hodnik)
CREATE(StalakEKRAR)-[:SACINJEN_OD]->(Aluminijum)
CREATE(KuhinjskiElementMAXID)-[:JE_DEO {uloga:['donji kuhinjski element']}]->(Kuhinja)
CREATE(KuhinjskiElementMAXID)-[:SACINJEN_OD]->(Medijapan)
CREATE(KuhinjskiElementMAXIU)-[:JE_DEO {uloga:['gornji kuhinjski element']}]->(Kuhinja)
CREATE(KuhinjskiElementMAXIU)-[:SACINJEN_OD]->(Medijapan)
CREATE(TepihLily)-[:JE_DEO {uloga:['tepih']}]->(DnevnaSoba)
CREATE(TepihLily)-[:JE_DEO {uloga:['tepih']}]->(DecijaSoba)
CREATE(TepihLily)-[:JE_DEO {uloga:['tepih']}]->(RadnaSoba)
CREATE(TepihLily)-[:JE_DEO {uloga:['tepih']}]->(SpavacaSoba)
CREATE(TepihLily)-[:SACINJEN_OD]->(Vuna)
CREATE(ProstirkaVINDUM)-[:JE_DEO {uloga:['prostirka']}]->(Kupatilo)
CREATE(ProstirkaVINDUM)-[:JE_DEO {uloga:['prostirka']}]->(Kuhinja)
CREATE(ProstirkaVINDUM)-[:SACINJEN_OD]->(Pamuk)
CREATE(OgledaloEKNE)-[:JE_DEO {uloga:['ogledalo']}]->(Hodnik)
CREATE(OgledaloEKNE)-[:SACINJEN_OD]->(Mahagoni)
CREATE(OgledaloHUNDIG)-[:JE_DEO {uloga:['ogledalo']}]->(Kupatilo)
CREATE(OgledaloHUNDIG)-[:SACINJEN_OD]->(BelaPlastika)
CREATE(SvecnjakGRAND)-[:JE_DEO {uloga:['svecnjak']}]->(Trpezarija)
CREATE(SvecnjakGRAND)-[:SACINJEN_OD]->(Staklo)
CREATE(AQUATICA)-[:JE_DEO {uloga:['biljka']}]->(DnevnaSoba)
CREATE(AQUATICA)-[:JE_DEO {uloga:['biljka']}]->(Trpezarija)
CREATE(FICUS)-[:JE_DEO {uloga:['biljka']}]->(DnevnaSoba)
CREATE(FICUS)-[:JE_DEO {uloga:['biljka']}]->(Trpezarija)
CREATE(CasovnikWIND)-[:JE_DEO {uloga:['casovnik']}]->(Trpezarija)
CREATE(CasovnikWIND)-[:JE_DEO {uloga:['casovnik']}]->(DnevnaSoba)
CREATE(CasovnikWIND)-[:SACINJEN_OD]->(Hrast)
CREATE(CasovnikCLOCK)-[:JE_DEO {uloga:['casovnik']}]->(Trpezarija)
CREATE(CasovnikCLOCK)-[:JE_DEO {uloga:['casovnik']}]->(DnevnaSoba)
CREATE(CasovnikCLOCK)-[:SACINJEN_OD]->(CrnaPlastika)
CREATE(SveceOASIS)-[:JE_DEO {uloga:['svece']}]->(Trpezarija)
CREATE(SveceOASIS)-[:JE_DEO {uloga:['svece']}]->(SpavacaSoba)
CREATE (SveceOASIS)-[:JE_DEO {uloga:['svece']}]->(DnevnaSoba)