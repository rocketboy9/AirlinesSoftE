using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoCoordinatePortable;


namespace Airlines.Models
{

    public class Ticket
    {
        public int TicketID { get; set; }
        public int FlightID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double PricePaid { get; set; }
        public int PointsPaid { get; set; }
        public string FullName { get; set; }
    }
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public int PointsUsed { get; set; }
        public int PointsAvailable { get; set; }
        public string Password { get; set; }
        public string CreditCard { get; set; }
        public int FlightID { get; set; }
        public bool FlightManager { get; set; }
        public bool LoadEngineer { get; set; }
        public bool Accountant { get; set; }
        public bool MarketingManager { get; set; }
    }

    public class FlightModel
    {
        public int FlightID { get; set; }
        public AirplaneTypeID AirplaneTypeID { get; }
        private void AirplaneTypeIDSet(AirplaneTypeID AT)
        {
            switch (AT)
            {
                case AirplaneTypeID.plane757:
                    Capacity = 239;
                    break;
                case AirplaneTypeID.plane767:
                    Capacity = 245;
                    break;
                case AirplaneTypeID.plane777:
                    Capacity = 312;
                    break;
                default:
                    Capacity = 5;
                    break;
            }
        }
        public int Capacity { get; set; }
        public string OriginCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime TakeoffTime { get; set; }
        public string Lane { get; set; }
    
        public int getDistance()
        {
            CitiesList citiesList = new CitiesList();
            City origin = citiesList.cities.Where(s => string.Equals(s.name, OriginCity)).FirstOrDefault();
            City Destination = citiesList.cities.Where(s => string.Equals(s.name, DestinationCity)).FirstOrDefault();

            return citiesList.GetDistanceBetweenCities(origin, Destination); 
        }

        public double getPrice()
        {
            double price = 0;
            double fixedPrice = 50;
            double TSAperSegment = 8;

            int distanceInMiles = getDistance();
            double distancePrice = .12 * distanceInMiles;

            //red eye discount
            if (TakeoffTime.Hour < 5 || TakeoffTime.AddHours(distanceInMiles / 500).Hour < 5)//if leaving or arriving before 5 am then 20% red-eye discount
            {
                distancePrice = distancePrice * .80;
            }
            else if(TakeoffTime.Hour<8 || TakeoffTime.AddHours(distanceInMiles / 500).Hour > 19)//if leaving before 8 or arriving after 7 pm gets 10% discount 
            {
                distancePrice = distancePrice * .90;

            }

            return distancePrice;
        }
    }


        

    public enum AirplaneTypeID
    {
        plane757,//0
        plane767,//1
        plane777//3
    }

    public class City
    {
        public string name;
        public double latitude;
        public double longitude;
    }

    public class CitiesList
    {
        public List<City> cities = new List<City>
        {
            new City() {name = "Nashville", latitude = 36.16, longitude = 86.78},
            new City() {name = "Cleveland", latitude = 41.5, longitude = 81.69 },
            new City() {name = "Detroit", latitude = 42.33, longitude = 83.05},
            new City() {name = "Denver", latitude = 39.74, longitude = 104.99},
            new City() {name = "Orlando", latitude = 28.54, longitude = 81.38},
            new City() {name = "Dallas", latitude = 32.78, longitude = 96.8 },
            new City() {name = "Seattle", latitude = 47.61, longitude = 122.33},
            new City() {name = "Chicago", latitude = 41.88, longitude = 87.63 },
            new City() {name = "Atlanta", latitude = 33.75, longitude = 84.39},
            new City() {name = "New York", latitude = 40.71, longitude = 74.01 },
        };

        public int GetDistanceBetweenCities(City Origin, City Destination)//returns the miles between cities
        {
            GeoCoordinate origin = new GeoCoordinate(Origin.latitude, Origin.longitude);
            GeoCoordinate destination = new GeoCoordinate(Destination.latitude, Destination.longitude);


            double distanceInMiles = origin.GetDistanceTo(destination)/1609.344;
            int distance = Convert.ToInt32(distanceInMiles);
            return distance;
        }
    }
}
