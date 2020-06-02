namespace RequestManager
{
    partial class ImapSettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iMAPServerAddresTextBox = new System.Windows.Forms.TextBox();
            this.iMAPServerLoginTextBox = new System.Windows.Forms.TextBox();
            this.iMAPServerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.iMAPWorkFolderTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.iMAPServerAddresTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iMAPServerLoginTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iMAPServerPasswordTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.iMAPWorkFolderTextBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.OkButton, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес IMAP-сервера:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рабочая папка:";
            // 
            // iMAPServerAddresTextBox
            // 
            this.iMAPServerAddresTextBox.Location = new System.Drawing.Point(3, 23);
            this.iMAPServerAddresTextBox.Name = "iMAPServerAddresTextBox";
            this.iMAPServerAddresTextBox.Size = new System.Drawing.Size(233, 20);
            this.iMAPServerAddresTextBox.TabIndex = 4;
            // 
            // iMAPServerLoginTextBox
            // 
            this.iMAPServerLoginTextBox.Location = new System.Drawing.Point(3, 63);
            this.iMAPServerLoginTextBox.Name = "iMAPServerLoginTextBox";
            this.iMAPServerLoginTextBox.Size = new System.Drawing.Size(233, 20);
            this.iMAPServerLoginTextBox.TabIndex = 5;
            // 
            // iMAPServerPasswordTextBox
            // 
            this.iMAPServerPasswordTextBox.Location = new System.Drawing.Point(3, 103);
            this.iMAPServerPasswordTextBox.Name = "iMAPServerPasswordTextBox";
            this.iMAPServerPasswordTextBox.Size = new System.Drawing.Size(233, 20);
            this.iMAPServerPasswordTextBox.TabIndex = 6;
            this.iMAPServerPasswordTextBox.UseSystemPasswordChar = true;
            this.iMAPServerPasswordTextBox.WordWrap = false;
            // 
            // iMAPWorkFolderTextBox
            // 
            this.iMAPWorkFolderTextBox.Location = new System.Drawing.Point(3, 149);
            this.iMAPWorkFolderTextBox.Name = "iMAPWorkFolderTextBox";
            this.iMAPWorkFolderTextBox.Size = new System.Drawing.Size(233, 20);
            this.iMAPWorkFolderTextBox.TabIndex = 7;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.Location = new System.Drawing.Point(62, 198);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(115, 27);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ImapSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 250);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImapSettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки IMAP-сервера";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iMAPServerAddresTextBox;
        private System.Windows.Forms.TextBox iMAPServerLoginTextBox;
        private System.Windows.Forms.TextBox iMAPServerPasswordTextBox;
        private System.Windows.Forms.TextBox iMAPWorkFolderTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}