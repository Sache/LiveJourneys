namespace livejourneys
{
    partial class stationstolines
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
            this.stationcombo = new System.Windows.Forms.ComboBox();
            this.tlineslistview = new System.Windows.Forms.ListView();
            this.Backbtn = new System.Windows.Forms.Button();
            this.loggedaslbl = new System.Windows.Forms.Label();
            this.tlineclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Station:";
            // 
            // stationcombo
            // 
            this.stationcombo.FormattingEnabled = true;
            this.stationcombo.Location = new System.Drawing.Point(140, 35);
            this.stationcombo.Name = "stationcombo";
            this.stationcombo.Size = new System.Drawing.Size(121, 21);
            this.stationcombo.TabIndex = 1;
            this.stationcombo.SelectedIndexChanged += new System.EventHandler(this.stationcombo_SelectedIndexChanged);
            // 
            // tlineslistview
            // 
            this.tlineslistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tlineclm});
            this.tlineslistview.Location = new System.Drawing.Point(51, 73);
            this.tlineslistview.Name = "tlineslistview";
            this.tlineslistview.Size = new System.Drawing.Size(721, 335);
            this.tlineslistview.TabIndex = 2;
            this.tlineslistview.UseCompatibleStateImageBehavior = false;
            this.tlineslistview.View = System.Windows.Forms.View.Details;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(778, 385);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // loggedaslbl
            // 
            this.loggedaslbl.AutoSize = true;
            this.loggedaslbl.Location = new System.Drawing.Point(737, 9);
            this.loggedaslbl.Name = "loggedaslbl";
            this.loggedaslbl.Size = new System.Drawing.Size(61, 13);
            this.loggedaslbl.TabIndex = 4;
            this.loggedaslbl.Text = "Logged As:";
            // 
            // tlineclm
            // 
            this.tlineclm.Text = "Train Lines";
            this.tlineclm.Width = 500;
            // 
            // stationstolines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.loggedaslbl);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.tlineslistview);
            this.Controls.Add(this.stationcombo);
            this.Controls.Add(this.label1);
            this.Name = "stationstolines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stationstolines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stationcombo;
        private System.Windows.Forms.ListView tlineslistview;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label loggedaslbl;
        private System.Windows.Forms.ColumnHeader tlineclm;
    }
}