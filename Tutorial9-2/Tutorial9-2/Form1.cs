using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //the getphonedata method accepts a cellphone object as an argument. it assigns
        // the data entered by the user to the object's properties.
        private void GetPhoneData(Cellphone phone)
        {
            //temporary variable to hold the price
            decimal price;

            //get the phone's brand
            phone.Brand = brandTextbox.Text;

            //get the phone's model
            phone.Model = modelTextBox.Text;

            //Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                //display an error message
                MessageBox.Show("Invalid price");
            }
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {
            //create a cellphone object
            Cellphone myPhone = new Cellphone();

            //Get the phone data
            GetPhoneData(myPhone);

            //display the phone data
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
