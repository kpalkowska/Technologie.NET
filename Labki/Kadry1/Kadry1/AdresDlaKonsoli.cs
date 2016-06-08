using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry1
{
    class AdresDlaKonsoli
    {
        private Adres adres;

        public Adres Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public AdresDlaKonsoli()
        {
            Console.Write("Podaj nazwę miejscowości: ");
            string miejscowosc = Console.ReadLine();
            Console.Write("Podaj kod: ");
            string kod = Console.ReadLine();
            Console.Write("Podaj nazwę ulicy: ");
            string nazwaUlicy = Console.ReadLine();
            int nrDomu;
            do{
                Console.Write("Podaj numer domu: ");
            }
            while(!int.TryParse(Console.ReadLine(), out nrDomu));
            Console.Write("Czy jest numer mieszkania <t/n>? ");
            char c = Console.ReadKey().KeyChar;
            int? nrMieszkania;
            if (c == 't')
            {
                int i;
                Console.WriteLine();
                do
                {
                    Console.Write("Podaj numer mieszkania: ");
                }
                while (!int.TryParse(Console.ReadLine(), out i));
                nrMieszkania = i;
            } else {
                nrMieszkania = null;
            }
                this.Adres = new Adres(nrDomu, nrMieszkania, nazwaUlicy, kod, miejscowosc);
            }
            public AdresDlaKonsoli(Adres adres){
                this.Adres = adres;
            }

            public void ZmienMiejscowosc() {
                Console.Write("Podaj nazwę miejscowści: ");
                Adres.Miejscowosc = Console.ReadLine();
            }

            public void ZmienKod() {
                Console.Write("Podaj kod: ");
                Adres.Kod = Console.ReadLine();
            }

            public void ZmienUlice() {
                Console.Write("Podaj nazwę ulicy: ");
                Adres.NazwaUlicy = Console.ReadLine();
            }

            public void ZmienNumerDomu() {
                int numerDomu;
                do {
                Console.Write("Podaj numer domu: ");
                } while (!int.TryParse(Console.ReadLine(),out numerDomu));
                Adres.NumerDomu = numerDomu;
            }

            public void ZmienNrMieszkania() {
                Console.Write("Czy jest numer mieszkania <t/n>: ");
                char c = Console.ReadKey().KeyChar;
                if (c == 't') {
                int i;
                Console.WriteLine();
                do {
                    Console.Write("Podaj numer meszkania: ");
                } while (!int.TryParse(Console.ReadLine(), out i));
                Adres.NumerMieszkania = i;
                } else {
                    Adres.NumerMieszkania = null;
                }
            }

            public void ZmienAdres() {
                ZmienMiejscowosc();
                ZmienKod();
                ZmienUlice();
                ZmienNumerDomu();
                ZmienNrMieszkania();
            }

            public void WypiszAdres(){
                Console.Write("{0} {1} ul. {2} nr {3}", Adres.Kod, Adres.Miejscowosc, Adres.NazwaUlicy, Adres.NumerDomu);
                if(Adres.NumerMieszkania != null ){
                    Console.Write("/{0}", Adres.NumerMieszkania);
                }
            }
    }
}
