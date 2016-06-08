﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kadry1
{
    class Adres
    {
        public string Miejscowosc { set; get; }
        public string Kod { set; get; }
        public string NazwaUlicy { set; get; }
        public int NumerDomu { set; get; }
        public int? NumerMieszkania { set; get; }

        public Adres(int numerDomu, int? numerMieszkania, string nazwaUlicy, string kod, string miejscowosc)
        {
            this.NumerDomu = numerDomu;
            this.NumerMieszkania = numerMieszkania;
            this.NazwaUlicy = nazwaUlicy;
            this.Kod = kod;
            this.Miejscowosc = miejscowosc;
        }
        public Adres(int numerDomu, int? numerMieszkania, string nazwaUlicy)
            :this(numerDomu,numerMieszkania,nazwaUlicy,"02-222", "Warszawa")
        {            
        }
        public Adres(int numerDomu, int? numerMieszkania)
            : this(numerDomu, numerMieszkania, "Aleje Jerozolimskie")
        {
        }
        public Adres(int numerDomu)
            :this(numerDomu, null)
        {            
        }

        public Adres(Adres adres)
            : this(adres.NumerDomu, adres.NumerMieszkania, adres.NazwaUlicy, adres.Kod,adres.Miejscowosc)
        {
        }

          
    }
       class Osoba
       {
            public string Nazwisko { set; get; }
            public string Imie{ set; get; }
            readonly int numerEwidencyjny;
            public int NumerEwidencyjny
            {
                get { return numerEwidencyjny; }
            }
            public Adres AdresZamieszkania { set; get; }
            private int rokUrodzenia;
            public int RokUrodzenia
            {
                get { return rokUrodzenia;  }
                set
                {
                    if (value > DateTime.Now.Year)
                        throw new ArgumentException("Rok urodzenia musi być wcześniejszy od bieżącego");
                    rokUrodzenia = value;
                }
            }

            public int Wiek
            {
                get { return DateTime.Now.Year - rokUrodzenia; }
            }

           public Osoba(int numerEwidencyjny, int rokUrodzenia, string imie, string nazwisko, Adres adres)
            {
                this.rokUrodzenia = rokUrodzenia;
                this.numerEwidencyjny = numerEwidencyjny;
                this.Imie = imie;
                this.Nazwisko = nazwisko;
                AdresZamieszkania = adres;
            }

            public Osoba(int numerEwidencyjny, int rokUrodzenia, string imie, string nazwisko, int numerDomu, int? numerMieszkania, string nazwaUlicy, string kod, string miejscowosc)
                : this(numerEwidencyjny, rokUrodzenia, imie, nazwisko, new Adres(numerDomu,numerMieszkania,nazwaUlicy,kod,miejscowosc))
            {         
            }

        

            public Osoba(int numerEwidencyjny, int rokUrodzenia, string imie, int numerDomu)
                : this(numerEwidencyjny, rokUrodzenia, imie, "Kowalski", numerDomu, null, "Aleje Jerrozolimskie", "02-222", "Warszawa")
            {
            }
            public Osoba(Osoba osoba)
            {
                numerEwidencyjny = osoba.numerEwidencyjny;
                Imie = osoba.Imie;
                Nazwisko = osoba.Nazwisko;
                AdresZamieszkania = new Adres(osoba.AdresZamieszkania);            
            }         
        }
}
