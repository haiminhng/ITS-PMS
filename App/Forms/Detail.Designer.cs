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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            splitContainer1 = new SplitContainer();
            groupBoxStudentAddress = new GroupBox();
            lblLocation = new Label();
            tbLocation = new TextBox();
            adressenBindingSource = new BindingSource(components);
            lblPostcode = new Label();
            tbPostcode = new TextBox();
            lblHnr = new Label();
            tbHnr = new TextBox();
            lblStreet = new Label();
            tbStreet = new TextBox();
            groupBoxStudentInfo = new GroupBox();
            lblEmail = new Label();
            tbEmail = new TextBox();
            schuelerBindingSource = new BindingSource(components);
            lblClass = new Label();
            tbClass = new TextBox();
            lblLastname = new Label();
            tbLastname = new TextBox();
            lblFirstname = new Label();
            tbFirstname = new TextBox();
            btnEmail = new Button();
            btnCancle = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            parkplatzantragBindingSource = new BindingSource(components);
            label12 = new Label();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            genehmigtstatusBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxStudentAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adressenBindingSource).BeginInit();
            groupBoxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schuelerBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parkplatzantragBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genehmigtstatusBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxStudentAddress);
            splitContainer1.Panel1.Controls.Add(groupBoxStudentInfo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEmail);
            splitContainer1.Panel2.Controls.Add(btnCancle);
            splitContainer1.Panel2.Controls.Add(btnSave);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(800, 346);
            splitContainer1.SplitterDistance = 291;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxStudentAddress
            // 
            groupBoxStudentAddress.Controls.Add(lblLocation);
            groupBoxStudentAddress.Controls.Add(tbLocation);
            groupBoxStudentAddress.Controls.Add(lblPostcode);
            groupBoxStudentAddress.Controls.Add(tbPostcode);
            groupBoxStudentAddress.Controls.Add(lblHnr);
            groupBoxStudentAddress.Controls.Add(tbHnr);
            groupBoxStudentAddress.Controls.Add(lblStreet);
            groupBoxStudentAddress.Controls.Add(tbStreet);
            groupBoxStudentAddress.Location = new Point(14, 164);
            groupBoxStudentAddress.Name = "groupBoxStudentAddress";
            groupBoxStudentAddress.Size = new Size(267, 145);
            groupBoxStudentAddress.TabIndex = 16;
            groupBoxStudentAddress.TabStop = false;
            groupBoxStudentAddress.Text = "Adresse";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(9, 113);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(24, 15);
            lblLocation.TabIndex = 15;
            lblLocation.Text = "Ort";
            // 
            // tbLocation
            // 
            tbLocation.DataBindings.Add(new Binding("Text", adressenBindingSource, "Ort", true));
            tbLocation.Location = new Point(83, 110);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(171, 23);
            tbLocation.TabIndex = 14;
            // 
            // adressenBindingSource
            // 
            adressenBindingSource.DataSource = typeof(Models.Models.Adressen);
            // 
            // lblPostcode
            // 
            lblPostcode.AutoSize = true;
            lblPostcode.FlatStyle = FlatStyle.Flat;
            lblPostcode.Location = new Point(9, 84);
            lblPostcode.Name = "lblPostcode";
            lblPostcode.Size = new Size(27, 15);
            lblPostcode.TabIndex = 13;
            lblPostcode.Text = "PLZ";
            // 
            // tbPostcode
            // 
            tbPostcode.DataBindings.Add(new Binding("Text", adressenBindingSource, "Plz", true));
            tbPostcode.Location = new Point(83, 81);
            tbPostcode.Name = "tbPostcode";
            tbPostcode.Size = new Size(171, 23);
            tbPostcode.TabIndex = 12;
            // 
            // lblHnr
            // 
            lblHnr.AutoSize = true;
            lblHnr.Location = new Point(9, 55);
            lblHnr.Name = "lblHnr";
            lblHnr.Size = new Size(47, 15);
            lblHnr.TabIndex = 11;
            lblHnr.Text = "HausNr";
            // 
            // tbHnr
            // 
            tbHnr.DataBindings.Add(new Binding("Text", adressenBindingSource, "Hausnr", true));
            tbHnr.Location = new Point(83, 52);
            tbHnr.Name = "tbHnr";
            tbHnr.Size = new Size(171, 23);
            tbHnr.TabIndex = 10;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(9, 26);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(40, 15);
            lblStreet.TabIndex = 9;
            lblStreet.Text = "Straße";
            // 
            // tbStreet
            // 
            tbStreet.DataBindings.Add(new Binding("Text", adressenBindingSource, "Strasse", true));
            tbStreet.Location = new Point(83, 23);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(171, 23);
            tbStreet.TabIndex = 8;
            // 
            // groupBoxStudentInfo
            // 
            groupBoxStudentInfo.Controls.Add(lblEmail);
            groupBoxStudentInfo.Controls.Add(tbEmail);
            groupBoxStudentInfo.Controls.Add(lblClass);
            groupBoxStudentInfo.Controls.Add(tbClass);
            groupBoxStudentInfo.Controls.Add(lblLastname);
            groupBoxStudentInfo.Controls.Add(tbLastname);
            groupBoxStudentInfo.Controls.Add(lblFirstname);
            groupBoxStudentInfo.Controls.Add(tbFirstname);
            groupBoxStudentInfo.Location = new Point(12, 12);
            groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            groupBoxStudentInfo.Size = new Size(269, 146);
            groupBoxStudentInfo.TabIndex = 17;
            groupBoxStudentInfo.TabStop = false;
            groupBoxStudentInfo.Text = "Schueler";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(9, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.DataBindings.Add(new Binding("Text", schuelerBindingSource, "Email", true));
            tbEmail.Location = new Point(83, 115);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(173, 23);
            tbEmail.TabIndex = 6;
            // 
            // schuelerBindingSource
            // 
            schuelerBindingSource.DataSource = typeof(Models.Models.Schueler);
            // 
            // lblClass
            // 
            lblClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblClass.AutoSize = true;
            lblClass.Location = new Point(9, 89);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(39, 15);
            lblClass.TabIndex = 5;
            lblClass.Text = "Klasse";
            // 
            // tbClass
            // 
            tbClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbClass.DataBindings.Add(new Binding("Text", schuelerBindingSource, "KlassenName", true));
            tbClass.Location = new Point(83, 86);
            tbClass.Name = "tbClass";
            tbClass.Size = new Size(173, 23);
            tbClass.TabIndex = 4;
            // 
            // lblLastname
            // 
            lblLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(8, 60);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(65, 15);
            lblLastname.TabIndex = 3;
            lblLastname.Text = "Nachname";
            // 
            // tbLastname
            // 
            tbLastname.DataBindings.Add(new Binding("Text", schuelerBindingSource, "Nachname", true));
            tbLastname.Location = new Point(83, 57);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(173, 23);
            tbLastname.TabIndex = 2;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(9, 31);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(54, 15);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "Vorname";
            // 
            // tbFirstname
            // 
            tbFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbFirstname.DataBindings.Add(new Binding("Text", schuelerBindingSource, "Vorname", true));
            tbFirstname.Location = new Point(83, 28);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(173, 23);
            tbFirstname.TabIndex = 0;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(248, 313);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(75, 23);
            btnEmail.TabIndex = 20;
            btnEmail.Text = "Email";
            btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(410, 313);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(83, 23);
            btnCancle.TabIndex = 19;
            btnCancle.Text = "Abbrechen";
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(329, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "Speichern";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 296);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = " Parkplatzantrag";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "Punkte", true));
            textBox7.Location = new Point(104, 259);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(123, 23);
            textBox7.TabIndex = 40;
            // 
            // parkplatzantragBindingSource
            // 
            parkplatzantragBindingSource.DataSource = typeof(Models.Models.Parkplatzantrag);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 264);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 39;
            label12.Text = "Antragpunkte";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(253, 82);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 38;
            label11.Text = "Fahrzeit";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "Fahrzeit", true));
            textBox6.Location = new Point(348, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(123, 23);
            textBox6.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(253, 56);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 36;
            label10.Text = "Reisezeit";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "Reisezeit", true));
            textBox1.Location = new Point(348, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 35;
            // 
            // richTextBox2
            // 
            richTextBox2.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "Moeglichkeit", true));
            richTextBox2.Location = new Point(253, 163);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(218, 91);
            richTextBox2.TabIndex = 34;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "Grund", true));
            richTextBox1.Location = new Point(9, 163);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(218, 91);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.DataBindings.Add(new Binding("CheckState", parkplatzantragBindingSource, "Mitfahrgelegenheit", true));
            checkBox2.Location = new Point(378, 112);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(36, 19);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Ja";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("CheckState", parkplatzantragBindingSource, "Besonderefall", true));
            checkBox1.Location = new Point(134, 112);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(36, 19);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Ja";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(253, 264);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 29;
            label9.Text = "Antragstatus";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", parkplatzantragBindingSource, "Genehmigt", true));
            comboBox1.DataSource = genehmigtstatusBindingSource;
            comboBox1.DisplayMember = "Beschreibung";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(348, 261);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(123, 23);
            comboBox1.TabIndex = 30;
            comboBox1.ValueMember = "Wert";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 28);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 23;
            label5.Text = "Antragsdatum";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "Antragsdatum", true));
            textBox5.Location = new Point(348, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(123, 23);
            textBox5.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(252, 144);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 21;
            label6.Text = "Möglichkeit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 112);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 19;
            label7.Text = "Mitfahrgelegenheit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 142);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 17;
            label8.Text = "Grund";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 113);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 15;
            label1.Text = "Besonderefall";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(9, 84);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 13;
            label2.Text = "Entfernung";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "EntfernungKm", true));
            textBox2.Location = new Point(104, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 55);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 11;
            label3.Text = "Kennzeichen";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "KfzKennzeichen", true));
            textBox3.Location = new Point(104, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 26);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 9;
            label4.Text = "Id";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", parkplatzantragBindingSource, "ParkplatzantragsId", true));
            textBox4.Location = new Point(104, 24);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(123, 23);
            textBox4.TabIndex = 8;
            // 
            // genehmigtstatusBindingSource
            // 
            genehmigtstatusBindingSource.DataSource = typeof(Models.Models.Genehmigtstatus);
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 346);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Detail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detail";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxStudentAddress.ResumeLayout(false);
            groupBoxStudentAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adressenBindingSource).EndInit();
            groupBoxStudentInfo.ResumeLayout(false);
            groupBoxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)schuelerBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parkplatzantragBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genehmigtstatusBindingSource).EndInit();
            ResumeLayout(false);
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
        private Button btnCancle;
        private Button btnSave;
        private BindingSource schuelerBindingSource;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private RadioButton radioButton5;
        private Button btnEmail;
        private Label label9;
        private BindingSource adressenBindingSource;
        private BindingSource parkplatzantragBindingSource;
        private ComboBox comboBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox1;
        private BindingSource genehmigtstatusBindingSource;
        private TextBox textBox7;
        private Label label12;
    }
}