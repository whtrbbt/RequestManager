namespace RequestManager
{
    partial class GetFinishedRequestsForm
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
            this.GetFinishedRequestsButton = new System.Windows.Forms.Button();
            this.SelectRequestsUserComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.51613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.48387F));
            this.tableLayoutPanel1.Controls.Add(this.GetFinishedRequestsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectRequestsUserComboBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GetFinishedRequestsButton
            // 
            this.GetFinishedRequestsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetFinishedRequestsButton.Location = new System.Drawing.Point(217, 15);
            this.GetFinishedRequestsButton.Name = "GetFinishedRequestsButton";
            this.GetFinishedRequestsButton.Size = new System.Drawing.Size(75, 23);
            this.GetFinishedRequestsButton.TabIndex = 0;
            this.GetFinishedRequestsButton.Text = "Выгрузить";
            this.GetFinishedRequestsButton.UseVisualStyleBackColor = true;
            // 
            // SelectRequestsUserComboBox
            // 
            this.SelectRequestsUserComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectRequestsUserComboBox.FormattingEnabled = true;
            this.SelectRequestsUserComboBox.Location = new System.Drawing.Point(13, 16);
            this.SelectRequestsUserComboBox.Name = "SelectRequestsUserComboBox";
            this.SelectRequestsUserComboBox.Size = new System.Drawing.Size(173, 21);
            this.SelectRequestsUserComboBox.TabIndex = 1;
            this.SelectRequestsUserComboBox.Text = "Пользователь";
            this.SelectRequestsUserComboBox.Enter += new System.EventHandler(this.SelectRequestsUserComboBox_Enter);
            // 
            // GetFinishedRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 53);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetFinishedRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выгрузка готовых запросов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GetFinishedRequestsButton;
        private System.Windows.Forms.ComboBox SelectRequestsUserComboBox;
    }
}