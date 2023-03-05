using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MassMailer
{
    public partial class MainForm : Form
    {
        private static bool isCSV = false;
        private static bool isHTML = false;
        private static string Mode = "Plain";
        public static string CSVData = "";
        public static string HTMLData = "";
        public MainForm()
        {
            InitializeComponent();
            LoadFonts();
        }
        private void LoadFonts()
        {
            Font HSESansRegular13 = new Font(FontsLoader.pfc.Families[0], 13, FontStyle.Regular);
            label_ToWhom.Font = HSESansRegular13;
            label_Topic.Font = HSESansRegular13;
            button_Send.Font = HSESansRegular13;
            textBox_Topic.Font = HSESansRegular13;
            textBox_Recipient.Font = HSESansRegular13;
            comboBox_Files.Font = HSESansRegular13;
            comboBox_Recipients.Font = HSESansRegular13;
        }
        private async void LabelStatusShowAndHide(string status)
        {
            switch (status)
            {
                case "noRecipients":
                    label_Status.Text = "Укажите получателей";
                    break;
                case "wrongAddress":
                    label_Status.Text = "Неправильные адреса";
                    break;
                case "filesOpened":
                    label_Status.Text = "Закройте файлы перед отправкой";
                    break;
                case "sendingCancelled":
                    label_Status.Text = "Отправка отменена";
                    break;
                case "success":
                    label_Status.Text = "Отправлено!";
                    label_Status.ForeColor = Color.Green;
                    break;
            }
            label_Status.Visible = true;
            await Task.Delay(3000);
            label_Status.Visible = false;
            label_Status.ForeColor = Color.Red;
        }

        private void textBox_Recipient_TextChanged(object sender, EventArgs e)
        {
            string s;
            s = textBox_Recipient.Text;
            if (!Equals(s, "") && (Equals(s.Substring(s.Length - 1)[0], ' ') || Equals(s.Substring(s.Length - 1)[0], ',')))
            {
                comboBox_Recipients.Items.Add(s.Substring(0, s.Length - 1));
                textBox_Recipient.Text = "";
                button_RecipientsClear.Enabled = true;
            }
        }

        private void comboBox_Recipients_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Recipients.Items.Remove(comboBox_Recipients.SelectedItem);
            if (comboBox_Recipients.Items.Count == 0)
            {
                button_RecipientsClear.Enabled = false;
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            string status = "sendingCancelled";
            if (comboBox_Recipients.Items.Count == 0)
            {
                status = "noRecipients";
            }
            else if (Mode != "Dynamic" || SMTPBrains.FormData(CSVData) >= comboBox_Recipients.Items.Count || MessageBox.Show("Количество указанных Вами получателей больше количества переменных в CSV-файле. Письма с уникальными данными придут не всем получателям. Продолжить отправку?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                status = SMTPBrains.Send(textBox_MessageText.Text, comboBox_Recipients.Items, textBox_Topic.Text, comboBox_Files.Items, Mode, CSVData);
            }
            LabelStatusShowAndHide(status);
        }

        private void button_AttachFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFilePathsForFiles = openFileDialog.FileNames;
                foreach (var file in selectedFilePathsForFiles)
                {
                    comboBox_Files.Items.Add(file);
                }
                button_AttachmentsClear.Enabled = true;
            }
        }

        private void button_RecipientsFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string[] fields;

                using (var reader = new StreamReader(selectedFilePath))
                {
                    var line = reader.ReadLine();
                    fields = line.Split(',');
                }

                comboBox_Recipients.Items.Clear();
                foreach (var address in fields)
                {
                    comboBox_Recipients.Items.Add(address);
                }
                button_RecipientsClear.Enabled = true;
            }
        }

        private void comboBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Files.Items.Remove(comboBox_Files.SelectedItem);
            if (comboBox_Files.Items.Count == 0)
            {
                button_AttachmentsClear.Enabled = false;
            }
        }

        private void button_CSVFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CSVData = File.ReadAllText(openFileDialog.FileName);
                isCSV = true;
                ModeUpdater();
            }
        }

        private void button_HTMLFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "HTML files (*.html)|*.html"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_MessageText.Text = File.ReadAllText(openFileDialog.FileName);
                isHTML = true;
                ModeUpdater();
            }
        }

        private void ModeUpdater()
        {
            if (isHTML && isCSV)
            {
                Text = "MassMailer: Dynamic HTML Mode";
                Mode = "Dynamic";
            }
            else if (isHTML)
            {
                Text = "MassMailer: Static HTML Mode";
                Mode = "Static";
            }
            else if (isCSV)
            {
                Text = "MassMailer: Plain Text Mode (CSV file selected)";
                Mode = "Plain";
            }
            else
            {
                Text = "MassMailer: Plain Text Mode";
                Mode = "Plain";
            }
            button_CSVClear.Enabled = isCSV;
            button_CSVView.Enabled = isCSV;
            button_HTMLClear.Enabled = isHTML;
            button_HTMLView.Enabled = isHTML;
        }

        private void button_RecipientsClear_Click(object sender, EventArgs e)
        {
            comboBox_Recipients.Items.Clear();
            button_RecipientsClear.Enabled = false;
        }

        private void button_HTMLClear_Click(object sender, EventArgs e)
        {
                textBox_MessageText.Text = "";
                isHTML = false;
                ModeUpdater();
        }

        private void button_CSVClear_Click(object sender, EventArgs e)
        {
            isCSV = false;
            ModeUpdater();
        }

        private void button_AttachmentsClear_Click(object sender, EventArgs e)
        {
            comboBox_Files.Items.Clear();
            button_AttachmentsClear.Enabled = false;
        }

        private void button_HTMLView_Click(object sender, EventArgs e)
        {
            new HTMLViewForm().ShowDialog();
        }

        private void button_CSVView_Click(object sender, EventArgs e)
        {
            new CSVViewForm().ShowDialog();
        }

        private void textBox_MessageText_TextChanged(object sender, EventArgs e)
        {
            HTMLData = textBox_MessageText.Text;
        }

        private void textBox_MessageText_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                textBox_MessageText.Text = File.ReadAllText(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
                isHTML = true;
                ModeUpdater();
            }
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                textBox_MessageText.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                isHTML = false;
                ModeUpdater();
            }

        }
        private void textBox_MessageText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat) || (e.Data.GetDataPresent(DataFormats.FileDrop) && (((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".html") || ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".txt"))))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBox_MessageText_DragLeave(object sender, EventArgs e)
        {

        }
    }
}
