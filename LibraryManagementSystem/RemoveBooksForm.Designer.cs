namespace LibraryManagementSystem
{
    partial class RemoveBooksForm
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
            this.removelabel = new System.Windows.Forms.Label();
            this.removeBookComboBox = new System.Windows.Forms.ComboBox();
            this.specificComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removelabel
            // 
            this.removelabel.AutoSize = true;
            this.removelabel.Location = new System.Drawing.Point(13, 48);
            this.removelabel.Name = "removelabel";
            this.removelabel.Size = new System.Drawing.Size(123, 13);
            this.removelabel.TabIndex = 1;
            this.removelabel.Text = "Remove Book Based on";
            // 
            // removeBookComboBox
            // 
            this.removeBookComboBox.FormattingEnabled = true;
            this.removeBookComboBox.Items.AddRange(new object[] {
            "ISBN",
            "Title",
            "Author",
            "Publisher"});
            this.removeBookComboBox.Location = new System.Drawing.Point(142, 45);
            this.removeBookComboBox.Name = "removeBookComboBox";
            this.removeBookComboBox.Size = new System.Drawing.Size(121, 21);
            this.removeBookComboBox.TabIndex = 2;
            this.removeBookComboBox.SelectedIndexChanged += new System.EventHandler(this.removeBookComboBox_SelectedIndexChanged);
            // 
            // specificComboBox
            // 
            this.specificComboBox.FormattingEnabled = true;
            this.specificComboBox.Location = new System.Drawing.Point(142, 72);
            this.specificComboBox.Name = "specificComboBox";
            this.specificComboBox.Size = new System.Drawing.Size(121, 21);
            this.specificComboBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(142, 108);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RemoveBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 262);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.specificComboBox);
            this.Controls.Add(this.removeBookComboBox);
            this.Controls.Add(this.removelabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RemoveBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem-RemoveBooksForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label removelabel;
        private System.Windows.Forms.ComboBox removeBookComboBox;
        private System.Windows.Forms.ComboBox specificComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}