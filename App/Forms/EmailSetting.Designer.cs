namespace App.Forms
{
    partial class EmailSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailSetting));
            this.SMTP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSmtpServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSenderEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.checkBoxEnableSsl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SMTP
            // 
            this.SMTP.AutoSize = true;
            this.SMTP.Location = new System.Drawing.Point(41, 90);
            this.SMTP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SMTP.Name = "SMTP";
            this.SMTP.Size = new System.Drawing.Size(149, 32);
            this.SMTP.TabIndex = 0;
            this.SMTP.Text = "SMTP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBoxSmtpServer
            // 
            this.textBoxSmtpServer.Location = new System.Drawing.Point(195, 83);
            this.textBoxSmtpServer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSmtpServer.Name = "textBoxSmtpServer";
            this.textBoxSmtpServer.Size = new System.Drawing.Size(405, 39);
            this.textBoxSmtpServer.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(195, 145);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(405, 39);
            this.textBoxPort.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(195, 269);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(405, 39);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxSenderEmail
            // 
            this.textBoxSenderEmail.Location = new System.Drawing.Point(195, 207);
            this.textBoxSenderEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSenderEmail.Name = "textBoxSenderEmail";
            this.textBoxSenderEmail.Size = new System.Drawing.Size(405, 39);
            this.textBoxSenderEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enable SSL";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 420);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 49);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(487, 420);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(139, 49);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "Abbrechen";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // checkBoxEnableSsl
            // 
            this.checkBoxEnableSsl.AutoSize = true;
            this.checkBoxEnableSsl.Location = new System.Drawing.Point(195, 346);
            this.checkBoxEnableSsl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxEnableSsl.Name = "checkBoxEnableSsl";
            this.checkBoxEnableSsl.Size = new System.Drawing.Size(67, 36);
            this.checkBoxEnableSsl.TabIndex = 13;
            this.checkBoxEnableSsl.Text = "Ja";
            this.checkBoxEnableSsl.UseVisualStyleBackColor = true;
            // 
            // EmailSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 499);
            this.Controls.Add(this.checkBoxEnableSsl);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxSenderEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxSmtpServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SMTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EmailSetting";
            this.Text = "Email Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SMTP;
        private Label label2;
        private TextBox textBoxSmtpServer;
        private TextBox textBoxPort;
        private TextBox textBoxPassword;
        private TextBox textBoxSenderEmail;
        private Label label3;
        private Label label4;
        private Label label1;
        private Button btnSave;
        private Button btnCancle;
        private CheckBox checkBoxEnableSsl;
    }
}