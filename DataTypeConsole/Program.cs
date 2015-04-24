using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataTypeConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //collect data for Student and print to screen
            GetStudentData();

            //collect data for Professor and print to screen
            GetProfessorData();

            //collect data for University and Program and print to screen
            GetUniversityData();

            //valide Student Birthday
            ValidateStudentBirthday(new DateTime());
            
            /// wait for response before exiting
            Console.ReadLine();
        }
       /// <summary>
       /// collect data for Student and print to screen
       /// </summary>
        private static void GetStudentData()
        {
            //Student data
            string studentFirstName;
            string studentLastName;
            DateTime? studentBirthdate = null;
            string studentAddressLine1;
            string studentAddressLine2;
            string studentCity;
            string studentStateProvince;
            int studentZipPostal;
            string studentCountry;
            double studentGpa;
            string studentEmail;

            Console.WriteLine("Enter Student First Name.");
            studentFirstName = Console.ReadLine(); // Bob
            Console.WriteLine("Enter Student Last Name.");
            studentLastName = Console.ReadLine(); // "Miller"
            
            //loop until the user enters a valid date format
            while(!studentBirthdate.HasValue)
            {                
                try // wrap the set studenBirthdate in a try catch until a datetime is a proper date.
                {
                    Console.WriteLine("Enter Student Birthdate (MM/DD/YYYY).");
                    studentBirthdate = DateTime.Parse(Console.ReadLine()); // new DateTime(1995, 11, 17);
                }
                catch//(InvalidCastException invalidCast)
                {
                    Console.WriteLine("An invalid value was entered, please try again.");
                }
            }
            
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
        /// <summary>
        /// collect data for Professor data and print to screen
        /// </summary>
        private static void GetProfessorData()
        {
            //professor data
            string professorFirstName;
            string professorLastName;
            string professorEmail = "";
            
            //use regular expression to confirm email is in the correct format
            //[\w] a set of word characters, + 1 or more {2,3} between 2 and 3 characters
            //regular expression references http://download.microsoft.com/download/D/2/4/D240EBF6-A9BA-4E4F-A63F-AEB6DA0B921C/Regular%20expressions%20quick%20reference.docx
            //https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex%28v=vs.110%29.aspx
            string emailPattern = @"[\w]+@[\w.]+.[\w]{2,3}";
            
            //Use an array as another way to structure the data
            string[] professorCoursesTaught;
            Console.WriteLine("Enter Professor First Name.");
            professorFirstName = Console.ReadLine(); // "William";

            Console.WriteLine("Enter Professor LastName Name.");
            professorLastName = Console.ReadLine(); // "Henderson";

            //loop until user enters a valid email address
            while(!Regex.IsMatch(professorEmail, emailPattern)){
                Console.WriteLine("Enter Professor Email (name@domain.com).");
                professorEmail = Console.ReadLine(); // "WHenderson@mySchool.edu";
                if (Regex.IsMatch(professorEmail, emailPattern)) 
                {
                    Console.WriteLine("An invalid value was entered, please try again.");
                }

            }
            
            //instantiate and populate array
            professorCoursesTaught = new string[] { "CIS 1010", "CIS 1080" };

            PrintProfessorData(professorFirstName, professorLastName, professorEmail, professorCoursesTaught);
        }
        /// <summary>
        /// Collect and print University and Program Data
        /// </summary>
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
        /// <summary>
        /// Print Student data
        /// </summary>
        /// <param name="studentFirstName"></param>
        /// <param name="studentLastName"></param>
        /// <param name="studentBirthdate"></param>
        /// <param name="studentAddressLine1"></param>
        /// <param name="studentAddressLine2"></param>
        /// <param name="studentCity"></param>
        /// <param name="studentStateProvince"></param>
        /// <param name="studentZipPostal"></param>
        /// <param name="studentCountry"></param>
        /// <param name="studentGpa"></param>
        /// <param name="studentEmail"></param>
        private static void PrintStudentData(string studentFirstName, string studentLastName, DateTime? studentBirthdate, string studentAddressLine1, string studentAddressLine2, string studentCity, string studentStateProvince, int studentZipPostal, string studentCountry, double studentGpa, string studentEmail)
        {

            //student outputs
            Console.WriteLine("Student");
            Console.WriteLine("\tName: {0} {1}", studentFirstName, studentLastName);
            Console.WriteLine("\tGPA: {0}", studentGpa);
            Console.WriteLine("\tDOB: {0}", ((DateTime)studentBirthdate).ToShortDateString());
            Console.WriteLine("\tEmail: {0}", studentEmail);
            Console.WriteLine("\t{0}", studentAddressLine1);
            Console.WriteLine("\t{0}", studentAddressLine2);
            Console.WriteLine("\t{0}, {1} {2}", studentCity, studentStateProvince, studentZipPostal);
            Console.WriteLine("\t{0}", studentCountry);
        }
        /// <summary>
        /// Print Professor Data
        /// </summary>
        /// <param name="professorFirstName"></param>
        /// <param name="professorLastName"></param>
        /// <param name="professorEmail"></param>
        /// <param name="professorCoursesTaught"></param>
        private static void PrintProfessorData(string professorFirstName, string professorLastName, string professorEmail, string[] professorCoursesTaught)
        {
            //profesor outputs
            Console.WriteLine("Professor");
            Console.WriteLine("\tName: {0} {1}", professorFirstName, professorLastName);
            Console.WriteLine("\tEmail: {0}", professorEmail);
            Console.WriteLine("\tCourses Taught:");
            PrintSubItems(professorCoursesTaught);
        }
        /// <summary>
        /// Print Unviersity and Program Data
        /// </summary>
        /// <param name="universityName"></param>
        /// <param name="universityProgram"></param>
        /// <param name="programCoreCourses"></param>
        /// <param name="programElectiveCourses"></param>
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
        /// <summary>
        /// Print an array of items.
        /// </summary>
        /// <param name="arrayOfSubItems"></param>
        private static void PrintSubItems(string[] arrayOfSubItems)
        {
            // loop through each item in the array printing on seperate lines.
            foreach (string subItem in arrayOfSubItems.ToList())
            {
                Console.WriteLine("\t** {0}", subItem);
            }
        }
        /// <summary>
        /// Confirm the Students DOB is valid
        /// </summary>
        /// <param name="studentDateOfBirth"></param>
        /// <returns></returns>
        private static Boolean ValidateStudentBirthday(DateTime studentDateOfBirth)
        {
            throw new NotImplementedException("The ValidateStudenBirthday Method has not been implemented.");
        }
    }
}
