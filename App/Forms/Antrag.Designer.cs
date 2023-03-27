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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antrag));
            splitContainer1 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            parkstatistikToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            mailServerToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tbProcessingCount = new TextBox();
            label7 = new Label();
            tbWaitlistedCount = new TextBox();
            label6 = new Label();
            tbRejectedCount = new TextBox();
            label5 = new Label();
            tbApprovedCount = new TextBox();
            label3 = new Label();
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
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            wViewGoogleMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControlAntrag = new TabControl();
            alleAntrag = new TabPage();
            dataGridViewParkingApplication = new DataGridView();
            ParkplatzantragsId = new DataGridViewTextBoxColumn();
            KfzKennzeichen = new DataGridViewTextBoxColumn();
            EntfernungKm = new DataGridViewTextBoxColumn();
            Reisezeit = new DataGridViewTextBoxColumn();
            Fahrzeit = new DataGridViewTextBoxColumn();
            Grund = new DataGridViewTextBoxColumn();
            Moeglichkeit = new DataGridViewTextBoxColumn();
            Besonderefall = new DataGridViewTextBoxColumn();
            Mitfahrgelegenheit = new DataGridViewTextBoxColumn();
            Antragsdatum = new DataGridViewTextBoxColumn();
            Antragszeit = new DataGridViewTextBoxColumn();
            Punkte = new DataGridViewTextBoxColumn();
            Genehmigt = new DataGridViewComboBoxColumn();
            genehmigtstatusBindingSource = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            cMenuGenehmigen = new ToolStripMenuItem();
            cMenuAblehnen = new ToolStripMenuItem();
            cMenuWarteliste = new ToolStripMenuItem();
            parkplatzantragBindingSource = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            tbSearch = new TextBox();
            panel1 = new Panel();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            splitContainer3 = new SplitContainer();
            btnNewCalc = new Button();
            btnEmail = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnNew = new Button();
            GenehmigtNavigation = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            cMenuImBearbeitung = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxStudentAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adressenBindingSource).BeginInit();
            groupBoxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schuelerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wViewGoogleMap).BeginInit();
            tabControlAntrag.SuspendLayout();
            alleAntrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkingApplication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genehmigtstatusBindingSource).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parkplatzantragBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            splitContainer1.Panel1.Controls.Add(tabControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(tbSearch);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1208, 729);
            splitContainer1.SplitterDistance = 280;
            splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { parkstatistikToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(280, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // parkstatistikToolStripMenuItem
            // 
            parkstatistikToolStripMenuItem.Name = "parkstatistikToolStripMenuItem";
            parkstatistikToolStripMenuItem.Size = new Size(82, 20);
            parkstatistikToolStripMenuItem.Text = "Parkstatistik";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mailServerToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // mailServerToolStripMenuItem
            // 
            mailServerToolStripMenuItem.Name = "mailServerToolStripMenuItem";
            mailServerToolStripMenuItem.Size = new Size(132, 22);
            mailServerToolStripMenuItem.Text = "Mail Server";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(3, 27);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(281, 702);
            tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbProcessingCount);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(tbWaitlistedCount);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tbRejectedCount);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(tbApprovedCount);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(groupBoxStudentAddress);
            tabPage1.Controls.Add(groupBoxStudentInfo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(273, 674);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Informationen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbProcessingCount
            // 
            tbProcessingCount.Enabled = false;
            tbProcessingCount.Location = new Point(119, 101);
            tbProcessingCount.Name = "tbProcessingCount";
            tbProcessingCount.Size = new Size(114, 23);
            tbProcessingCount.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 104);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 22;
            label7.Text = "Im Bearbeitung";
            // 
            // tbWaitlistedCount
            // 
            tbWaitlistedCount.Enabled = false;
            tbWaitlistedCount.Location = new Point(119, 72);
            tbWaitlistedCount.Name = "tbWaitlistedCount";
            tbWaitlistedCount.Size = new Size(114, 23);
            tbWaitlistedCount.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 75);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 20;
            label6.Text = "Wartelist";
            // 
            // tbRejectedCount
            // 
            tbRejectedCount.Enabled = false;
            tbRejectedCount.Location = new Point(119, 43);
            tbRejectedCount.Name = "tbRejectedCount";
            tbRejectedCount.Size = new Size(114, 23);
            tbRejectedCount.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 46);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 18;
            label5.Text = "Abgelehnt";
            // 
            // tbApprovedCount
            // 
            tbApprovedCount.Enabled = false;
            tbApprovedCount.Location = new Point(119, 14);
            tbApprovedCount.Name = "tbApprovedCount";
            tbApprovedCount.Size = new Size(114, 23);
            tbApprovedCount.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 17);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 16;
            label3.Text = "Genehmigt";
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
            groupBoxStudentAddress.Location = new Point(1, 393);
            groupBoxStudentAddress.Name = "groupBoxStudentAddress";
            groupBoxStudentAddress.Size = new Size(263, 145);
            groupBoxStudentAddress.TabIndex = 14;
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
            groupBoxStudentInfo.Location = new Point(-1, 241);
            groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            groupBoxStudentInfo.Size = new Size(265, 146);
            groupBoxStudentInfo.TabIndex = 15;
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
            tbFirstname.DataBindings.Add(new Binding("Text", schuelerBindingSource, "Vorname", true, DataSourceUpdateMode.OnPropertyChanged));
            tbFirstname.Location = new Point(83, 28);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(173, 23);
            tbFirstname.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(3, 49);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tabControlAntrag);
            splitContainer2.Size = new Size(917, 639);
            splitContainer2.SplitterDistance = 315;
            splitContainer2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(wViewGoogleMap);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 639);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fahrzeit Informationen";
            // 
            // wViewGoogleMap
            // 
            wViewGoogleMap.AllowExternalDrop = true;
            wViewGoogleMap.CreationProperties = null;
            wViewGoogleMap.DefaultBackgroundColor = Color.White;
            wViewGoogleMap.Dock = DockStyle.Fill;
            wViewGoogleMap.Location = new Point(3, 19);
            wViewGoogleMap.Name = "wViewGoogleMap";
            wViewGoogleMap.Size = new Size(309, 617);
            wViewGoogleMap.Source = new Uri("https://its-stuttgart.de", UriKind.Absolute);
            wViewGoogleMap.TabIndex = 0;
            wViewGoogleMap.ZoomFactor = 1D;
            // 
            // tabControlAntrag
            // 
            tabControlAntrag.Controls.Add(alleAntrag);
            tabControlAntrag.Dock = DockStyle.Fill;
            tabControlAntrag.Location = new Point(0, 0);
            tabControlAntrag.Name = "tabControlAntrag";
            tabControlAntrag.SelectedIndex = 0;
            tabControlAntrag.Size = new Size(598, 639);
            tabControlAntrag.TabIndex = 1;
            // 
            // alleAntrag
            // 
            alleAntrag.Controls.Add(dataGridViewParkingApplication);
            alleAntrag.Location = new Point(4, 24);
            alleAntrag.Name = "alleAntrag";
            alleAntrag.Padding = new Padding(3);
            alleAntrag.Size = new Size(590, 611);
            alleAntrag.TabIndex = 0;
            alleAntrag.Text = "Alle";
            alleAntrag.UseVisualStyleBackColor = true;
            // 
            // dataGridViewParkingApplication
            // 
            dataGridViewParkingApplication.AllowUserToOrderColumns = true;
            dataGridViewParkingApplication.AutoGenerateColumns = false;
            dataGridViewParkingApplication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewParkingApplication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewParkingApplication.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkingApplication.Columns.AddRange(new DataGridViewColumn[] { ParkplatzantragsId, KfzKennzeichen, EntfernungKm, Reisezeit, Fahrzeit, Grund, Moeglichkeit, Besonderefall, Mitfahrgelegenheit, Antragsdatum, Antragszeit, Punkte, Genehmigt });
            dataGridViewParkingApplication.ContextMenuStrip = contextMenuStrip1;
            dataGridViewParkingApplication.DataSource = parkplatzantragBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewParkingApplication.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewParkingApplication.Dock = DockStyle.Fill;
            dataGridViewParkingApplication.GridColor = SystemColors.ControlText;
            dataGridViewParkingApplication.Location = new Point(3, 3);
            dataGridViewParkingApplication.Name = "dataGridViewParkingApplication";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewParkingApplication.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewParkingApplication.RowHeadersWidth = 51;
            dataGridViewParkingApplication.RowTemplate.Height = 25;
            dataGridViewParkingApplication.Size = new Size(584, 605);
            dataGridViewParkingApplication.TabIndex = 0;
            // 
            // ParkplatzantragsId
            // 
            ParkplatzantragsId.DataPropertyName = "ParkplatzantragsId";
            ParkplatzantragsId.HeaderText = "ParkplatzantragsId";
            ParkplatzantragsId.MinimumWidth = 6;
            ParkplatzantragsId.Name = "ParkplatzantragsId";
            ParkplatzantragsId.Width = 129;
            // 
            // KfzKennzeichen
            // 
            KfzKennzeichen.DataPropertyName = "KfzKennzeichen";
            KfzKennzeichen.HeaderText = "KfzKennzeichen";
            KfzKennzeichen.MinimumWidth = 6;
            KfzKennzeichen.Name = "KfzKennzeichen";
            KfzKennzeichen.Width = 115;
            // 
            // EntfernungKm
            // 
            EntfernungKm.DataPropertyName = "EntfernungKm";
            dataGridViewCellStyle2.Format = "0, km";
            EntfernungKm.DefaultCellStyle = dataGridViewCellStyle2;
            EntfernungKm.HeaderText = "EntfernungKm";
            EntfernungKm.MinimumWidth = 6;
            EntfernungKm.Name = "EntfernungKm";
            EntfernungKm.Width = 109;
            // 
            // Reisezeit
            // 
            Reisezeit.DataPropertyName = "Reisezeit";
            Reisezeit.HeaderText = "Reisezeit";
            Reisezeit.MinimumWidth = 6;
            Reisezeit.Name = "Reisezeit";
            Reisezeit.Width = 77;
            // 
            // Fahrzeit
            // 
            Fahrzeit.DataPropertyName = "Fahrzeit";
            Fahrzeit.HeaderText = "Fahrzeit";
            Fahrzeit.MinimumWidth = 6;
            Fahrzeit.Name = "Fahrzeit";
            Fahrzeit.Width = 73;
            // 
            // Grund
            // 
            Grund.DataPropertyName = "Grund";
            Grund.HeaderText = "Grund";
            Grund.MinimumWidth = 6;
            Grund.Name = "Grund";
            Grund.Width = 65;
            // 
            // Moeglichkeit
            // 
            Moeglichkeit.DataPropertyName = "Moeglichkeit";
            Moeglichkeit.HeaderText = "Moeglichkeit";
            Moeglichkeit.MinimumWidth = 6;
            Moeglichkeit.Name = "Moeglichkeit";
            Moeglichkeit.Width = 101;
            // 
            // Besonderefall
            // 
            Besonderefall.DataPropertyName = "Besonderefall";
            Besonderefall.HeaderText = "Besonderefall";
            Besonderefall.MinimumWidth = 6;
            Besonderefall.Name = "Besonderefall";
            Besonderefall.Width = 103;
            // 
            // Mitfahrgelegenheit
            // 
            Mitfahrgelegenheit.DataPropertyName = "Mitfahrgelegenheit";
            Mitfahrgelegenheit.HeaderText = "Mitfahrgelegenheit";
            Mitfahrgelegenheit.MinimumWidth = 6;
            Mitfahrgelegenheit.Name = "Mitfahrgelegenheit";
            Mitfahrgelegenheit.Width = 133;
            // 
            // Antragsdatum
            // 
            Antragsdatum.DataPropertyName = "Antragsdatum";
            Antragsdatum.HeaderText = "Antragsdatum";
            Antragsdatum.MinimumWidth = 6;
            Antragsdatum.Name = "Antragsdatum";
            Antragsdatum.Width = 108;
            // 
            // Antragszeit
            // 
            Antragszeit.DataPropertyName = "Antragszeit";
            Antragszeit.HeaderText = "Antragszeit";
            Antragszeit.MinimumWidth = 6;
            Antragszeit.Name = "Antragszeit";
            Antragszeit.Width = 91;
            // 
            // Punkte
            // 
            Punkte.DataPropertyName = "Punkte";
            Punkte.HeaderText = "Punkte";
            Punkte.MinimumWidth = 6;
            Punkte.Name = "Punkte";
            Punkte.Width = 69;
            // 
            // Genehmigt
            // 
            Genehmigt.DataPropertyName = "Genehmigt";
            Genehmigt.DataSource = genehmigtstatusBindingSource;
            Genehmigt.DisplayMember = "Beschreibung";
            Genehmigt.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Genehmigt.FlatStyle = FlatStyle.Flat;
            Genehmigt.HeaderText = "Genehmigt";
            Genehmigt.MinimumWidth = 100;
            Genehmigt.Name = "Genehmigt";
            Genehmigt.ValueMember = "Wert";
            // 
            // genehmigtstatusBindingSource
            // 
            genehmigtstatusBindingSource.DataSource = typeof(Models.Models.Genehmigtstatus);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cMenuGenehmigen, cMenuAblehnen, cMenuImBearbeitung, cMenuWarteliste });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(204, 114);
            // 
            // cMenuGenehmigen
            // 
            cMenuGenehmigen.Name = "cMenuGenehmigen";
            cMenuGenehmigen.Size = new Size(203, 22);
            cMenuGenehmigen.Text = "Genehmigen";
            // 
            // cMenuAblehnen
            // 
            cMenuAblehnen.Name = "cMenuAblehnen";
            cMenuAblehnen.Size = new Size(203, 22);
            cMenuAblehnen.Text = "Ablehnen";
            // 
            // cMenuWarteliste
            // 
            cMenuWarteliste.Name = "cMenuWarteliste";
            cMenuWarteliste.Size = new Size(203, 22);
            cMenuWarteliste.Text = "Auf die Warteliste setzen";
            // 
            // parkplatzantragBindingSource
            // 
            parkplatzantragBindingSource.DataSource = typeof(Models.Models.Parkplatzantrag);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 12);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 4;
            label2.Text = "Parkplatz anträge";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(712, 20);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Suchen";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(765, 17);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(148, 23);
            tbSearch.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLast);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnFirst);
            panel1.Controls.Add(splitContainer3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 687);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 42);
            panel1.TabIndex = 1;
            // 
            // btnLast
            // 
            btnLast.Dock = DockStyle.Right;
            btnLast.Location = new Point(756, 0);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(42, 42);
            btnLast.TabIndex = 6;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Right;
            btnNext.Location = new Point(798, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 42);
            btnNext.TabIndex = 5;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Dock = DockStyle.Right;
            btnPrevious.Location = new Point(840, 0);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(42, 42);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Dock = DockStyle.Right;
            btnFirst.Location = new Point(882, 0);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(42, 42);
            btnFirst.TabIndex = 3;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Panel1MinSize = 320;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btnNewCalc);
            splitContainer3.Panel2.Controls.Add(btnEmail);
            splitContainer3.Panel2.Controls.Add(btnDelete);
            splitContainer3.Panel2.Controls.Add(btnSave);
            splitContainer3.Panel2.Controls.Add(btnNew);
            splitContainer3.Size = new Size(924, 42);
            splitContainer3.SplitterDistance = 320;
            splitContainer3.TabIndex = 7;
            // 
            // btnNewCalc
            // 
            btnNewCalc.BackColor = SystemColors.Menu;
            btnNewCalc.Dock = DockStyle.Left;
            btnNewCalc.Location = new Point(300, 0);
            btnNewCalc.Name = "btnNewCalc";
            btnNewCalc.Size = new Size(75, 42);
            btnNewCalc.TabIndex = 6;
            btnNewCalc.Text = "Neu berechnen";
            btnNewCalc.UseVisualStyleBackColor = false;
            // 
            // btnEmail
            // 
            btnEmail.BackColor = Color.DarkOrange;
            btnEmail.Dock = DockStyle.Left;
            btnEmail.Location = new Point(225, 0);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(75, 42);
            btnEmail.TabIndex = 5;
            btnEmail.Text = "Email senden";
            btnEmail.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Dock = DockStyle.Left;
            btnDelete.Location = new Point(150, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "löschen";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Dock = DockStyle.Left;
            btnSave.Location = new Point(75, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 42);
            btnSave.TabIndex = 2;
            btnSave.Text = "speichern";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSeaGreen;
            btnNew.Dock = DockStyle.Left;
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 42);
            btnNew.TabIndex = 0;
            btnNew.Text = "hinzufügen";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // GenehmigtNavigation
            // 
            GenehmigtNavigation.DataPropertyName = "GenehmigtNavigation";
            GenehmigtNavigation.DataSource = parkplatzantragBindingSource;
            GenehmigtNavigation.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            GenehmigtNavigation.HeaderText = "Genehmigt";
            GenehmigtNavigation.MinimumWidth = 6;
            GenehmigtNavigation.Name = "GenehmigtNavigation";
            GenehmigtNavigation.Width = 72;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.DataPropertyName = "GenehmigtNavigation";
            dataGridViewComboBoxColumn1.DataSource = parkplatzantragBindingSource;
            dataGridViewComboBoxColumn1.DisplayMember = "GenehmigtNavigation";
            dataGridViewComboBoxColumn1.HeaderText = "GenehmigtNavigation";
            dataGridViewComboBoxColumn1.MinimumWidth = 6;
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewComboBoxColumn1.Width = 149;
            // 
            // cMenuImBearbeitung
            // 
            cMenuImBearbeitung.Name = "cMenuImBearbeitung";
            cMenuImBearbeitung.Size = new Size(203, 22);
            cMenuImBearbeitung.Text = "Im Bearbeitung";
            // 
            // Antrag
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1208, 729);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Antrag";
            Text = "Parkplatzantragverwaltung";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBoxStudentAddress.ResumeLayout(false);
            groupBoxStudentAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adressenBindingSource).EndInit();
            groupBoxStudentInfo.ResumeLayout(false);
            groupBoxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)schuelerBindingSource).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wViewGoogleMap).EndInit();
            tabControlAntrag.ResumeLayout(false);
            alleAntrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkingApplication).EndInit();
            ((System.ComponentModel.ISupportInitialize)genehmigtstatusBindingSource).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)parkplatzantragBindingSource).EndInit();
            panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Microsoft.Web.WebView2.WinForms.WebView2 wViewGoogleMap;
        private SplitContainer splitContainer3;
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
        private BindingSource genehmigtstatusBindingSource;
        private DataGridViewComboBoxColumn GenehmigtNavigation;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ParkplatzantragsId;
        private DataGridViewTextBoxColumn KfzKennzeichen;
        private DataGridViewTextBoxColumn EntfernungKm;
        private DataGridViewTextBoxColumn Reisezeit;
        private DataGridViewTextBoxColumn Fahrzeit;
        private DataGridViewTextBoxColumn Grund;
        private DataGridViewTextBoxColumn Moeglichkeit;
        private DataGridViewTextBoxColumn Besonderefall;
        private DataGridViewTextBoxColumn Mitfahrgelegenheit;
        private DataGridViewTextBoxColumn Antragsdatum;
        private DataGridViewTextBoxColumn Antragszeit;
        private DataGridViewTextBoxColumn Punkte;
        private DataGridViewComboBoxColumn Genehmigt;
        private ToolStripMenuItem parkstatistikToolStripMenuItem;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TextBox textBox3;
        private TextBox tbApprovedCount;
        private Label label4;
        private Button button1;
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
        private TextBox tbProcessingCount;
        private Label label7;
        private TextBox tbWaitlistedCount;
        private Label label6;
        private TextBox tbRejectedCount;
        private Label label5;
        private ToolStripMenuItem cMenuImBearbeitung;
    }
}