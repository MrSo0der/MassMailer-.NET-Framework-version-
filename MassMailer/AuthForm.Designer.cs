using System.Drawing;
using System.Windows.Forms;


namespace MassMailer
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.tLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label_MassMailer = new System.Windows.Forms.Label();
            this.panel_LoginPassword = new System.Windows.Forms.Panel();
            this.checkBox_Remember = new System.Windows.Forms.CheckBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.tLP_LoginButton = new System.Windows.Forms.TableLayoutPanel();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Errors = new System.Windows.Forms.Label();
            this.tLP_Main.SuspendLayout();
            this.panel_LoginPassword.SuspendLayout();
            this.tLP_LoginButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Main
            // 
            this.tLP_Main.ColumnCount = 3;
            this.tLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLP_Main.Controls.Add(this.label_MassMailer, 1, 0);
            this.tLP_Main.Controls.Add(this.panel_LoginPassword, 1, 1);
            this.tLP_Main.Controls.Add(this.label_Errors, 1, 2);
            this.tLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tLP_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLP_Main.Name = "tLP_Main";
            this.tLP_Main.RowCount = 3;
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.20513F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.51282F));
            this.tLP_Main.Size = new System.Drawing.Size(480, 582);
            this.tLP_Main.TabIndex = 0;
            // 
            // label_MassMailer
            // 
            this.label_MassMailer.AutoSize = true;
            this.label_MassMailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MassMailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.17391F, System.Drawing.FontStyle.Bold);
            this.label_MassMailer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.label_MassMailer.Location = new System.Drawing.Point(99, 0);
            this.label_MassMailer.Name = "label_MassMailer";
            this.label_MassMailer.Size = new System.Drawing.Size(282, 164);
            this.label_MassMailer.TabIndex = 0;
            this.label_MassMailer.Text = "MassMailer";
            this.label_MassMailer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_LoginPassword
            // 
            this.panel_LoginPassword.Controls.Add(this.checkBox_Remember);
            this.panel_LoginPassword.Controls.Add(this.textBox_Password);
            this.panel_LoginPassword.Controls.Add(this.tLP_LoginButton);
            this.panel_LoginPassword.Controls.Add(this.label_Password);
            this.panel_LoginPassword.Controls.Add(this.textBox_Login);
            this.panel_LoginPassword.Controls.Add(this.label_Login);
            this.panel_LoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LoginPassword.Location = new System.Drawing.Point(99, 166);
            this.panel_LoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_LoginPassword.Name = "panel_LoginPassword";
            this.panel_LoginPassword.Size = new System.Drawing.Size(282, 294);
            this.panel_LoginPassword.TabIndex = 11;
            // 
            // checkBox_Remember
            // 
            this.checkBox_Remember.AutoSize = true;
            this.checkBox_Remember.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26956F);
            this.checkBox_Remember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkBox_Remember.Location = new System.Drawing.Point(0, 104);
            this.checkBox_Remember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Remember.Name = "checkBox_Remember";
            this.checkBox_Remember.Size = new System.Drawing.Size(282, 28);
            this.checkBox_Remember.TabIndex = 9;
            this.checkBox_Remember.Text = "Запомнить";
            this.checkBox_Remember.UseVisualStyleBackColor = true;
            this.checkBox_Remember.CheckedChanged += new System.EventHandler(this.checkBox_Remember_CheckedChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F);
            this.textBox_Password.Location = new System.Drawing.Point(0, 72);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '•';
            this.textBox_Password.Size = new System.Drawing.Size(282, 32);
            this.textBox_Password.TabIndex = 8;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
            // 
            // tLP_LoginButton
            // 
            this.tLP_LoginButton.ColumnCount = 3;
            this.tLP_LoginButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_LoginButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tLP_LoginButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLP_LoginButton.Controls.Add(this.button_Login, 1, 0);
            this.tLP_LoginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLP_LoginButton.Location = new System.Drawing.Point(0, 193);
            this.tLP_LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLP_LoginButton.Name = "tLP_LoginButton";
            this.tLP_LoginButton.RowCount = 1;
            this.tLP_LoginButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_LoginButton.Size = new System.Drawing.Size(282, 101);
            this.tLP_LoginButton.TabIndex = 12;
            // 
            // button_Login
            // 
            this.button_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F);
            this.button_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.button_Login.Location = new System.Drawing.Point(31, 19);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(219, 80);
            this.button_Login.TabIndex = 10;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold);
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.label_Password.Location = new System.Drawing.Point(0, 50);
            this.label_Password.Name = "label_Password";
            this.label_Password.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_Password.Size = new System.Drawing.Size(67, 22);
            this.label_Password.TabIndex = 7;
            this.label_Password.Text = "Пароль";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F);
            this.textBox_Login.Location = new System.Drawing.Point(0, 18);
            this.textBox_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Login.Multiline = true;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(282, 32);
            this.textBox_Login.TabIndex = 6;
            this.textBox_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Login_KeyDown);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold);
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.label_Login.Location = new System.Drawing.Point(0, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(55, 18);
            this.label_Login.TabIndex = 5;
            this.label_Login.Text = "Логин";
            // 
            // label_Errors
            // 
            this.label_Errors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26956F);
            this.label_Errors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_Errors.Location = new System.Drawing.Point(99, 462);
            this.label_Errors.Name = "label_Errors";
            this.label_Errors.Size = new System.Drawing.Size(282, 120);
            this.label_Errors.TabIndex = 12;
            this.label_Errors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Errors.Visible = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(119F, 119F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(480, 582);
            this.Controls.Add(this.tLP_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(496, 617);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MassMailer";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.tLP_Main.ResumeLayout(false);
            this.tLP_Main.PerformLayout();
            this.panel_LoginPassword.ResumeLayout(false);
            this.panel_LoginPassword.PerformLayout();
            this.tLP_LoginButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tLP_Main;
        private Label label_MassMailer;
        private Label label_Login;
        private TextBox textBox_Login;
        private Label label_Password;
        private TextBox textBox_Password;
        private CheckBox checkBox_Remember;
        private Button button_Login;
        private Panel panel_LoginPassword;
        private TableLayoutPanel tLP_LoginButton;
        private Label label_Errors;
    }
}