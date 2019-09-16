using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    class Converter
    {
        private double usd;
        private double eur;

        public Converter(double _usd, double _eur)
        {
            usd = _usd;
            eur = _eur;
        }
        public void ConvertFromDollars(double hrn)
        {
            Console.Write("Dollars in hryvnas: ");
            Console.WriteLine("{0:0.##}", (hrn / usd));
        }
        public void ConvertFromEuros(double hrn)
        {
            Console.Write("Euros in hryvnas: ");
            Console.WriteLine("{0:0.##}", (hrn / eur));
        }
        public void ConvertToDollars(double hrn)
        {
            Console.Write("Hryvnas in dollars: ");
            Console.WriteLine("{0:0.##}", (hrn * usd));
        }
        public void ConverttoEuros(double hrn)
        {
            Console.Write("Hryvnas in euros: ");
            Console.WriteLine("{0:0.##}", (hrn * eur));
        }
    }
}
