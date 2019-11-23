namespace livejourneys
{
    partial class trainlines
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
            this.addtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.loggedlbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.listviewlines = new System.Windows.Forms.ListView();
            this.idclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainlineclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addtbx
            // 
            this.addtbx.Location = new System.Drawing.Point(113, 39);
            this.addtbx.Name = "addtbx";
            this.addtbx.Size = new System.Drawing.Size(188, 20);
            this.addtbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add trainlines:";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(307, 39);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // loggedlbl
            // 
            this.loggedlbl.AutoSize = true;
            this.loggedlbl.Location = new System.Drawing.Point(666, 9);
            this.loggedlbl.Name = "loggedlbl";
            this.loggedlbl.Size = new System.Drawing.Size(60, 13);
            this.loggedlbl.TabIndex = 3;
            this.loggedlbl.Text = "Logged as:";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(765, 394);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // listviewlines
            // 
            this.listviewlines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idclm,
            this.trainlineclm});
            this.listviewlines.FullRowSelect = true;
            this.listviewlines.GridLines = true;
            this.listviewlines.Location = new System.Drawing.Point(37, 81);
            this.listviewlines.MultiSelect = false;
            this.listviewlines.Name = "listviewlines";
            this.listviewlines.Size = new System.Drawing.Size(722, 327);
            this.listviewlines.TabIndex = 5;
            this.listviewlines.UseCompatibleStateImageBehavior = false;
            this.listviewlines.View = System.Windows.Forms.View.Details;
            // 
            // idclm
            // 
            this.idclm.Text = "ID";
            // 
            // trainlineclm
            // 
            this.trainlineclm.Tag = "";
            this.trainlineclm.Text = "Trainlines";
            this.trainlineclm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trainlineclm.Width = 176;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(765, 133);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 6;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(765, 175);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // trainlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 420);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.listviewlines);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.loggedlbl);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addtbx);
            this.Name = "trainlines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainlines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label loggedlbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ListView listviewlines;
        private System.Windows.Forms.ColumnHeader idclm;
        private System.Windows.Forms.ColumnHeader trainlineclm;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}