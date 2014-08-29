namespace LibraryManagementSystem
{
    partial class BooksAdditionForm
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.publishedDateLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIdentifierLabel = new System.Windows.Forms.Label();
            this.bookIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.maskedPublishedDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(21, 67);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(106, 64);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(22, 93);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(106, 90);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 6;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(22, 119);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "Author";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(106, 116);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 8;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(22, 145);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 9;
            this.publisherLabel.Text = "Publisher";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(106, 142);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 10;
            // 
            // publishedDateLabel
            // 
            this.publishedDateLabel.AutoSize = true;
            this.publishedDateLabel.Location = new System.Drawing.Point(20, 172);
            this.publishedDateLabel.Name = "publishedDateLabel";
            this.publishedDateLabel.Size = new System.Drawing.Size(79, 13);
            this.publishedDateLabel.TabIndex = 11;
            this.publishedDateLabel.Text = "Published Date";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(106, 194);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(21, 197);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addFormMenuStrip
            // 
            this.addFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.addFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.addFormMenuStrip.Name = "addFormMenuStrip";
            this.addFormMenuStrip.Size = new System.Drawing.Size(278, 24);
            this.addFormMenuStrip.TabIndex = 0;
            this.addFormMenuStrip.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            this.aboutLibraryManagementSystemToolStripMenuItem.Click += new System.EventHandler(this.aboutLibraryManagementSystemToolStripMenuItem_Click);
            // 
            // bookIdentifierLabel
            // 
            this.bookIdentifierLabel.AutoSize = true;
            this.bookIdentifierLabel.Location = new System.Drawing.Point(21, 41);
            this.bookIdentifierLabel.Name = "bookIdentifierLabel";
            this.bookIdentifierLabel.Size = new System.Drawing.Size(60, 13);
            this.bookIdentifierLabel.TabIndex = 1;
            this.bookIdentifierLabel.Text = "Book ISBN";
            // 
            // bookIdentifierTextBox
            // 
            this.bookIdentifierTextBox.Location = new System.Drawing.Point(106, 38);
            this.bookIdentifierTextBox.Name = "bookIdentifierTextBox";
            this.bookIdentifierTextBox.ReadOnly = true;
            this.bookIdentifierTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIdentifierTextBox.TabIndex = 2;
            // 
            // maskedPublishedDateTextBox
            // 
            this.maskedPublishedDateTextBox.Location = new System.Drawing.Point(107, 169);
            this.maskedPublishedDateTextBox.Mask = "00/00/0000";
            this.maskedPublishedDateTextBox.Name = "maskedPublishedDateTextBox";
            this.maskedPublishedDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.maskedPublishedDateTextBox.TabIndex = 12;
            this.maskedPublishedDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // BooksAdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 268);
            this.Controls.Add(this.maskedPublishedDateTextBox);
            this.Controls.Add(this.bookIdentifierTextBox);
            this.Controls.Add(this.bookIdentifierLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.publishedDateLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.addFormMenuStrip);
            this.MainMenuStrip = this.addFormMenuStrip;
            this.Name = "BooksAdditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem-BooksAdditionForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addFormMenuStrip.ResumeLayout(false);
            this.addFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label publishedDateLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip addFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label bookIdentifierLabel;
        private System.Windows.Forms.TextBox bookIdentifierTextBox;
        private System.Windows.Forms.MaskedTextBox maskedPublishedDateTextBox;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem;
    }
}

