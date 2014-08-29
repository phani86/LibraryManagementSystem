/* User.cs
 User Class which registers a new user into LibraryManagementSystem.
 
 Revision History
                Srinivasa Phanindra Valluri, Puneet Kalva 2013.07.31: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    //User Super Class and taking input through get and set methods.
    class User
    {
        private string id;
        private string forename;
        private string surname;
        private string password;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        //Empty user object calls this constructor
        public User() { }

        //User object calls this constructor
        public User(string id , string forename,string surname,string password)
        {
            this.ID = id;
            this.Forename = forename;
            this.Surname = surname;
            this.Password = password;
        }
    }

}
