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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
            this.Visible = false;
        }


        private void historyManagerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            historyManagerBox.Items.Clear();
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                historyManagerBox.Items.Add(string.Format("{0} - {1} - {2} ", item.Date, item.Title, item.URL));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string inquiry = searchBox.Text;
            historyManagerBox.Items.Clear();
            var items = HistoryManager.GetItems();
            foreach(var item in items)
            {
                if (item.Title.Contains(inquiry) || item.URL.Contains(inquiry)) {
                    historyManagerBox.Items.Add(string.Format("{0} - {1} - {2} ", item.Date, item.Title, item.URL));
                }
            }
        }

        private void deleteHistory_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
            historyManagerBox.Items.Clear();
        }
    }
}
