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
    public partial class stations : Form
    {
        ListViewItem item;
        Form edit;
        TextBox edittbx;
        public stations()
        {
            InitializeComponent();
            loggedlbl.Text = "Logged as: " + livejourneycwrk.getusername;
            OleDbDataReader reader = database.populatestationlist();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["stations"].ToString());
                listviewstatn.Items.Add(item);


            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (addstatntbx.Text != "" && string.IsNullOrWhiteSpace(addstatntbx.Text) == false)
            {
                String addnotify = database.addstation(addstatntbx.Text);
                listviewstatn.Items.Clear();
                listviewstatn.BeginUpdate();
                OleDbDataReader reader = database.populatestationlist();
                while (reader.Read())
                {
                    item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["stations"].ToString());
                    listviewstatn.Items.Add(item);

                }
                listviewstatn.EndUpdate();
                MessageBox.Show(addnotify);
            }
            else { MessageBox.Show("You cannot add a blank trainline."); }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = listviewstatn.SelectedItems[0].Text;
                int idint = Int32.Parse(id);
                database.deletestation(idint);
                listviewstatn.Items.RemoveAt(listviewstatn.SelectedIndices[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a trainline ID to delete.");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try {
            var id = Int32.Parse(listviewstatn.SelectedItems[0].Text);
            edit = new Form();
            edit.FormBorderStyle = FormBorderStyle.FixedDialog;
            edit.StartPosition = FormStartPosition.CenterScreen;
            edit.MaximizeBox = false; edit.MinimizeBox = false;
            edit.Size = new Size(235, 150);

            var updateline = listviewstatn.SelectedItems[0].SubItems[1].Text;
            edittbx = new TextBox(); edit.Controls.Add(edittbx);
            edittbx.Text = updateline;
            edittbx.Location = new Point(10, 25);
            edittbx.Size = new Size(200, 20);
            //////////////////////////BUTTON PROPERTIES/////////////////////////////////////////////
            Button ok = new Button(); edit.Controls.Add(ok); ok.Location = new Point(20, 50);     //
            ok.Text = "OK"; ok.Click += new EventHandler(ok_Click);                               //
            Button cancel = new Button(); edit.Controls.Add(cancel); edit.CancelButton = cancel;  //    
            cancel.Text = "Cancel"; cancel.Location = new Point(120, 50);                         //  
            ////////////////////////////////////////////////////////////////////////////////////////
            edit.ShowDialog();
             }catch { MessageBox.Show("Please select a station to edit."); }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(listviewstatn.SelectedItems[0].Text);

            database.editstation(edittbx.Text, id);
            edit.Close();
            listviewstatn.Items.Clear();
            listviewstatn.BeginUpdate();
            OleDbDataReader reader = database.populatestationlist();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["stations"].ToString());
                listviewstatn.Items.Add(item);
            }
            listviewstatn.EndUpdate();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
