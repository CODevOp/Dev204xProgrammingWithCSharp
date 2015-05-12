using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod_9_Homework
{
    class Student
    {
        //txtFirstName.Text.ToString(), txtLastName.Text.ToString(), txtCity.Text.ToString()
        public string firstName;
        public string lastName;
        public string city;

        public Student(string p1, string p2, string p3)
        {
            // TODO: Complete member initialization
            this.firstName = p1;
            this.lastName = p2;
            this.city = p3;
        }
    }
}
