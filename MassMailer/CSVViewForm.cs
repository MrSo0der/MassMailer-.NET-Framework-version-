using System;
using System.Windows.Forms;

namespace MassMailer
{
    public partial class CSVViewForm : Form
    {
        public CSVViewForm()
        {
            InitializeComponent();
            richTextBox1.Text = MainForm.CSVData;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            MainForm.CSVData = richTextBox1.Text;
        }
    }
}
