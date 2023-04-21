using Airlines.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Airlines
{
    public partial class AccountHistoryForm : Form
    {
        CustomerModel Customer;
        public AccountHistoryForm(CustomerModel customer)
        {
            InitializeComponent();
            Customer = customer;
            Setup();
        }

        private void Setup()
        {
            List<FinancialTransactions>? fts = null;

            SqliteDataService svc = new SqliteDataService();
            fts = svc.GetFinancialTransactions(Customer.Id);

            List<Ticket> userTickets = null;

            userTickets = svc.GetUserTickets(Customer.Id);

            List<FinancialTransactions> flightsRefunded = fts.Where(s=>s.CustomerPaid == false).ToList();
            List<FinancialTransactions> flightsPaidFor = fts.Where(s=>s.CustomerPaid == true).ToList();

            List<FlightModel> flightModelList = new List<FlightModel>();

            foreach(Ticket ticket in userTickets)
            {
                FlightModel flight = svc.GetFlight(ticket.FlightID);
                flightModelList.Add(flight);
            }

            List<FlightModel> flightsTaken = flightModelList.Where(s=>s.TakeoffTime.Date <= DateTime.Now.Date).ToList();

            if (fts != null)
            {
                foreach (FinancialTransactions transaction in flightsRefunded)
                {
                    richTextBoxFlightsCancelled.Text = richTextBoxFlightsCancelled.Text + $"FlightID: {transaction.FlightID}\nTime booked: {transaction.TransactionDateTime}\n\n";
                }

                foreach (FinancialTransactions transaction in flightsPaidFor)
                {
                    richTextBoxFlightsBooked.Text = richTextBoxFlightsBooked.Text + $"FlightID: {transaction.FlightID}\nTime booked: {transaction.TransactionDateTime}\n\n";
                }

                foreach(FlightModel flight in flightsTaken)
                {
                    richTextBoxFlightsTaken.Text = richTextBoxFlightsTaken.Text + $"FlightID: {flight.FlightID}\nTakeoff Time: {flight.TakeoffTime}\n\n";
                }
            }

            textBoxPointsAvailable.Text = Customer.PointsAvailable.ToString();
            textBoxPointsUsed.Text = Customer.PointsUsed.ToString();
        }
    }
}
