using System.Text;
using System.Security.Cryptography;
using Airlines.Models;


namespace Airlines
{
    public partial class LoginScreenForm : Form
    {
        public LoginScreenForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (!AllTextBoxesFilled())
                return;

            AccountVerification();
        }

        //Goes into the database to retrieve the customerModel with the id supplied in the id textbox.
        //Then Converts the password in the textbox to hash and compares it with the hash password that is in the specific customerModel
        private void AccountVerification()
        {
            CustomerModel customer = null;

            SqliteDataService svc = new SqliteDataService();
            customer = svc.GetCustomer(Convert.ToInt32(textBoxId.Text));
            var lightRed = "#ffcccb";

            if (customer == null)//database wasn't able to return a customer with this id if the customer is null
            {
                textBoxId.BackColor = ColorTranslator.FromHtml(lightRed);
                textBoxPassword.BackColor = ColorTranslator.FromHtml(lightRed);
                return;
            }

            if (customer.Password.Equals(ConvertToHash(textBoxPassword.Text)))//if passwords match then open the MainForm
            {
                if (customer.FlightManager == true)
                {
                    FlightsListForm flight = new FlightsListForm(true, false, false);
                    flight.ShowDialog();
                    this.Close();
                }
                else if (customer.Accountant == true)
                {
                    //open accountantForm
                }
                else if (customer.LoadEngineer == true)
                {
                    //open Flights List Form
                    FlightsListForm flights = new FlightsListForm(false, true, false);
                    flights.ShowDialog();
                    this.Close();
                }
                else if (customer.MarketingManager == true)
                {
                    //open Flights List Form
                    FlightsListForm flights = new FlightsListForm(false, false, true);
                    flights.ShowDialog();
                    this.Close();
                }
                else
                {
                    //open the customer/Main Form if they don't have any roles
                    MainForm mainform = new MainForm(customer);
                    mainform.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                textBoxId.BackColor = ColorTranslator.FromHtml(lightRed);
                textBoxPassword.BackColor = ColorTranslator.FromHtml(lightRed);
                return;
            }
        }

        //Opens NewAccountForm if buttonCreateNewAccount is pressed
        private void buttonCreateNewAccount_Click(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.ShowDialog();
        }


        //Makes sure all text boxes are filled in before logging in
        //Otherwise if they are not filled in, the function will return false and the textboxes will turn light red
        private bool AllTextBoxesFilled()
        {
            var lightRed = "#ffcccb";
            bool filled = true;

            if (textBoxId.Text == string.Empty)
            {
                textBoxId.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.BackColor = ColorTranslator.FromHtml(lightRed);
                filled = false;
            }

            return filled;
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

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}