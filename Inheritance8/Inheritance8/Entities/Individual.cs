using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance8.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double perc = 0;
            if (base.Tax() <= 20000.0)
            {
                perc = 0.15;
            } else
            {
                perc = 0.25;
            }

            if(HealthExpenditures > 0)
            {
                return (base.Tax() * perc) - (HealthExpenditures * 0.5);
            }
           
            return base.Tax() * perc;
        }
    }
}
