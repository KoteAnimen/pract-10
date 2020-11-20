using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_10
{

    public struct Product
    {
        public int selfCost;
        public int costSell;

        public Product(int self_Cost, int cost_Sell)
        {
            selfCost = self_Cost;
            costSell = cost_Sell;
        }
    }

    public partial class Form1 : Form
    {
        public List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i < products.Count)
            {
                if(products[i].costSell - products[i].selfCost < 0)
                {
                    answer.Text = (i + 1).ToString();
                    break;                    
                }
                i++;
            }
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            Product product = new Product((int)selfCost.Value, (int)costSell.Value);
            products.Add(product);
            productsList.Items.Add(products.Count + ". " + nameProduct.Text + " затраты - " + product.selfCost + ", цена - " + product.costSell);
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк ИСП-31, вариант 1. В первом одномерном массиве хранятся затраты на производство продуктов, во втором — цены на эти продукты. Указать номер первого продукта, затраты на производство которого превышают цены. ");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
