namespace LibraryManagementSystem
{
    partial class AdminHomeForm
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
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchBooksRadioButton = new System.Windows.Forms.RadioButton();
            this.viewBooksRadioButton = new System.Windows.Forms.RadioButton();
            this.removeBooksRadioButton = new System.Windows.Forms.RadioButton();
            this.addBooksRadioButton = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLibraryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.searchBooksRadioButton);
            this.actionsGroupBox.Controls.Add(this.viewBooksRadioButton);
            this.actionsGroupBox.Controls.Add(this.removeBooksRadioButton);
            this.actionsGroupBox.Controls.Add(this.addBooksRadioButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(27, 34);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(147, 122);
            this.actionsGroupBox.TabIndex = 1;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // searchBooksRadioButton
            // 
            this.searchBooksRadioButton.AutoSize = true;
            this.searchBooksRadioButton.Location = new System.Drawing.Point(17, 92);
            this.searchBooksRadioButton.Name = "searchBooksRadioButton";
            this.searchBooksRadioButton.Size = new System.Drawing.Size(92, 17);
            this.searchBooksRadioButton.TabIndex = 3;
            this.searchBooksRadioButton.TabStop = true;
            this.searchBooksRadioButton.Text = "Search Books";
            this.searchBooksRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewBooksRadioButton
            // 
            this.viewBooksRadioButton.AutoSize = true;
            this.viewBooksRadioButton.Location = new System.Drawing.Point(17, 68);
            this.viewBooksRadioButton.Name = "viewBooksRadioButton";
            this.viewBooksRadioButton.Size = new System.Drawing.Size(81, 17);
            this.viewBooksRadioButton.TabIndex = 2;
            this.viewBooksRadioButton.TabStop = true;
            this.viewBooksRadioButton.Text = "View Books";
            this.viewBooksRadioButton.UseVisualStyleBackColor = true;
            // 
            // removeBooksRadioButton
            // 
            this.removeBooksRadioButton.AutoSize = true;
            this.removeBooksRadioButton.Location = new System.Drawing.Point(17, 44);
            this.removeBooksRadioButton.Name = "removeBooksRadioButton";
            this.removeBooksRadioButton.Size = new System.Drawing.Size(98, 17);
            this.removeBooksRadioButton.TabIndex = 1;
            this.removeBooksRadioButton.TabStop = true;
            this.removeBooksRadioButton.Text = "Remove Books";
            this.removeBooksRadioButton.UseVisualStyleBackColor = true;
            // 
            // addBooksRadioButton
            // 
            this.addBooksRadioButton.AutoSize = true;
            this.addBooksRadioButton.Location = new System.Drawing.Point(17, 20);
            this.addBooksRadioButton.Name = "addBooksRadioButton";
            this.addBooksRadioButton.Size = new System.Drawing.Size(77, 17);
            this.addBooksRadioButton.TabIndex = 0;
            this.addBooksRadioButton.TabStop = true;
            this.addBooksRadioButton.Text = "Add Books";
            this.addBooksRadioButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(27, 174);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagementSystem-AdminHomeForm";
           // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHomeForm_FormClosing);
            this.actionsGroupBox.ResumeLayout(false);
            this.actionsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.RadioButton searchBooksRadioButton;
        private System.Windows.Forms.RadioButton viewBooksRadioButton;
        private System.Windows.Forms.RadioButton removeBooksRadioButton;
        private System.Windows.Forms.RadioButton addBooksRadioButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLibraryManagementSystemToolStripMenuItem;
    }
}