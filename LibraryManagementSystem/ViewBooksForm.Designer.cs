namespace LibraryManagementSystem
{
    partial class ViewBooksForm
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
            this.booksListView = new System.Windows.Forms.ListView();
            this.bookISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookcategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.booktitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookauthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookpublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookpubdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookISBN,
            this.bookcategory,
            this.booktitle,
            this.bookauthor,
            this.bookpublisher,
            this.bookpubdate,
            this.bookPrice});
            this.booksListView.GridLines = true;
            this.booksListView.Location = new System.Drawing.Point(21, 33);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(424, 142);
            this.booksListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.booksListView.TabIndex = 1;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // bookISBN
            // 
            this.bookISBN.Text = "BookISBN";
            // 
            // bookcategory
            // 
            this.bookcategory.Text = "Category";
            // 
            // booktitle
            // 
            this.booktitle.Text = "Title";
            // 
            // bookauthor
            // 
            this.bookauthor.Text = "Author";
            // 
            // bookpublisher
            // 
            this.bookpublisher.Text = "Publisher";
            // 
            // bookpubdate
            // 
            this.bookpubdate.Text = "Published Date";
            // 
            // bookPrice
            // 
            this.bookPrice.Text = "Price";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutLibraryManagementSystemToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutLibraryManagementSystemToolStripMenuItem
            // 
            this.aboutLibraryManagementSystemToolStripMenuItem.Name = "aboutLibraryManagementSystemToolStripMenuItem";
            this.aboutLibraryManagementSystemToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.aboutLibraryManagementSystemToolStripMenuItem.Text = "About Library Management System";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.helpToolStripMenuItem1});
            this.fileToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(463, 24);
            this.fileToolStripMenuItem.TabIndex = 0;
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.closeToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem1,
            this.aboutLibraryManagementSystemToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // viewHelpToolStripMenuItem1
            // 
            this.viewHelpToolStripMenuItem1.Name = "viewHelpToolStripMenuItem1";
            this.viewHelpToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.viewHelpToolStripMenuItem1.Text = "View Help";
            this.viewHelpToolStripMenuItem1.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutLibraryManagementSystemToolStripMenuItem1
            // 
            this.aboutLibraryManagementSystemToolStripMenuItem1.Name = "aboutLibraryManagementSystemToolStripMenuItem1";
            this.aboutLibraryManagementSystemToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.aboutLibraryManagementSystemToolStripMenuItem1.Text = "About LibraryManagementSystem";
            this.aboutLibraryManagementSystemToolStripMenuItem1.Click += new System.EventHandler(this.aboutLibraryManagementSystemToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ViewBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 217);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.fileToolStripMenuItem);
            this.MainMenuStrip = this.fileToolStripMenuItem;
            this.Name = "ViewBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem-ViewBooksForm";
            this.Load += new System.EventHandler(this.ViewBooksForm_Load);
            this.fileToolStripMenuItem.ResumeLayout(false);
            this.fileToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader bookISBN;
        private System.Windows.Forms.ColumnHeader bookcategory;
        private System.Windows.Forms.ColumnHeader booktitle;
        private System.Windows.Forms.ColumnHeader bookauthor;
        private System.Windows.Forms.ColumnHeader bookpublisher;
        private System.Windows.Forms.ColumnHeader bookpubdate;
        private System.Windows.Forms.ColumnHeader bookPrice;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem;
        private System.Windows.Forms.MenuStrip fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
    }
}