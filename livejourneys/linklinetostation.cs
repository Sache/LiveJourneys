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
    public partial class linklinetostation : Form
    {

        
        public linklinetostation()
        {
            
            InitializeComponent();
            loggedaslbl.Text = "Logged as: " + livejourneycwrk.getusername;

            OleDbDataReader trainreader = database.populatelistview();
            while (trainreader.Read())
            {
                traindropdwn.Items.Add(trainreader["trainlines"].ToString());
            }
            OleDbDataReader statreader = database.populatestationlist();
            while (statreader.Read())
            {
                stationdropdown.Items.Add(statreader["stations"].ToString());
            }
            loadlistview();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int distanceval = Int32.Parse(distancetbx.Text.ToString());
                int tlineid = database.gettrainid(traindropdwn.Text);
                int statid = database.getstationid(stationdropdown.Text);
                database.link(tlineid, statid, distanceval);
                loadlistview();
                MessageBox.Show("Successfully Linked");
            }
            catch (Exception)
            {
                MessageBox.Show("Please input distance value!");
            }

        }



        private void rmlinkbtn_Click(object sender, EventArgs e)
        {
            int getlinkid = Int32.Parse(linkedtslistview.SelectedItems[0].Text);
                database.deletelinks(getlinkid);
            loadlistview();



        }

        private void distancetbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }


        }

        private void distancetbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(distancetbx.Text.ToString()) > 50)
                {
                    distancetbx.ForeColor = Color.Red;
                    disterrlbl.Visible = true;

                }
                else
                {
                    distancetbx.ForeColor = Color.Black;
                    disterrlbl.Visible = false;
                }
            }catch (Exception)
            {

            }

        }
        private void loadlistview()
        {
            linkedtslistview.Items.Clear();
            linkedtslistview.BeginUpdate();
            OleDbDataReader reader = database.showlinkedlineandstation();
            while (reader.Read())
            {
                ListViewItem itemlink = new ListViewItem(reader["ID"].ToString());
                itemlink.SubItems.Add(reader["trainlines"].ToString());
                itemlink.SubItems.Add(reader["stations"].ToString());
                itemlink.SubItems.Add(reader["distance"].ToString());
                linkedtslistview.Items.Add(itemlink);

            }
            linkedtslistview.EndUpdate();
        }
    }
}
