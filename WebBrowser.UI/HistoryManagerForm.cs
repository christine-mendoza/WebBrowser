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
        }
        // list to control list collection
        List<HistoryItem> collectionList = new List<HistoryItem>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {//FORM LOAD
            var items = HistoryManager.GetItems();

            foreach (var item in items)
            {

                listBoxHistory.Items.Add(item);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {//SEARCH BUTTON

            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                listBoxHistory.Items.Clear();
                foreach (HistoryItem obj in HistoryManager.GetItems())
                {
                    if ((obj.URL.ToLower().Contains(textBoxSearch.Text.ToLower())) || obj.Title.ToLower().Contains(textBoxSearch.Text.ToLower()))
                    {
                        listBoxHistory.Items.Add(obj);
                    }
                }
            }
            else if (textBoxSearch.Text == "")
            {
                listBoxHistory.Items.Clear();
                foreach (HistoryItem obj in HistoryManager.GetItems())
                {
                    listBoxHistory.Items.Add(obj);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {//DELETE BUTTON
            var historyMang = new HistoryManager();


            foreach (HistoryItem item in listBoxHistory.SelectedItems)
            {
                historyMang.DeleteItem(item.ID);

            }

            listBoxHistory.Items.Clear();
            foreach (HistoryItem item in HistoryManager.GetItems())
            {
                listBoxHistory.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//CLEAR HISTORY BUTTON
            var historyMang = new HistoryManager();
            foreach (var item in HistoryManager.GetItems())
            {
                historyMang.DeleteItem(item.ID);
            }
            listBoxHistory.Items.Clear();



        }
    }
}


