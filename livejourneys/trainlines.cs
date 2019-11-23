using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace livejourneys
{
    public partial class trainlines : Form
    {
        public ListViewItem item;
        public Form edit;
        public TextBox edittbx;
        public trainlines()
        {
            InitializeComponent();
            loggedlbl.Text = "Logged as: " +livejourneycwrk.getusername;
            OleDbDataReader reader = database.populatelistview();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["trainlines"].ToString());
                listviewlines.Items.Add(item);

            }
            
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (addtbx.Text != "" && string.IsNullOrWhiteSpace(addtbx.Text) == false)
            {
                String addnotify = database.addtrainline(addtbx.Text);
                listviewlines.Items.Clear();
                listviewlines.BeginUpdate();
                OleDbDataReader reader = database.populatelistview();
                while (reader.Read())
                {
                    item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["trainlines"].ToString());
                    listviewlines.Items.Add(item);

                }
                listviewlines.EndUpdate();
                MessageBox.Show(addnotify);
            } else { MessageBox.Show("You cannot add a blank trainline."); }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = listviewlines.SelectedItems[0].Text;
                int idint = Int32.Parse(id);
                database.deletetrainline(idint);
                listviewlines.Items.RemoveAt(listviewlines.SelectedIndices[0]);
            } catch (Exception)   
            {
                MessageBox.Show("Please select a trainline ID to delete.");
            }


        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Int32.Parse(listviewlines.SelectedItems[0].Text);
                edit = new Form();
                edit.FormBorderStyle = FormBorderStyle.FixedDialog;
                edit.StartPosition = FormStartPosition.CenterScreen;
                edit.MaximizeBox = false; edit.MinimizeBox = false;
                edit.Size = new Size(235, 150);

                var updateline = listviewlines.SelectedItems[0].SubItems[1].Text;
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
            }catch { MessageBox.Show("Please select a trainline to edit."); }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(listviewlines.SelectedItems[0].Text);
            
            database.edittrainlines(edittbx.Text, id);
            edit.Close();
            listviewlines.Items.Clear();
            listviewlines.BeginUpdate();
            OleDbDataReader reader = database.populatelistview();
            while (reader.Read())
            {
                item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["trainlines"].ToString());
                listviewlines.Items.Add(item);
            }
            listviewlines.EndUpdate();
        }
    }
}
