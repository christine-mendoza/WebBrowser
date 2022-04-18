namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.listBoxBookmarkManager = new System.Windows.Forms.ListBox();
            this.textBoxBMSearch = new System.Windows.Forms.TextBox();
            this.buttonBookmarkSearch = new System.Windows.Forms.Button();
            this.buttonBookmarkDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBookmarkManager
            // 
            this.listBoxBookmarkManager.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxBookmarkManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBookmarkManager.FormattingEnabled = true;
            this.listBoxBookmarkManager.Location = new System.Drawing.Point(0, 0);
            this.listBoxBookmarkManager.Name = "listBoxBookmarkManager";
            this.listBoxBookmarkManager.Size = new System.Drawing.Size(800, 450);
            this.listBoxBookmarkManager.TabIndex = 0;
            this.listBoxBookmarkManager.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxBMSearch
            // 
            this.textBoxBMSearch.Location = new System.Drawing.Point(12, 418);
            this.textBoxBMSearch.Name = "textBoxBMSearch";
            this.textBoxBMSearch.Size = new System.Drawing.Size(176, 20);
            this.textBoxBMSearch.TabIndex = 1;
            // 
            // buttonBookmarkSearch
            // 
            this.buttonBookmarkSearch.Location = new System.Drawing.Point(207, 418);
            this.buttonBookmarkSearch.Name = "buttonBookmarkSearch";
            this.buttonBookmarkSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonBookmarkSearch.TabIndex = 2;
            this.buttonBookmarkSearch.Text = "Search";
            this.buttonBookmarkSearch.UseVisualStyleBackColor = true;
            this.buttonBookmarkSearch.Click += new System.EventHandler(this.buttonBookmarkSearch_Click);
            // 
            // buttonBookmarkDelete
            // 
            this.buttonBookmarkDelete.Location = new System.Drawing.Point(288, 418);
            this.buttonBookmarkDelete.Name = "buttonBookmarkDelete";
            this.buttonBookmarkDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonBookmarkDelete.TabIndex = 3;
            this.buttonBookmarkDelete.Text = "Delete";
            this.buttonBookmarkDelete.UseVisualStyleBackColor = true;
            this.buttonBookmarkDelete.Click += new System.EventHandler(this.buttonBookmarkDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBookmarkDelete);
            this.Controls.Add(this.buttonBookmarkSearch);
            this.Controls.Add(this.textBoxBMSearch);
            this.Controls.Add(this.listBoxBookmarkManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmarkManager;
        private System.Windows.Forms.TextBox textBoxBMSearch;
        private System.Windows.Forms.Button buttonBookmarkSearch;
        private System.Windows.Forms.Button buttonBookmarkDelete;
        private System.Windows.Forms.Button button1;
    }
}