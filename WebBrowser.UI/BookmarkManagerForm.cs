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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }
        //list to use to control the collection list 

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {//FORM LOAD
            var items = BookmarkManager.GetItems();
            listBoxBookmarkManager.Items.Clear();
            foreach (var item in items)
            {
                listBoxBookmarkManager.Items.Add(item);
            }

        }

        private void buttonBookmarkSearch_Click(object sender, EventArgs e)
        {//SEARCH BUTTON

            if (!string.IsNullOrEmpty(textBoxBMSearch.Text))
            {
                listBoxBookmarkManager.Items.Clear();
                foreach (BookmarkItem obj in BookmarkManager.GetItems())
                {
                    if (obj.URL.ToLower().StartsWith(textBoxBMSearch.Text.ToLower()) || (obj.Title.ToLower().StartsWith(textBoxBMSearch.Text.ToLower())))
                    {
                        listBoxBookmarkManager.Items.Add(obj);
                    }
                }
            }
            else if (textBoxBMSearch.Text == "")
            {
                listBoxBookmarkManager.Items.Clear();
                foreach (BookmarkItem obj in BookmarkManager.GetItems())
                {
                    listBoxBookmarkManager.Items.Add(obj);
                }
            }
        }

        private void buttonBookmarkDelete_Click(object sender, EventArgs e)
        {//DELETE BUTTON
            var BMdeleteObj = new BookmarkManager();

            foreach (BookmarkItem item in listBoxBookmarkManager.SelectedItems)
            {
                BMdeleteObj.DeleteItem(item.ID);

            }

            listBoxBookmarkManager.Items.Clear();
            foreach (BookmarkItem item in BookmarkManager.GetItems())
            {
                listBoxBookmarkManager.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {//reset button
         //   listBoxBookmarkManager.Items.Clear();
            textBoxBMSearch.Text = "";

                listBoxBookmarkManager.Items.Clear();
                foreach (BookmarkItem obj in BookmarkManager.GetItems())
                {
                    listBoxBookmarkManager.Items.Add(obj);
                }

            }
        
    }
}
