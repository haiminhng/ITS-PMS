namespace App.Forms
{
    partial class ParkingStatistics
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
            lblPfadUntis = new Label();
            textBox1 = new TextBox();
            btnLoadFileUntis = new Button();
            dateTimePicker1 = new DateTimePicker();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            progressBar1 = new ProgressBar();
            btnStatCalc = new Button();
            SuspendLayout();
            // 
            // lblPfadUntis
            // 
            lblPfadUntis.AutoSize = true;
            lblPfadUntis.Location = new Point(12, 9);
            lblPfadUntis.Name = "lblPfadUntis";
            lblPfadUntis.RightToLeft = RightToLeft.No;
            lblPfadUntis.Size = new Size(34, 15);
            lblPfadUntis.TabIndex = 0;
            lblPfadUntis.Text = "Untis";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // btnLoadFileUntis
            // 
            btnLoadFileUntis.Location = new Point(162, 6);
            btnLoadFileUntis.Name = "btnLoadFileUntis";
            btnLoadFileUntis.Size = new Size(75, 23);
            btnLoadFileUntis.TabIndex = 2;
            btnLoadFileUntis.Text = "Load";
            btnLoadFileUntis.UseVisualStyleBackColor = true;
            btnLoadFileUntis.Click += btnLoadFileUntis_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(12, 64);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(776, 374);
            plotView1.TabIndex = 4;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(243, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 5;
            // 
            // btnStatCalc
            // 
            btnStatCalc.Location = new Point(349, 6);
            btnStatCalc.Name = "btnStatCalc";
            btnStatCalc.Size = new Size(75, 23);
            btnStatCalc.TabIndex = 6;
            btnStatCalc.Text = "Berechnen";
            btnStatCalc.UseVisualStyleBackColor = true;
            btnStatCalc.Click += btnStatCalc_Click;
            // 
            // ParkingStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStatCalc);
            Controls.Add(progressBar1);
            Controls.Add(plotView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnLoadFileUntis);
            Controls.Add(textBox1);
            Controls.Add(lblPfadUntis);
            Name = "ParkingStatistics";
            Text = "ParkingStatistics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPfadUntis;
        private TextBox textBox1;
        private Button btnLoadFileUntis;
        private DateTimePicker dateTimePicker1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private ProgressBar progressBar1;
        private Button btnStatCalc;
    }
}