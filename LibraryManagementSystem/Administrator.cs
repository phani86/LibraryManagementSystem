/* Administrator.cs
 Administrator Class which registers administrator into LibrarymanagementSystem.
 
 Revision History
                Srinivasa Phanindra Valluri, Puneet Kalva 2013.07.31: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    class Administrator:User
    {
        //Empty Administrator object calls this constructor.
        public Administrator() { }

        //Administrator object calls this constructor
        public Administrator(string id, string forename, string surname, string password)
        {
            this.ID = id;
            this.Forename = forename;
            this.Surname = surname;
            this.Password = password;
        }
    }
}
