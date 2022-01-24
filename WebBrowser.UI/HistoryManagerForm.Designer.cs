namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.historyManagerBox = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyManagerBox
            // 
            this.historyManagerBox.FormattingEnabled = true;
            this.historyManagerBox.ItemHeight = 20;
            this.historyManagerBox.Location = new System.Drawing.Point(0, 0);
            this.historyManagerBox.Name = "historyManagerBox";
            this.historyManagerBox.Size = new System.Drawing.Size(426, 664);
            this.historyManagerBox.TabIndex = 0;
            this.historyManagerBox.SelectedIndexChanged += new System.EventHandler(this.historyManagerBox_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(0, 681);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(298, 26);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(304, 672);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 45);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteHistory
            // 
            this.deleteHistory.Location = new System.Drawing.Point(0, 723);
            this.deleteHistory.Name = "deleteHistory";
            this.deleteHistory.Size = new System.Drawing.Size(417, 68);
            this.deleteHistory.TabIndex = 4;
            this.deleteHistory.Text = "DELETE HISTORY";
            this.deleteHistory.UseVisualStyleBackColor = true;
            this.deleteHistory.Click += new System.EventHandler(this.deleteHistory_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 803);
            this.Controls.Add(this.deleteHistory);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.historyManagerBox);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyManagerBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteHistory;
    }
}