using System;
using System.Collections.Generic;
using System.Text;

namespace AulasCSHARP2.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TotalRate();
        
    }
}
