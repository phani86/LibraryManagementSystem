/* AdminSearchBooksForm.cs
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
    public partial class AdminSearchBooksForm : Form
    {
        private OleDbConnection mycon;
      
        public AdminSearchBooksForm()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;");
            InitializeComponent();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        //Combo box which populates the list of selected item values in second combo box.  
        private void searchBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (searchBookComboBox.SelectedItem.ToString() == "Category")
            {
                searchLabel.Visible = true;
                searchLabel.Text = "Select Category";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select distinct Category from Book";
                cmd.Connection = mycon;
                mycon.Open();

                OleDbDataReader dr = cmd.ExecuteReader();
                specificComboBox.Items.Clear();
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
               mycon.Close();
                specificComboBox.SelectedIndex = -1;
              }
           
        else if (searchBookComboBox.SelectedItem.ToString() == "Title")
            {
                specificComboBox.Items.Clear();
                searchLabel.Visible = true;
                searchLabel.Text = "Select Title";                
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Title from Book";
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
            else if (searchBookComboBox.SelectedItem.ToString() == "Author")
            {
                specificComboBox.Items.Clear();
                
                searchLabel.Visible = true;
                searchLabel.Text = "Select AuthorName";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select distinct Author from Book";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                mycon.Close();
            }
            else if (searchBookComboBox.SelectedItem.ToString() == "Publisher")
            {
                specificComboBox.Items.Clear();
                searchLabel.Visible = true;
                searchLabel.Text = "Select Publisher";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select distinct Publisher from Book";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    specificComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                mycon.Close();              
            }
          
        }

        //Search books based on first combox selected item values in second combo box        
        private void searchButton_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            if (searchBookComboBox.SelectedItem.ToString() == "Category")
            {
                int copies = 0;
                double price=0;
                cmd.CommandText = "select Price from Book where Category='" + specificComboBox.SelectedItem.ToString()+ "'";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    copies++;
                    price = Convert.ToDouble(dr.GetValue(0).ToString());
                }
                copiesLabel.Visible = true;
                copiesTextBox.Visible = true;
                copiesTextBox.Text = copies.ToString();
                priceLabel.Visible = true;
                priceTextBox.Visible = true;
                priceTextBox.Text = price.ToString("c");
                dr.Close();
                mycon.Close();
            
            }
            else if (searchBookComboBox.SelectedItem.ToString() == "Title")
            {
                int copies = 0;
                double price = 0;
                cmd.CommandText = "select Price from Book where Title='" + specificComboBox.SelectedItem.ToString() + "'";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    copies++;
                    price = Convert.ToDouble(dr.GetValue(0).ToString());
                }
                copiesLabel.Visible = true;
                copiesTextBox.Visible = true;
                copiesTextBox.Text = copies.ToString();
                priceLabel.Visible = true;
                priceTextBox.Visible = true;
                priceTextBox.Text = price.ToString("c");
                dr.Close();
                mycon.Close();
              }
            else if (searchBookComboBox.SelectedItem.ToString() == "Author")
            {
                int copies = 0;
                double price = 0;
                cmd.CommandText = "select Price from Book where Author='" + specificComboBox.SelectedItem.ToString() + "'";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    copies++;
                    price = Convert.ToDouble(dr.GetValue(0).ToString());
                }
                copiesLabel.Visible = true;
                copiesTextBox.Visible = true;
                copiesTextBox.Text = copies.ToString();
                priceLabel.Visible = true;
                priceTextBox.Visible = true;
                priceTextBox.Text = price.ToString("c");
                dr.Close();
                mycon.Close();
             }
            else if (searchBookComboBox.SelectedItem.ToString() == "Publisher")
            {
                int copies = 0;
                double price = 0;
                cmd.CommandText = "select Price from Book where Publisher='" + specificComboBox.SelectedItem.ToString() + "'";
                cmd.Connection = mycon;
                mycon.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    copies++;
                    price = Convert.ToDouble(dr.GetValue(0).ToString());
                }
                copiesLabel.Visible = true;
                copiesTextBox.Visible = true;
                copiesTextBox.Text = copies.ToString();
                priceLabel.Visible = true;
                priceTextBox.Visible = true;
                priceTextBox.Text = price.ToString("c");
                dr.Close();
                mycon.Close();
               }
        }

      

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHomeForm adminHomeForm = new AdminHomeForm();
            adminHomeForm.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        
            DialogResult closeDialogResult = MessageBox.Show("Do you want to close " + Text + "?", 
                Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (closeDialogResult == DialogResult.Yes) this.Close();
        
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "LibraryManagementSystemHelp.pdf";
            proc.Start();
        }

       

        private void aboutLibraryManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAboutBox searchAboutBox = new SearchAboutBox();
            searchAboutBox.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

       
    }
}
