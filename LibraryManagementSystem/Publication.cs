/* Publication.cs
 Publication Class which adds different publications to new and existing LibraryManagementSystem 
 catalogue 
 
 Revision History
                Srinivasa Phanindra Valluri, Puneet Kalva 2013.07.31: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    //Publication Super Class and taking input through get and set methods.
    class Publication
    {
        private float price;
        private string category, title, author, publisher; 
        private DateTime publisheddate;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public DateTime Publisheddate
        {
            get { return publisheddate; }
            set { publisheddate = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        
        //Empty publication object calls this constructor.
        public Publication() { }

        //Publication object calls this constructor.
        public Publication(string category, string title, string author, string publisher,
            DateTime publisheddate,float price)
        {
            this.Category =category;
            this.Title = title;
            this.Author = author;
            this.Publisher =publisher;
            this.Publisheddate =publisheddate;
            this.Price = price;
         }
      
    }
}
