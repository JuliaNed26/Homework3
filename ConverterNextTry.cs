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
            if (eur == 0)
            {
                throw new Exception("eur is 0");
            }
            return grnSum / eur;
        }
        public double GrnToUsd(double grnSum)
        {
            if(usd == 0)
            {
                throw new Exception("usd is 0");
            }
            return grnSum / usd;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print usd: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Print eur: ");
            double eur = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(usd, eur);
            Console.Write("Print sum: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Grn to eur: " + converter.GrnToEur(sum));
            Console.WriteLine("Grn to usd: " + converter.GrnToUsd(sum));
        }
    }
}
