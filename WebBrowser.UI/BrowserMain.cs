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
    public partial class BrowserWindow : Form
    {
        public UserControlTab ucTab = new UserControlTab();
        public BrowserWindow()
        {
            InitializeComponent();
            ucTab.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(ucTab);
            tabPage1.Text = "New Tab";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Welcome to Midiscape Navigator. A web browser by Derek Conner." +
                " Right now it doesn't do much, but just you wait. We're gonna" +
                " beat Google Chrome. " +
                "\n\n STUDENT ID: djc0065@auburn.edu" +
                "\n\nNew to programming but not new to creating. Was a full " +
                "time DJ and music artist for 4 years and I dabble in the visual arts. Looking forward" +
                " to learning more and programming something great in the future!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            UserControlTab newUCTab = new UserControlTab();
            newUCTab.Dock = DockStyle.Fill;
            newTab.Controls.Add(newUCTab);
            tabControl.TabPages.Add(newTab);
            newTab.Text = "New Tab";
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var History = new HistoryManagerForm();
            History.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Bookmarks = new BookmarksManagerForm();
            Bookmarks.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
