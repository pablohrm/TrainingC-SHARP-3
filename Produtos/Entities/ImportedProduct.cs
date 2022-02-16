using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price += CustomsFee;
        }

        public override string PriceTag()
        {
            return ($"{Name}, R$ {totalPrice()}, (Customs Fee: {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
        }
    }
}
