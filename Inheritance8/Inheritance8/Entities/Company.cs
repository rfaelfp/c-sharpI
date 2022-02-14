using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance8.Entities
{
    internal class Company : TaxPayer
    {
        public int NumerOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numerOfEmployees)
            : base(name, anualIncome)
        {
            NumerOfEmployees = numerOfEmployees;
        }

        public override double Tax()
        {
            if (NumerOfEmployees <= 10)
            {
                return base.Tax() * 0.16;
            } else
            {
                return base.Tax() * 0.14;

            }
        }
    }
}
