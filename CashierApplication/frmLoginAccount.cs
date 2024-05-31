using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Clarisa Castro";
            string un = "cashier101";
            string pw = "cashier12345";
            string fi = "Finance";

            string username = textBox1.Text;
            string password = textBox2.Text;


            Cashier c = new Cashier(name, fi, un, pw);
            bool verify = c.validateLogin(username, password);

            if (verify == true)
            {
                MessageBox.Show("Welcome " + c.getFullName() + " of " + c.getDepartment());
                new frmPurchaseDiscountedItem().Show();
                this.Hide();
            }
            else if (verify == false)
            {
                MessageBox.Show("incorrect username or password.");
            }
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
