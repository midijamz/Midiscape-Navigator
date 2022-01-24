using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarksManagerForm : Form
    {
        public BookmarksManagerForm()
        {
            InitializeComponent();
            this.Visible = false;
        }


        private void BookmarksManagerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookmarksManagerForm_Load_1(object sender, EventArgs e)
        {
            BookmarksManagerBox.Items.Clear();
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                BookmarksManagerBox.Items.Add(string.Format("{0} - {1}", item.Title, item.URL));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string inquiry = searchBox.Text;
            BookmarksManagerBox.Items.Clear();
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                if (item.Title.Contains(inquiry) || item.URL.Contains(inquiry))
                {
                    BookmarksManagerBox.Items.Add(string.Format("{0} - {1}", item.Title, item.URL));
                }
            }
        }

        private void deleteBookmark_Click(object sender, EventArgs e)
        {
            int index = BookmarksManagerBox.SelectedIndex;
            int i = 0;
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                if (i == index)
                {
                    BookmarkManager.DeleteBookmark(item);
                    BookmarksManagerBox.Items.Clear();
                    var refreshed = BookmarkManager.GetItems();
                    foreach (var newitem in refreshed)
                    {
                        BookmarksManagerBox.Items.Add(string.Format("{0} - {1}", item.Title, item.URL));
                    }
                }
                i++;
            }
        }
    }
}
