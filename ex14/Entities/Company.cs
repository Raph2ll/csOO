using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex14.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }
        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        override public double Tax()
        {
            double ret = 0.0;

            if (NumberOfEmployees > 10)
            {
                ret = AnualIncome * 0.14;
            }
            else
            {
                ret = AnualIncome * 0.16;
            }

            return ret;
        }
    }
}