using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2.Entities
{
    class UsedProduct : Product
    {
        DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manuDate) : base(name, price)
        {
            ManufacturedDate = manuDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price + " (Manufactured Date: " + ManufacturedDate.ToString("dd/MM/yyyy") +")";
        }
    }
}
