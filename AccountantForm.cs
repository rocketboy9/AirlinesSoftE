using Airlines.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines
{
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            SqliteDataService svc = new SqliteDataService();
            List<FlightModel> flights = svc.GetFlights();
            List<Ticket> tickets = svc.GetAllTickets();

            richTextBoxAccountSummary.Text = "Number of Flights: " + flights.Count.ToString() + "\n";


            foreach (FlightModel flight in flights)
            {
                List<Ticket> ticketsForFlight = tickets.Where(s => s.FlightID == flight.FlightID).ToList();
                double percentage = ticketsForFlight.Count / flight.Capacity;
                richTextBoxAccountSummary.Text += "FlightID: " + flight.FlightID.ToString() + "\n";
                richTextBoxAccountSummary.Text += "Path: " + flight.Lane + "\n";
                richTextBoxAccountSummary.Text += "Number of people on the flight: " + ticketsForFlight.Count.ToString() + "\n";
                richTextBoxAccountSummary.Text += "Flight capacity: " + flight.Capacity.ToString() + "\n";
                richTextBoxAccountSummary.Text += "Percentage of flight full: " + percentage * 100 + "%\n";
                richTextBoxAccountSummary.Text += "Income on flight: " + ticketsForFlight.Sum(s => s.PricePaid) + "\n\n";
            }

            textBoxTotalIncome.Text = tickets.Sum(s => s.PricePaid).ToString();
        }
    }
}
