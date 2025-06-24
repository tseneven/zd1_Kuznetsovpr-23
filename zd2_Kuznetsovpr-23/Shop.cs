using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_Kuznetsovpr_23
{
    internal class Shop
    {
        private Dictionary<Product, int> products;
        private ListBox _listbox;
        private decimal allPrice;


        public Shop(ListBox listBox)
        {
            products = new Dictionary<Product, int>();
            _listbox = listBox;
        }

        // Метод для добавления продукта в список
        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }

        //Метод для печати всего списка
        public void WriteAllProducts()
        {
            _listbox.Items.Clear();
            _listbox.Items.Add("Список продуктов:");
            foreach (var product in products)
            {
                _listbox.Items.Add(product.Key.GetInfo()+" Количество: "+ product.Value);
            }
        }
        
        // Метод для создания продукта
        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }

        public void Sell(Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    _listbox.Items.Add("Нет в наличии!");
                }
                else
                {
                    products[product]--;
                    allPrice += product.Price;
                }
            }
            else
            {
                _listbox.Items.Add("Товар не найден!");
            }
        }

        //Метод для поиска по имени
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        //Метод продажи
        public void Sell(string ProductName)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell);
            }
            else
            {
                _listbox.Items.Add("Товар не найден!");
            }
        }

        //Метод получения прибыли магазина
        public decimal GetProfit()
        {
            return allPrice;
        }

        //Метод с перегрузкой получения прибыли магазина
        public decimal GetProfit(decimal nalog)
        {
            return allPrice - nalog;
        }
    }
}
