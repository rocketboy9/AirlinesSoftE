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
    public partial class MarketingManagerForm : Form
    {

        FlightModel Flight = new FlightModel();
        public MarketingManagerForm(FlightModel flight)
        {
            InitializeComponent();
            Flight = flight;
        }

        private void button757_Click(object sender, EventArgs e)
        {
            SqliteDataService svc = new SqliteDataService();
            svc.UpdateFlightPlaneType(Flight.FlightID, 0);
        }

        private void button767_Click(object sender, EventArgs e)
        {
            SqliteDataService svc = new SqliteDataService();
            svc.UpdateFlightPlaneType(Flight.FlightID, 1);
        }

        private void button777_Click(object sender, EventArgs e)
        {
            SqliteDataService svc = new SqliteDataService();
            svc.UpdateFlightPlaneType(Flight.FlightID, 2);
        }
    }
}
