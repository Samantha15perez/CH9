using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_3
{
    public partial class Form1 : Form
    {
        //bankaccount field with a $1000 starting balance
        private BankAccount account = new BankAccount(1000);

        public Form1()
        {
            InitializeComponent();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount; //to hold the amount of the deposit

            //convert the amount to a decimal
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                //Deposit the amount into the account
                account.Deposit(amount);

                //display the new balance
                balanceLabel.Text = account.Balance.ToString("c");

                //clear the text box
                depositTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount; //to hold the amount of the withdrawal

            //convert the amount to a decimal
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                //Deposit the amount into the account
                account.Withdraw(amount);

                //display the new balance
                balanceLabel.Text = account.Balance.ToString("c");

                //clear the text box
                withdrawTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //display starting balance
            balanceLabel.Text = account.Balance.ToString("c");
        }
    }
}
