using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HandlebarsDotNet;

namespace MassMailer
{
    public partial class HTMLViewForm : Form
    {
        private int currentUserNumber = 0;
        private List<Dictionary<string, string>> userList = new List<Dictionary<string, string>>();
        private ComboBox.ObjectCollection recipients;
        private bool isDynamic;


        public HTMLViewForm(ComboBox.ObjectCollection recipients, bool isDynamic)
        {
            this.recipients = recipients;
            this.isDynamic = isDynamic;
            InitializeComponent();
        }

        private async void HTMLViewForm_Load(object sender, EventArgs e)
        {

            await webView21.EnsureCoreWebView2Async(null);
            if (isDynamic)
                userList = SMTPBrains.FormData(MainForm.CSVData);
            foreach (Object item in recipients)
            {
                comboBox_Templates.Items.Add(item.ToString());
            }
            RecipientController();
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            currentUserNumber++;
            RecipientController();
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            currentUserNumber--;
            RecipientController();
        }

        private void RecipientController()
        {
            button_Right.Enabled = currentUserNumber != recipients.Count;
            button_Left.Enabled = currentUserNumber != 0;
            comboBox_Templates.SelectedIndex = currentUserNumber;

            string webViewContent;

            if (isDynamic && currentUserNumber != 0)
            {
                webViewContent = (userList.Count >= currentUserNumber)
                    ? Handlebars.Compile(MainForm.HTMLData)(userList[currentUserNumber - 1])
                    : "<h1><span style=\"color: #ff0000;\"><strong>Нет данных.</strong></span></h1>" +
                    "<h1><span style=\"color: #ff0000;\"><strong>Выбранному получателю письмо не будет доставлено.</strong></span></h1>";
            }
            else
            {
                webViewContent = MainForm.HTMLData;
            }

            webView21.CoreWebView2.NavigateToString(webViewContent);
        }

        private void comboBox_Templates_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUserNumber = comboBox_Templates.SelectedIndex;
            RecipientController();
        }
    }
}
