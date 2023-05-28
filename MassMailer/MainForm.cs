using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MassMailer
{
    public partial class MainForm : Form
    {
        private static bool isCSV = false;
        private static bool isHTML = false;
        private static short mode = 0;
        private static short status;
        private static string cSVData = "";
        private static string hTMLData = "";

        public static string CSVData { get => cSVData; set => cSVData = value; }
        public static string HTMLData { get => hTMLData; set => hTMLData = value; }

        public MainForm()
        {
            InitializeComponent();
            LoadFonts();
        }
        private void LoadFonts()
        {
            Font HSESansRegular13 = new Font(FontsLoader.Pfc.Families[0], 13, FontStyle.Regular);
            label_ToWhom.Font = HSESansRegular13;
            label_Topic.Font = HSESansRegular13;
            button_Send.Font = HSESansRegular13;
            textBox_Topic.Font = HSESansRegular13;
            textBox_Recipient.Font = HSESansRegular13;
            comboBox_Files.Font = HSESansRegular13;
            comboBox_Recipients.Font = HSESansRegular13;
        }
        private void LabelStatusShowAndHide(short status)
        {
            switch (status)
            {
                case 1: // noRecipients
                    label_Status.Text = "Укажите получателей";
                    break;
                case 2: // wrongAddress
                    label_Status.Text = "Неправильные адреса";
                    break;
                case 3: // filesOpened
                    label_Status.Text = "Закройте файлы перед отправкой";
                    break;
                case 4: // sendingCancelled
                    label_Status.Text = "Отправка отменена";
                    break;
                case 5: // filesNotFound
                    label_Status.Text = "Файлы перемещены или удалены.";
                    break;
                case 0: // success
                    label_Status.Text = "Отправлено!";
                    label_Status.ForeColor = Color.Green;
                    break;
            }
            label_Status.Visible = true;
            timer_LabelShow.Enabled = false;
            timer_LabelShow.Enabled = true;
        }
        private void timer_LabelShow_Tick(object sender, EventArgs e)
        {
            label_Status.Visible = false;
            label_Status.ForeColor = Color.Red;
        }

        private void textBox_Recipient_TextChanged(object sender, EventArgs e)
        {
            string s;
            s = textBox_Recipient.Text;
            if (!Equals(s, "") && Equals(s.Substring(s.Length - 1)[0], ' '))
            {
                comboBox_Recipients.Items.Add(s.Trim());
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
            status = 4;
            if (comboBox_Recipients.Items.Count == 0)
            {
                status = 1;
            }
            else if (mode != 2 || ShouldContinueWithDynamicMode())
            {
                status = SMTPBrains.Send(textBox_MessageText.Text, comboBox_Recipients.Items, textBox_Topic.Text, comboBox_Files.Items, mode);
            }
            LabelStatusShowAndHide(status);
        }

        private bool ShouldContinueWithDynamicMode()
        {
            int recipientsInCSVCount = SMTPBrains.FormData(CSVData).Count;
            int recipientsInComboBoxCount = comboBox_Recipients.Items.Count;

            if (recipientsInCSVCount == recipientsInComboBoxCount) { return true; }

            string warning = recipientsInCSVCount > recipientsInComboBoxCount
                ? "Количество указанных Вами получателей меньше количества полей данных в CSV-файле.\nЧасть данных при отправке писем использоваться не будет.\nПродолжить отправку?"
                : "Количество указанных Вами получателей больше количества полей данных в CSV-файле.\nПисьма дойдут не всем получателям.\nПродолжить отправку?";

            return MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void button_AttachFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                comboBox_Files_Fill(openFileDialog.FileNames);
        }

        private void button_RecipientsFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                RecipientsForm(openFileDialog.FileName);
        }

        private void RecipientsForm(string path)
        {
            string[] fields;

            using (var reader = new StreamReader(path))
            {
                fields = reader.ReadLine().Split('\t');
            }

            comboBox_Recipients.Items.Clear();
            foreach (var address in fields)
            {
                comboBox_Recipients.Items.Add(address);
            }
            button_RecipientsClear.Enabled = true;
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
                isHTML = true;
                ModeUpdater();
                textBox_MessageText.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void ModeUpdater()
        {
            if (isHTML && isCSV)
            {
                Text = "MassMailer: Dynamic HTML Mode";
                mode = 2; // Dynamic
            }
            else if (isHTML)
            {
                Text = "MassMailer: Static HTML Mode";
                mode = 1; // Static
            }
            else if (isCSV)
            {
                Text = "MassMailer: Plain Text Mode (CSV file selected)";
                mode = 0; // Plain
            }
            else
            {
                Text = "MassMailer: Plain Text Mode";
                mode = 0;
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
            HTMLViewForm form = new HTMLViewForm(comboBox_Recipients.Items, mode == 2);
            form.ShowDialog();
        }

        private void button_CSVView_Click(object sender, EventArgs e)
        {
            new CSVViewForm().ShowDialog();
        }

        private void textBox_MessageText_TextChanged(object sender, EventArgs e)
        {
            if (isHTML)
                HTMLData = textBox_MessageText.Text;
        }

        private void textBox_MessageText_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                textBox_MessageText.Text = File.ReadAllText(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
                if (((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".html"))
                {
                    isHTML = true;
                    ModeUpdater();
                    HTMLData = textBox_MessageText.Text;
                }
                else
                {
                    isHTML = false;
                    ModeUpdater();
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                textBox_MessageText.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                isHTML = false;
                ModeUpdater();
            }

        }
        private void textBox_MessageText_DragEnter(object sender, DragEventArgs e)
        {
            bool isStringFormat = e.Data.GetDataPresent(DataFormats.StringFormat);
            bool isFileDropWithHTMLorTXT = e.Data.GetDataPresent(DataFormats.FileDrop) &&
                                           (((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".html") ||
                                            ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".txt"));
            if (isStringFormat || isFileDropWithHTMLorTXT)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void comboBox_Files_Fill(string[] filePaths)
        {
            foreach (var file in filePaths)
            {
                comboBox_Files.Items.Add(file);
            }
            button_AttachmentsClear.Enabled = true;
        }

        private void comboBoxAndButton_Files_DragDrop(object sender, DragEventArgs e)
        {
            comboBox_Files_Fill((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void comboBoxAndButton_Files_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void button_HTMLFile_DragDrop(object sender, DragEventArgs e)
        {
            isHTML = true;
            ModeUpdater();
            textBox_MessageText.Text = File.ReadAllText(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        private void button_HTMLFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".html"))
                e.Effect = DragDropEffects.Copy;
        }

        private void button_CSVFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".csv"))
            {
                CSVData = File.ReadAllText(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
                isCSV = true;
                ModeUpdater();
            }
        }

        private void button_CSVFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".csv"))
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox_Topic_DragDrop(object sender, DragEventArgs e)
        {
            textBox_Topic.Text = (string)e.Data.GetData(DataFormats.StringFormat);
        }

        private void textBox_Topic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
        }
        
        private void recipients_DragEnter(object sender, DragEventArgs e)
        {
            bool isStringFormat = e.Data.GetDataPresent(DataFormats.StringFormat);
            bool isFileDropWithCSV = e.Data.GetDataPresent(DataFormats.FileDrop) &&
                                           ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".csv");
            if (isStringFormat || isFileDropWithCSV)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void recipients_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                RecipientsForm(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            else if (e.Data.GetDataPresent(DataFormats.StringFormat))
                comboBox_Recipients.Items.Add((string)e.Data.GetData(DataFormats.StringFormat));
        }

        private void textBox_Recipient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                comboBox_Recipients.Items.Add(textBox_Recipient.Text.Trim());
                textBox_Recipient.Text = "";
            }
        }
    }
}
