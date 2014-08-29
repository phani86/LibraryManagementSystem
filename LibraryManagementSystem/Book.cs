/* Book.cs
 Book Class through which book details are added to new and existing LibraryManagementSystem 
 sbooks catalogue
 
 Revision History
                Srinivasa Phanindra Valluri, Puneet Kalva 2013.07.31: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    //Book class inheriting from Publication Super Class.
    class Book : Publication
    {
        private static int isbn = 1000;

        public int ISBN
        {
            get { return isbn; }
        }

        //Empty Book object calls this constructor.
        public Book() { }

        //Book object calls this constructor.
        public Book(string category, string title, string author, string publisher,
            DateTime publisheddate, float price)
        {
            isbn++;
            this.Category = category;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Publisheddate = publisheddate;
            this.Price = price;

        }
    }
}
