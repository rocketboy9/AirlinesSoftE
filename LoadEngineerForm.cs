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
    public partial class LoadEngineerForm : Form
    {
        FlightModel FlightModel;
        public LoadEngineerForm(FlightModel flightModel)
        {
            InitializeComponent();
            if (flightModel == null)
            {
                Close();
            }
            FlightModel = flightModel;
            Setup();

        }

        private void Setup()
        {
            richTextBoxFlightData.Text = $"Flight ID: {FlightModel.FlightID}\n" +
                                            $"Flight Capacity: {FlightModel.Capacity}\n\n" +
                                            $"Flight Takeoff Time:\n {FlightModel.TakeoffTime}\n\n" +
                                            $"Flight Origin-Destination:\n {FlightModel.OriginCity} - {FlightModel.DestinationCity}";


        }

        private void buttonChangeFlight_Click(object sender, EventArgs e)
        {
            if (IsError())
                return;

            SqliteDataService svc = new SqliteDataService();

            FlightModel.TakeoffTime = dateTimePickerFlightTakeoff.Value; 
            FlightModel.OriginCity = textBoxOrigin.Text; 
            FlightModel.DestinationCity = textBoxDestination.Text;

            svc.UpdateFlight(FlightModel);
            GetFlightandSetup();
        }

        private void GetFlightandSetup()
        {
            SqliteDataService svc = new SqliteDataService();
            FlightModel = svc.GetFlight(FlightModel.FlightID);
            Setup();
        }
        private bool IsError()
        {
            var lightRed = "#ffcccb";
            bool isError = false;

            CitiesList citiesList = new CitiesList();
            var originCheck = citiesList.cities.Where(s => s.name == textBoxOrigin.Text)?.FirstOrDefault();
            var destinationCheck = citiesList.cities.Where(s => s.name == textBoxDestination.Text)?.FirstOrDefault();

            if (originCheck == null || destinationCheck == null)
            {
                textBoxOrigin.BackColor = ColorTranslator.FromHtml(lightRed);
                textBoxDestination.BackColor = ColorTranslator.FromHtml(lightRed);
                isError = true;
            }
            else
            {
                textBoxOrigin.BackColor = TextBox.DefaultBackColor;
                textBoxDestination.BackColor = TextBox.DefaultBackColor;
            }

            if(dateTimePickerFlightTakeoff.Value < DateTime.Now)
            {
                dateTimePickerFlightTakeoff.BackColor = ColorTranslator.FromHtml(lightRed);
                isError = true;
            }
            else
            {
                dateTimePickerFlightTakeoff.BackColor = DateTimePicker.DefaultBackColor;
            }

            return isError;
        }
    }
}
