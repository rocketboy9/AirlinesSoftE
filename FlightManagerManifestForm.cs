using Airlines.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FlightManagerManifestForm : Form
    {

        FlightModel Flight;
        List<Ticket> FlightAttendees;
        public FlightManagerManifestForm(FlightModel flight)
        {
            InitializeComponent();
            Flight = flight;

            SetupListOfPeople();
        }

        private void SetupListOfPeople()
        {
            SqliteDataService svc = new SqliteDataService();
            List<Ticket> FlightManifest = svc.GetPeopleOnFlight(Flight.FlightID);

            foreach (Ticket ticket in FlightManifest)
            {
                richTextBoxFlightManifest.Text += $"Ticket ID: {ticket.TicketID}   Name: {ticket.FullName} \n";
            }
        }
    }
}
