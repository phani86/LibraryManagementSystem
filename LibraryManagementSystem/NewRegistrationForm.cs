/* NewRegistrationForm.cs
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
    public partial class NewRegistrationForm : Form
    {
        private OleDbConnection mycon;
        public NewRegistrationForm()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;");
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            String errorMessage = "Please correct the following input";
            bool isInputError = false;
            studentIdentifierTextBox.Text = studentIdentifierTextBox.Text.Trim();
            studentForenameTextBox.Text = studentForenameTextBox.Text.Trim();
            studentSurnameTextBox.Text = studentSurnameTextBox.Text.Trim();
            passwordTextBox.Text = passwordTextBox.Text.Trim();
            if (studentIdentifierTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - StudentID";
                isInputError = true;
            }

            if (studentForenameTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - Studentforename";
                isInputError = true;
            }
            if (studentSurnameTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - Studentsurname";
                isInputError = true;
            }
            if (passwordTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - password";
                isInputError = true;
            }

            if (isInputError == true) MessageBox.Show(errorMessage);
            else
            {

               User user = new User(studentIdentifierTextBox.Text, studentForenameTextBox.Text,
                            studentSurnameTextBox.Text, passwordTextBox.Text);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Registration values('" + user.ID + "' ,'" +
                    user.Forename + "','" + user.Surname + "','" + user.Password + "')";
                cmd.Connection = mycon;
                mycon.Open();
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    MessageBox.Show("Registration Successful", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration not successful", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
    

