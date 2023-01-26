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
            this.lblPfadUntis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoadFileUntis = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // lblPfadUntis
            // 
            this.lblPfadUntis.AutoSize = true;
            this.lblPfadUntis.Location = new System.Drawing.Point(12, 9);
            this.lblPfadUntis.Name = "lblPfadUntis";
            this.lblPfadUntis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPfadUntis.Size = new System.Drawing.Size(34, 15);
            this.lblPfadUntis.TabIndex = 0;
            this.lblPfadUntis.Text = "Untis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnLoadFileUntis
            // 
            this.btnLoadFileUntis.Location = new System.Drawing.Point(162, 6);
            this.btnLoadFileUntis.Name = "btnLoadFileUntis";
            this.btnLoadFileUntis.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFileUntis.TabIndex = 2;
            this.btnLoadFileUntis.Text = "Load";
            this.btnLoadFileUntis.UseVisualStyleBackColor = true;
            this.btnLoadFileUntis.Click += new System.EventHandler(this.btnLoadFileUntis_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(12, 64);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(776, 374);
            this.plotView1.TabIndex = 4;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // ParkingStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnLoadFileUntis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPfadUntis);
            this.Name = "ParkingStatistics";
            this.Text = "ParkingStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPfadUntis;
        private TextBox textBox1;
        private Button btnLoadFileUntis;
        private DateTimePicker dateTimePicker1;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}