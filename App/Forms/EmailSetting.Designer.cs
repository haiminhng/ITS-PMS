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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxEnableSsl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SMTP
            // 
            this.SMTP.AutoSize = true;
            this.SMTP.Location = new System.Drawing.Point(22, 42);
            this.SMTP.Name = "SMTP";
            this.SMTP.Size = new System.Drawing.Size(72, 15);
            this.SMTP.TabIndex = 0;
            this.SMTP.Text = "SMTP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBoxSmtpServer
            // 
            this.textBoxSmtpServer.Location = new System.Drawing.Point(105, 39);
            this.textBoxSmtpServer.Name = "textBoxSmtpServer";
            this.textBoxSmtpServer.Size = new System.Drawing.Size(220, 23);
            this.textBoxSmtpServer.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(105, 68);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(220, 23);
            this.textBoxPort.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(105, 126);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxSenderEmail
            // 
            this.textBoxSenderEmail.Location = new System.Drawing.Point(105, 97);
            this.textBoxSenderEmail.Name = "textBoxSenderEmail";
            this.textBoxSenderEmail.Size = new System.Drawing.Size(220, 23);
            this.textBoxSenderEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enable SSL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableSsl
            // 
            this.checkBoxEnableSsl.AutoSize = true;
            this.checkBoxEnableSsl.Location = new System.Drawing.Point(105, 162);
            this.checkBoxEnableSsl.Name = "checkBoxEnableSsl";
            this.checkBoxEnableSsl.Size = new System.Drawing.Size(36, 19);
            this.checkBoxEnableSsl.TabIndex = 13;
            this.checkBoxEnableSsl.Text = "Ja";
            this.checkBoxEnableSsl.UseVisualStyleBackColor = true;
            // 
            // EmailSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 234);
            this.Controls.Add(this.checkBoxEnableSsl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Button button2;
        private CheckBox checkBoxEnableSsl;
    }
}