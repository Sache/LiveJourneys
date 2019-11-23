namespace livejourneys
{
    partial class viewlinks
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
            this.linescombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showlinkndist = new System.Windows.Forms.ListView();
            this.idli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linesli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backbtn = new System.Windows.Forms.Button();
            this.loggedaslbl = new System.Windows.Forms.Label();
            this.grpcalc = new System.Windows.Forms.GroupBox();
            this.caldistancelbl = new System.Windows.Forms.Label();
            this.finddistbtn = new System.Windows.Forms.Button();
            this.descmb = new System.Windows.Forms.ComboBox();
            this.spointcmb = new System.Windows.Forms.ComboBox();
            this.destlb = new System.Windows.Forms.Label();
            this.statlblfi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlinecmbbx = new System.Windows.Forms.ComboBox();
            this.grpcalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // linescombo
            // 
            this.linescombo.FormattingEnabled = true;
            this.linescombo.Location = new System.Drawing.Point(105, 51);
            this.linescombo.Name = "linescombo";
            this.linescombo.Size = new System.Drawing.Size(121, 21);
            this.linescombo.TabIndex = 0;
            this.linescombo.SelectedIndexChanged += new System.EventHandler(this.linescombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Train Line:";
            // 
            // showlinkndist
            // 
            this.showlinkndist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idli,
            this.linesli,
            this.statli});
            this.showlinkndist.Location = new System.Drawing.Point(12, 78);
            this.showlinkndist.Name = "showlinkndist";
            this.showlinkndist.Size = new System.Drawing.Size(417, 310);
            this.showlinkndist.TabIndex = 5;
            this.showlinkndist.UseCompatibleStateImageBehavior = false;
            this.showlinkndist.View = System.Windows.Forms.View.Details;
            // 
            // idli
            // 
            this.idli.Text = "ID";
            this.idli.Width = 25;
            // 
            // linesli
            // 
            this.linesli.Text = "Train Lines";
            this.linesli.Width = 130;
            // 
            // statli
            // 
            this.statli.Text = "Stations";
            this.statli.Width = 94;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(767, 394);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // loggedaslbl
            // 
            this.loggedaslbl.AutoSize = true;
            this.loggedaslbl.Location = new System.Drawing.Point(675, 9);
            this.loggedaslbl.Name = "loggedaslbl";
            this.loggedaslbl.Size = new System.Drawing.Size(61, 13);
            this.loggedaslbl.TabIndex = 7;
            this.loggedaslbl.Text = "Logged As:";
            // 
            // grpcalc
            // 
            this.grpcalc.Controls.Add(this.caldistancelbl);
            this.grpcalc.Controls.Add(this.finddistbtn);
            this.grpcalc.Controls.Add(this.descmb);
            this.grpcalc.Controls.Add(this.spointcmb);
            this.grpcalc.Controls.Add(this.destlb);
            this.grpcalc.Controls.Add(this.statlblfi);
            this.grpcalc.Controls.Add(this.label2);
            this.grpcalc.Controls.Add(this.tlinecmbbx);
            this.grpcalc.Location = new System.Drawing.Point(435, 49);
            this.grpcalc.Name = "grpcalc";
            this.grpcalc.Size = new System.Drawing.Size(407, 339);
            this.grpcalc.TabIndex = 8;
            this.grpcalc.TabStop = false;
            this.grpcalc.Text = "Total Distance";
            // 
            // caldistancelbl
            // 
            this.caldistancelbl.AutoSize = true;
            this.caldistancelbl.Location = new System.Drawing.Point(131, 229);
            this.caldistancelbl.Name = "caldistancelbl";
            this.caldistancelbl.Size = new System.Drawing.Size(105, 13);
            this.caldistancelbl.TabIndex = 15;
            this.caldistancelbl.Text = "Calculated Distance:";
            // 
            // finddistbtn
            // 
            this.finddistbtn.Location = new System.Drawing.Point(290, 154);
            this.finddistbtn.Name = "finddistbtn";
            this.finddistbtn.Size = new System.Drawing.Size(75, 23);
            this.finddistbtn.TabIndex = 14;
            this.finddistbtn.Text = "Distance";
            this.finddistbtn.UseVisualStyleBackColor = true;
            this.finddistbtn.Click += new System.EventHandler(this.finddistbtn_Click);
            // 
            // descmb
            // 
            this.descmb.FormattingEnabled = true;
            this.descmb.Location = new System.Drawing.Point(131, 156);
            this.descmb.Name = "descmb";
            this.descmb.Size = new System.Drawing.Size(121, 21);
            this.descmb.TabIndex = 13;
            // 
            // spointcmb
            // 
            this.spointcmb.FormattingEnabled = true;
            this.spointcmb.Location = new System.Drawing.Point(131, 88);
            this.spointcmb.Name = "spointcmb";
            this.spointcmb.Size = new System.Drawing.Size(121, 21);
            this.spointcmb.TabIndex = 12;
            this.spointcmb.SelectedIndexChanged += new System.EventHandler(this.spointcmb_SelectedIndexChanged);
            // 
            // destlb
            // 
            this.destlb.AutoSize = true;
            this.destlb.Location = new System.Drawing.Point(19, 159);
            this.destlb.Name = "destlb";
            this.destlb.Size = new System.Drawing.Size(96, 13);
            this.destlb.TabIndex = 11;
            this.destlb.Text = "Select Destination:";
            // 
            // statlblfi
            // 
            this.statlblfi.AutoSize = true;
            this.statlblfi.Location = new System.Drawing.Point(19, 91);
            this.statlblfi.Name = "statlblfi";
            this.statlblfi.Size = new System.Drawing.Size(106, 13);
            this.statlblfi.TabIndex = 10;
            this.statlblfi.Text = "Select Starting Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Train Line:";
            // 
            // tlinecmbbx
            // 
            this.tlinecmbbx.FormattingEnabled = true;
            this.tlinecmbbx.Location = new System.Drawing.Point(131, 24);
            this.tlinecmbbx.Name = "tlinecmbbx";
            this.tlinecmbbx.Size = new System.Drawing.Size(121, 21);
            this.tlinecmbbx.TabIndex = 9;
            this.tlinecmbbx.SelectedIndexChanged += new System.EventHandler(this.tlinecmbbx_SelectedIndexChanged);
            // 
            // viewlinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.grpcalc);
            this.Controls.Add(this.loggedaslbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.showlinkndist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linescombo);
            this.Name = "viewlinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewlinks";
            this.Load += new System.EventHandler(this.viewlinks_Load);
            this.grpcalc.ResumeLayout(false);
            this.grpcalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox linescombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView showlinkndist;
        private System.Windows.Forms.ColumnHeader idli;
        private System.Windows.Forms.ColumnHeader linesli;
        private System.Windows.Forms.ColumnHeader statli;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label loggedaslbl;
        private System.Windows.Forms.GroupBox grpcalc;
        private System.Windows.Forms.ComboBox descmb;
        private System.Windows.Forms.ComboBox spointcmb;
        private System.Windows.Forms.Label destlb;
        private System.Windows.Forms.Label statlblfi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tlinecmbbx;
        private System.Windows.Forms.Button finddistbtn;
        private System.Windows.Forms.Label caldistancelbl;
    }
}