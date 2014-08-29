/* AdminHomeForm.cs
   This LibraryManagementSystem Application deals with add,remove,view and search functionality 
   where administrator can add,remove,view and search books.When a book is searched,Number of
   copies and price is displayed.Student can search for books after completing registration 
   process.
 
   Revision History
               Srinivasa Phanindra Valluri, Puneet Kalva, 2013.08.11: Created   
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

       

        //To select which operation to perform by the administrator.
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (addBooksRadioButton.Checked)
            {
                BooksAdditionForm bookAdditionForm = new BooksAdditionForm();
                bookAdditionForm.Show();
                this.Hide();
            }
            else if (removeBooksRadioButton.Checked)
            {
                RemoveBooksForm removeBookForm = new RemoveBooksForm();
                removeBookForm.Show();
                this.Hide();
            }
            else if (viewBooksRadioButton.Checked)
            {
                ViewBooksForm viewBooksForm = new ViewBooksForm();
                viewBooksForm.Show();
                this.Hide();
            }
            else if (searchBooksRadioButton.Checked)
            {
                AdminSearchBooksForm searchBookForm = new AdminSearchBooksForm();
                searchBookForm.Show();
                this.Hide();
            }


        }

      
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closeDialogResult = MessageBox.Show("Do you want to close " + Text + "?",
                Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeDialogResult == DialogResult.Yes) this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "LibraryManagementSystemHelp.pdf";
            proc.Start();
        }
    }
}
