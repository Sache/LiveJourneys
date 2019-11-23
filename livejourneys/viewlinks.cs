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
    public partial class viewlinks : Form
    {
        public viewlinks()
        {
            InitializeComponent();
            loggedaslbl.Text = "Logged as: " + livejourneycwrk.getusername;
            OleDbDataReader trainreader = database.populatelistview();
            while (trainreader.Read())
            {
                linescombo.Items.Add(trainreader["trainlines"].ToString());
                tlinecmbbx.Items.Add(trainreader["trainlines"].ToString());
            }
            loadlistview();
        }

        private void loadlistview()
        {
            showlinkndist.Items.Clear();
            showlinkndist.BeginUpdate();
            OleDbDataReader reader = database.showlinkedlineandstation();
            while (reader.Read())
            {
                ListViewItem itemlink = new ListViewItem(reader["ID"].ToString());
                itemlink.SubItems.Add(reader["trainlines"].ToString());
                itemlink.SubItems.Add(reader["stations"].ToString());
                showlinkndist.Items.Add(itemlink);

            }
            showlinkndist.EndUpdate();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlinecmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int tlineid = database.gettrainid(tlinecmbbx.Text);
               spointcmb.Items.Clear();
               descmb.Items.Clear();
                spointcmb.Text = null;
                descmb.Text = null;

                OleDbDataReader reader = database.displaylinkedlinestatndist(tlineid);
                while (reader.Read())
                {
                    spointcmb.Items.Add(reader["stations"].ToString());
                    


                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

        }

        private void finddistbtn_Click(object sender, EventArgs e)
        {
            try
            {

                    int tlvalue = database.gettrainid(tlinecmbbx.Text);
                    int startvalue = database.getstationid(spointcmb.Text);
                    int endvalue = database.getstationid(descmb.Text);
                if (tlvalue != 0 && startvalue != 0 && endvalue != 0 ) {
                    int totaldistance = database.calculatedistance(tlvalue, startvalue, endvalue);
                    caldistancelbl.Text = "Distance = " + totaldistance;
                }
                else { MessageBox.Show("Please fill all the dropdown menu!"); }
                


            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all the dropdown menu!");
            }
        }

        private void linescombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tlineid = database.gettrainid(linescombo.Text);
                showlinkndist.Items.Clear();
                showlinkndist.BeginUpdate();
                OleDbDataReader reader = database.displaylinkedlinestatndist(tlineid);
                while (reader.Read())
                {
                    ListViewItem itemlink = new ListViewItem(reader["ID"].ToString());
                    itemlink.SubItems.Add(reader["trainlines"].ToString());
                    itemlink.SubItems.Add(reader["stations"].ToString());
                    showlinkndist.Items.Add(itemlink);

                }
                showlinkndist.EndUpdate();

            }
            catch (Exception)
            {
                MessageBox.Show("Some problem with the database.  Try again later!");
            }
        }

        private void viewlinks_Load(object sender, EventArgs e)
        {

        }

        private void spointcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tlineid = database.gettrainid(tlinecmbbx.Text);
                descmb.Items.Clear();

                OleDbDataReader reader = database.displaylinkedlinestatndist(tlineid);
                while (reader.Read())
                {
                    descmb.Items.Add(reader["stations"].ToString());


                }
                descmb.Items.Remove(spointcmb.Text);
                descmb.Text = null;

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            
        }
    }
}
