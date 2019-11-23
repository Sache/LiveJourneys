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
    public partial class livejourneycwrk : Form
    {
        
        public livejourneycwrk()
        {
            InitializeComponent();
            
        }
        public static string getusername = "";

        private void loginbtn_Click(object sender, EventArgs e)
        {
            errorlbl.Visible = false;
             getusername = usernametbx.Text;
            string getpassword = passwordtbx.Text;
            if (database.pullUsernameandPass(getusername, getpassword)) // check if the user input matches with usernames and passwords stored on database
            {
                this.Visible = false;
                trainmgmt trainmgmt = new trainmgmt();
                trainmgmt.ShowDialog();
                

            }
            else
            {
                errorlbl.Text = "Invalid username or password";
                errorlbl.Visible = true;
            }
        }
    }
}
