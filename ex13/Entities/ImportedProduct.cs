using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex13.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return $"{base.Name} $ {TotalPrice()} (CustomsFee fee: $ {CustomsFee} )";
        }
    }
}