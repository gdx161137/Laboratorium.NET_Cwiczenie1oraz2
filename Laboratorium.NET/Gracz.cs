using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium.NET;

namespace Laboratorium.NET
{
    internal class Gracz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public Gracz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Gracz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod nowySamochod)
        {
            if (liczbaSamochodow >= pojemnosc)
            {
                Console.WriteLine("Garaż jest pełny. Nie można dodać kolejnego samochodu.");
            }
            else
            {
                samochody[liczbaSamochodow] = nowySamochod;
                liczbaSamochodow++;
            }
        }

        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow > 0)
            {
                Samochod ostatniSamochod = samochody[liczbaSamochodow - 1];
                samochody[liczbaSamochodow - 1] = null;
                liczbaSamochodow--;
                return ostatniSamochod;
            }
            else
            {
                Console.WriteLine("Garaż jest pusty. Nie można wyprowadzić samochodu.");
                return null;
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Adres garażu: {Adres}");
            Console.WriteLine($"Pojemność garażu: {Pojemnosc}");

            Console.WriteLine("Garażowane samochody:");
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
                Console.WriteLine();
            }
        }
    }
}
