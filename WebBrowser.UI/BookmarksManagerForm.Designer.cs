
namespace WebBrowser.UI
{
    partial class BookmarksManagerForm
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
            this.BookmarksManagerBox = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteBookmark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookmarksManagerBox
            // 
            this.BookmarksManagerBox.FormattingEnabled = true;
            this.BookmarksManagerBox.ItemHeight = 20;
            this.BookmarksManagerBox.Location = new System.Drawing.Point(5, 0);
            this.BookmarksManagerBox.Name = "BookmarksManagerBox";
            this.BookmarksManagerBox.Size = new System.Drawing.Size(466, 584);
            this.BookmarksManagerBox.TabIndex = 0;
            this.BookmarksManagerBox.SelectedIndexChanged += new System.EventHandler(this.BookmarksManagerBox_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(5, 590);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(312, 26);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(323, 590);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(148, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteBookmark
            // 
            this.deleteBookmark.Location = new System.Drawing.Point(123, 623);
            this.deleteBookmark.Name = "deleteBookmark";
            this.deleteBookmark.Size = new System.Drawing.Size(222, 47);
            this.deleteBookmark.TabIndex = 3;
            this.deleteBookmark.Text = "Delete Selected Bookmark";
            this.deleteBookmark.UseVisualStyleBackColor = true;
            this.deleteBookmark.Click += new System.EventHandler(this.deleteBookmark_Click);
            // 
            // BookmarksManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 677);
            this.Controls.Add(this.deleteBookmark);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.BookmarksManagerBox);
            this.Name = "BookmarksManagerForm";
            this.Text = "BookmarksManagerForm";
            this.Load += new System.EventHandler(this.BookmarksManagerForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarksManagerBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteBookmark;
    }
}