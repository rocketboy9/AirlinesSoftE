using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlines.Models;

namespace Airlines
{
    public partial class MainForm : Form
    {
        CustomerModel Customer;
        FlightModel RecommendedFlight;
        FlightModel CurrentFlight;
       
        public MainForm(CustomerModel customer)
        {
            InitializeComponent();
            this.Customer = customer;

            Setup();
        }

        private void Setup()
        {
            labelCurrentCustomer.Text = Customer.FirstName + " " + Customer.LastName;
            dateTimePickerInitialFlight.Value = DateTime.Now;
            dateTimePickerReturnFlight.Value = DateTime.Now;

            if (Customer.FlightID != null && Customer.FlightID != 0)
            {
                FlightModel flight = GetCustomerFlight(Customer.FlightID);
                SetupRichTextBoxAndButton(flight);
                CurrentFlight = flight;
                buttonAcceptFlight.Text = "Cancel Flight";
            }
        }

        private FlightModel GetCustomerFlight(int CustomerID)
        {
            SqliteDataService svc = new SqliteDataService();
            FlightModel flight = svc.GetFlight(CustomerID);
            return flight;
        }

        private void checkBoxRoundTrip_CheckedChanged(object sender, EventArgs e)//makes the datetimeReturnFlight visible or invisible
        {
            if (checkBoxRoundTrip.Checked)
            {
                labelReturnFlight.Visible = true;
                dateTimePickerReturnFlight.Visible = true;
            }
            else
            {
                labelReturnFlight.Visible = false;
                dateTimePickerReturnFlight.Visible = false;
            }
        }

        private void buttonFindOrCreateFlight_Click(object sender, EventArgs e)
        {
            if (IsError())//checks for errors with what the user types in the boxes before creating a flight
                return;
            
            CheckFlights();
        }



        private void SetupRichTextBoxAndButton(FlightModel flight)
        {
            
            int distance = flight.getDistance();

            richTextBoxFlightInformation.Text =
                $"Flight ID: {flight.FlightID}\n" +
                $"Take Off Time: {flight.TakeoffTime}\n" +
                $"Capacity: {flight.Capacity}\n" +
                $"Origin: {flight.OriginCity}\n" +
                $"Destination: {flight.DestinationCity}\n" +
                $"Distance: {distance}";

            richTextBoxFlightInformation.Visible = true;
            buttonAcceptFlight.Visible = true;
        }

        private void CheckFlights()//checks to see if there are any relevant flights in the interest of the customer
        {
            SqliteDataService svc = new SqliteDataService();
            List<FlightModel> flights = svc.GetFlights();

            FlightModel recomendedFlight = GetRecommendedFlights(flights);

            if (recomendedFlight != null)
            {
                RecommendedFlight = recomendedFlight;
                SetupRichTextBoxAndButton(recomendedFlight);
            }

            else
            {
                richTextBoxFlightInformation.Visible = true;
                richTextBoxFlightInformation.Text = "No relevant Flights\n Sorry :(";
            }
        }

        private FlightModel GetRecommendedFlights(List<FlightModel> flights)
        {
            CitiesList citiesList = new CitiesList();
            string origin = textBoxOrigin.Text;
            string destination = textBoxDestination.Text;
            DateTime Takeoff = dateTimePickerInitialFlight.Value;//trim down list to some cities that have the same origin and destination
            List<FlightModel> result = flights.Where(f => string.Equals(f.OriginCity, origin) && string.Equals(f.DestinationCity, destination)).ToList();

            if (result.Count == 1)
                return result[0];
            else if (result.Count > 1)
            {                               //get a single flight that is within a week of the user's needed take off time
                FlightModel flight = result.Where(r => r.TakeoffTime < Takeoff.AddDays(7) && r.TakeoffTime > Takeoff.AddDays(7)).FirstOrDefault();
                if (flight != null)
                    return flight;
                else if (flight == null)
                    return result.FirstOrDefault();//asdf
            }

            return null;
        }

        private bool IsError()
        {
            bool isError = false;

            var lightRed = "#ffcccb";

            if (!checkBoxRoundTrip.Checked)//Checks that initial flight time is a day past whatever the time is now and if it is more than 6 months in the future or 180 days
            {
                if (dateTimePickerInitialFlight.Value > DateTime.Now.AddDays(180) || dateTimePickerInitialFlight.Value.AddDays(1) < DateTime.Now)
                {
                    isError = true;
                    dateTimePickerInitialFlight.BackColor = ColorTranslator.FromHtml(lightRed);
                }
            }
            else if (dateTimePickerReturnFlight.Checked)//Checks that return flight is greater than the initial flight by two days
            {
                if (dateTimePickerInitialFlight.Value > DateTime.Now.AddDays(180) || 
                    dateTimePickerInitialFlight.Value.AddDays(1) < DateTime.Now || 
                    dateTimePickerReturnFlight.Value < dateTimePickerInitialFlight.Value.AddDays(2))
                {
                    isError = true;
                    dateTimePickerInitialFlight.BackColor = ColorTranslator.FromHtml(lightRed);
                    dateTimePickerReturnFlight.BackColor = ColorTranslator.FromHtml(lightRed);

                }
            }

            //Add in some error checks when we chose the 10 cities and make sure there are valid cities in the text boxes

            return isError;
        }

        private void buttonAcceptFlight_Click(object sender, EventArgs e)
        {
            SqliteDataService svc = new SqliteDataService();

            if (buttonAcceptFlight.Text == "Pay and Resrve seat for flight")
            {
                richTextBoxFlightInformation.Text = "Current Flight: \n" + richTextBoxFlightInformation.Text;
                buttonAcceptFlight.Text = "Cancel Flight";

                svc.UpdateCustomerFlight(Customer.Id, RecommendedFlight.FlightID);

                Ticket ticket = new Ticket()
                {
                    FirstName = Customer.FirstName,
                    LastName = Customer.LastName,
                    FlightID = RecommendedFlight.FlightID,
                    UserID = Customer.Id,
                    PointsPaid = 0,//Need to Update the PricePaid and the PointsPaid at some point
                    PricePaid = 0   //Need to update the PricePaid and the PointsPaid at some point
                };

                //Also need to create another ticket if there is a return flight

                svc.CreateTicket(ticket);

            }
            else if(buttonAcceptFlight.Text == "Cancel Flight")
            {
                //Insert code here to take the customer off the flight and give them credit or point refund
                buttonAcceptFlight.Visible = false;
                buttonAcceptFlight.Text = "Pay and Resrve seat for flight";
                richTextBoxFlightInformation.Visible = false;
                svc.UpdateCustomerFlight(Customer.Id);

                svc.DeleteTicketsForUser(Customer.Id);

                RecommendedFlight = null;

            }
        }
    }
}
