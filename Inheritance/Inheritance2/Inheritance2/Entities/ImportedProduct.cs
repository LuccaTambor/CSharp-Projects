using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double fee) : base(name, price)
        {
            CustomsFee = fee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + " (Customs fee: $ " + CustomsFee +")";
        }
    }
}
