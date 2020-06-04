namespace RequestManager
{
    partial class NewRequestsForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewRequestsCountLabel = new System.Windows.Forms.Label();
            this.IMAPFolderStatusLabel = new System.Windows.Forms.Label();
            this.IMAPServerAuthStatusLabel = new System.Windows.Forms.Label();
            this.iMAPServerStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadRequestsDataButton = new System.Windows.Forms.Button();
            this.СancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadRequestsProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iMAPServerStatusLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.IMAPServerAuthStatusLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.IMAPFolderStatusLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.NewRequestsCountLabel, 1, 3);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(272, 102);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус подключения к IMAP-серверу:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Статус авторизации IMAP-сервера:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рабочая папка IMAP-сервера:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во новых завершенных заявок:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewRequestsCountLabel
            // 
            this.NewRequestsCountLabel.AutoSize = true;
            this.NewRequestsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewRequestsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewRequestsCountLabel.Location = new System.Drawing.Point(207, 60);
            this.NewRequestsCountLabel.Name = "NewRequestsCountLabel";
            this.NewRequestsCountLabel.Size = new System.Drawing.Size(62, 20);
            this.NewRequestsCountLabel.TabIndex = 7;
            this.NewRequestsCountLabel.Text = "label5";
            this.NewRequestsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMAPFolderStatusLabel
            // 
            this.IMAPFolderStatusLabel.AutoSize = true;
            this.IMAPFolderStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMAPFolderStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMAPFolderStatusLabel.Location = new System.Drawing.Point(207, 40);
            this.IMAPFolderStatusLabel.Name = "IMAPFolderStatusLabel";
            this.IMAPFolderStatusLabel.Size = new System.Drawing.Size(62, 20);
            this.IMAPFolderStatusLabel.TabIndex = 5;
            this.IMAPFolderStatusLabel.Text = "label4";
            this.IMAPFolderStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMAPServerAuthStatusLabel
            // 
            this.IMAPServerAuthStatusLabel.AutoSize = true;
            this.IMAPServerAuthStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMAPServerAuthStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMAPServerAuthStatusLabel.Location = new System.Drawing.Point(207, 20);
            this.IMAPServerAuthStatusLabel.Name = "IMAPServerAuthStatusLabel";
            this.IMAPServerAuthStatusLabel.Size = new System.Drawing.Size(62, 20);
            this.IMAPServerAuthStatusLabel.TabIndex = 3;
            this.IMAPServerAuthStatusLabel.Text = "label3";
            this.IMAPServerAuthStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iMAPServerStatusLabel
            // 
            this.iMAPServerStatusLabel.AutoSize = true;
            this.iMAPServerStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMAPServerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iMAPServerStatusLabel.Location = new System.Drawing.Point(207, 0);
            this.iMAPServerStatusLabel.Name = "iMAPServerStatusLabel";
            this.iMAPServerStatusLabel.Size = new System.Drawing.Size(62, 20);
            this.iMAPServerStatusLabel.TabIndex = 1;
            this.iMAPServerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DownloadRequestsDataButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.СancelButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.61468F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // DownloadRequestsDataButton
            // 
            this.DownloadRequestsDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownloadRequestsDataButton.Enabled = false;
            this.DownloadRequestsDataButton.Location = new System.Drawing.Point(32, 3);
            this.DownloadRequestsDataButton.Name = "DownloadRequestsDataButton";
            this.DownloadRequestsDataButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadRequestsDataButton.TabIndex = 0;
            this.DownloadRequestsDataButton.Text = "Получить";
            this.DownloadRequestsDataButton.UseVisualStyleBackColor = true;
            this.DownloadRequestsDataButton.Click += new System.EventHandler(this.DownloadRequestsDataButton_Click);
            // 
            // СancelButton
            // 
            this.СancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.СancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.СancelButton.Location = new System.Drawing.Point(171, 3);
            this.СancelButton.Name = "СancelButton";
            this.СancelButton.Size = new System.Drawing.Size(75, 23);
            this.СancelButton.TabIndex = 1;
            this.СancelButton.Text = "Отмена";
            this.СancelButton.UseVisualStyleBackColor = true;
            this.СancelButton.Click += new System.EventHandler(this.СancelButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.DownloadRequestsProgressBar, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(272, 22);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // DownloadRequestsProgressBar
            // 
            this.DownloadRequestsProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadRequestsProgressBar.Location = new System.Drawing.Point(3, 3);
            this.DownloadRequestsProgressBar.Name = "DownloadRequestsProgressBar";
            this.DownloadRequestsProgressBar.Size = new System.Drawing.Size(266, 16);
            this.DownloadRequestsProgressBar.TabIndex = 0;
            // 
            // NewRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.СancelButton;
            this.ClientSize = new System.Drawing.Size(278, 159);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Готовые заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewRequestsForm_FormClosed);
            this.Load += new System.EventHandler(this.NewRequestsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label iMAPServerStatusLabel;
        private System.Windows.Forms.Label IMAPServerAuthStatusLabel;
        private System.Windows.Forms.Label IMAPFolderStatusLabel;
        private System.Windows.Forms.Label NewRequestsCountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button DownloadRequestsDataButton;
        private System.Windows.Forms.Button СancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ProgressBar DownloadRequestsProgressBar;
    }
}