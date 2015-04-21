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

            GetStudentData();

            GetProfessorData();

            GetUniversityData();

            //ValidateStudenBirthday(new DateTime());
            
            /// wait for response before exiting
            Console.ReadLine();
        }

        private static void GetStudentData()
        {
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
            PrintStudentData(studentFirstName, studentLastName, studentBirthdate, studentAddressLine1, studentAddressLine2, studentCity, studentStateProvince, studentZipPostal, studentCountry, studentGpa, studentEmail);
        }
        private static void GetProfessorData()
        {
            //professor data
            string professorFirstName;
            string professorLastName;
            string professorEmail;
            //Use an array as another way to structure the data
            string[] professorCoursesTaught;
            professorFirstName = "William";
            professorLastName = "Henderson";
            professorEmail = "WHenderson@mySchool.edu";
            //instantiate and populate array
            professorCoursesTaught = new string[] { "CIS 1010", "CIS 1080" };

            PrintProfessorData(professorFirstName, professorLastName, professorEmail, professorCoursesTaught);
        }
        private static void GetUniversityData()
        {
            //School data
            string universityName;
            string universityProgram;
            string[] programCoreCourses;
            string[] programElectiveCourses;

            universityName = "Colorado State University";
            universityProgram = "CIS Graduate Program";

            programCoreCourses = new string[]{
            "CIS600 - IT and Project Management",
            "CIS601 - Enterprise Computing & Systems Integration",
            "CIS605 - Business Visual Application Development",
            "CIS606 - Application Software Infrastructure",
            "CIS610 - Software Development Methodology",
            "CIS611 - Object-Oriented Systems",
            "CIS620 - IT Communication Infrastructure",
            "CIS655 - Business Database Systems",
            "CIS665 - E-Business Application Technology",
            };

            programElectiveCourses = new string[] {
            "BUS690C - Agile Project Management with Scrum",
            "BUS690C - Information Technology Management",
            "BUS690C - Data Visualization and Manipulation",
            "BUS690C - Advanced Networking and Security",
            "CIS570 - Business Intelligence",
            "CIS575 - Applied Data Mining and Analytics in Business",
            "CIS670 - Advanced Project Management and Preparation for the PMP Exam",
            "CIS680A1 - Data, Systems and Network Security",
            "CIS695 - Professional Project or Paper",
            };
            
            PrintUniversityData(universityName, universityProgram, programCoreCourses, programElectiveCourses);
        }

        private static void PrintStudentData(string studentFirstName, string studentLastName, DateTime studentBirthdate, string studentAddressLine1, string studentAddressLine2, string studentCity, string studentStateProvince, int studentZipPostal, string studentCountry, double studentGpa, string studentEmail)
        {

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
        }
        private static void PrintProfessorData(string professorFirstName, string professorLastName, string professorEmail, string[] professorCoursesTaught)
        {
            //profesor outputs
            Console.WriteLine("Professor");
            Console.WriteLine("\tName: {0} {1}", professorFirstName, professorLastName);
            Console.WriteLine("\tEmail: {0}", professorEmail);
            Console.WriteLine("\tCourses Taught:");
            PrintSubItems(professorCoursesTaught);
        }
        private static void PrintUniversityData(string universityName, string universityProgram, string[] programCoreCourses, string[] programElectiveCourses)
        {
            // School outputs
            Console.WriteLine("School/University");
            Console.WriteLine("\t{0}", universityName);
            Console.WriteLine("\t{0}", universityProgram);
            Console.WriteLine("Core Courses");
            PrintSubItems(programCoreCourses);
            Console.WriteLine("Elective Courses");
            PrintSubItems(programElectiveCourses);

        }
        private static void PrintSubItems(string[] arrayOfSubItems)
        {
            // loop through each item in the array printing on seperate lines.
            foreach (string subItem in arrayOfSubItems.ToList())
            {
                Console.WriteLine("\t** {0}", subItem);
            }
        }
        private static Boolean ValidateStudenBirthday(DateTime studentDateOfBirth)
        {
            throw new NotImplementedException("The ValidateStudenBirthday Method has not been implemented.");
        }
    }
}
