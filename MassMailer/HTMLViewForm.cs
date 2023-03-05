using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;

namespace MassMailer
{
    public partial class HTMLViewForm : Form
    {
        public HTMLViewForm()
        {
            InitializeComponent();
        }

        private async void HTMLViewForm_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);

            webView21.CoreWebView2.NavigateToString(MainForm.HTMLData);
        }
    }
}
