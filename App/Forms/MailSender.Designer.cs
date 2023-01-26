namespace App.Forms
{
    partial class MailSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailSender));
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmailFrom = new System.Windows.Forms.TextBox();
            this.tbEmailTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmailSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbEmailBody = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(1174, 885);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(139, 49);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Senden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von";
            // 
            // tbEmailFrom
            // 
            this.tbEmailFrom.Location = new System.Drawing.Point(143, 26);
            this.tbEmailFrom.Margin = new System.Windows.Forms.Padding(6);
            this.tbEmailFrom.Name = "tbEmailFrom";
            this.tbEmailFrom.ReadOnly = true;
            this.tbEmailFrom.Size = new System.Drawing.Size(1317, 39);
            this.tbEmailFrom.TabIndex = 2;
            // 
            // tbEmailTo
            // 
            this.tbEmailTo.Location = new System.Drawing.Point(143, 87);
            this.tbEmailTo.Margin = new System.Windows.Forms.Padding(6);
            this.tbEmailTo.Name = "tbEmailTo";
            this.tbEmailTo.Size = new System.Drawing.Size(1317, 39);
            this.tbEmailTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "An";
            // 
            // tbEmailSubject
            // 
            this.tbEmailSubject.Location = new System.Drawing.Point(143, 149);
            this.tbEmailSubject.Margin = new System.Windows.Forms.Padding(6);
            this.tbEmailSubject.Name = "tbEmailSubject";
            this.tbEmailSubject.Size = new System.Drawing.Size(1317, 39);
            this.tbEmailSubject.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Betreff";
            // 
            // rtbEmailBody
            // 
            this.rtbEmailBody.Location = new System.Drawing.Point(143, 211);
            this.rtbEmailBody.Margin = new System.Windows.Forms.Padding(6);
            this.rtbEmailBody.Name = "rtbEmailBody";
            this.rtbEmailBody.Size = new System.Drawing.Size(1317, 657);
            this.rtbEmailBody.TabIndex = 7;
            this.rtbEmailBody.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(1324, 885);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbEmailBody);
            this.Controls.Add(this.tbEmailSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmailTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmailFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MailSender";
            this.Text = "MailSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSend;
        private Label label1;
        private TextBox tbEmailFrom;
        private TextBox tbEmailTo;
        private Label label2;
        private TextBox tbEmailSubject;
        private Label label3;
        private RichTextBox rtbEmailBody;
        private Button btnCancel;
    }
}