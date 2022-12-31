using System.Windows.Forms;

namespace App
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antrag));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControlAntrag = new System.Windows.Forms.TabControl();
            this.alleAntrag = new System.Windows.Forms.TabPage();
            this.dataGridViewParkingApplication = new System.Windows.Forms.DataGridView();
            this.genehmigtstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenuGenehmigen = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuAblehnen = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuWarteliste = new System.Windows.Forms.ToolStripMenuItem();
            this.parkplatzantragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genehmigteAntrag = new System.Windows.Forms.TabPage();
            this.abgelehnteAntrag = new System.Windows.Forms.TabPage();
            this.warteliste = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnNewCalc = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.GenehmigtNavigation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ParkplatzantragsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KfzKennzeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntfernungKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reisezeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Besonderefall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mitfahrgelegenheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moeglichkeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antragsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antragszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genehmigt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxStudentAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).BeginInit();
            this.groupBoxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.tabControlAntrag.SuspendLayout();
            this.alleAntrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkingApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genehmigtstatusBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkplatzantragBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1208, 729);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailServerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // mailServerToolStripMenuItem
            // 
            this.mailServerToolStripMenuItem.Name = "mailServerToolStripMenuItem";
            this.mailServerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mailServerToolStripMenuItem.Text = "Mail Server";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(3, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(281, 702);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBoxStudentAddress);
            this.tabPage1.Controls.Add(this.groupBoxStudentInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informationen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(14, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 23);
            this.textBox3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Aktuelle Mietzeitraum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(121, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 23);
            this.textBox2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gesammte Platz";
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
            this.groupBoxStudentAddress.Location = new System.Drawing.Point(1, 393);
            this.groupBoxStudentAddress.Name = "groupBoxStudentAddress";
            this.groupBoxStudentAddress.Size = new System.Drawing.Size(263, 145);
            this.groupBoxStudentAddress.TabIndex = 14;
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
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(-1, 241);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(265, 146);
            this.groupBoxStudentInfo.TabIndex = 15;
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
            this.tbFirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schuelerBindingSource, "Vorname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFirstname.Location = new System.Drawing.Point(83, 28);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(173, 23);
            this.tbFirstname.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(273, 674);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Belastung";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 49);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlAntrag);
            this.splitContainer2.Size = new System.Drawing.Size(921, 639);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webView21);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 639);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fahrzeit Informationen";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(3, 19);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(314, 617);
            this.webView21.Source = new System.Uri("https://its-stuttgart.de", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // tabControlAntrag
            // 
            this.tabControlAntrag.Controls.Add(this.alleAntrag);
            this.tabControlAntrag.Controls.Add(this.genehmigteAntrag);
            this.tabControlAntrag.Controls.Add(this.abgelehnteAntrag);
            this.tabControlAntrag.Controls.Add(this.warteliste);
            this.tabControlAntrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAntrag.Location = new System.Drawing.Point(0, 0);
            this.tabControlAntrag.Name = "tabControlAntrag";
            this.tabControlAntrag.SelectedIndex = 0;
            this.tabControlAntrag.Size = new System.Drawing.Size(597, 639);
            this.tabControlAntrag.TabIndex = 1;
            // 
            // alleAntrag
            // 
            this.alleAntrag.Controls.Add(this.dataGridViewParkingApplication);
            this.alleAntrag.Location = new System.Drawing.Point(4, 24);
            this.alleAntrag.Name = "alleAntrag";
            this.alleAntrag.Padding = new System.Windows.Forms.Padding(3);
            this.alleAntrag.Size = new System.Drawing.Size(589, 611);
            this.alleAntrag.TabIndex = 0;
            this.alleAntrag.Text = "Alle";
            this.alleAntrag.UseVisualStyleBackColor = true;
            // 
            // dataGridViewParkingApplication
            // 
            this.dataGridViewParkingApplication.AllowUserToOrderColumns = true;
            this.dataGridViewParkingApplication.AutoGenerateColumns = false;
            this.dataGridViewParkingApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewParkingApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParkingApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParkplatzantragsId,
            this.KfzKennzeichen,
            this.EntfernungKm,
            this.Reisezeit,
            this.Fahrzeit,
            this.Besonderefall,
            this.Grund,
            this.Mitfahrgelegenheit,
            this.Moeglichkeit,
            this.Antragsdatum,
            this.Antragszeit,
            this.Genehmigt});
            this.dataGridViewParkingApplication.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewParkingApplication.DataSource = this.parkplatzantragBindingSource;
            this.dataGridViewParkingApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParkingApplication.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewParkingApplication.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewParkingApplication.Name = "dataGridViewParkingApplication";
            this.dataGridViewParkingApplication.RowTemplate.Height = 25;
            this.dataGridViewParkingApplication.Size = new System.Drawing.Size(583, 605);
            this.dataGridViewParkingApplication.TabIndex = 0;
            // 
            // genehmigtstatusBindingSource
            // 
            this.genehmigtstatusBindingSource.DataSource = typeof(Models.Models.Genehmigtstatus);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuGenehmigen,
            this.cMenuAblehnen,
            this.cMenuWarteliste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 70);
            // 
            // cMenuGenehmigen
            // 
            this.cMenuGenehmigen.Name = "cMenuGenehmigen";
            this.cMenuGenehmigen.Size = new System.Drawing.Size(203, 22);
            this.cMenuGenehmigen.Text = "Genehmigen";
            // 
            // cMenuAblehnen
            // 
            this.cMenuAblehnen.Name = "cMenuAblehnen";
            this.cMenuAblehnen.Size = new System.Drawing.Size(203, 22);
            this.cMenuAblehnen.Text = "Ablehnen";
            // 
            // cMenuWarteliste
            // 
            this.cMenuWarteliste.Name = "cMenuWarteliste";
            this.cMenuWarteliste.Size = new System.Drawing.Size(203, 22);
            this.cMenuWarteliste.Text = "Auf die Warteliste setzen";
            // 
            // parkplatzantragBindingSource
            // 
            this.parkplatzantragBindingSource.DataSource = typeof(Models.Models.Parkplatzantrag);
            // 
            // genehmigteAntrag
            // 
            this.genehmigteAntrag.Location = new System.Drawing.Point(4, 24);
            this.genehmigteAntrag.Name = "genehmigteAntrag";
            this.genehmigteAntrag.Padding = new System.Windows.Forms.Padding(3);
            this.genehmigteAntrag.Size = new System.Drawing.Size(589, 611);
            this.genehmigteAntrag.TabIndex = 1;
            this.genehmigteAntrag.Text = "Genehmigt";
            this.genehmigteAntrag.UseVisualStyleBackColor = true;
            // 
            // abgelehnteAntrag
            // 
            this.abgelehnteAntrag.Location = new System.Drawing.Point(4, 24);
            this.abgelehnteAntrag.Name = "abgelehnteAntrag";
            this.abgelehnteAntrag.Size = new System.Drawing.Size(589, 611);
            this.abgelehnteAntrag.TabIndex = 2;
            this.abgelehnteAntrag.Text = "Abgelehnt";
            this.abgelehnteAntrag.UseVisualStyleBackColor = true;
            // 
            // warteliste
            // 
            this.warteliste.Location = new System.Drawing.Point(4, 24);
            this.warteliste.Name = "warteliste";
            this.warteliste.Size = new System.Drawing.Size(589, 611);
            this.warteliste.TabIndex = 3;
            this.warteliste.Text = "Wartelist";
            this.warteliste.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parkplatz anträge";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suchen";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(769, 17);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(148, 23);
            this.tbSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 687);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnLast
            // 
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLast.Location = new System.Drawing.Point(756, 0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(42, 42);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(798, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 42);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrevious.Location = new System.Drawing.Point(840, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(42, 42);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFirst.Location = new System.Drawing.Point(882, 0);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(42, 42);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Panel1MinSize = 320;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnNewCalc);
            this.splitContainer3.Panel2.Controls.Add(this.btnEmail);
            this.splitContainer3.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer3.Panel2.Controls.Add(this.btnSave);
            this.splitContainer3.Panel2.Controls.Add(this.btnNew);
            this.splitContainer3.Size = new System.Drawing.Size(924, 42);
            this.splitContainer3.SplitterDistance = 320;
            this.splitContainer3.TabIndex = 7;
            // 
            // btnNewCalc
            // 
            this.btnNewCalc.BackColor = System.Drawing.SystemColors.Menu;
            this.btnNewCalc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewCalc.Location = new System.Drawing.Point(300, 0);
            this.btnNewCalc.Name = "btnNewCalc";
            this.btnNewCalc.Size = new System.Drawing.Size(75, 42);
            this.btnNewCalc.TabIndex = 6;
            this.btnNewCalc.Text = "Neu berechnen";
            this.btnNewCalc.UseVisualStyleBackColor = false;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmail.Location = new System.Drawing.Point(225, 0);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 42);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Email senden";
            this.btnEmail.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(150, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(75, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "hinzufügen";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // GenehmigtNavigation
            // 
            this.GenehmigtNavigation.DataPropertyName = "GenehmigtNavigation";
            this.GenehmigtNavigation.DataSource = this.parkplatzantragBindingSource;
            this.GenehmigtNavigation.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.GenehmigtNavigation.HeaderText = "Genehmigt";
            this.GenehmigtNavigation.Name = "GenehmigtNavigation";
            this.GenehmigtNavigation.Width = 72;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "GenehmigtNavigation";
            this.dataGridViewComboBoxColumn1.DataSource = this.parkplatzantragBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "GenehmigtNavigation";
            this.dataGridViewComboBoxColumn1.HeaderText = "GenehmigtNavigation";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 149;
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
            dataGridViewCellStyle1.Format = "0, km";
            this.EntfernungKm.DefaultCellStyle = dataGridViewCellStyle1;
            this.EntfernungKm.HeaderText = "EntfernungKm";
            this.EntfernungKm.Name = "EntfernungKm";
            this.EntfernungKm.Width = 109;
            // 
            // Reisezeit
            // 
            this.Reisezeit.DataPropertyName = "Reisezeit";
            this.Reisezeit.HeaderText = "Reisezeit";
            this.Reisezeit.Name = "Reisezeit";
            this.Reisezeit.Width = 77;
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
            // Antragszeit
            // 
            this.Antragszeit.DataPropertyName = "Antragszeit";
            this.Antragszeit.HeaderText = "Antragszeit";
            this.Antragszeit.Name = "Antragszeit";
            this.Antragszeit.Width = 91;
            // 
            // Genehmigt
            // 
            this.Genehmigt.DataPropertyName = "Genehmigt";
            this.Genehmigt.DataSource = this.genehmigtstatusBindingSource;
            this.Genehmigt.DisplayMember = "Beschreibung";
            this.Genehmigt.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Genehmigt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genehmigt.HeaderText = "Genehmigt";
            this.Genehmigt.MinimumWidth = 100;
            this.Genehmigt.Name = "Genehmigt";
            this.Genehmigt.ValueMember = "Wert";
            this.Genehmigt.Width = 100;
            // 
            // Antrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 729);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Antrag";
            this.Text = "Parkplatzantragverwaltung";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxStudentAddress.ResumeLayout(false);
            this.groupBoxStudentAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).EndInit();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schuelerBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.tabControlAntrag.ResumeLayout(false);
            this.alleAntrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkingApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genehmigtstatusBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkplatzantragBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private BindingSource parkplatzantragBindingSource;
        private Panel panel1;
        private Button btnSave;
        private Button btNew;
        private Button btnNew;
        private MenuStrip menuStrip1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private BindingSource schuelerBindingSource;
        private BindingSource adressenBindingSource;
        private SplitContainer splitContainer2;
        private DataGridView dataGridViewParkingApplication;
        private GroupBox groupBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private SplitContainer splitContainer3;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
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
        private TabPage tabPage3;
        private Button btnEmail;
        private Button btnDelete;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem mailServerToolStripMenuItem;
        private TextBox tbSearch;
        private Button btnNewCalc;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cMenuGenehmigen;
        private ToolStripMenuItem cMenuAblehnen;
        private ToolStripMenuItem cMenuWarteliste;
        private TabControl tabControlAntrag;
        private TabPage alleAntrag;
        private TabPage genehmigteAntrag;
        private TabPage abgelehnteAntrag;
        private TabPage warteliste;
        private BindingSource genehmigtstatusBindingSource;
        private DataGridViewComboBoxColumn GenehmigtNavigation;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ParkplatzantragsId;
        private DataGridViewTextBoxColumn KfzKennzeichen;
        private DataGridViewTextBoxColumn EntfernungKm;
        private DataGridViewTextBoxColumn Reisezeit;
        private DataGridViewTextBoxColumn Fahrzeit;
        private DataGridViewTextBoxColumn Besonderefall;
        private DataGridViewTextBoxColumn Grund;
        private DataGridViewTextBoxColumn Mitfahrgelegenheit;
        private DataGridViewTextBoxColumn Moeglichkeit;
        private DataGridViewTextBoxColumn Antragsdatum;
        private DataGridViewTextBoxColumn Antragszeit;
        private DataGridViewComboBoxColumn Genehmigt;
    }
}