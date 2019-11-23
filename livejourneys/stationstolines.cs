using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livejourneys
{
    public partial class stationstolines : Form
    {
        public stationstolines()
        {
            InitializeComponent();
            loggedaslbl.Text = "Logged as: " + livejourneycwrk.getusername;
            try
            {
                OleDbDataReader reader = database.populatestationlist();
                while (reader.Read())
                {
                    stationcombo.Items.Add(reader["stations"].ToString());
                }
                OleDbDataReader readertlines = database.populatelistview();
                while (readertlines.Read())
                {
                    ListViewItem itemlink = new ListViewItem(readertlines["trainlines"].ToString());
                    tlineslistview.Items.Add(itemlink);
                }
            }catch (Exception)
            {

            }

        }

        private void stationcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int statid = database.getstationid(stationcombo.Text);
                tlineslistview.Items.Clear();
                tlineslistview.BeginUpdate();
                OleDbDataReader reader = database.gettlinesofthatstation(statid);
                while (reader.Read())
                {
                    ListViewItem itemlink = new ListViewItem(reader["trainlines"].ToString());
                    tlineslistview.Items.Add(itemlink);

                }
                tlineslistview.EndUpdate();

            }
            catch (Exception)
            {
                MessageBox.Show("Some problem with the database.  Try again later!");
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
