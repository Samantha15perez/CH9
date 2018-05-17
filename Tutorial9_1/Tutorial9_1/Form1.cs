using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a coin object
            Coin myCoin = new Coin();

            //clear the listbox
            listBox1.Items.Clear();

            //Toss the coin five times
            for (int count = 0; count < 5; count++)
            {
                //toss the coin
                myCoin.Toss();
                //display the side that is up
                listBox1.Items.Add(myCoin.GetSideUp());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
