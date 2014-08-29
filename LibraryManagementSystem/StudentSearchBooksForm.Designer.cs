namespace LibraryManagementSystem
{
    partial class StudentSearchBooksForm
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
            this.specificComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.searchBookComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibrarymanagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // specificComboBox
            // 
            this.specificComboBox.FormattingEnabled = true;
            this.specificComboBox.Location = new System.Drawing.Point(104, 80);
            this.specificComboBox.Name = "specificComboBox";
            this.specificComboBox.Size = new System.Drawing.Size(121, 21);
            this.specificComboBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(104, 160);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(67, 163);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            this.priceLabel.Visible = false;
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(104, 134);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.ReadOnly = true;
            this.copiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.copiesTextBox.TabIndex = 7;
            this.copiesTextBox.Visible = false;
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Location = new System.Drawing.Point(7, 137);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(91, 13);
            this.copiesLabel.TabIndex = 6;
            this.copiesLabel.Text = "Number of Copies";
            this.copiesLabel.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(104, 105);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(7, 55);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(37, 13);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Select";
            // 
            // searchBookComboBox
            // 
            this.searchBookComboBox.FormattingEnabled = true;
            this.searchBookComboBox.Items.AddRange(new object[] {
            "Category",
            "Title",
            "Author",
            "Publisher"});
            this.searchBookComboBox.Location = new System.Drawing.Point(104, 52);
            this.searchBookComboBox.Name = "searchBookComboBox";
            this.searchBookComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchBookComboBox.TabIndex = 2;
            this.searchBookComboBox.SelectedIndexChanged += new System.EventHandler(this.searchBookComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aboutLibrarymanagementSystemToolStripMenuItem});
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
            // aboutLibrarymanagementSystemToolStripMenuItem
            // 
            this.aboutLibrarymanagementSystemToolStripMenuItem.Name = "aboutLibrarymanagementSystemToolStripMenuItem";
            this.aboutLibrarymanagementSystemToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.aboutLibrarymanagementSystemToolStripMenuItem.Text = "About LibrarymanagementSystem";
            this.aboutLibrarymanagementSystemToolStripMenuItem.Click += new System.EventHandler(this.aboutLibrarymanagementSystemToolStripMenuItem_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(7, 83);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(0, 13);
            this.searchLabel.TabIndex = 3;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.aboutLibraryManagementSystemToolStripMenuItem1.Click += new System.EventHandler(this.aboutLibrarymanagementSystemToolStripMenuItem_Click);
            // 
            // StudentSearchBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 262);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.specificComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.searchBookComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentSearchBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem-StudentSearchForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox specificComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.ComboBox searchBookComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibrarymanagementSystemToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem1;
    }
}