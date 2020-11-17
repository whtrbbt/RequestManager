namespace RequestManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inDirTextBox = new System.Windows.Forms.TextBox();
            this.outDirTextBox = new System.Windows.Forms.TextBox();
            this.outDirSelectButton = new System.Windows.Forms.Button();
            this.inDirSelectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenNewRequestsFormButton = new System.Windows.Forms.Button();
            this.LoadRequestsButton = new System.Windows.Forms.Button();
            this.GetFinishedRequestsButton = new System.Windows.Forms.Button();
            this.RunBatchModeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMAPServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DBServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutDirCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.95183F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.04817F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inDirTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outDirTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outDirSelectButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.inDirSelectButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.clearOutDirCheckBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Папка с файлами заявок для проверки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Папка с проверенными файлами заявок";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inDirTextBox
            // 
            this.inDirTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inDirTextBox.Location = new System.Drawing.Point(3, 28);
            this.inDirTextBox.Name = "inDirTextBox";
            this.inDirTextBox.ReadOnly = true;
            this.inDirTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inDirTextBox.Size = new System.Drawing.Size(382, 20);
            this.inDirTextBox.TabIndex = 2;
            // 
            // outDirTextBox
            // 
            this.outDirTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outDirTextBox.Location = new System.Drawing.Point(3, 99);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.ReadOnly = true;
            this.outDirTextBox.Size = new System.Drawing.Size(382, 20);
            this.outDirTextBox.TabIndex = 3;
            // 
            // outDirSelectButton
            // 
            this.outDirSelectButton.Location = new System.Drawing.Point(391, 99);
            this.outDirSelectButton.Name = "outDirSelectButton";
            this.outDirSelectButton.Size = new System.Drawing.Size(125, 21);
            this.outDirSelectButton.TabIndex = 5;
            this.outDirSelectButton.Text = "Выбрать";
            this.outDirSelectButton.UseVisualStyleBackColor = true;
            this.outDirSelectButton.Click += new System.EventHandler(this.outDirSelectButton_Click);
            // 
            // inDirSelectButton
            // 
            this.inDirSelectButton.Location = new System.Drawing.Point(391, 28);
            this.inDirSelectButton.Name = "inDirSelectButton";
            this.inDirSelectButton.Size = new System.Drawing.Size(125, 23);
            this.inDirSelectButton.TabIndex = 4;
            this.inDirSelectButton.Text = "Выбрать";
            this.inDirSelectButton.UseVisualStyleBackColor = true;
            this.inDirSelectButton.Click += new System.EventHandler(this.inDirSelectButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.6911F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.3089F));
            this.tableLayoutPanel2.Controls.Add(this.OpenNewRequestsFormButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LoadRequestsButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.GetFinishedRequestsButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.RunBatchModeButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 126);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 86);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // OpenNewRequestsFormButton
            // 
            this.OpenNewRequestsFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenNewRequestsFormButton.Location = new System.Drawing.Point(3, 3);
            this.OpenNewRequestsFormButton.Name = "OpenNewRequestsFormButton";
            this.OpenNewRequestsFormButton.Size = new System.Drawing.Size(180, 38);
            this.OpenNewRequestsFormButton.TabIndex = 0;
            this.OpenNewRequestsFormButton.Text = "Получить данные о готовых заявках";
            this.OpenNewRequestsFormButton.UseVisualStyleBackColor = true;
            this.OpenNewRequestsFormButton.Click += new System.EventHandler(this.OpenNewRequestsFormButton_Click);
            // 
            // LoadRequestsButton
            // 
            this.LoadRequestsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadRequestsButton.Location = new System.Drawing.Point(189, 3);
            this.LoadRequestsButton.Name = "LoadRequestsButton";
            this.LoadRequestsButton.Size = new System.Drawing.Size(190, 38);
            this.LoadRequestsButton.TabIndex = 1;
            this.LoadRequestsButton.Text = "Загрузить запросы в БД";
            this.LoadRequestsButton.UseVisualStyleBackColor = true;
            this.LoadRequestsButton.Click += new System.EventHandler(this.LoadRequestsButton_Click);
            // 
            // GetFinishedRequestsButton
            // 
            this.GetFinishedRequestsButton.Location = new System.Drawing.Point(189, 47);
            this.GetFinishedRequestsButton.Name = "GetFinishedRequestsButton";
            this.GetFinishedRequestsButton.Size = new System.Drawing.Size(190, 36);
            this.GetFinishedRequestsButton.TabIndex = 2;
            this.GetFinishedRequestsButton.Text = "Выгрузить готовые запросы";
            this.GetFinishedRequestsButton.UseVisualStyleBackColor = true;
            this.GetFinishedRequestsButton.Click += new System.EventHandler(this.GetFinishedRequestsButton_Click);
            // 
            // RunBatchModeButton
            // 
            this.RunBatchModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunBatchModeButton.Location = new System.Drawing.Point(3, 47);
            this.RunBatchModeButton.Name = "RunBatchModeButton";
            this.RunBatchModeButton.Size = new System.Drawing.Size(180, 36);
            this.RunBatchModeButton.TabIndex = 3;
            this.RunBatchModeButton.Text = "Пакетная обработка";
            this.RunBatchModeButton.UseVisualStyleBackColor = true;
            this.RunBatchModeButton.Click += new System.EventHandler(this.RunBatchModeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMAPServerSettingsToolStripMenuItem,
            this.DBServerSettingsToolStripMenuItem,
            this.UserManamentToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // iMAPServerSettingsToolStripMenuItem
            // 
            this.iMAPServerSettingsToolStripMenuItem.Name = "iMAPServerSettingsToolStripMenuItem";
            this.iMAPServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.iMAPServerSettingsToolStripMenuItem.Text = "Параметры IMAP-сервера...";
            this.iMAPServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.IMAPServerSettingsToolStripMenuItem_Click);
            // 
            // DBServerSettingsToolStripMenuItem
            // 
            this.DBServerSettingsToolStripMenuItem.Name = "DBServerSettingsToolStripMenuItem";
            this.DBServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.DBServerSettingsToolStripMenuItem.Text = "Параметры сервера базы данных...";
            this.DBServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.DBServerSettingsToolStripMenuItem_Click);
            // 
            // UserManamentToolStripMenuItem
            // 
            this.UserManamentToolStripMenuItem.Name = "UserManamentToolStripMenuItem";
            this.UserManamentToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.UserManamentToolStripMenuItem.Text = "Управление пользователями...";
            this.UserManamentToolStripMenuItem.Click += new System.EventHandler(this.UserManamentToolStripMenuItem_Click);
            // 
            // clearOutDirCheckBox
            // 
            this.clearOutDirCheckBox.AutoSize = true;
            this.clearOutDirCheckBox.Location = new System.Drawing.Point(3, 78);
            this.clearOutDirCheckBox.Name = "clearOutDirCheckBox";
            this.clearOutDirCheckBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.clearOutDirCheckBox.Size = new System.Drawing.Size(110, 15);
            this.clearOutDirCheckBox.TabIndex = 7;
            this.clearOutDirCheckBox.Text = "Очистить папку";
            this.clearOutDirCheckBox.UseVisualStyleBackColor = true;
            this.clearOutDirCheckBox.CheckedChanged += new System.EventHandler(this.clearOutDirCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 239);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер запросов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inDirTextBox;
        private System.Windows.Forms.TextBox outDirTextBox;
        private System.Windows.Forms.Button inDirSelectButton;
        private System.Windows.Forms.Button outDirSelectButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMAPServerSettingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button OpenNewRequestsFormButton;
        private System.Windows.Forms.ToolStripMenuItem DBServerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserManamentToolStripMenuItem;
        private System.Windows.Forms.Button LoadRequestsButton;
        private System.Windows.Forms.Button GetFinishedRequestsButton;
        private System.Windows.Forms.Button RunBatchModeButton;
        private System.Windows.Forms.CheckBox clearOutDirCheckBox;
    }
}

