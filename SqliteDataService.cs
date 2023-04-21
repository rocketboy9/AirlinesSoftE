using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using Microsoft.VisualBasic.ApplicationServices;

namespace Airlines
{

    //This class holds all the sql statements that updates inserts deletes data from the sqlite database
    //This class is the bridge between the UI and the Database
    public class SqliteDataService
    {
        //returns a customerModel object from the database by matching the id number using a sql query
        public CustomerModel GetCustomer(int Id)
        {
            CustomerModel customer = null;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = $"SELECT * " +
                                  $"FROM Customers " +
                                  $"WHERE Id = '{Id}'";

                customer = cnn.Query<CustomerModel>(sqlQuery, new DynamicParameters())?.FirstOrDefault();
            }

            return customer;
        }

        //Saves a new customer into the database and returns it if it is from the createAccountForm
        //Uses sql queries in order to save and get the customer
        public CustomerModel SaveCustomer(CustomerModel customer, bool fromCreateAccountForm = false)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Customers(FirstName, LastName, Address, PhoneNumber, Age, Password, CreditCard)" +
                    "VALUES (@FirstName, @LastName, @Address, @PhoneNumber, @Age, @Password, @CreditCard)", customer);

                if (fromCreateAccountForm)
                {
                    string sqlQuery = $"SELECT * " +
                                  $"FROM Customers " +
                                  $"WHERE FirstName = '{customer.FirstName}' AND LastName = '{customer.LastName}'";

                    customer = cnn.Query<CustomerModel>(sqlQuery, new DynamicParameters())?.FirstOrDefault();

                    return customer;
                }
            }
            return null;
        }

        public List<FlightModel> GetFlights()
        {
            List<FlightModel> flights = null;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                    string sqlQuery = $"SELECT *, OriginCity || ' - ' || DestinationCity AS Lane FROM Flights";

                    flights = cnn.Query<FlightModel>(sqlQuery, new DynamicParameters())?.ToList();

                    return flights;
            }
            return null;
        }

        public void UpdateCustomerFlight(int customerID, int? FlightID = null)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if(FlightID == null)
                {
                    cnn.Execute($"UPDATE Customers SET FlightID = NULL WHERE {customerID} = Id");
                }
                else
                {
                    cnn.Execute($"UPDATE Customers SET FlightID = {FlightID} WHERE {customerID} = Id");

                }
            }
        }

        public FlightModel GetFlight(int FlightID)
        {
            FlightModel flight = null;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = $"SELECT * FROM Flights WHERE FlightID = {FlightID}";

                flight = cnn.Query<FlightModel>(sqlQuery, new DynamicParameters())?.FirstOrDefault();

                return flight;
            }
        }

        public List<Ticket> GetPeopleOnFlight(int FlightID)
        {
            List<Ticket> PeopleOnFlight = null;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = $"SELECT *, FirstName || ' - ' || LastName AS FullName FROM Tickets WHERE FlightID = {FlightID}";

                PeopleOnFlight = cnn.Query<Ticket>(sqlQuery, new DynamicParameters())?.ToList();

                return PeopleOnFlight;
            }
            return null;
        }

        public void CreateTicket(Ticket ticket)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Tickets(FlightID, UserID, FirstName, LastName, PricePaid, PointsPaid)" +
                    "VALUES (@FlightID, @UserID, @FirstName, @LastName, @PricePaid, @PointsPaid)", ticket);
            }
        }

        public void DeleteTicketsForUser(int UserID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Tickets WHERE UserID = {UserID}");
            }
        }

        public void UpdateFlight(FlightModel flight)
        {
            string flightTime = flight.TakeoffTime.ToString();
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Flights " +
                            $"SET OriginCity = '{flight.OriginCity}', DestinationCity = '{flight.DestinationCity}', TakeOffTime = '{flightTime}' " +
                            $"WHERE FlightID = {flight.FlightID}");
            }
        }

        public void CreateFinancialTransaction(FinancialTransactions ft)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO FinancialTransactions(FlightID, UserID, FirstName, LastName, MoneyAmount, PointsAmount, CustomerPaid, TransactionDateTime, CreditCardNumber)" +
                    "VALUES (@FlightID, @UserID, @FirstName, @LastName, @MoneyAmount, @PointsAmount, @CustomerPaid, @TransactionDateTime, @CreditCardNumber)", ft);
            }
        }

        public List<Ticket> GetUserTickets(int userID)//returns the tickets so it knows how many to refund
        {
            List<Ticket> ticketsForCustomer = null;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = $"SELECT *, FirstName || ' - ' || LastName AS FullName FROM Tickets WHERE UserID = {userID}";

                ticketsForCustomer = cnn.Query<Ticket>(sqlQuery, new DynamicParameters())?.ToList();

                return ticketsForCustomer;
            }
            return null;
        }

        public List<FinancialTransactions> GetFinancialTransactions(int userID)//returns the tickets so it knows how many to refund
        {
            List<FinancialTransactions> financialTransactionsForCustomer = null;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = $"SELECT * FROM FinancialTransactions WHERE UserID = {userID}";

                financialTransactionsForCustomer = cnn.Query<FinancialTransactions>(sqlQuery, new DynamicParameters())?.ToList();

                return financialTransactionsForCustomer;
            }
            return null;
        }



        //Connection string that has a path to the database
        private string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
//should work now