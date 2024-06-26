﻿using System.Drawing;
using System.Windows.Forms;

namespace MassMailer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_AttachFiles = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.comboBox_Files = new System.Windows.Forms.ComboBox();
            this.button_AttachmentsClear = new System.Windows.Forms.Button();
            this.tLP_Top = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Topic = new System.Windows.Forms.TextBox();
            this.label_Topic = new System.Windows.Forms.Label();
            this.tableLP_TopRight = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Recipients = new System.Windows.Forms.ComboBox();
            this.button_RecipientsClear = new System.Windows.Forms.Button();
            this.button_RecipientsFile = new System.Windows.Forms.Button();
            this.textBox_Recipient = new System.Windows.Forms.TextBox();
            this.textBox_FromWho = new System.Windows.Forms.TextBox();
            this.label_ToWhom = new System.Windows.Forms.Label();
            this.label_FromWho = new System.Windows.Forms.Label();
            this.tLP_html = new System.Windows.Forms.TableLayoutPanel();
            this.button_HTMLFile = new System.Windows.Forms.Button();
            this.button_HTMLClear = new System.Windows.Forms.Button();
            this.button_CSVFile = new System.Windows.Forms.Button();
            this.button_HTMLView = new System.Windows.Forms.Button();
            this.button_CSVView = new System.Windows.Forms.Button();
            this.button_CSVClear = new System.Windows.Forms.Button();
            this.textBox_MessageText = new System.Windows.Forms.TextBox();
            this.timer_LabelShow = new System.Windows.Forms.Timer(this.components);
            this.tLP_Main.SuspendLayout();
            this.tLP_Bottom.SuspendLayout();
            this.tLP_Top.SuspendLayout();
            this.tableLP_TopRight.SuspendLayout();
            this.tLP_html.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Main
            // 
            this.tLP_Main.ColumnCount = 1;
            this.tLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Main.Controls.Add(this.tLP_Bottom, 0, 3);
            this.tLP_Main.Controls.Add(this.tLP_Top, 0, 0);
            this.tLP_Main.Controls.Add(this.tLP_html, 0, 1);
            this.tLP_Main.Controls.Add(this.textBox_MessageText, 0, 2);
            this.tLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tLP_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Main.Name = "tLP_Main";
            this.tLP_Main.Padding = new System.Windows.Forms.Padding(17);
            this.tLP_Main.RowCount = 4;
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Main.Size = new System.Drawing.Size(1020, 700);
            this.tLP_Main.TabIndex = 0;
            // 
            // tLP_Bottom
            // 
            this.tLP_Bottom.ColumnCount = 7;
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tLP_Bottom.Controls.Add(this.button_Send, 0, 0);
            this.tLP_Bottom.Controls.Add(this.button_AttachFiles, 2, 0);
            this.tLP_Bottom.Controls.Add(this.label_Status, 6, 0);
            this.tLP_Bottom.Controls.Add(this.comboBox_Files, 5, 0);
            this.tLP_Bottom.Controls.Add(this.button_AttachmentsClear, 3, 0);
            this.tLP_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Bottom.Location = new System.Drawing.Point(17, 642);
            this.tLP_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Bottom.Name = "tLP_Bottom";
            this.tLP_Bottom.RowCount = 1;
            this.tLP_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Bottom.Size = new System.Drawing.Size(986, 41);
            this.tLP_Bottom.TabIndex = 4;
            // 
            // button_Send
            // 
            this.button_Send.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Send.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.button_Send.Location = new System.Drawing.Point(2, 2);
            this.button_Send.Margin = new System.Windows.Forms.Padding(2);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(144, 37);
            this.button_Send.TabIndex = 12;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_AttachFiles
            // 
            this.button_AttachFiles.AllowDrop = true;
            this.button_AttachFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_AttachFiles.Image = ((System.Drawing.Image)(resources.GetObject("button_AttachFiles.Image")));
            this.button_AttachFiles.Location = new System.Drawing.Point(184, 2);
            this.button_AttachFiles.Margin = new System.Windows.Forms.Padding(2);
            this.button_AttachFiles.Name = "button_AttachFiles";
            this.button_AttachFiles.Size = new System.Drawing.Size(36, 37);
            this.button_AttachFiles.TabIndex = 13;
            this.button_AttachFiles.UseVisualStyleBackColor = true;
            this.button_AttachFiles.Click += new System.EventHandler(this.button_AttachFiles_Click);
            this.button_AttachFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxAndButton_Files_DragDrop);
            this.button_AttachFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxAndButton_Files_DragEnter);
            // 
            // label_Status
            // 
            this.label_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Status.Location = new System.Drawing.Point(588, 2);
            this.label_Status.Margin = new System.Windows.Forms.Padding(2);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(396, 37);
            this.label_Status.TabIndex = 4;
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Status.Visible = false;
            // 
            // comboBox_Files
            // 
            this.comboBox_Files.AllowDrop = true;
            this.comboBox_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Files.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.comboBox_Files.FormattingEnabled = true;
            this.comboBox_Files.Location = new System.Drawing.Point(297, 2);
            this.comboBox_Files.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Files.Name = "comboBox_Files";
            this.comboBox_Files.Size = new System.Drawing.Size(287, 38);
            this.comboBox_Files.TabIndex = 0;
            this.comboBox_Files.TabStop = false;
            this.comboBox_Files.SelectedIndexChanged += new System.EventHandler(this.comboBox_Files_SelectedIndexChanged);
            this.comboBox_Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxAndButton_Files_DragDrop);
            this.comboBox_Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxAndButton_Files_DragEnter);
            // 
            // button_AttachmentsClear
            // 
            this.button_AttachmentsClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_AttachmentsClear.Enabled = false;
            this.button_AttachmentsClear.Image = ((System.Drawing.Image)(resources.GetObject("button_AttachmentsClear.Image")));
            this.button_AttachmentsClear.Location = new System.Drawing.Point(224, 2);
            this.button_AttachmentsClear.Margin = new System.Windows.Forms.Padding(2);
            this.button_AttachmentsClear.Name = "button_AttachmentsClear";
            this.button_AttachmentsClear.Size = new System.Drawing.Size(36, 37);
            this.button_AttachmentsClear.TabIndex = 14;
            this.button_AttachmentsClear.UseVisualStyleBackColor = true;
            this.button_AttachmentsClear.Click += new System.EventHandler(this.button_AttachmentsClear_Click);
            // 
            // tLP_Top
            // 
            this.tLP_Top.ColumnCount = 4;
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tLP_Top.Controls.Add(this.textBox_Topic, 3, 1);
            this.tLP_Top.Controls.Add(this.label_Topic, 2, 1);
            this.tLP_Top.Controls.Add(this.tableLP_TopRight, 3, 0);
            this.tLP_Top.Controls.Add(this.textBox_Recipient, 0, 0);
            this.tLP_Top.Controls.Add(this.textBox_FromWho, 1, 1);
            this.tLP_Top.Controls.Add(this.label_ToWhom, 0, 0);
            this.tLP_Top.Controls.Add(this.label_FromWho, 0, 1);
            this.tLP_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Top.Location = new System.Drawing.Point(17, 17);
            this.tLP_Top.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Top.Name = "tLP_Top";
            this.tLP_Top.RowCount = 2;
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Top.Size = new System.Drawing.Size(986, 82);
            this.tLP_Top.TabIndex = 0;
            // 
            // textBox_Topic
            // 
            this.textBox_Topic.AllowDrop = true;
            this.textBox_Topic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Topic.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox_Topic.Location = new System.Drawing.Point(620, 43);
            this.textBox_Topic.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Topic.Name = "textBox_Topic";
            this.textBox_Topic.Size = new System.Drawing.Size(364, 36);
            this.textBox_Topic.TabIndex = 4;
            this.textBox_Topic.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Topic_DragDrop);
            this.textBox_Topic.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Topic_DragEnter);
            // 
            // label_Topic
            // 
            this.label_Topic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Topic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Topic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.label_Topic.Location = new System.Drawing.Point(550, 41);
            this.label_Topic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Topic.Name = "label_Topic";
            this.label_Topic.Size = new System.Drawing.Size(66, 41);
            this.label_Topic.TabIndex = 6;
            this.label_Topic.Text = "Тема:";
            this.label_Topic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLP_TopRight
            // 
            this.tableLP_TopRight.ColumnCount = 4;
            this.tableLP_TopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_TopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLP_TopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLP_TopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLP_TopRight.Controls.Add(this.comboBox_Recipients, 0, 0);
            this.tableLP_TopRight.Controls.Add(this.button_RecipientsClear, 3, 0);
            this.tableLP_TopRight.Controls.Add(this.button_RecipientsFile, 2, 0);
            this.tableLP_TopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_TopRight.Location = new System.Drawing.Point(618, 0);
            this.tableLP_TopRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableLP_TopRight.Name = "tableLP_TopRight";
            this.tableLP_TopRight.RowCount = 1;
            this.tableLP_TopRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_TopRight.Size = new System.Drawing.Size(368, 41);
            this.tableLP_TopRight.TabIndex = 5;
            // 
            // comboBox_Recipients
            // 
            this.comboBox_Recipients.AllowDrop = true;
            this.comboBox_Recipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Recipients.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.comboBox_Recipients.FormattingEnabled = true;
            this.comboBox_Recipients.Location = new System.Drawing.Point(2, 2);
            this.comboBox_Recipients.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Recipients.Name = "comboBox_Recipients";
            this.comboBox_Recipients.Size = new System.Drawing.Size(251, 38);
            this.comboBox_Recipients.TabIndex = 0;
            this.comboBox_Recipients.TabStop = false;
            this.comboBox_Recipients.SelectedIndexChanged += new System.EventHandler(this.comboBox_Recipients_SelectedIndexChanged);
            this.comboBox_Recipients.DragDrop += new System.Windows.Forms.DragEventHandler(this.recipients_DragDrop);
            this.comboBox_Recipients.DragEnter += new System.Windows.Forms.DragEventHandler(this.recipients_DragEnter);
            // 
            // button_RecipientsClear
            // 
            this.button_RecipientsClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_RecipientsClear.Enabled = false;
            this.button_RecipientsClear.Image = ((System.Drawing.Image)(resources.GetObject("button_RecipientsClear.Image")));
            this.button_RecipientsClear.Location = new System.Drawing.Point(330, 2);
            this.button_RecipientsClear.Margin = new System.Windows.Forms.Padding(2);
            this.button_RecipientsClear.Name = "button_RecipientsClear";
            this.button_RecipientsClear.Size = new System.Drawing.Size(36, 37);
            this.button_RecipientsClear.TabIndex = 3;
            this.button_RecipientsClear.UseVisualStyleBackColor = true;
            this.button_RecipientsClear.Click += new System.EventHandler(this.button_RecipientsClear_Click);
            // 
            // button_RecipientsFile
            // 
            this.button_RecipientsFile.AllowDrop = true;
            this.button_RecipientsFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_RecipientsFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_RecipientsFile.Image = ((System.Drawing.Image)(resources.GetObject("button_RecipientsFile.Image")));
            this.button_RecipientsFile.Location = new System.Drawing.Point(290, 2);
            this.button_RecipientsFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RecipientsFile.Name = "button_RecipientsFile";
            this.button_RecipientsFile.Size = new System.Drawing.Size(36, 37);
            this.button_RecipientsFile.TabIndex = 2;
            this.button_RecipientsFile.UseVisualStyleBackColor = true;
            this.button_RecipientsFile.Click += new System.EventHandler(this.button_RecipientsFile_Click);
            this.button_RecipientsFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.recipients_DragDrop);
            this.button_RecipientsFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.recipients_DragEnter);
            // 
            // textBox_Recipient
            // 
            this.textBox_Recipient.AllowDrop = true;
            this.textBox_Recipient.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Recipient.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox_Recipient.Location = new System.Drawing.Point(102, 2);
            this.textBox_Recipient.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Recipient.Multiline = true;
            this.textBox_Recipient.Name = "textBox_Recipient";
            this.textBox_Recipient.Size = new System.Drawing.Size(444, 36);
            this.textBox_Recipient.TabIndex = 1;
            this.textBox_Recipient.TextChanged += new System.EventHandler(this.textBox_Recipient_TextChanged);
            this.textBox_Recipient.DragDrop += new System.Windows.Forms.DragEventHandler(this.recipients_DragDrop);
            this.textBox_Recipient.DragEnter += new System.Windows.Forms.DragEventHandler(this.recipients_DragEnter);
            this.textBox_Recipient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Recipient_KeyDown);
            // 
            // textBox_FromWho
            // 
            this.textBox_FromWho.AllowDrop = true;
            this.textBox_FromWho.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_FromWho.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.textBox_FromWho.Location = new System.Drawing.Point(102, 43);
            this.textBox_FromWho.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FromWho.Name = "textBox_FromWho";
            this.textBox_FromWho.Size = new System.Drawing.Size(444, 36);
            this.textBox_FromWho.TabIndex = 5;
            this.textBox_FromWho.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_FromWho_DragDrop);
            this.textBox_FromWho.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_FromWho_DragEnter);
            // 
            // label_ToWhom
            // 
            this.label_ToWhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ToWhom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_ToWhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.label_ToWhom.Location = new System.Drawing.Point(2, 0);
            this.label_ToWhom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ToWhom.Name = "label_ToWhom";
            this.label_ToWhom.Size = new System.Drawing.Size(96, 41);
            this.label_ToWhom.TabIndex = 0;
            this.label_ToWhom.Text = "Кому:";
            this.label_ToWhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_FromWho
            // 
            this.label_FromWho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FromWho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_FromWho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.label_FromWho.Location = new System.Drawing.Point(2, 41);
            this.label_FromWho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FromWho.Name = "label_FromWho";
            this.label_FromWho.Size = new System.Drawing.Size(96, 41);
            this.label_FromWho.TabIndex = 0;
            this.label_FromWho.Text = "От кого:";
            this.label_FromWho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tLP_html
            // 
            this.tLP_html.ColumnCount = 8;
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_html.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_html.Controls.Add(this.button_HTMLFile, 0, 0);
            this.tLP_html.Controls.Add(this.button_HTMLClear, 2, 0);
            this.tLP_html.Controls.Add(this.button_CSVFile, 4, 0);
            this.tLP_html.Controls.Add(this.button_HTMLView, 1, 0);
            this.tLP_html.Controls.Add(this.button_CSVView, 5, 0);
            this.tLP_html.Controls.Add(this.button_CSVClear, 6, 0);
            this.tLP_html.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_html.Location = new System.Drawing.Point(17, 99);
            this.tLP_html.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_html.Name = "tLP_html";
            this.tLP_html.RowCount = 1;
            this.tLP_html.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_html.Size = new System.Drawing.Size(986, 41);
            this.tLP_html.TabIndex = 2;
            // 
            // button_HTMLFile
            // 
            this.button_HTMLFile.AllowDrop = true;
            this.button_HTMLFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_HTMLFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_HTMLFile.Image = ((System.Drawing.Image)(resources.GetObject("button_HTMLFile.Image")));
            this.button_HTMLFile.Location = new System.Drawing.Point(2, 2);
            this.button_HTMLFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_HTMLFile.Name = "button_HTMLFile";
            this.button_HTMLFile.Size = new System.Drawing.Size(36, 37);
            this.button_HTMLFile.TabIndex = 5;
            this.button_HTMLFile.UseVisualStyleBackColor = true;
            this.button_HTMLFile.Click += new System.EventHandler(this.button_HTMLFile_Click);
            this.button_HTMLFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.button_HTMLFile_DragDrop);
            this.button_HTMLFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.button_HTMLFile_DragEnter);
            // 
            // button_HTMLClear
            // 
            this.button_HTMLClear.Enabled = false;
            this.button_HTMLClear.Image = ((System.Drawing.Image)(resources.GetObject("button_HTMLClear.Image")));
            this.button_HTMLClear.Location = new System.Drawing.Point(82, 2);
            this.button_HTMLClear.Margin = new System.Windows.Forms.Padding(2);
            this.button_HTMLClear.Name = "button_HTMLClear";
            this.button_HTMLClear.Size = new System.Drawing.Size(36, 37);
            this.button_HTMLClear.TabIndex = 7;
            this.button_HTMLClear.UseVisualStyleBackColor = true;
            this.button_HTMLClear.Click += new System.EventHandler(this.button_HTMLClear_Click);
            // 
            // button_CSVFile
            // 
            this.button_CSVFile.AllowDrop = true;
            this.button_CSVFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_CSVFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_CSVFile.Image = ((System.Drawing.Image)(resources.GetObject("button_CSVFile.Image")));
            this.button_CSVFile.Location = new System.Drawing.Point(155, 2);
            this.button_CSVFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_CSVFile.Name = "button_CSVFile";
            this.button_CSVFile.Size = new System.Drawing.Size(36, 37);
            this.button_CSVFile.TabIndex = 8;
            this.button_CSVFile.UseVisualStyleBackColor = true;
            this.button_CSVFile.Click += new System.EventHandler(this.button_CSVFile_Click);
            this.button_CSVFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.button_CSVFile_DragDrop);
            this.button_CSVFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.button_CSVFile_DragEnter);
            // 
            // button_HTMLView
            // 
            this.button_HTMLView.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_HTMLView.Enabled = false;
            this.button_HTMLView.Image = ((System.Drawing.Image)(resources.GetObject("button_HTMLView.Image")));
            this.button_HTMLView.Location = new System.Drawing.Point(42, 2);
            this.button_HTMLView.Margin = new System.Windows.Forms.Padding(2);
            this.button_HTMLView.Name = "button_HTMLView";
            this.button_HTMLView.Size = new System.Drawing.Size(36, 37);
            this.button_HTMLView.TabIndex = 6;
            this.button_HTMLView.UseVisualStyleBackColor = true;
            this.button_HTMLView.Click += new System.EventHandler(this.button_HTMLView_Click);
            // 
            // button_CSVView
            // 
            this.button_CSVView.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_CSVView.Enabled = false;
            this.button_CSVView.Image = ((System.Drawing.Image)(resources.GetObject("button_CSVView.Image")));
            this.button_CSVView.Location = new System.Drawing.Point(195, 2);
            this.button_CSVView.Margin = new System.Windows.Forms.Padding(2);
            this.button_CSVView.Name = "button_CSVView";
            this.button_CSVView.Size = new System.Drawing.Size(36, 37);
            this.button_CSVView.TabIndex = 9;
            this.button_CSVView.UseVisualStyleBackColor = true;
            this.button_CSVView.Click += new System.EventHandler(this.button_CSVView_Click);
            // 
            // button_CSVClear
            // 
            this.button_CSVClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_CSVClear.Enabled = false;
            this.button_CSVClear.Image = ((System.Drawing.Image)(resources.GetObject("button_CSVClear.Image")));
            this.button_CSVClear.Location = new System.Drawing.Point(235, 2);
            this.button_CSVClear.Margin = new System.Windows.Forms.Padding(2);
            this.button_CSVClear.Name = "button_CSVClear";
            this.button_CSVClear.Size = new System.Drawing.Size(36, 37);
            this.button_CSVClear.TabIndex = 10;
            this.button_CSVClear.UseVisualStyleBackColor = true;
            this.button_CSVClear.Click += new System.EventHandler(this.button_CSVClear_Click);
            // 
            // textBox_MessageText
            // 
            this.textBox_MessageText.AllowDrop = true;
            this.textBox_MessageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MessageText.Location = new System.Drawing.Point(20, 143);
            this.textBox_MessageText.Multiline = true;
            this.textBox_MessageText.Name = "textBox_MessageText";
            this.textBox_MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_MessageText.Size = new System.Drawing.Size(980, 496);
            this.textBox_MessageText.TabIndex = 5;
            this.textBox_MessageText.TextChanged += new System.EventHandler(this.textBox_MessageText_TextChanged);
            this.textBox_MessageText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_MessageText_DragDrop);
            this.textBox_MessageText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_MessageText_DragEnter);
            // 
            // timer_LabelShow
            // 
            this.timer_LabelShow.Interval = 3000;
            this.timer_LabelShow.Tick += new System.EventHandler(this.timer_LabelShow_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(119F, 119F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.tLP_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 629);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MassMailer: Plain Text Mode";
            this.tLP_Main.ResumeLayout(false);
            this.tLP_Main.PerformLayout();
            this.tLP_Bottom.ResumeLayout(false);
            this.tLP_Top.ResumeLayout(false);
            this.tLP_Top.PerformLayout();
            this.tableLP_TopRight.ResumeLayout(false);
            this.tLP_html.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tLP_Main;
        private TableLayoutPanel tLP_Bottom;
        private Button button_Send;
        private Button button_AttachFiles;
        private ComboBox comboBox_Files;
        private TableLayoutPanel tLP_Top;
        private TextBox textBox_Recipient;
        private Label label_ToWhom;
        private ComboBox comboBox_Recipients;
        private Button button_RecipientsFile;
        private Label label_Status;
        private TableLayoutPanel tLP_html;
        private Button button_HTMLFile;
        private Button button_CSVFile;
        private Button button_RecipientsClear;
        private Button button_HTMLClear;
        private Button button_HTMLView;
        private Button button_CSVView;
        private Button button_CSVClear;
        private Button button_AttachmentsClear;
        private TextBox textBox_MessageText;
        private Timer timer_LabelShow;
        private Label label_Topic;
        private TextBox textBox_FromWho;
        private Label label_FromWho;
        private TextBox textBox_Topic;
        private TableLayoutPanel tableLP_TopRight;
    }
}