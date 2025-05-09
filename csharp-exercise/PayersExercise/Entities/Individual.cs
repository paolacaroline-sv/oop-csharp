using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayersExercise.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }
        public Individual() { }
        public Individual(string name, double anualIncome, double healthExpe) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpe;
        }

        public override double TaxPaid()
        {
            if (AnualIncome < 20000)
            {
                return AnualIncome * 0.15 - HealthExpeditures / 2;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpeditures / 2;

            }
        }


    }
}
