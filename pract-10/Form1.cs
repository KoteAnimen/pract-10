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
    public partial class Form1 : Form
    {
        public int id = 0;
        public List<int> cost_Self = new List<int>();
        public List<int> cost_Sell = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            cost_Self.Add((int)selfCost.Value);
            cost_Sell.Add((int)costSell.Value);
            productsList.Items.Add(cost_Self.Count + ". " + nameProduct.Text + " затраты - " + cost_Self[id] + ", цена - " + cost_Sell[id]);
            id++;
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            int j = 0;
            while (j < cost_Self.Count)
            {
                if (cost_Sell[j] - cost_Self[j] < 0)
                {
                    answer.Text = (j + 1).ToString();
                    break;
                }
                j++;
            }
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
