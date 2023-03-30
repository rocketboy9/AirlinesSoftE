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
    public partial class FlightManagerForm : Form
    {
        bool _initialized = false;
        FlightModel _selectedFlight;

        public FlightManagerForm()
        {
            InitializeComponent();
            SetupListBox();

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
                    FlightManagerManifestForm flightManagerManifestForm = new FlightManagerManifestForm(fm);
                    flightManagerManifestForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void listBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
