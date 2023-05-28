namespace MassMailer
{
    partial class HTMLViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTMLViewForm));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.comboBox_Templates = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.tLP_Main.SuspendLayout();
            this.tLP_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = false;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(8, 8);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(735, 410);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // tLP_Main
            // 
            this.tLP_Main.ColumnCount = 1;
            this.tLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Main.Controls.Add(this.webView21, 0, 0);
            this.tLP_Main.Controls.Add(this.tLP_Bottom, 0, 1);
            this.tLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tLP_Main.Name = "tLP_Main";
            this.tLP_Main.Padding = new System.Windows.Forms.Padding(5);
            this.tLP_Main.RowCount = 2;
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tLP_Main.Size = new System.Drawing.Size(751, 467);
            this.tLP_Main.TabIndex = 1;
            // 
            // tLP_Bottom
            // 
            this.tLP_Bottom.ColumnCount = 5;
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tLP_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Bottom.Controls.Add(this.button_Left, 0, 0);
            this.tLP_Bottom.Controls.Add(this.button_Right, 2, 0);
            this.tLP_Bottom.Controls.Add(this.comboBox_Templates, 4, 0);
            this.tLP_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Bottom.Location = new System.Drawing.Point(5, 421);
            this.tLP_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Bottom.Name = "tLP_Bottom";
            this.tLP_Bottom.RowCount = 1;
            this.tLP_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Bottom.Size = new System.Drawing.Size(741, 41);
            this.tLP_Bottom.TabIndex = 1;
            // 
            // button_Left
            // 
            this.button_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Left.Enabled = false;
            this.button_Left.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Left.Image = ((System.Drawing.Image)(resources.GetObject("button_Left.Image")));
            this.button_Left.Location = new System.Drawing.Point(2, 2);
            this.button_Left.Margin = new System.Windows.Forms.Padding(2);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(36, 37);
            this.button_Left.TabIndex = 8;
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Right
            // 
            this.button_Right.Enabled = false;
            this.button_Right.Image = ((System.Drawing.Image)(resources.GetObject("button_Right.Image")));
            this.button_Right.Location = new System.Drawing.Point(52, 2);
            this.button_Right.Margin = new System.Windows.Forms.Padding(2);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(36, 37);
            this.button_Right.TabIndex = 9;
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // comboBox_Templates
            // 
            this.comboBox_Templates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Templates.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.comboBox_Templates.FormattingEnabled = true;
            this.comboBox_Templates.Items.AddRange(new object[] {
            "Шаблон"});
            this.comboBox_Templates.Location = new System.Drawing.Point(125, 2);
            this.comboBox_Templates.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Templates.Name = "comboBox_Templates";
            this.comboBox_Templates.Size = new System.Drawing.Size(614, 38);
            this.comboBox_Templates.TabIndex = 10;
            this.comboBox_Templates.Text = "Шаблон";
            this.comboBox_Templates.SelectedIndexChanged += new System.EventHandler(this.comboBox_Templates_SelectedIndexChanged);
            // 
            // HTMLViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.tLP_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(355, 301);
            this.Name = "HTMLViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HTML Viewer";
            this.Load += new System.EventHandler(this.HTMLViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.tLP_Main.ResumeLayout(false);
            this.tLP_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TableLayoutPanel tLP_Main;
        private System.Windows.Forms.TableLayoutPanel tLP_Bottom;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.ComboBox comboBox_Templates;
    }
}