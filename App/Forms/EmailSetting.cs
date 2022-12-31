﻿using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;


namespace App.Forms
{
    public partial class EmailSetting : Form, IEmailSetting
    {
        private IMailServerConfiguration _mailServer = UnityConfig.container.Resolve<IMailServerConfiguration>();
        private IEncryptionTool _encryptionTool = UnityConfig.container.Resolve<IEncryptionTool>();

        public EmailSetting()
        {
            InitializeComponent();
            textBoxSmtpServer.Text = _mailServer.SmtpServer; ;

            //_mailServer.SmtpServer = textBoxSmtpServer.Text;
            /*
            _mailServer.Port = int.Parse(textBoxPort.Text);
            _mailServer.SenderEmail = textBoxSenderEmail.Text;
            _mailServer.Password = textBoxPassword.Text;
            _mailServer.EnableSsl = checkBoxEnableSsl.Checked;
            */
        }

        public void ShowEmailSetting()
        {
            this.ShowDialog();
        }
    }
}
