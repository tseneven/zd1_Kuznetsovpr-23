using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_Kuznetsovpr_23
{
    internal class Product
    {
        private decimal price;
        private string name;

        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.price = Price;
        }

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }

        // Метод для получения информации о товаре
        public string GetInfo()
        {
            return $"Наименование: {Name}; Цена: {price}";
        }


    }
}
