/* Login.cs
 Login Class which validates the login of user.
 
 Revision History
                Srinivasa Phanindra Valluri, Puneet Kalva 2013.07.31: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    //Login Class taking input through get and set methods.
    class Login
    {
        private static string id;
        private static string password;
        
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //Empty login object calls this constructor.
        public Login() { }

        //Login object calls this constructor.
        public Login(string id, string password)
        {
            this.ID = id;
            this.Password = password;
        }
    }
}

