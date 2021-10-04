using System;

namespace Converter
{
    class Converter
    {
        double usd;
        double eur;
        public Converter(double _usd,double _eur)
        {
            usd = _usd;
            eur = _eur;
        }
        public double GrnToEur(double grnSum)
        {
            return eur * grnSum;
        }
        public double GrnToUsd(double grnSum)
        {
            return usd * grnSum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(26.667, 31.06);
            Console.Write("Print sum: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Grn to eur: " + converter.GrnToEur(sum));
            Console.WriteLine("Grn to usd: " + converter.GrnToUsd(sum));
        }
    }
}
