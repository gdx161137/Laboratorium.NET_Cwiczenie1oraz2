using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium.NET;

namespace Laboratorium.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            SPRAWDZENIE ĆWICZENIA 1
                        Samochod s1 = new Samochod(); 
                        s1.WypiszInfo(); // nie bardzo wiem po co jest ten fragment - zakładam, że do sprawdzenia czy jest ok. Wypisuje on dane jeszcze przed ich wprowadzeniem ale zgodnie z treścią ćwiczenia zostawiam.
                        s1.Marka = "Fiat"; 
                        s1.Model = "126p"; 
                        s1.IloscDrzwi = 2; 
                        s1.PojemnoscSilnika = 650;
                        s1.SrednieSpalanie = 6.0;
                        s1.WypiszInfo();

                        Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
                        s2.WypiszInfo();

                        double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85); Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
                        Samochod.WypiszIloscSamochodow();

                        Console.ReadKey();
            */

            // SPRWADZENIE ĆWICZENIA 2
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0); 
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
            
            Gracz g1 = new Gracz(); 
            g1.Adres = "ul. Garażowa 1"; 
            g1.Pojemnosc = 1; 
            
            Gracz g2 = new Gracz("ul. Garażowa 2", 2); 
            
            g1.WprowadzSamochod(s1); 
            g1.WypiszInfo(); 
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2); 
            g2.WprowadzSamochod(s1); 
            g2.WypiszInfo();
            g2.WyprowadzSamochod(); 
            g2.WypiszInfo();
            g2.WyprowadzSamochod(); 
            g2.WyprowadzSamochod();

            Console.ReadKey();

        }
    }
}
