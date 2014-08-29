/* RemoveBooksForm.cs
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
    public partial class RemoveBooksForm : Form
    {
        private OleDbConnection mycon;
        public RemoveBooksForm()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;");
            InitializeComponent();
        }

        /*Combo box which populates the list of selected item values from database in second 
        combo box.*/
        private void removeBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removeBookComboBox.SelectedItem.ToString() == "ISBN")
            {
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select BookISBN from Book";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                mycon.Close();
                specificComboBox.SelectedIndex = -1;

            }
            else if (removeBookComboBox.SelectedItem.ToString() == "Title")
            {
                specificComboBox.Items.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Title from Book";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                mycon.Close();
                specificComboBox.SelectedIndex = -1;
                
            }
             else if (removeBookComboBox.SelectedItem.ToString() == "Author")
            {
                specificComboBox.Items.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Author from Book";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                mycon.Close();
                specificComboBox.SelectedIndex = -1;
              
            }
             else if (removeBookComboBox.SelectedItem.ToString() == "Publisher")
            {
                specificComboBox.Items.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Publisher from Book";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                mycon.Close();
                specificComboBox.SelectedIndex = -1;
                
            }         
        }
        
        /*To remove existing books based on first combo box selected item values in second 
        combo box.*/
        private void removeButton_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            if (removeBookComboBox.SelectedItem.ToString() == "ISBN")
            {
                cmd.CommandText = "delete from Book where BookISBN=" + specificComboBox.SelectedItem.ToString() + "";
                cmd.Connection = mycon;
                mycon.Open();
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    MessageBox.Show("Book Removed",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    specificComboBox.Items.Remove(specificComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Book not removed",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                mycon.Close();
            }
            else if (removeBookComboBox.SelectedItem.ToString() == "Title")
            {
                cmd.CommandText = "delete from Book where Title='" + specificComboBox.SelectedItem.ToString() + "'";
                cmd.Connection = mycon;
                mycon.Open();
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    MessageBox.Show("Book Removed",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    specificComboBox.Items.Remove(specificComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Book not removed",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                mycon.Close();

            }
            else if (removeBookComboBox.SelectedItem.ToString() == "Author")
            {
                cmd.CommandText = "delete from Book where Author='" + specificComboBox.SelectedItem.ToString() + "'";
                cmd.Connection = mycon;
                mycon.Open();
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    MessageBox.Show("Book Removed");
                    specificComboBox.Items.Remove(specificComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Book not removed");
                }
                mycon.Close();


            }
            else if (removeBookComboBox.SelectedItem.ToString() == "Publisher")
            {
                cmd.CommandText = "delete from Book where Publisher=" + specificComboBox.SelectedItem.ToString() + "'";
                cmd.Connection = mycon;
                mycon.Open();
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    MessageBox.Show("Book Removed",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    specificComboBox.Items.Remove(specificComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Book not removed",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                mycon.Close();

            }

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHomeForm adminHomeForm = new AdminHomeForm();
            adminHomeForm.Show();
            this.Hide();
        }

        

       
    }
}
