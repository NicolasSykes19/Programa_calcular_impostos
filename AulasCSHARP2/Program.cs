using AulasCSHARP2.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Globalization;

namespace AulasCSHARP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Taxpayer> list = new List<Taxpayer>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Tax payer #" + i);
                Console.Write("Individual or company? (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualInc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PhysichalPerson(name,annualInc, healthExp));

                }
                else
                {
                    Console.Write("Number of emplyees: ");
                    int numberEmp = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, annualInc, numberEmp));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Taxpayer p in list)
            {
                Console.WriteLine(p.Name + " $ " + p.TotalRate().ToString("F2"));
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: ");
            double sum = 0;
            foreach (Taxpayer p in list)
            {
                sum += p.TotalRate();
            }
            Console.WriteLine("$ " + sum.ToString("F2"));
        }
    }
}
