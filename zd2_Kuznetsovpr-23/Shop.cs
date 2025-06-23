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

        public decimal AllPrice { get => allPrice;}

        public Shop(ListBox listBox)
        {
            products = new Dictionary<Product, int>();
            _listbox = listBox;
        }

        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }
        public void WriteAllProducts()
        {
            _listbox.Items.Clear();
            _listbox.Items.Add("Список продуктов:");
            foreach (var product in products)
            {
                _listbox.Items.Add(product.Key.GetInfo()+" Количество: "+ product.Value);
            }
        }
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

        
    }
}
