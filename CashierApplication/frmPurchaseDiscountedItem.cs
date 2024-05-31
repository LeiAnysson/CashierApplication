using ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        string itemName;
        double price, discount;
        int quantity;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemName = textBox1.Text;
            double price, discount;
            price = Convert.ToDouble(textBox2.Text);
            discount = Convert.ToDouble(textBox3.Text);
            quantity = Convert.ToInt32(textBox4.Text);

            DiscountedItem disItem = new DiscountedItem(itemName, price, quantity, discount);

            label6.Text = disItem.getTotalPrice().ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemName = textBox1.Text;
            double price, discount;
            price = Convert.ToDouble(textBox2.Text);
            discount = Convert.ToDouble(textBox3.Text);
            quantity = Convert.ToInt32(textBox4.Text);
            DiscountedItem disItem = new DiscountedItem(itemName, price, quantity, discount);
            
            disItem.setPayment(Convert.ToDouble(textBox5.Text));
            label8.Text = disItem.getChange().ToString();
        }
    }
}
