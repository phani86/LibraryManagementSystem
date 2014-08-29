namespace LibraryManagementSystem
{
    partial class AdminSearchBooksForm
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
            this.searchBookComboBox = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.specificComboBox = new System.Windows.Forms.ComboBox();
            this.searchMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBookComboBox
            // 
            this.searchBookComboBox.FormattingEnabled = true;
            this.searchBookComboBox.Items.AddRange(new object[] {
            "Category",
            "Title",
            "Author",
            "Publisher"});
            this.searchBookComboBox.Location = new System.Drawing.Point(99, 44);
            this.searchBookComboBox.Name = "searchBookComboBox";
            this.searchBookComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchBookComboBox.TabIndex = 2;
            this.searchBookComboBox.SelectedIndexChanged += new System.EventHandler(this.searchBookComboBox_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(2, 47);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(37, 13);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Select";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(99, 97);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(2, 75);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(0, 13);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Visible = false;
            // 
            // searchMenuStrip
            // 
            this.searchMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.searchMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.searchMenuStrip.Name = "searchMenuStrip";
            this.searchMenuStrip.Size = new System.Drawing.Size(380, 24);
            this.searchMenuStrip.TabIndex = 0;
            this.searchMenuStrip.Text = "menuStrip1";
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutLibraryManagementSystemToolStripMenuItem
            // 
            this.aboutLibraryManagementSystemToolStripMenuItem.Name = "aboutLibraryManagementSystemToolStripMenuItem";
            this.aboutLibraryManagementSystemToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.aboutLibraryManagementSystemToolStripMenuItem.Text = "About LibraryManagementSystem";
            this.aboutLibraryManagementSystemToolStripMenuItem.Click += new System.EventHandler(this.aboutLibraryManagementSystemToolStripMenuItem_Click);
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Location = new System.Drawing.Point(2, 129);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(91, 13);
            this.copiesLabel.TabIndex = 6;
            this.copiesLabel.Text = "Number of Copies";
            this.copiesLabel.Visible = false;
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(99, 126);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.ReadOnly = true;
            this.copiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.copiesTextBox.TabIndex = 7;
            this.copiesTextBox.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(62, 155);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            this.priceLabel.Visible = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(99, 152);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.Visible = false;
            // 
            // specificComboBox
            // 
            this.specificComboBox.FormattingEnabled = true;
            this.specificComboBox.Location = new System.Drawing.Point(99, 72);
            this.specificComboBox.Name = "specificComboBox";
            this.specificComboBox.Size = new System.Drawing.Size(121, 21);
            this.specificComboBox.TabIndex = 4;
            // 
            // AdminSearchBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 228);
            this.Controls.Add(this.specificComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.searchBookComboBox);
            this.Controls.Add(this.searchMenuStrip);
            this.MainMenuStrip = this.searchMenuStrip;
            this.Name = "AdminSearchBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem-AdminSearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.Click += new System.EventHandler(this.searchButton_Click);
            this.searchMenuStrip.ResumeLayout(false);
            this.searchMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchBookComboBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.MenuStrip searchMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox specificComboBox;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem;
    }
}