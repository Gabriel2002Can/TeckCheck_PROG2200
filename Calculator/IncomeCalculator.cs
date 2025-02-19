using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class IncomeCalculator
    {
        public double GetAnnualIncome(double monthlyIncome) 
        {

            if (monthlyIncome <= 0)
            {
                throw new InvalidOperationException("Income must be greater than zero");
            }
            else
            {
                return monthlyIncome * 12;
            }
        }

        public double GetWeeklyIncome(double annualIncome)
        {

            if (annualIncome <= 0)
            {
                throw new InvalidOperationException("Income must be greater than zero");
            }
            else
            {
                return annualIncome / 52;
            }
        }

        public TaxEntries GetTaxPayment(double annualEarning, double donAmount)
        {

            if (annualEarning <= 0 || donAmount <= 0)
            {
                throw new InvalidOperationException("The annual earning and donation amount must be greater than zero");
            }
            else
            {
                TaxEntries taxIncome = new TaxEntries(annualEarning, donAmount);

                return taxIncome;
            }
        }

    }
}
