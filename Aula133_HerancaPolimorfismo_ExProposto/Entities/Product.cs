/* >>> CLASSE PRODUCT <<< */
using System.Globalization;

namespace Aula133_HerancaPolimorfismo_ExProposto.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; protected set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return (Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
