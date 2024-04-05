using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium.NET
{
    internal class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika; // odmiennie od treści zadania zmienna nie jest int a double.
        private double srednieSpalanie; // w zadaniu nie ma informacji o jakim srednim spalaniu mówimy. Jest "Średnie spalanie". Przyjmuję, że jest to średnie spalanie na 100km

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        private static int liczbaSamochodow = 0;

        public Samochod()
        {
            liczbaSamochodow++;
        }

        public Samochod(string marka_, string model_, int iloscDrzwi_, double pojemnoscSilnika_, double srednieSpalanie_)
        {
            Marka = marka_;
            Model = model_;
            IloscDrzwi = iloscDrzwi_;
            PojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
            liczbaSamochodow++;
        }

        public double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Ilość drzwi: {IloscDrzwi}");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika} l");
            Console.WriteLine($"Średnie spalanie na 100 km: {SrednieSpalanie} l");
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine($"Liczba utworzonych samochodów: {liczbaSamochodow}");
        }
    }

}
