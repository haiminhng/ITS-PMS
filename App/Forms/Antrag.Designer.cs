﻿namespace App
{
    partial class Antrag
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parkplatzbelastungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belastungrechnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridViewParkingApplication = new System.Windows.Forms.DataGridView();
            this.ParkplatzantragsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KfzKennzeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntfernungKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Besonderefall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mitfahrgelegenheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moeglichkeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antragsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genehmigt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schuelerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkplatzantragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxStudentAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).BeginInit();
            this.groupBoxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuelerBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkingApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkplatzantragBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewParkingApplication);
            this.splitContainer1.Size = new System.Drawing.Size(886, 497);
            this.splitContainer1.SplitterDistance = 271;
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
            this.groupBoxStudentAddress.Location = new System.Drawing.Point(5, 198);
            this.groupBoxStudentAddress.Name = "groupBoxStudentAddress";
            this.groupBoxStudentAddress.Size = new System.Drawing.Size(263, 145);
            this.groupBoxStudentAddress.TabIndex = 0;
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
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(5, 46);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(263, 146);
            this.groupBoxStudentInfo.TabIndex = 0;
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
            this.tbEmail.Size = new System.Drawing.Size(171, 23);
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
            this.tbClass.Size = new System.Drawing.Size(171, 23);
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
            this.tbLastname.Size = new System.Drawing.Size(171, 23);
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
            this.tbFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuelerBindingSource, "Vorname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFirstname.Location = new System.Drawing.Point(83, 28);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(171, 23);
            this.tbFirstname.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkplatzbelastungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parkplatzbelastungToolStripMenuItem
            // 
            this.parkplatzbelastungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belastungrechnenToolStripMenuItem});
            this.parkplatzbelastungToolStripMenuItem.Name = "parkplatzbelastungToolStripMenuItem";
            this.parkplatzbelastungToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.parkplatzbelastungToolStripMenuItem.Text = "Parkplatzbelastung";
            // 
            // belastungrechnenToolStripMenuItem
            // 
            this.belastungrechnenToolStripMenuItem.Name = "belastungrechnenToolStripMenuItem";
            this.belastungrechnenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.belastungrechnenToolStripMenuItem.Text = "Belastungrechnen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parkplatz anträge";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suchen";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(460, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(568, 7);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(31, 26);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(536, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 26);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(504, 7);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(31, 26);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(470, 7);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(31, 26);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "hinzufügen";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridViewParkingApplication
            // 
            this.dataGridViewParkingApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParkingApplication.AutoGenerateColumns = false;
            this.dataGridViewParkingApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewParkingApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParkingApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParkplatzantragsId,
            this.KfzKennzeichen,
            this.EntfernungKm,
            this.Fahrzeit,
            this.Besonderefall,
            this.Grund,
            this.Mitfahrgelegenheit,
            this.Moeglichkeit,
            this.Antragsdatum,
            this.Genehmigt,
            this.schuelerIdDataGridViewTextBoxColumn});
            this.dataGridViewParkingApplication.DataSource = this.parkplatzantragBindingSource;
            this.dataGridViewParkingApplication.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewParkingApplication.Location = new System.Drawing.Point(3, 46);
            this.dataGridViewParkingApplication.Name = "dataGridViewParkingApplication";
            this.dataGridViewParkingApplication.RowTemplate.Height = 25;
            this.dataGridViewParkingApplication.Size = new System.Drawing.Size(605, 403);
            this.dataGridViewParkingApplication.TabIndex = 0;
            // 
            // ParkplatzantragsId
            // 
            this.ParkplatzantragsId.DataPropertyName = "ParkplatzantragsId";
            this.ParkplatzantragsId.HeaderText = "ParkplatzantragsId";
            this.ParkplatzantragsId.Name = "ParkplatzantragsId";
            this.ParkplatzantragsId.Width = 129;
            // 
            // KfzKennzeichen
            // 
            this.KfzKennzeichen.DataPropertyName = "KfzKennzeichen";
            this.KfzKennzeichen.HeaderText = "KfzKennzeichen";
            this.KfzKennzeichen.Name = "KfzKennzeichen";
            this.KfzKennzeichen.Width = 115;
            // 
            // EntfernungKm
            // 
            this.EntfernungKm.DataPropertyName = "EntfernungKm";
            this.EntfernungKm.HeaderText = "EntfernungKm";
            this.EntfernungKm.Name = "EntfernungKm";
            this.EntfernungKm.Width = 109;
            // 
            // Fahrzeit
            // 
            this.Fahrzeit.DataPropertyName = "Fahrzeit";
            this.Fahrzeit.HeaderText = "Fahrzeit";
            this.Fahrzeit.Name = "Fahrzeit";
            this.Fahrzeit.Width = 73;
            // 
            // Besonderefall
            // 
            this.Besonderefall.DataPropertyName = "Besonderefall";
            this.Besonderefall.HeaderText = "Besonderefall";
            this.Besonderefall.Name = "Besonderefall";
            this.Besonderefall.Width = 103;
            // 
            // Grund
            // 
            this.Grund.DataPropertyName = "Grund";
            this.Grund.HeaderText = "Grund";
            this.Grund.Name = "Grund";
            this.Grund.Width = 65;
            // 
            // Mitfahrgelegenheit
            // 
            this.Mitfahrgelegenheit.DataPropertyName = "Mitfahrgelegenheit";
            this.Mitfahrgelegenheit.HeaderText = "Mitfahrgelegenheit";
            this.Mitfahrgelegenheit.Name = "Mitfahrgelegenheit";
            this.Mitfahrgelegenheit.Width = 133;
            // 
            // Moeglichkeit
            // 
            this.Moeglichkeit.DataPropertyName = "Moeglichkeit";
            this.Moeglichkeit.HeaderText = "Moeglichkeit";
            this.Moeglichkeit.Name = "Moeglichkeit";
            this.Moeglichkeit.Width = 101;
            // 
            // Antragsdatum
            // 
            this.Antragsdatum.DataPropertyName = "Antragsdatum";
            this.Antragsdatum.HeaderText = "Antragsdatum";
            this.Antragsdatum.Name = "Antragsdatum";
            this.Antragsdatum.Width = 108;
            // 
            // Genehmigt
            // 
            this.Genehmigt.DataPropertyName = "Genehmigt";
            this.Genehmigt.HeaderText = "Genehmigt";
            this.Genehmigt.Name = "Genehmigt";
            this.Genehmigt.Width = 91;
            // 
            // schuelerIdDataGridViewTextBoxColumn
            // 
            this.schuelerIdDataGridViewTextBoxColumn.DataPropertyName = "SchuelerId";
            this.schuelerIdDataGridViewTextBoxColumn.HeaderText = "SchuelerId";
            this.schuelerIdDataGridViewTextBoxColumn.Name = "schuelerIdDataGridViewTextBoxColumn";
            this.schuelerIdDataGridViewTextBoxColumn.Width = 87;
            // 
            // parkplatzantragBindingSource
            // 
            this.parkplatzantragBindingSource.DataSource = typeof(Models.Models.Parkplatzantrag);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Antrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 497);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Antrag";
            this.Text = "Antrag";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxStudentAddress.ResumeLayout(false);
            this.groupBoxStudentAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).EndInit();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuelerBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkingApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkplatzantragBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBoxStudentInfo;
        private GroupBox groupBoxStudentAddress;
        private DataGridView dataGridViewParkingApplication;
        private BindingSource parkplatzantragBindingSource;
        private Label lblLocation;
        private TextBox tbLocation;
        private Label lblPostcode;
        private TextBox tbPostcode;
        private Label lblHnr;
        private TextBox tbHnr;
        private Label lblStreet;
        private TextBox tbStreet;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblClass;
        private TextBox tbClass;
        private Label lblLastname;
        private TextBox tbLastname;
        private Label lblFirstname;
        private TextBox tbFirstname;
        private Panel panel1;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnSave;
        private Button btnDelete;
        private Button btNew;
        private Button btnNew;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem parkplatzbelastungToolStripMenuItem;
        private ToolStripMenuItem belastungrechnenToolStripMenuItem;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private BindingSource schuelerBindingSource;
        private BindingSource adressenBindingSource;
        private DataGridViewTextBoxColumn ParkplatzantragsId;
        private DataGridViewTextBoxColumn KfzKennzeichen;
        private DataGridViewTextBoxColumn EntfernungKm;
        private DataGridViewTextBoxColumn Fahrzeit;
        private DataGridViewTextBoxColumn Besonderefall;
        private DataGridViewTextBoxColumn Grund;
        private DataGridViewTextBoxColumn Mitfahrgelegenheit;
        private DataGridViewTextBoxColumn Moeglichkeit;
        private DataGridViewTextBoxColumn Antragsdatum;
        private DataGridViewTextBoxColumn Genehmigt;
        private DataGridViewTextBoxColumn schuelerIdDataGridViewTextBoxColumn;
    }
}