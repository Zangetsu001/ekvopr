using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Converter
    {
        private double usdRate;
        private double eurRate;
        private double rubRate;

        public Converter(double usd, double eur, double rub)
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }

 
        public double ConvertFromBYN(string currency, double amount)
        {
            currency = currency.ToUpper();

            if (currency == "USD")
                return amount / usdRate;
            else if (currency == "EUR")
                return amount / eurRate;
            else if (currency == "RUB")
                return amount / rubRate;
            else
                return 0;
        }

        public double ConvertToBYN(string currency, double amount)
        {
            currency = currency.ToUpper();

            if (currency == "USD")
                return amount * usdRate;
            else if (currency == "EUR")
                return amount * eurRate;
            else if (currency == "RUB")
                return amount * rubRate;
            else
                return 0;
        }
    }
}
