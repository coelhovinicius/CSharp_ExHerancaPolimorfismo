/* >>> CLASSE USEDPRODUCT <<< */
using System;
using System.Globalization;

namespace Aula133_HerancaPolimorfismo_ExProposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + base.Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
