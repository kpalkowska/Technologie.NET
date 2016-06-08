using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry
{
    class Adres
    {
        private string miejscowosc;
        private string kod;
        private string nazwaUlicy;
        private int nrDomu;
        private int? nrMieszkania;

        public Adres(int nrDomu, int? nrMieszkania, string nazwaUlicy, string kod, string miejscowosc)
        {
            this.nrDomu = nrDomu;
            this.nrMieszkania = nrMieszkania;
            this.nazwaUlicy = nazwaUlicy;
            this.kod = kod;
            this.miejscowosc = miejscowosc;
        }

        public Adres(int nrDomu, int? nrMieszkania, string nazwaUlicy) 
            :this(nrDomu, nrMieszkania, nazwaUlicy, "02-222", "Warszawa") {}

        public Adres(int nrDomu, int? nrMieszkania)
            :this(nrDomu, nrMieszkania, "Aleje Jerozolimskie") {}

        public Adres(int nrDomu)
            :this(nrDomu, null) {}

        public Adres(Adres adres)
            :this(adres.nrDomu, adres.nrMieszkania, adres.nazwaUlicy, adres.kod, adres.miejscowosc) {}

        public string ZwrocInformacjeAdresowe()
        {
            return nrMieszkania != null ?
                string.Format("{0} {1} ul. {2} {3} m. {4}", kod, miejscowosc, nazwaUlicy, nrDomu, nrMieszkania) :
            string.Format("{0} {1} ul. {2} {3}", kod, miejscowosc, nazwaUlicy, nrDomu);
        }

        public string ZwrocMiejscowosc()
        {
            return miejscowosc;
        }

        public string ZwrocNazweUlicy()
        {
            return nazwaUlicy;
        }

        public string ZwrocKod()
        {
            return kod;
        }

        public int ZwrocNumerDomu()
        {
            return nrDomu;
        }

        public int? ZwrocNumerMieszkania()
        {
            return nrMieszkania;
        }

        public void ZmienAdres(){
            Console.WriteLine("Podaj nazwę miejscowości: ");
            miejscowosc = Console.ReadLine();

            Console.WriteLine("Podaj kod: ");
            kod = Console.ReadLine();

            Console.WriteLine("Podaj nazwę ulicy: ");
            nazwaUlicy = Console.ReadLine();

            do{
                Console.WriteLine("Podaj numer domu: ");
            }
            while(!int.TryParse(Console.ReadLine(), out nrDomu));
            Console.WriteLine("Czy jest numer mieszkania <t/n>? ");
            char c = Console.ReadKey().KeyChar;
            if(c == 't'){
                Console.WriteLine();
                int i;

                do{
                    Console.Write("Podaj numer meszkania: ");
                }
                while (!int.TryParse(Console.ReadLine(), out i));
                nrMieszkania = i;
            } else{
                nrMieszkania = null;
            }
        }
    }

    class Osoba
    {
        private string nazwisko;
        private string imie;
        private int numerEwidencyjny;
        private Adres adresZamieszkania;

        public Osoba(int numerEwidencyjny, string imie, string nazwisko, int nrDomu, int? nrMieszkania, string nazwaUlicy, string kod, string miejscowosc)
        {
            this.numerEwidencyjny = numerEwidencyjny;
            this.imie = imie;
            this.nazwisko = nazwisko;
            adresZamieszkania = new Adres(nrDomu, nrMieszkania, nazwaUlicy, kod, miejscowosc);
        }

        public Osoba(int numerEwidencyjny, string imie, string nazwisko, Adres adres)
            : this(numerEwidencyjny, imie, nazwisko, adres.ZwrocNumerDomu(), adres.ZwrocNumerMieszkania(), adres.ZwrocNazweUlicy(), adres.ZwrocKod(), adres.ZwrocMiejscowosc())
        { }

        public Osoba(int numerEwidencyjny, string imie, int nrDomu)
            : this(numerEwidencyjny, imie, "Kowalski", nrDomu, null, "Aleje Jerrozolimskie", "02-222", "Warszawa")
        { }
        public Osoba(Osoba osoba)
        {
            numerEwidencyjny = osoba.numerEwidencyjny;
            imie = osoba.imie;
            nazwisko = osoba.nazwisko;
            adresZamieszkania = new Adres(osoba.adresZamieszkania);
        }

        public string ZwrocInnformacjeOsobowe(){
            return string.Format("Pan(i) {0} {1} o numerze ewidencyjnym {2} zamieszkały(a): {3}",imie, nazwisko, numerEwidencyjny, adresZamieszkania.ZwrocInformacjeAdresowe());
        }

        public Osoba Klonuj()
        {
            return (Osoba)this.MemberwiseClone();
        }

        public void ZmienDaneOsobowe()
        {
            Console.Write("Podaj imię: ");
            imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();
            do
            {
                Console.Write("Podaj numer ewidencyjny: ");
            } while (!int.TryParse(Console.ReadLine(), out numerEwidencyjny));
            adresZamieszkania.ZmienAdres();
        }
    }
}
