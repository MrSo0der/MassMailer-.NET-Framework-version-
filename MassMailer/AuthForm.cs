using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassMailer
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            RestoreCredentials();
            LoadFonts();

        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            switch (SMTPBrains.Auth(textBox_Login.Text, textBox_Password.Text))
            {
                case "wrongCredentials":
                    label_Errors.Text = "Неправильный логин или пароль!";
                    LabelErrorsShowAndHide();
                    break;
                case "badInternetConnection":
                    label_Errors.Text = "Проверьте соединение с интернетом.";
                    LabelErrorsShowAndHide();
                    break;
                case "success":
                    if (Properties.Settings.Default.RememberChecked)
                    {
                        Properties.Settings.Default.Login = textBox_Login.Text;
                        Properties.Settings.Default.Password = Encryption.Encrypt(textBox_Password.Text);
                        Properties.Settings.Default.Save();
                    }
                    Hide();
                    new MainForm().ShowDialog();
                    Close();
                    break;
            }
        }

        private void LoadFonts()
        {
            label_MassMailer.Font = new Font(FoantsLoader.pfc.Families[1], 28, FontStyle.Bold);
            checkBox_Remember.Font = new Font(FoantsLoader.pfc.Families[0], 11, FontStyle.Regular);
            textBox_Login.Font = new Font(FoantsLoader.pfc.Families[0], 12, FontStyle.Regular);
            textBox_Password.Font = new Font(FoantsLoader.pfc.Families[0], 12, FontStyle.Regular);
            button_Login.Font = new Font(FoantsLoader.pfc.Families[0], 16, FontStyle.Regular);
            label_Password.Font = new Font(FoantsLoader.pfc.Families[0], 9, FontStyle.Bold);
            label_Login.Font = new Font(FoantsLoader.pfc.Families[0], 9, FontStyle.Bold);
            label_Errors.Font = new Font(FoantsLoader.pfc.Families[0], 11, FontStyle.Regular);
        }

        private async void LabelErrorsShowAndHide()
        {
            label_Errors.Visible = true;
            await Task.Delay(3000);
            label_Errors.Visible = false;
        }

        private void RestoreCredentials()
        {
            if (Properties.Settings.Default.RememberChecked)
            {
                checkBox_Remember.Checked = true;
                textBox_Login.Text = Properties.Settings.Default.Login;
                textBox_Password.Text = Encryption.Decrypt(Properties.Settings.Default.Password);
            }
        }

        private void checkBox_Remember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberChecked = checkBox_Remember.Checked;
            if (!Properties.Settings.Default.RememberChecked)
            {
                Properties.Settings.Default.Login = "";
                Properties.Settings.Default.Password = "";
            }
            Properties.Settings.Default.Save();
        }

    }
}
