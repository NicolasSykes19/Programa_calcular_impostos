using System;
using System.Collections.Generic;
using System.Text;

namespace AulasCSHARP2.Entities
{
    internal class PhysichalPerson : Taxpayer
    {
        public double MedicalExpenses { get; set; }

        public PhysichalPerson(string name, double annualIncome, double medicalExpenses) : base(name, annualIncome)
        {
            MedicalExpenses = medicalExpenses;
        }

        public override double TotalRate()
        {
            double total;

            if (AnnualIncome < 20000)
            {
                total = (AnnualIncome * 0.15);

            }
            else
            {
                total = (AnnualIncome * 0.25);
            }

            if (MedicalExpenses > 0)
            {
                total = total - (MedicalExpenses * 0.50);
            }

            return total;
        }

    }
}
