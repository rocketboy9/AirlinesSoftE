using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlines.Models;
using System.Security.Cryptography;


namespace Airlines
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (AllTextBoxesFilled())//error check before adding the new customer to the database
            {
                AddCustomerToDB();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Adds a new customer to the database
        private void AddCustomerToDB()
        {
            CustomerModel customer = new CustomerModel()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Password = ConvertToHash(textBoxPassword.Text),
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Age = Convert.ToInt32(textBoxAge?.Text),
                CreditCard = textBoxCreditCard?.Text
            };
            int x = 5;

            SqliteDataService svc = new SqliteDataService();
            CustomerModel newCustomer;
            newCustomer = svc.SaveCustomer(customer, true);//Puts the new customer in the database and also returns the new customer with the newly generated id that will be used to log in 

            if (newCustomer != null)//Account was successfully made and returned from the database with the new Identifier number
            {
                labelID.Text = labelID.Text + Convert.ToString(newCustomer.Id);
                labelID.ForeColor = Color.Green;
                labelID.Visible = true;
                buttonCreateAccount.Enabled = false;

            }                   
            else//Account was not able to be made
            {
                labelID.Text = "failure to create account";
                labelID.ForeColor = Color.Red;
                labelID.Visible = true;

            }

        }

        //Converts strings to a SHA-512 hash value
        private string ConvertToHash(string password)
        {
            string hash;
            var bytes = Encoding.UTF8.GetBytes(password);

            using (SHA512 sha512 = SHA512.Create())
            {
                var byteHash = sha512.ComputeHash(bytes);
                hash = Convert.ToBase64String(byteHash);
            }

            return hash;
        }

        //Makes sure all text boxes are filled in before logging in
        //Otherwise if they are not filled in, the function will return false and the textboxes will turn light red
        private bool AllTextBoxesFilled()
        {
            var lightRed = "#ffcccb";
            bool filled = true;

            if (textBoxFirstName.Text == string.Empty)
            {
                textBoxFirstName.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }
            
            if (textBoxLastName.Text == string.Empty)
            {
                textBoxLastName.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }
            
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            if (textBoxAddress.Text == string.Empty)
            {
                textBoxAddress.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            if (textBoxPhoneNumber.Text == string.Empty)
            {
                textBoxPhoneNumber.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            if (textBoxAge.Text == string.Empty)
            {
                textBoxAge.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            if (textBoxCreditCard.Text == string.Empty)
            {
                textBoxCreditCard.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            return filled;
        }
    }
}
