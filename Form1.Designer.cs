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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMAPServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.outDirTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.outDirSelectButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.inDirSelectButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 245);
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
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
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
            this.outDirTextBox.Location = new System.Drawing.Point(3, 87);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.ReadOnly = true;
            this.outDirTextBox.Size = new System.Drawing.Size(382, 20);
            this.outDirTextBox.TabIndex = 3;
            // 
            // outDirSelectButton
            // 
            this.outDirSelectButton.Location = new System.Drawing.Point(391, 87);
            this.outDirSelectButton.Name = "outDirSelectButton";
            this.outDirSelectButton.Size = new System.Drawing.Size(125, 23);
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
            this.iMAPServerSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // iMAPServerSettingsToolStripMenuItem
            // 
            this.iMAPServerSettingsToolStripMenuItem.Name = "iMAPServerSettingsToolStripMenuItem";
            this.iMAPServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.iMAPServerSettingsToolStripMenuItem.Text = "Параметры IMAP-сервера...";
            this.iMAPServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.параметрыIMAPсервераToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 269);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Менеджер запросов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
    }
}

