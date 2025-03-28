using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Lab3
{
    public partial class pharmacy : Form
    {
        public string result1;
        public pharmacy()
        {
            InitializeComponent();
            generateProductList();
            string result = "Ваша корзина: \r\n";
            textBox1.Text = result;
        }

        private Dictionary<string, string[]> products = new Dictionary<string, string[]>()
        {
            {"От давления", new string[] { "Лозартан", "Физиотенз", "Лориста"}},
            {"От температуры", new string[] { "Нурофен", "Парацетамол", "Ибупрофен"}},
            {"От аллергии", new string[] { "Фенистил", "Виброцил", "Супрастин"}}
        };

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productList.SelectedItem != null)
            {
                string selectedItem = productList.SelectedItem.ToString();

                product1.Text = products[selectedItem][0];
                product2.Text = products[selectedItem][1];
                product3.Text = products[selectedItem][2];
            }
        }

        private void generateProductList()
        {

            foreach (string key in products.Keys)
            {
                productList.Items.Add(key);
            }
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            

            if (product1.Checked)
            {
                result1 += $"{product1.Text}: {productQuantity1.Value}\r\n";
                product1.Checked = false; 
                productQuantity1.Value = 0; 
                
            }
            if (product2.Checked)
            {
                result1 += $"{product2.Text}: {productQuantity2.Value}\r\n";
                product2.Checked = false;
                productQuantity2.Value = 0;
                
            }
            if (product3.Checked)
            {
                result1 += $"{product3.Text}: {productQuantity3.Value}\r\n";
                product3.Checked = false;
                productQuantity3.Value = 0;

            }

            textBox1.Text += result1;
            result1 = ""; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}