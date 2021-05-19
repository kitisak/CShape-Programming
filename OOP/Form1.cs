using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Create Object : Instaniate
            BankAccount account = new BankAccount("Tissana", 500);

            account.Deposit(2000);
            account.Withdraw(400);

            textBoxName.Text = account.AccountName;
            textBoxBalance.Text = Convert.ToString(account.Balance);

        }
    }
}
