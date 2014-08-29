/* LoginForm.cs
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
    public partial class LoginForm : Form
    {
        private OleDbConnection mycon;
        public LoginForm()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;");
            InitializeComponent();
        }

        //New user Registration form is displayed.
        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewRegistrationForm newRegistrationForm = new NewRegistrationForm();
            newRegistrationForm.Show();
            this.Hide();
        }

        //User login validation ,if valid,directed to respective home forms.
        private void loginButton_Click(object sender, EventArgs e)
        {

            String errorMessage = "Please correct the following input";
            bool isInputError = false;
            userIDTextBox.Text = userIDTextBox.Text.Trim();
            passwordTextBox.Text = passwordTextBox.Text.Trim();
            if (userIDTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - Userid";
                isInputError = true;
            }

            if (passwordTextBox.Text=="")
            {
                errorMessage = errorMessage + "\n - password";
                isInputError = true;
            }
            if (isInputError == true) MessageBox.Show(errorMessage,Text,MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            else
            {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Registration where StudentID='" 
                        + userIDTextBox.Text + "' and Password='" + passwordTextBox.Text + "'";
                    cmd.Connection = mycon;
                    mycon.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (userIDTextBox.Text == dr.GetValue(0).ToString() && 
                                passwordTextBox.Text == dr.GetValue(3).ToString())
                            {
                                StudentHomeForm studentHomeForm = new StudentHomeForm();
                                studentHomeForm.Show();
                                this.Hide();
                            }
                        }
                        dr.Close();
                    }
                
                  else if (userIDTextBox.Text == "admin" && passwordTextBox.Text == "admin123")
                    {
                        AdminHomeForm adminHomeForm = new AdminHomeForm();
                        adminHomeForm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Not valid login", Text, MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                    mycon.Close();
                }      
            }
        
      
        //Closes form on user confirmation.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closeDialogResult=MessageBox.Show("Do You want to close?",Text,
            MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (closeDialogResult == DialogResult.Yes)
                this.Close();
        }

        //To exit the application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        //To view help about using the LibraryManagementSystem.
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "LibraryManagementSystemHelp.pdf";
            proc.Start();
        }

        //About box which shows brief description about LibraryManagementSystem. 
        private void aboutLibraryManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
        }


    }

