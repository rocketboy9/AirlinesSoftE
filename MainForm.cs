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
        FlightModel RecommendedReturnFlight;
        FlightModel CurrentFlight;

        List<FlightModel> ConnectedInitialFlights;
        List<FlightModel> ConnectedReturnFlights;

        bool IsConnectedInitialFlight = false;
        bool IsConnectedReturnFlight = false;
        bool returnFlight = false;

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
            if (checkBoxRoundTrip.Checked)
            {
                returnFlight = true;
            }

            SqliteDataService svc = new SqliteDataService();
            List<FlightModel> flights = svc.GetFlights();

            FlightModel recomendedFlight = GetRecommendedFlights(flights);



            if (recomendedFlight != null)
            {
                RecommendedFlight = recomendedFlight;

                if (returnFlight == true)
                {
                    GetReturnFlight(flights);
                    GetReturnFlight(flights);
                }

                SetupRichTextBoxAndButton(recomendedFlight);
            }
            else
            {

                List<FlightModel> connectedFlights = GetConnectedFlights(flights, textBoxOrigin.Text, textBoxDestination.Text, dateTimePickerInitialFlight.Value.Date);
                if (connectedFlights != null)
                {
                    ConnectedInitialFlights = connectedFlights;
                    IsConnectedInitialFlight = true;
                }
                //add functionality to search for possibility of 2 legged flight
                richTextBoxFlightInformation.Visible = true;
                richTextBoxFlightInformation.Text = "No relevant Flights\n Sorry :(";
            }
        }

        private void GetReturnFlight(List<FlightModel> flights)
        {

            FlightModel returnFlight = flights.Where(s => string.Equals(s.DestinationCity, textBoxOrigin.Text) && string.Equals(s.OriginCity, textBoxDestination.Text) &&
                                                        (s.TakeoffTime > RecommendedFlight.TakeoffTime && s.TakeoffTime.Day == dateTimePickerReturnFlight.Value.Day)).FirstOrDefault();

            if (returnFlight != null)
            {
                RecommendedReturnFlight = returnFlight;
            }

            if (returnFlight == null)//Get connected return flights if a single return flight doesn't work
            {
                List<FlightModel> ConnectedFlights = GetConnectedFlights(flights, textBoxDestination.Text, textBoxOrigin.Text, dateTimePickerReturnFlight.Value);

                if (ConnectedFlights != null)
                {
                    ConnectedReturnFlights = ConnectedFlights;
                    IsConnectedReturnFlight = true;
                }

            }
            else//a single and a connected route flights could not be found so make recommendedInitialReturnFlight null
            {
                ConnectedReturnFlights = null;
            }

        }

        private List<FlightModel> GetConnectedFlights(List<FlightModel> flights, string Origin, string Destination, DateTime dateOfFlight)//test this asdfasdfasdf
        {
            List<FlightModel> ConnectedFlights = null;

            FlightModel secondFlight = null;

            FlightModel firstFlight = flights.Where(s => s.TakeoffTime.Day == dateOfFlight.Day && string.Equals(Origin, s.OriginCity)).FirstOrDefault();//if its the same day as the return flight is requested and it starts at the same origin city
            if (firstFlight != null)
            {
                secondFlight = flights.Where(s => (s.TakeoffTime > firstFlight.TakeoffTime.AddHours(3) && s.TakeoffTime < firstFlight.TakeoffTime.AddHours(9)) && firstFlight.DestinationCity == s.OriginCity &&
                                                   string.Equals(Destination, s.DestinationCity)).FirstOrDefault();//if the flight is within 3-9 hours of the first one and the first flights destination is the same as this flights origin and the destination is the same as the main destination

            }

            if (firstFlight == null || secondFlight == null)
            {
                return null;
            }
            else
            {
                ConnectedFlights?.Add(firstFlight);
                ConnectedFlights?.Add(secondFlight);

                return ConnectedFlights;
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
                    return result.FirstOrDefault();//get a flight that has the same origin and destination but might not be in the timeframe they desire
            }

            return null;//return null if no flights are available
        }

        private bool IsError()
        {

            CitiesList citiesList = new CitiesList();
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
            var originCheck = citiesList.cities.Where(s => s.name == textBoxOrigin.Text)?.FirstOrDefault();
            var destinationCheck = citiesList.cities.Where(s => s.name == textBoxDestination.Text)?.FirstOrDefault();

            if (originCheck == null || destinationCheck == null)
            {
                textBoxOrigin.BackColor = ColorTranslator.FromHtml(lightRed);
                textBoxDestination.BackColor = ColorTranslator.FromHtml(lightRed);
                isError = true;
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

                if (!IsConnectedInitialFlight)
                {
                    BookFlightAndCreateFinancialTransactionRecord(RecommendedFlight);

                }
                else if (IsConnectedInitialFlight)
                {
                    BookFlightAndCreateFinancialTransactionRecord(ConnectedInitialFlights[0]);//test these to make sure that they are able to work
                    BookFlightAndCreateFinancialTransactionRecord(ConnectedReturnFlights[1]);
                }

                if (checkBoxRoundTrip.Checked)
                {
                    if (!IsConnectedReturnFlight)
                    {
                        BookFlightAndCreateFinancialTransactionRecord(RecommendedReturnFlight);
                    }
                    else if (IsConnectedReturnFlight)
                    {
                        BookFlightAndCreateFinancialTransactionRecord(ConnectedReturnFlights[0]);
                        BookFlightAndCreateFinancialTransactionRecord(ConnectedReturnFlights[1]);
                    }
                }


            }
            else if (buttonAcceptFlight.Text == "Cancel Flight")
            {
                //Insert code here to take the customer off the flight and give them credit or point refund
                buttonAcceptFlight.Visible = false;
                buttonUsePoints.Visible = false;
                buttonAcceptFlight.Text = "Pay and Resrve seat for flight";
                richTextBoxFlightInformation.Visible = false;
                svc.UpdateCustomerFlight(Customer.Id);

                List<Ticket> userTickets = svc.GetUserTickets(Customer.Id);

                foreach (Ticket ticket in userTickets)
                {
                    FinancialTransactions ft = new FinancialTransactions()
                    {
                        UserID = Customer.Id,
                        FlightID = ticket.FlightID,
                        MoneyAmount = ticket.PricePaid,
                        PointsAmount = 0,
                        CustomerPaid = false,//false means that the customer is recieving a refund for their flight
                        TransactionDateTime = DateTime.Now,
                        FirstName = Customer.FirstName,
                        LastName = Customer.LastName,
                        CreditCardNumber = Customer.CreditCard
                    };
                    svc.CreateFinancialTransaction(ft);
                }

                svc.DeleteTicketsForUser(Customer.Id);

                //CreateFinancialTransactionForRefund();

                RecommendedFlight = null;

            }
        }

        private void BookFlightAndCreateFinancialTransactionRecord(FlightModel flight)
        {
            SqliteDataService svc = new SqliteDataService();

            svc.UpdateCustomerFlight(Customer.Id, flight.FlightID);//attaches a flight to the customer so we know they are on the flight, acts as a bool

            double price = RecommendedFlight.getPrice();

            Ticket ticket = new Ticket()
            {
                FirstName = Customer.FirstName,
                LastName = Customer.LastName,
                FlightID = flight.FlightID,
                UserID = Customer.Id,
                PointsPaid = 0,//Need to Update the PricePaid and the PointsPaid at some point
                PricePaid = flight.getPrice()   //Need to update the PricePaid and the PointsPaid at some point
            };
            svc.CreateTicket(ticket);


            FinancialTransactions ft = new FinancialTransactions()
            {
                UserID = Customer.Id,
                FlightID = flight.FlightID,
                MoneyAmount = flight.getPrice(),
                PointsAmount = 0,
                CustomerPaid = true,
                TransactionDateTime = DateTime.Now,
                FirstName = Customer.FirstName,
                LastName = Customer.LastName,
                CreditCardNumber = Customer.CreditCard
            };
            svc.CreateFinancialTransaction(ft);

        }

        private void buttonAccountHistory_Click(object sender, EventArgs e)
        {
            AccountHistoryForm form = new AccountHistoryForm(Customer);
            form.ShowDialog();


        }
    }
}
