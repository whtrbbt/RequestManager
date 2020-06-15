namespace RequestManager
{
    partial class LoadRequestsToDB
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
            this.RequestFileLoadButton = new System.Windows.Forms.Button();
            this.LoadUserRequestsToDBButton = new System.Windows.Forms.Button();
            this.RequestFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RequestsUserSelectComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.36232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.63768F));
            this.tableLayoutPanel1.Controls.Add(this.RequestFileLoadButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RequestFilePathTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoadUserRequestsToDBButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RequestsUserSelectComboBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RequestFileLoadButton
            // 
            this.RequestFileLoadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RequestFileLoadButton.Location = new System.Drawing.Point(325, 25);
            this.RequestFileLoadButton.Name = "RequestFileLoadButton";
            this.RequestFileLoadButton.Size = new System.Drawing.Size(75, 23);
            this.RequestFileLoadButton.TabIndex = 0;
            this.RequestFileLoadButton.Text = "Выбрать";
            this.RequestFileLoadButton.UseVisualStyleBackColor = true;
            this.RequestFileLoadButton.Click += new System.EventHandler(this.RequestFileLoadButton_Click);
            // 
            // LoadUserRequestsToDBButton
            // 
            this.LoadUserRequestsToDBButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadUserRequestsToDBButton.Location = new System.Drawing.Point(325, 78);
            this.LoadUserRequestsToDBButton.Name = "LoadUserRequestsToDBButton";
            this.LoadUserRequestsToDBButton.Size = new System.Drawing.Size(75, 23);
            this.LoadUserRequestsToDBButton.TabIndex = 1;
            this.LoadUserRequestsToDBButton.Text = "Загрузить";
            this.LoadUserRequestsToDBButton.UseVisualStyleBackColor = true;
            this.LoadUserRequestsToDBButton.Click += new System.EventHandler(this.LoadUserRequestsToDBButton_Click);
            // 
            // RequestFilePathTextBox
            // 
            this.RequestFilePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequestFilePathTextBox.Location = new System.Drawing.Point(3, 27);
            this.RequestFilePathTextBox.Name = "RequestFilePathTextBox";
            this.RequestFilePathTextBox.ReadOnly = true;
            this.RequestFilePathTextBox.Size = new System.Drawing.Size(305, 20);
            this.RequestFilePathTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Файл со списком запросов:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пользователь:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RequestsUserSelectComboBox
            // 
            this.RequestsUserSelectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestsUserSelectComboBox.FormattingEnabled = true;
            this.RequestsUserSelectComboBox.Location = new System.Drawing.Point(3, 79);
            this.RequestsUserSelectComboBox.Name = "RequestsUserSelectComboBox";
            this.RequestsUserSelectComboBox.Size = new System.Drawing.Size(306, 21);
            this.RequestsUserSelectComboBox.TabIndex = 5;
            // 
            // LoadRequestsToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadRequestsToDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка запросов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LoadUserRequestsToDBButton;
        private System.Windows.Forms.TextBox RequestFilePathTextBox;
        private System.Windows.Forms.Button RequestFileLoadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RequestsUserSelectComboBox;
    }
}