using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }


        public void SetOrderDetails(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }


        public double GetTotalWithoutVAT(double unitPrice)
        {
            return unitPrice * quantity;
        }


        public double GetTotalWithVAT(double unitPrice)
        {
            double total = GetTotalWithoutVAT(unitPrice);
            double vat = total * 0.20;
            return total + vat;
        }


        public string GetArticle()
        {
            return article;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
}
