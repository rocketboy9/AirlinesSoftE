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
                        FlightManagerManifestForm flightManagerManifestForm = new FlightManagerManifestForm(fm);
                        flightManagerManifestForm.ShowDialog();
                    }
                    else if(LoadEngineer)
                    {
                        LoadEngineerForm loadEngineerForm = new LoadEngineerForm(fm);
                        loadEngineerForm.ShowDialog();
                    }
                    else if (MarketingManager)
                    {
                        //add some code to get to the marketing manager form here 
                    }
                    
                }
            }
        }

        private void listBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
