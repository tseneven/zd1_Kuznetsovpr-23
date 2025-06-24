using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_Kuznetsovpr_23
{
    public partial class Form1 : Form
    {
        Shop pyaterochka;
        Product product;
        public Form1()
        {
            InitializeComponent();
        }

        // Метод с загрузкой формы
        private void Form1_Load(object sender, EventArgs e)
        {
            pyaterochka = new Shop(listBox1);
            pyaterochka.CreateProduct("Кола", 85, 200);
            pyaterochka.CreateProduct("Сок \"Добрый\"", 100, 50);
            pyaterochka.WriteAllProducts();
            label6.Text = $"0 рублей";
            label7.Text = $"0 рублей";

        }

        //Кнопка продажи товара
        private void button1_Click(object sender, EventArgs e)
        {
            pyaterochka.Sell(textBox1.Text);
            pyaterochka.WriteAllProducts();
            label6.Text = $"{pyaterochka.GetProfit().ToString()} рублей";
            label7.Text = $"{pyaterochka.GetProfit(1000).ToString()} рублей";
        }

        // Кнопка добавления товара
        private void button2_Click(object sender, EventArgs e)
        {
            product = new Product(textBox3.Text, Convert.ToDecimal(textBox4.Text));
            pyaterochka.AddProduct(product, Convert.ToInt32(textBox5.Text));
            listBox1.Items.Clear();
            pyaterochka.WriteAllProducts();
        }
    }
}
