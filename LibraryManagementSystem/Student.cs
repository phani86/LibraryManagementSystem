/* Student.cs
 Student Class which registers a new student into LibraryManagementSystem. 
 
 Revision History
                Srinivasa Phanindra Valluri, Puneet Kalva 2013.07.31: Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    //Student class inheriting from User Super Class.
    class Student:User
    {
        //Empty student object calls this constructor
        public Student() {}

        //Student object calls this constructor
        public Student(string id, string forename, string surname, string password)
        {

            this.ID = id;
            this.Forename = forename;
            this.Surname = surname; 
            this.Password = password;

         }
    }
}
