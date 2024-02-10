using System;
using System.Collections.Generic;
using System.Linq;
using ex13.Entities;

namespace ex13.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manuFactureDate) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }
    
        public override string PriceTag()
        {
            return $"{base.Name} (used) $ {base.Price} (Manufacture date: {ManuFactureDate.ToString("dd/MM/yyyy")} )";
        }
    }
}