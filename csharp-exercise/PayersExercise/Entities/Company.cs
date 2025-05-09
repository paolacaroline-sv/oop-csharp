using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayersExercise.Entities
{
    internal class Company : TaxPayer
    {
        public int Employees { get; set; }
        public Company() { }
        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double TaxPaid()
        {
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }


    }
}
