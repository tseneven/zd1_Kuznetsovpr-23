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
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pyaterochka = new Shop(listBox1);
            pyaterochka.CreateProduct("Кола", 85, 200);
            pyaterochka.CreateProduct("Сок \"Добрый\"", 100, 50);
            pyaterochka.WriteAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pyaterochka.Sell(textBox1.Text);
            pyaterochka.WriteAllProducts();
        }

    }
}
