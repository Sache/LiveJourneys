namespace livejourneys
{
    partial class trainmgmt
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
            this.trainlinebtn = new System.Windows.Forms.Button();
            this.stationsbtn = new System.Windows.Forms.Button();
            this.addstattolinebtn = new System.Windows.Forms.Button();
            this.distancebtn = new System.Windows.Forms.Button();
            this.loggedaslbl = new System.Windows.Forms.Label();
            this.stationtolinesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainlinebtn
            // 
            this.trainlinebtn.Location = new System.Drawing.Point(191, 65);
            this.trainlinebtn.Name = "trainlinebtn";
            this.trainlinebtn.Size = new System.Drawing.Size(181, 103);
            this.trainlinebtn.TabIndex = 0;
            this.trainlinebtn.Text = "Train Lines (Add, edit and delete)";
            this.trainlinebtn.UseVisualStyleBackColor = true;
            this.trainlinebtn.Click += new System.EventHandler(this.trainlinebtn_Click);
            // 
            // stationsbtn
            // 
            this.stationsbtn.Location = new System.Drawing.Point(494, 65);
            this.stationsbtn.Name = "stationsbtn";
            this.stationsbtn.Size = new System.Drawing.Size(181, 103);
            this.stationsbtn.TabIndex = 1;
            this.stationsbtn.Text = "Stations (Add,  edit and delete)";
            this.stationsbtn.UseVisualStyleBackColor = true;
            this.stationsbtn.Click += new System.EventHandler(this.stationsbtn_Click);
            // 
            // addstattolinebtn
            // 
            this.addstattolinebtn.Location = new System.Drawing.Point(191, 245);
            this.addstattolinebtn.Name = "addstattolinebtn";
            this.addstattolinebtn.Size = new System.Drawing.Size(181, 103);
            this.addstattolinebtn.TabIndex = 2;
            this.addstattolinebtn.Text = "Add stations to train lines";
            this.addstattolinebtn.UseVisualStyleBackColor = true;
            this.addstattolinebtn.Click += new System.EventHandler(this.addstattolinebtn_Click);
            // 
            // distancebtn
            // 
            this.distancebtn.Location = new System.Drawing.Point(494, 245);
            this.distancebtn.Name = "distancebtn";
            this.distancebtn.Size = new System.Drawing.Size(181, 103);
            this.distancebtn.TabIndex = 3;
            this.distancebtn.Text = "View Data";
            this.distancebtn.UseVisualStyleBackColor = true;
            this.distancebtn.Click += new System.EventHandler(this.distancebtn_Click);
            // 
            // loggedaslbl
            // 
            this.loggedaslbl.AutoSize = true;
            this.loggedaslbl.Location = new System.Drawing.Point(675, 9);
            this.loggedaslbl.Name = "loggedaslbl";
            this.loggedaslbl.Size = new System.Drawing.Size(60, 13);
            this.loggedaslbl.TabIndex = 4;
            this.loggedaslbl.Text = "Logged as:";
            // 
            // stationtolinesbtn
            // 
            this.stationtolinesbtn.Location = new System.Drawing.Point(372, 190);
            this.stationtolinesbtn.Name = "stationtolinesbtn";
            this.stationtolinesbtn.Size = new System.Drawing.Size(123, 38);
            this.stationtolinesbtn.TabIndex = 5;
            this.stationtolinesbtn.Text = "Stations on Lines";
            this.stationtolinesbtn.UseVisualStyleBackColor = true;
            this.stationtolinesbtn.Click += new System.EventHandler(this.stationtolinesbtn_Click);
            // 
            // trainmgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.stationtolinesbtn);
            this.Controls.Add(this.loggedaslbl);
            this.Controls.Add(this.distancebtn);
            this.Controls.Add(this.addstattolinebtn);
            this.Controls.Add(this.stationsbtn);
            this.Controls.Add(this.trainlinebtn);
            this.Name = "trainmgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trainlinebtn;
        private System.Windows.Forms.Button stationsbtn;
        private System.Windows.Forms.Button addstattolinebtn;
        private System.Windows.Forms.Button distancebtn;
        private System.Windows.Forms.Label loggedaslbl;
        private System.Windows.Forms.Button stationtolinesbtn;
    }
}