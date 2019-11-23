using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livejourneys
{
    public partial class trainmgmt : Form
    {
        public trainmgmt()
        {
            InitializeComponent();
            loggedaslbl.Text = "Logged as: "+livejourneycwrk.getusername;
        }

        private void trainlinebtn_Click(object sender, EventArgs e)
        {
            trainlines addtrainlines = new trainlines();
            addtrainlines.ShowDialog();
        }

        private void stationsbtn_Click(object sender, EventArgs e)
        {
            stations addstations = new stations();
            addstations.ShowDialog();
        }

        private void addstattolinebtn_Click(object sender, EventArgs e)
        {
            linklinetostation linkform = new linklinetostation();
            linkform.ShowDialog();
        }

        private void distancebtn_Click(object sender, EventArgs e)
        {
            viewlinks linkwindow = new viewlinks();
            linkwindow.ShowDialog();
        }

        private void stationtolinesbtn_Click(object sender, EventArgs e)
        {
            stationstolines window = new stationstolines();
            window.ShowDialog();
        }
    }
}
