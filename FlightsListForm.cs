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
    public partial class FlightsListForm : Form
    {
        bool _initialized = false;
        FlightModel _selectedFlight;
        bool FlightManager;
        bool LoadEngineer;
        bool MarketingManager;


        public FlightsListForm(bool flightManager, bool loadEngineer, bool marketingManager)
        {
            InitializeComponent();
            SetupListBox();

            FlightManager = flightManager;
            LoadEngineer = loadEngineer;
            MarketingManager = marketingManager;


            _initialized = true;
        }

        private void SetupListBox()
        {
            SqliteDataService svc = new SqliteDataService();
            List<FlightModel> flights = svc.GetFlights();

            listBoxFlights.DataSource = flights;
        }

        private void listBoxFlights_Click(object sender, EventArgs e)
        {
            if (listBoxFlights.SelectedIndex == -1)
            {

            }
        }

        private void listBoxFlights_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                if (listBoxFlights.SelectedItem is FlightModel fm && fm != _selectedFlight)
                {
                    _selectedFlight = fm;
                    if (FlightManager)
                    {
                        FlightManagerManifestForm flightManagerManifestForm = new FlightManagerManifestForm(fm);//flight manifest
                        flightManagerManifestForm.ShowDialog();
                    }
                    else if (LoadEngineer)
                    {
                        LoadEngineerForm loadEngineerForm = new LoadEngineerForm(fm);//load engineer form for changing origin and destination
                        loadEngineerForm.ShowDialog();
                    }
                    else if (MarketingManager)
                    {
                        MarketingManagerForm mm = new MarketingManagerForm(fm);//Marketing manager form for changing the Airplane type
                        mm.ShowDialog();
                    }
                }
            }
        }

        private void listBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
