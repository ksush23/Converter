using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrv;
            do
            {
                Console.WriteLine("Enter how much hryvnas you have: ");
                hrv = Convert.ToDouble(Console.ReadLine());
            } while (hrv <= 0);

            double usd;
            do
            {
                Console.WriteLine("Enter convert course in dollars: ");
                usd = Convert.ToDouble(Console.ReadLine());
            } while (usd <= 0);

            double eur;
            do
            {
                Console.WriteLine("Enter convert course in euros: ");
                eur = Convert.ToDouble(Console.ReadLine());
            } while (eur <= 0);

            Converter conv = new Converter(usd, eur);

            conv.ConvertFromDollars(hrv);
            conv.ConvertFromEuros(hrv);
            conv.ConvertToDollars(hrv);
            conv.ConverttoEuros(hrv);

            Console.ReadKey();
        }
    }
}
