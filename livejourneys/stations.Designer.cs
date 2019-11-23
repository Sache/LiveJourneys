namespace livejourneys
{
    partial class stations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addstatntbx = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.listviewstatn = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stationsclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.loggedlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Station:";
            // 
            // addstatntbx
            // 
            this.addstatntbx.Location = new System.Drawing.Point(104, 39);
            this.addstatntbx.Name = "addstatntbx";
            this.addstatntbx.Size = new System.Drawing.Size(187, 20);
            this.addstatntbx.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(297, 37);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // listviewstatn
            // 
            this.listviewstatn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.stationsclm});
            this.listviewstatn.FullRowSelect = true;
            this.listviewstatn.GridLines = true;
            this.listviewstatn.Location = new System.Drawing.Point(36, 84);
            this.listviewstatn.MultiSelect = false;
            this.listviewstatn.Name = "listviewstatn";
            this.listviewstatn.Size = new System.Drawing.Size(721, 324);
            this.listviewstatn.TabIndex = 3;
            this.listviewstatn.UseCompatibleStateImageBehavior = false;
            this.listviewstatn.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // stationsclm
            // 
            this.stationsclm.Text = "Stations";
            this.stationsclm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stationsclm.Width = 150;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(763, 116);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 4;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(763, 163);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(763, 394);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // loggedlbl
            // 
            this.loggedlbl.AutoSize = true;
            this.loggedlbl.Location = new System.Drawing.Point(722, 9);
            this.loggedlbl.Name = "loggedlbl";
            this.loggedlbl.Size = new System.Drawing.Size(60, 13);
            this.loggedlbl.TabIndex = 6;
            this.loggedlbl.Text = "Logged as:";
            // 
            // stations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.loggedlbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.listviewstatn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.addstatntbx);
            this.Controls.Add(this.label1);
            this.Name = "stations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addstatntbx;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListView listviewstatn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader stationsclm;
        private System.Windows.Forms.Label loggedlbl;
    }
}