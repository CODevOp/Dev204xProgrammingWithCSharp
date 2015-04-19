using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // I contemplated using structs to represent the student information but decided against it.
            //Student data
            string studentFirstName;
            string studentLastName;
            DateTime studentBirthdate;
            string studentAddressLine1;
            string studentAddressLine2;
            string studentCity;
            string studentStateProvince;
            int studentZipPostal;
            string studentCountry;
            double studentGpa;
            string studentEmail;

            //professor data
            string professorFirstName;
            string professorLastName;
            string professorEmail;
            //Use an array as another way to structure the data
            string[] professorCoursesTaught;

            //School data
            string universityName;
            string universityProgram;


            studentFirstName = "Bob";
            studentLastName = "Miller";
            studentBirthdate = new DateTime(1995, 11, 17);
            studentAddressLine1 = "1234 1st Street";
            studentAddressLine2 = "A";
            studentCity = "City Ville";
            studentStateProvince = "CO";
            studentZipPostal = 80010;
            studentCountry = "USA";
            studentGpa = 4.0;
            studentEmail = "Bob.Miller@g.com";


            professorFirstName = "William";
            professorLastName = "Henderson";
            professorEmail = "WHenderson@mySchool.edu";
            //instantiate and populate array
            professorCoursesTaught = new string[] { "CIS 1010", "CIS 1080" };

            universityName = "My School U";
            universityProgram = "Computer Information Systems";

            //student outputs
            Console.WriteLine("Student");
            Console.WriteLine("\tName: {0} {1}", studentFirstName, studentLastName);
            Console.WriteLine("\tGPA: {0}", studentGpa);
            Console.WriteLine("\tDOB: {0}", studentBirthdate.ToShortDateString());
            Console.WriteLine("\tEmail: {0}", studentEmail);
            Console.WriteLine("\t{0}", studentAddressLine1);
            Console.WriteLine("\t{0}", studentAddressLine2);
            Console.WriteLine("\t{0}, {1} {2}", studentCity, studentStateProvince, studentZipPostal);
            Console.WriteLine("\t{0}", studentCountry);

            //profesor outputs
            Console.WriteLine("Professor");
            Console.WriteLine("\tName: {0} {1}", professorFirstName, professorLastName);
            Console.WriteLine("\tEmail: {0}", professorEmail);
            Console.WriteLine("\tCourses Taught:");
            
            // loop through each item in the array printing on seperate lines.
            foreach (string course in professorCoursesTaught.ToList())
            {
                Console.WriteLine("\t- {0}", course);
            }

            // School outputs
            Console.WriteLine("School/University");
            Console.WriteLine("\t{0}", universityName);
            Console.WriteLine("\t{0}", universityProgram);

            /// wait for response before exiting
            Console.ReadLine();


        }
        public struct Student
        {
            public string firstName;
            public string lastName;
            public DateTime birthdate;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string StateProvince;
            public int zipPostal;
            public string Country;
            public double gpa;
        }
        public struct Professor
        {
            string firstName;
            string lastName;
            DateTime birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string StateProvince;
            int zipPostal;
            string Country;
            string[] degrees;
            string[] articles;

        }
        //public struct 

        //    A university degree with pertinent fields such as Bachelor or Master
        //    A degree can be Bachelor of Science in Information Technology and include fields such as Degree Name, credits required, etc.  Some of the fields, such as course list and prerequisites will need to wait until you know how to create arrays or collections.
        //    A university program with pertinent fields such as Computer Science or Arts.  Fields might include:
        //    Program name
        //    Degrees offered (Bachelor, Master, Ph.D.)
        //    Department Head
        //    Information for a course that would be part of your selected degree and program, with pertinent fields
    }
}
