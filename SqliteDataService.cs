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

namespace Airlines
{
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

        //Connection string that has a path to the database
        private string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
//should work now