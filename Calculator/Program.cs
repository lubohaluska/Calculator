using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("napis nieco, napr. cislo> ");  //tu vypise text
            string line = Console.ReadLine();  //tymto si konvertujem na cislo z cohokolvek
            int a = Convert.ToInt32(line);


            IntCalculator intCalculator = new IntCalculator();

            int sucet = intCalculator.Add(10, 5);

            Console.WriteLine("Sucet cisiel 10 + 5 je: {0} ", sucet);



            IntCalculator intCalculator1 = new IntCalculator();

            int podiel = intCalculator1.Divide(10, 5);

            Console.WriteLine("Podiel cisiel 10 + 5 je: {0} ", podiel);



            FloatCalculator floatCalculator = new FloatCalculator();
            //            float res = floatCalculator.Add(14.5565f, 12.5f); na dalsom ide to a z line

            float res = floatCalculator.Add(a, 12.5f);
            Console.WriteLine("Vysledek suctu float je {0:0.00}", res);  //formatovanie vystupu na dve miesta


            string naformatovanyString = String.Format("Vysledek suctu {0}", res);
            //novy csahrp postup na formatovani stringu
            string novyCSharFormat = $"Vysledek suctu {res} a dalsi vysledek je {podiel}"; /// skratene formatovanie


            //sekvencia lomitok v ceste sa da pisat takto:
            string cestaKSouboru = "C:\\temp\\log.txt";
            string cestaKSouboru1 = @"C:\temp\log.txt";



            Console.ReadLine();

           
        }
    }
}
