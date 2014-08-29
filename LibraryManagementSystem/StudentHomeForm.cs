/* StudentHomeForm.cs
   This LibraryManagementSystem Application deals with add,remove,view and search functionality 
   where administrator can add,remove,view and search books.When a book is searched,Number of
   copies and price is displayed.Student can search for books after completing registration 
   process.
 
  Revision History
               Srinivasa Phanindra Valluri Puneet Kalva, 2013.08.11: Created     

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
    public partial class StudentHomeForm : Form
    {
        public StudentHomeForm()
        {
            InitializeComponent();
        }

        //To select operation to be perofrmed by the student.
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (searchBooksRadioButton.Checked)
            {
                StudentSearchBooksForm studentSearchBooksForm = new StudentSearchBooksForm();
                studentSearchBooksForm.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult closeDialogResult = MessageBox.Show("Do you want to close " + Text + 
                 "?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (closeDialogResult == DialogResult.Yes) this.Close();
        }

        private void aboutLibraryManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "LibraryManagementSystemHelp.pdf";
            proc.Start();
        }

       

       
    }
}
