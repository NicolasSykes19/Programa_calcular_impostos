using System;
using System.Collections.Generic;
using System.Text;

namespace AulasCSHARP2.Entities
{
    internal class LegalPerson : Taxpayer
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double annualIncome,int employees) :base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double TotalRate()
        {
            double total;
            if(Employees > 10) { total = (AnnualIncome * 0.14); }
            else { total = (AnnualIncome * 0.16); }

            return total;
        }
    }
}
