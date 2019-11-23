namespace livejourneys
{
    partial class linklinetostation
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
            this.components = new System.ComponentModel.Container();
            this.linkbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.rmlinkbtn = new System.Windows.Forms.Button();
            this.trainlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new livejourneys.dbDataSet1();
            this.trainlines_TableAdapter = new livejourneys.dbDataSet1TableAdapters.trainlines_TableAdapter();
            this.traindropdwn = new System.Windows.Forms.ComboBox();
            this.distancetbx = new System.Windows.Forms.TextBox();
            this.stationdropdown = new System.Windows.Forms.ComboBox();
            this.linelbl = new System.Windows.Forms.Label();
            this.stationlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disterrlbl = new System.Windows.Forms.Label();
            this.linkedtslistview = new System.Windows.Forms.ListView();
            this.showall = new System.Windows.Forms.Label();
            this.idlinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlineslinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statlinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loggedaslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkbtn
            // 
            this.linkbtn.Location = new System.Drawing.Point(763, 100);
            this.linkbtn.Name = "linkbtn";
            this.linkbtn.Size = new System.Drawing.Size(79, 23);
            this.linkbtn.TabIndex = 3;
            this.linkbtn.Text = "Link";
            this.linkbtn.UseVisualStyleBackColor = true;
            this.linkbtn.Click += new System.EventHandler(this.linkbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(763, 297);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(79, 23);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // rmlinkbtn
            // 
            this.rmlinkbtn.Location = new System.Drawing.Point(763, 200);
            this.rmlinkbtn.Name = "rmlinkbtn";
            this.rmlinkbtn.Size = new System.Drawing.Size(79, 26);
            this.rmlinkbtn.TabIndex = 6;
            this.rmlinkbtn.Text = "Remove Link";
            this.rmlinkbtn.UseVisualStyleBackColor = true;
            this.rmlinkbtn.Click += new System.EventHandler(this.rmlinkbtn_Click);
            // 
            // trainlinesBindingSource
            // 
            this.trainlinesBindingSource.DataMember = "trainlines_";
            this.trainlinesBindingSource.DataSource = this.dbDataSet1;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "dbDataSet1";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainlines_TableAdapter
            // 
            this.trainlines_TableAdapter.ClearBeforeFill = true;
            // 
            // traindropdwn
            // 
            this.traindropdwn.FormattingEnabled = true;
            this.traindropdwn.Location = new System.Drawing.Point(587, 61);
            this.traindropdwn.Name = "traindropdwn";
            this.traindropdwn.Size = new System.Drawing.Size(121, 21);
            this.traindropdwn.TabIndex = 8;
            // 
            // distancetbx
            // 
            this.distancetbx.Location = new System.Drawing.Point(587, 294);
            this.distancetbx.Name = "distancetbx";
            this.distancetbx.Size = new System.Drawing.Size(121, 20);
            this.distancetbx.TabIndex = 11;
            this.distancetbx.TextChanged += new System.EventHandler(this.distancetbx_TextChanged);
            this.distancetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distancetbx_KeyPress);
            // 
            // stationdropdown
            // 
            this.stationdropdown.FormattingEnabled = true;
            this.stationdropdown.Location = new System.Drawing.Point(587, 183);
            this.stationdropdown.Name = "stationdropdown";
            this.stationdropdown.Size = new System.Drawing.Size(121, 21);
            this.stationdropdown.TabIndex = 12;
            // 
            // linelbl
            // 
            this.linelbl.AutoSize = true;
            this.linelbl.Location = new System.Drawing.Point(482, 64);
            this.linelbl.Name = "linelbl";
            this.linelbl.Size = new System.Drawing.Size(99, 13);
            this.linelbl.TabIndex = 13;
            this.linelbl.Text = "Select a Train Line:";
            // 
            // stationlbl
            // 
            this.stationlbl.AutoSize = true;
            this.stationlbl.Location = new System.Drawing.Point(496, 186);
            this.stationlbl.Name = "stationlbl";
            this.stationlbl.Size = new System.Drawing.Size(85, 13);
            this.stationlbl.TabIndex = 14;
            this.stationlbl.Text = "Select a Station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Distance to Next Station:";
            // 
            // disterrlbl
            // 
            this.disterrlbl.ForeColor = System.Drawing.Color.Red;
            this.disterrlbl.Location = new System.Drawing.Point(473, 317);
            this.disterrlbl.Name = "disterrlbl";
            this.disterrlbl.Size = new System.Drawing.Size(252, 20);
            this.disterrlbl.TabIndex = 16;
            this.disterrlbl.Text = "*The distance value shouldn\'t be more than 50.";
            this.disterrlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.disterrlbl.Visible = false;
            // 
            // linkedtslistview
            // 
            this.linkedtslistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idlinked,
            this.tlineslinked,
            this.statlinked,
            this.dista});
            this.linkedtslistview.FullRowSelect = true;
            this.linkedtslistview.Location = new System.Drawing.Point(12, 61);
            this.linkedtslistview.MultiSelect = false;
            this.linkedtslistview.Name = "linkedtslistview";
            this.linkedtslistview.Size = new System.Drawing.Size(431, 347);
            this.linkedtslistview.TabIndex = 17;
            this.linkedtslistview.UseCompatibleStateImageBehavior = false;
            this.linkedtslistview.View = System.Windows.Forms.View.Details;
            // 
            // showall
            // 
            this.showall.AutoSize = true;
            this.showall.Location = new System.Drawing.Point(105, 45);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(248, 13);
            this.showall.TabIndex = 18;
            this.showall.Text = "List of stations and its distance linked with trainlines";
            // 
            // idlinked
            // 
            this.idlinked.Text = "ID";
            // 
            // tlineslinked
            // 
            this.tlineslinked.Text = "Train Lines";
            this.tlineslinked.Width = 158;
            // 
            // statlinked
            // 
            this.statlinked.Text = "Stations";
            this.statlinked.Width = 136;
            // 
            // dista
            // 
            this.dista.Text = "Distance";
            // 
            // loggedaslbl
            // 
            this.loggedaslbl.AutoSize = true;
            this.loggedaslbl.Location = new System.Drawing.Point(675, 9);
            this.loggedaslbl.Name = "loggedaslbl";
            this.loggedaslbl.Size = new System.Drawing.Size(61, 13);
            this.loggedaslbl.TabIndex = 19;
            this.loggedaslbl.Text = "Logged As:";
            // 
            // linklinetostation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.loggedaslbl);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.linkedtslistview);
            this.Controls.Add(this.disterrlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stationlbl);
            this.Controls.Add(this.linelbl);
            this.Controls.Add(this.stationdropdown);
            this.Controls.Add(this.distancetbx);
            this.Controls.Add(this.traindropdwn);
            this.Controls.Add(this.rmlinkbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.linkbtn);
            this.Name = "linklinetostation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "linklinetostation";
            ((System.ComponentModel.ISupportInitialize)(this.trainlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button linkbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button rmlinkbtn;
        private dbDataSet1 dbDataSet1;
        private System.Windows.Forms.BindingSource trainlinesBindingSource;
        private dbDataSet1TableAdapters.trainlines_TableAdapter trainlines_TableAdapter;
        private System.Windows.Forms.ComboBox traindropdwn;
        private System.Windows.Forms.TextBox distancetbx;
        private System.Windows.Forms.ComboBox stationdropdown;
        private System.Windows.Forms.Label linelbl;
        private System.Windows.Forms.Label stationlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label disterrlbl;
        private System.Windows.Forms.ListView linkedtslistview;
        private System.Windows.Forms.Label showall;
        private System.Windows.Forms.ColumnHeader idlinked;
        private System.Windows.Forms.ColumnHeader tlineslinked;
        private System.Windows.Forms.ColumnHeader statlinked;
        private System.Windows.Forms.ColumnHeader dista;
        private System.Windows.Forms.Label loggedaslbl;
    }
}