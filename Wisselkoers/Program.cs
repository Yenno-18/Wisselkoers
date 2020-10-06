using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisselkoers
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIE van variabelen en de constante wisselkoers
            Double dblBedragEUR, dblBedragUSD;
            const Double cdblWisselkoers = 1.2231;


            //INPUT
            //Opvragen bedrag in EUR.
            Console.WriteLine("Welk bedrag in EUR wenst u om te zetten in USD? ");
            dblBedragEUR = Convert.ToDouble(Console.ReadLine());

            //PROCESSING
            //Omrekenen van EUR naar USD
            dblBedragUSD = dblBedragEUR * cdblWisselkoers;

            //OUTPUT
            //Resultaat tonen
            Console.WriteLine(dblBedragEUR.ToString() + " EUR is gelijk aan " + Math.Round(dblBedragUSD, 2).ToString() + " USD");
            Console.ReadLine();
         }
    }
}
