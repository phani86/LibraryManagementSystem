/* BooksAdditionForm.cs
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
using System.Globalization;
using System.Data.OleDb;

namespace LibraryManagementSystem
{
    public partial class BooksAdditionForm : Form
    {
        private OleDbConnection mycon;
        DateTime pubDate;
        float price;
        System.IFormatProvider ifpformat = new System.Globalization.CultureInfo("en-US", true);
        public BooksAdditionForm()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;");
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Add Books to database if the form data  is valid
        private void addButton_Click(object sender, EventArgs e)
        {

            string errorMessage = "Please correct the following input";
            bool isInputError = false;
            categoryTextBox.Text = categoryTextBox.Text.Trim();
            titleTextBox.Text = titleTextBox.Text.Trim();
            authorTextBox.Text = authorTextBox.Text.Trim();
            publisherTextBox.Text = publisherTextBox.Text.Trim();
            maskedPublishedDateTextBox.Text = maskedPublishedDateTextBox.Text.Trim();
            priceTextBox.Text = priceTextBox.Text.Trim();

            if (categoryTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - category";
                isInputError = true;
            }

            if (titleTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n - title";
                isInputError = true;
            }
            if (authorTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n-author";
                isInputError = true;
            }
            if (publisherTextBox.Text == "")
            {
                errorMessage = errorMessage + "\n-publisher";
                isInputError = true;
            }
            if (maskedPublishedDateTextBox.Text == "")
            {

                errorMessage += "\n-Publisheddate";
                isInputError = true;

            }
            if (priceTextBox.Text != "")
            {
                try
                {
                    price = float.Parse(priceTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid input for price");
                }
            }
            else
            {
                errorMessage = errorMessage + "\n-price";
                isInputError = true;
            }
            if (isInputError == true) MessageBox.Show(errorMessage);
            else
            {
                try
                {
                    pubDate = Convert.ToDateTime(maskedPublishedDateTextBox.Text, ifpformat);
                    price = float.Parse(priceTextBox.Text);

                    Book newBook = new Book(categoryTextBox.Text, titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text,
                       Convert.ToDateTime(maskedPublishedDateTextBox.Text, ifpformat), float.Parse(priceTextBox.Text));
                    bookIdentifierTextBox.Text = newBook.ISBN.ToString();
                    if (int.Parse(bookIdentifierTextBox.Text) >= 1001)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into Book values(" + newBook.ISBN + " ,'" +
                                newBook.Category + "','" + newBook.Title + "','" + newBook.Author + "','"
                                + newBook.Publisher + "' ,'" + newBook.Publisheddate.ToShortDateString() +
                                "' ," + newBook.Price + ")";
                            cmd.Connection = mycon;
                            mycon.Open();

                            try
                            {
                            int temp = cmd.ExecuteNonQuery();
                            if (temp > 0)
                            {
                                MessageBox.Show("Book added", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            }
                            catch
                            {
                                MessageBox.Show("Book Not  added", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                    }
                   
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    mycon.Close(); 
                }
            
        }
        

        private void searchBookButton_Click(object sender, EventArgs e)
        {
            AdminSearchBooksForm searchForm = new AdminSearchBooksForm();
            searchForm.Show();
            this.Hide();
        }

        private void viewBooksButton_Click(object sender, EventArgs e)
        {
           ViewBooksForm viewBooks = new ViewBooksForm();
           viewBooks.Show();
           this.Hide();
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHomeForm adminHomeForm = new AdminHomeForm();
            adminHomeForm.Show();
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
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "LibraryManagementSystemHelp.pdf";
            proc.Start();

        }
        private void aboutLibraryManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

       
       
       
       

      
    }
}
