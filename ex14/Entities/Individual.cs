using System;
using System.Collections.Generic;
using System.Linq;
using ex14.Entities;

namespace ex14.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() : base()
        {

        }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        override public double Tax()
        {
            double ret = 0.0;

            if (AnualIncome < 20000.00)
            {
                ret = AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                ret = AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }

            return ret;
        }
    }
}