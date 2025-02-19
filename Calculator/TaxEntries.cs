using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Luis Gabriel Stedile Portella
//W0490083

namespace Calculator
{
    public class TaxEntries
    {
        public double TaxAmount { get; set; }
        public double DonationDeduct { get; set; }
        public double NetTaxAmount { get; set; }
        public double NetIncome { get; set; }

        public TaxEntries(double annualEarning, double donAmount)
        {
            TaxAmount = annualEarning * 0.4;
            
            if (donAmount >= 50000)
            {
                DonationDeduct = donAmount * 1.25;
            }
            else
            {
                DonationDeduct = donAmount * 0.1;
            }

            NetTaxAmount = TaxAmount - DonationDeduct;

            NetIncome = annualEarning - NetTaxAmount;
        }
    }
}
