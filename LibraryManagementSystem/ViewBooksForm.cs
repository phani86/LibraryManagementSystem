/* ViewBooksForm.cs
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
using System.Data.OleDb;

namespace LibraryManagementSystem
{
    public partial class ViewBooksForm : Form
    {
        private OleDbConnection mycon;
        public ViewBooksForm()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;");
            InitializeComponent();

        }

       //Book data population from database to view exisiting books.
        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Book";
            cmd.Connection = mycon;
            mycon.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            ListViewItem lvi = new ListViewItem();
            while (dr.Read())
            {

                lvi = new ListViewItem(new string[] { dr.GetValue(0).ToString(), 
                dr.GetValue(1).ToString(), dr.GetValue(2).ToString(),dr.GetValue(3).ToString(), 
                dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), 
                dr.GetValue(6).ToString() });
                booksListView.Items.Add(lvi);
            }
            dr.Close();
            mycon.Close();
        }
        
        //To go to home form for performing different operations.
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHomeForm adminHomeForm = new AdminHomeForm();
            adminHomeForm.Show();
            this.Hide();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "LibraryManagementSystemHelp.pdf";
            proc.Start();
          
           
        }

        //Closes form on user confirmation.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closeDialogResult = MessageBox.Show("Do You want to close?", Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeDialogResult == DialogResult.Yes)
                this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutLibraryManagementSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
            
        }

        

    }

}


