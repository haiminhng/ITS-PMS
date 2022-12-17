namespace App.Forms
{
    partial class Detail
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxStudentAddress = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.lblHnr = new System.Windows.Forms.Label();
            this.tbHnr = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxStudentAddress.SuspendLayout();
            this.groupBoxStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxStudentAddress);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxStudentInfo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxStudentAddress
            // 
            this.groupBoxStudentAddress.Controls.Add(this.lblLocation);
            this.groupBoxStudentAddress.Controls.Add(this.tbLocation);
            this.groupBoxStudentAddress.Controls.Add(this.lblPostcode);
            this.groupBoxStudentAddress.Controls.Add(this.tbPostcode);
            this.groupBoxStudentAddress.Controls.Add(this.lblHnr);
            this.groupBoxStudentAddress.Controls.Add(this.tbHnr);
            this.groupBoxStudentAddress.Controls.Add(this.lblStreet);
            this.groupBoxStudentAddress.Controls.Add(this.tbStreet);
            this.groupBoxStudentAddress.Location = new System.Drawing.Point(14, 164);
            this.groupBoxStudentAddress.Name = "groupBoxStudentAddress";
            this.groupBoxStudentAddress.Size = new System.Drawing.Size(267, 145);
            this.groupBoxStudentAddress.TabIndex = 16;
            this.groupBoxStudentAddress.TabStop = false;
            this.groupBoxStudentAddress.Text = "Adresse";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 113);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(24, 15);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Ort";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(83, 110);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(171, 23);
            this.tbLocation.TabIndex = 14;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPostcode.Location = new System.Drawing.Point(9, 84);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(27, 15);
            this.lblPostcode.TabIndex = 13;
            this.lblPostcode.Text = "PLZ";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(83, 81);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(171, 23);
            this.tbPostcode.TabIndex = 12;
            // 
            // lblHnr
            // 
            this.lblHnr.AutoSize = true;
            this.lblHnr.Location = new System.Drawing.Point(9, 55);
            this.lblHnr.Name = "lblHnr";
            this.lblHnr.Size = new System.Drawing.Size(47, 15);
            this.lblHnr.TabIndex = 11;
            this.lblHnr.Text = "HausNr";
            // 
            // tbHnr
            // 
            this.tbHnr.Location = new System.Drawing.Point(83, 52);
            this.tbHnr.Name = "tbHnr";
            this.tbHnr.Size = new System.Drawing.Size(171, 23);
            this.tbHnr.TabIndex = 10;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(9, 26);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(40, 15);
            this.lblStreet.TabIndex = 9;
            this.lblStreet.Text = "Straße";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(83, 23);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(171, 23);
            this.tbStreet.TabIndex = 8;
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.lblEmail);
            this.groupBoxStudentInfo.Controls.Add(this.tbEmail);
            this.groupBoxStudentInfo.Controls.Add(this.lblClass);
            this.groupBoxStudentInfo.Controls.Add(this.tbClass);
            this.groupBoxStudentInfo.Controls.Add(this.lblLastname);
            this.groupBoxStudentInfo.Controls.Add(this.tbLastname);
            this.groupBoxStudentInfo.Controls.Add(this.lblFirstname);
            this.groupBoxStudentInfo.Controls.Add(this.tbFirstname);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(269, 146);
            this.groupBoxStudentInfo.TabIndex = 17;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "Schueler";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(83, 115);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(173, 23);
            this.tbEmail.TabIndex = 6;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(9, 89);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 15);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Klasse";
            // 
            // tbClass
            // 
            this.tbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClass.Location = new System.Drawing.Point(83, 86);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(173, 23);
            this.tbClass.TabIndex = 4;
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(8, 60);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(65, 15);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Nachname";
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(83, 57);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(173, 23);
            this.tbLastname.TabIndex = 2;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(9, 31);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(54, 15);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Vorname";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstname.Location = new System.Drawing.Point(83, 28);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(173, 23);
            this.tbFirstname.TabIndex = 0;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxStudentAddress.ResumeLayout(false);
            this.groupBoxStudentAddress.PerformLayout();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBoxStudentAddress;
        private Label lblLocation;
        private TextBox tbLocation;
        private Label lblPostcode;
        private TextBox tbPostcode;
        private Label lblHnr;
        private TextBox tbHnr;
        private Label lblStreet;
        private TextBox tbStreet;
        private GroupBox groupBoxStudentInfo;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblClass;
        private TextBox tbClass;
        private Label lblLastname;
        private TextBox tbLastname;
        private Label lblFirstname;
        private TextBox tbFirstname;
    }
}