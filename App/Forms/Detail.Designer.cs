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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxStudentAddress = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.adressenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPostcode = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.lblHnr = new System.Windows.Forms.Label();
            this.tbHnr = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.schuelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClass = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.parkplatzantragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genehmigtstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxStudentAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).BeginInit();
            this.groupBoxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuelerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkplatzantragBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genehmigtstatusBindingSource)).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancle);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 346);
            this.splitContainer1.SplitterDistance = 291;
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
            this.tbLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Ort", true));
            this.tbLocation.Location = new System.Drawing.Point(83, 110);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(171, 23);
            this.tbLocation.TabIndex = 14;
            // 
            // adressenBindingSource
            // 
            this.adressenBindingSource.DataSource = typeof(Models.Models.Adressen);
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
            this.tbPostcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Plz", true));
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
            this.tbHnr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Hausnr", true));
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
            this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Strasse", true));
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
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuelerBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(83, 115);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(173, 23);
            this.tbEmail.TabIndex = 6;
            // 
            // schuelerBindingSource
            // 
            this.schuelerBindingSource.DataSource = typeof(Models.Models.Schueler);
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
            this.tbClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuelerBindingSource, "KlassenName", true));
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
            this.tbLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuelerBindingSource, "Nachname", true));
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
            this.tbFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuelerBindingSource, "Vorname", true));
            this.tbFirstname.Location = new System.Drawing.Point(83, 28);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(173, 23);
            this.tbFirstname.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Email";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(410, 313);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(83, 23);
            this.btnCancle.TabIndex = 19;
            this.btnCancle.Text = "Abbrechen";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 296);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Parkplatzantrag";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "Punkte", true));
            this.textBox7.Location = new System.Drawing.Point(104, 259);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(123, 23);
            this.textBox7.TabIndex = 40;
            // 
            // parkplatzantragBindingSource
            // 
            this.parkplatzantragBindingSource.DataSource = typeof(Models.Models.Parkplatzantrag);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Antragpunkte";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Fahrzeit";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "Fahrzeit", true));
            this.textBox6.Location = new System.Drawing.Point(348, 79);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(123, 23);
            this.textBox6.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Reisezeit";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "Reisezeit", true));
            this.textBox1.Location = new System.Drawing.Point(348, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 35;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(253, 163);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(218, 91);
            this.richTextBox2.TabIndex = 34;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 163);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 91);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(378, 112);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(36, 19);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Ja";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 112);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 19);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Ja";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Antragstatus";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.parkplatzantragBindingSource, "Genehmigt", true));
            this.comboBox1.DataSource = this.genehmigtstatusBindingSource;
            this.comboBox1.DisplayMember = "Beschreibung";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 261);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 23);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "Wert";
            // 
            // genehmigtstatusBindingSource
            // 
            this.genehmigtstatusBindingSource.DataSource = typeof(Models.Models.Genehmigtstatus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Antragsdatum";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "Antragsdatum", true));
            this.textBox5.Location = new System.Drawing.Point(348, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 23);
            this.textBox5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(252, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Möglichkeit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mitfahrgelegenheit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Grund";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Besonderefall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Entfernung";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "EntfernungKm", true));
            this.textBox2.Location = new System.Drawing.Point(104, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kennzeichen";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "KfzKennzeichen", true));
            this.textBox3.Location = new System.Drawing.Point(104, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parkplatzantragBindingSource, "ParkplatzantragsId", true));
            this.textBox4.Location = new System.Drawing.Point(104, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 23);
            this.textBox4.TabIndex = 8;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxStudentAddress.ResumeLayout(false);
            this.groupBoxStudentAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).EndInit();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuelerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkplatzantragBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genehmigtstatusBindingSource)).EndInit();
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
        private Button button3;
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