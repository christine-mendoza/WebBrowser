using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;



namespace WebBrowser.UI
{
    public partial class MainForm : Form
    {
        String URL = "";
        public MainForm()
        {
            InitializeComponent();
            
        }




private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {//save as html on tool bar
            UserControlForWebBrowser tester = (UserControlForWebBrowser)tabControl1.SelectedTab.Controls[0];
            tester.Save();
           



        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser was created at Auburn University"
                + " by Christine Mendoza AUID:CEM0179 3/19/2021.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripComboBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
        //bookmark button
        public void userControlForWebBrowser1_Load(object sender, EventArgs e)
        {
            
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlForWebBrowser UserControlForWebBrowswerobj = new UserControlForWebBrowser();
            TabControl newTab = new TabControl();
            TabPage tp = new TabPage();

            UserControlForWebBrowswerobj.Dock = DockStyle.Fill;
            tp.Text = "New Page";
            tp.Controls.Add(UserControlForWebBrowswerobj);
            this.tabControl1.TabPages.Add(tp);

           





        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
            {
                UserControlForWebBrowser UserControlForWebBrowswerobj = new UserControlForWebBrowser();
                TabControl newTab = new TabControl();
                TabPage tp = new TabPage();
               

                UserControlForWebBrowswerobj.Dock = DockStyle.Fill;
                tp.Text = "New Page";
                tp.Controls.Add(UserControlForWebBrowswerobj);
                this.tabControl1.TabPages.Add(tp);
                

            }
            if (e.Control && (e.KeyCode == Keys.W))
            {
                this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
            }
        }




        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForm = new HistoryManagerForm();
            itemsForm.ShowDialog();
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {//bookmark dialog box
            var itemsForm = new BookmarkManagerForm();
            itemsForm.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {//tool bar delete\

            var historyMang = new HistoryManager();
            foreach (var item in HistoryManager.GetItems())
            {
                historyMang.DeleteItem(item.ID);

                
            }
         
                var historyForm = new HistoryManagerForm();
            historyForm.listBoxHistory.Items.Clear();
        }


        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {//print selection

            UserControlForWebBrowser tester = (UserControlForWebBrowser)tabControl1.SelectedTab.Controls[0];
            tester.PrintDocument();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

    }


}
