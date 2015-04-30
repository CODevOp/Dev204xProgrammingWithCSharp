using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataTypeConsole
{
    class Program
    {
        #region Program Fields
        static Student[] studenList;
        static Professor professor;
        static UniversityProgram program;
        static Course course;
        #endregion
        static void Main(string[] args)
        {
            //collect data for Student and print to screen
            GenerateStudentData();

            //collect data for Professor and print to screen
            GenerateProfessorData();

            //collect data for University and Program and print to screen
            CollectProgramData();

            //collect Course data
            CollectCourseData();
            course.Print();

        }
        /// <summary>
        /// Struct to store Student Data
        /// </summary>        
        public struct Student
        {
            #region fields
            string studentFirstName;
            string studentLastName;
            string studentAddressLine1;
            string studentAddressLine2;
            string studentCity;
            string studentStateProvince;
            int studentZipPostal;
            DateTime? studentBirthdate;
            string studentCountry;
            double studentGpa;
            string studentEmail;

            #endregion
            #region properties
            public string StudentFirstName
            {
                get { return studentFirstName; }
                set { studentFirstName = value; }
            }
            public string StudentLastName
            {
                get { return studentLastName; }
                set { studentLastName = value; }
            }
            public DateTime? StudentBirthdate
            {
                get { return studentBirthdate; }
                set { studentBirthdate = value; }
            }
            public string StudentAddressLine1
            {
                get { return studentAddressLine1; }
                set { studentAddressLine1 = value; }
            }
            public string StudentAddressLine2
            {
                get { return studentAddressLine2; }
                set { studentAddressLine2 = value; }
            }
            public string StudentCity
            {
                get { return studentCity; }
                set { studentCity = value; }
            }
            public string StudentStateProvince
            {
                get { return studentStateProvince; }
                set { studentStateProvince = value; }
            }
            public int StudentZipPostal
            {
                get { return studentZipPostal; }
                set { studentZipPostal = value; }
            }
            public string StudentCountry
            {
                get { return studentCountry; }
                set { studentCountry = value; }
            }
            public double StudentGpa
            {
                get { return studentGpa; }
                set { studentGpa = value; }
            }
            public string StudentEmail
            {
                get { return studentEmail; }
                set { studentEmail = value; }
            }
            #endregion
            #region Constructor
            public Student(string studentFirstName, string studentLastName, DateTime? studentBirthdate, string studentEmail, double studentGpa, string studentAddressLine1, string studentAddressLine2, string studentCity, string studentStateProvince, int studentZipPostal, string studentCountry)
            {
                this.studentFirstName = studentFirstName;
                this.studentLastName = studentLastName;
                this.studentBirthdate = studentBirthdate;
                this.studentEmail = studentEmail;
                this.studentGpa = studentGpa;
                this.studentAddressLine1 = studentAddressLine1;
                this.studentAddressLine2 = studentAddressLine2;
                this.studentCity = studentCity;
                this.studentStateProvince = studentStateProvince;
                this.studentZipPostal = studentZipPostal;
                this.studentCountry = studentCountry;

            }
            #endregion
            #region Methods

            /// <summary>
            /// collect data for Student and print to screen
            /// </summary>
            public void CollectStudentData()
            {
                Console.WriteLine("\nCollect New StudentData");
                Console.WriteLine("\tFirst Name");
                StudentFirstName = Console.ReadLine(); // Bob
                Console.WriteLine("\tLast Name.");
                StudentLastName = Console.ReadLine(); // "Miller"

                //loop until the user enters a valid date format
                while (!studentBirthdate.HasValue)
                {
                    try // wrap the set studenBirthdate in a try catch until a datetime is a proper date.
                    {
                        Console.WriteLine("Birthdate (MM/DD/YYYY).");
                        StudentBirthdate = DateTime.Parse(Console.ReadLine()); // new DateTime(1995, 11, 17);
                    }
                    catch//(InvalidCastException invalidCast)
                    {
                        Console.WriteLine("An invalid value was entered, please try again.");
                    }
                }

                Console.WriteLine("\tAddress 1");
                StudentAddressLine1 = Console.ReadLine(); // "1234 1st Street";

                Console.WriteLine("\tAddress 2");
                StudentAddressLine2 = Console.ReadLine(); // "A";

                Console.WriteLine("\t City");
                StudentCity = Console.ReadLine(); // "City Ville";

                Console.WriteLine("\tState");
                StudentStateProvince = Console.ReadLine(); // "CO";

                StudentZipPostal = CollectZipPostal();

                Console.WriteLine("\tCountry");
                StudentCountry = Console.ReadLine(); // "USA";

                Console.WriteLine("\tGPA");
                StudentGpa = (int.Parse(Console.ReadLine())); // 4.0;

                StudentEmail = CollectEmail(); // "Bob.Miller@g.com";

            }


            /// <summary>
            /// Print Student data
            /// </summary>

            public void Print(int classNumber)
            {
                //student outputs
                Console.WriteLine("\nStudent {0}:", classNumber);
                Console.WriteLine("\tName: {0} {1}", studentFirstName, studentLastName);
                Console.WriteLine("\tGPA: {0}", studentGpa);
                Console.WriteLine("\tDOB: {0}", ((DateTime)studentBirthdate).ToShortDateString());
                Console.WriteLine("\tEmail: {0}", studentEmail);
                Console.WriteLine("\t{0}", studentAddressLine1);
                Console.WriteLine("\t{0}", studentAddressLine2);
                Console.WriteLine("\t{0}, {1} {2}", studentCity, studentStateProvince, studentZipPostal);
                Console.WriteLine("\t{0}", studentCountry);
            }
            internal static void PrintList(Student[] list)
            {
                for (int counter = 0; counter < list.Length; counter++)
                {
                    list[counter].Print(counter + 1);

                }
            }

            #endregion
        }
        /// <summary>
        /// Struct to store Professor Data
        /// </summary>
        public struct Professor
        {
            #region Fields
            private string professorFirstName;
            private string professorLastName;
            private string professorEmail;
            private string[] professorCoursesTaught;


            #endregion
            #region Properties
            public string ProfessorFirstName
            {
                get { return professorFirstName; }
                set { professorFirstName = value; }
            }
            public string ProfessorLastName
            {
                get { return professorLastName; }
                set { professorLastName = value; }
            }

            public string ProfessorEmail
            {
                get { return professorEmail; }
                set { professorEmail = value; }
            }
            public string[] ProfessorCoursesTaught
            {
                get { return professorCoursesTaught; }
                set { professorCoursesTaught = value; }
            }
            #endregion
            #region Constructor

            public Professor(string firstName, string lastName, string email, string[] professorCoursesTaught)
            {
                this.professorFirstName = firstName;
                this.professorLastName = lastName;
                this.professorEmail = email;
                this.professorCoursesTaught = professorCoursesTaught;
            }

            #endregion
            #region Methods
            public void CollectProfessorData()
            {

                Console.WriteLine("Enter Professor First Name.");
                ProfessorFirstName = Console.ReadLine(); // "William";

                Console.WriteLine("Enter Professor LastName Name.");
                ProfessorLastName = Console.ReadLine(); // "Henderson";

                ProfessorEmail = CollectEmail();

                //instantiate and populate array of courses
                Console.WriteLine("Enter the number of courses the professor teaches.");
                int numberOfCourses = int.Parse(Console.ReadLine());
                ProfessorCoursesTaught = new string[numberOfCourses];

                for (int counter = 0; counter < professorCoursesTaught.Length; counter++)
                {
                    Console.WriteLine("Enter course number {0}", counter + 1);
                    ProfessorCoursesTaught[counter] = Console.ReadLine();
                }
            }
            public void Print()
            {
                //profesor outputs
                Console.WriteLine("\nProfessor");
                Console.WriteLine("\tName: {0} {1}", professorFirstName, professorLastName);
                Console.WriteLine("\tEmail: {0}", professorEmail);
                Console.WriteLine("\tCourses Taught:");
                PrintSubItems(professorCoursesTaught);
            }
            #endregion
        }
        /// <summary>
        /// Struct to store Program Data
        /// </summary>
        public struct UniversityProgram
        {
            #region Properties
            public string UniversityName { get; set; }
            public string ProgramName { get; set; }
            public string[] ProgramCoreCourses { get; set; }
            public string[] ProgramElectiveCourses { get; set; }
            #endregion
            #region Methods
            public void Print()
            {
                // School outputs
                Console.WriteLine("\nSchool/University");
                Console.WriteLine("\t{0}", UniversityName);
                Console.WriteLine("\t{0}", ProgramName);
                Console.WriteLine("\nCore Courses");
                PrintSubItems(ProgramCoreCourses);
                Console.WriteLine("\nElective Courses");
                PrintSubItems(ProgramElectiveCourses);

            }
            #endregion
        }
        /// <summary>
        /// Struct to combine all data for a course
        /// </summary>
        public struct Course
        {
            #region Properties
            public string CourseName { get; set; }
            public Professor Professor { get; set; }
            public Student[] StudentList { get; set; }
            public UniversityProgram Program { get; set; }

            #endregion
            #region Constructor
            public Course(string courseName)
                : this()
            {
                CourseName = courseName;
            }
            #endregion
            #region Methods
            public void Print()
            {
                Console.Clear();
                Program.Print();
                Console.WriteLine("\n{0}", CourseName);
                Professor.Print();
                Student.PrintList(StudentList);

            }
            #endregion
        }

        #region Utility Methods
        /// <summary>
        /// Method to collect email type data
        /// </summary>
        /// <param name="emailPattern"></param>
        /// <returns></returns>
        private static string CollectEmail(string emailPattern = @"[\w]+@[\w.]+.[\w]{2,3}")
        {
            #region Reference
            //use regular expression to confirm email is in the correct format
            //[\w] a set of word characters, + 1 or more {2,3} between 2 and 3 characters
            //regular expression references http://download.microsoft.com/download/D/2/4/D240EBF6-A9BA-4E4F-A63F-AEB6DA0B921C/Regular%20expressions%20quick%20reference.docx
            //https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex%28v=vs.110%29.aspx

            #endregion

            string email = "";
            //loop until user enters a valid email address
            while (!Regex.IsMatch(email, emailPattern))
            {
                Console.WriteLine("\tEmail (name@domain.com).");
                email = Console.ReadLine(); // "WHenderson@mySchool.edu";
                if (Regex.IsMatch(email, emailPattern))
                {
                    Console.WriteLine("An invalid value was entered, please try again.");
                }

            }
            return email;
        }
        /// <summary>
        /// Methods to collect zip codes for all structs
        /// </summary>
        /// <returns></returns>
        private static int CollectZipPostal()
        {
            int zipPostal = int.MinValue;
            while (zipPostal == int.MinValue)
            {
                Console.WriteLine(@"\tZip Code\Province");
                try
                {
                    zipPostal = (int.Parse(Console.ReadLine())); // 80010;

                }
                catch
                {
                    Console.WriteLine(@"\nAn invalid value was entered, please try again.");
                }
            }
            return zipPostal;
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

        #region Create test data
        /// <summary>
        /// Collect and print University and Program Data
        /// </summary>
        private static void CollectProgramData()
        {
            program = new UniversityProgram();

            program.UniversityName = "Colorado State University";
            program.ProgramName = "CIS Graduate Program";

            program.ProgramCoreCourses = new string[]{
            "CIS600 - IT and Project Management",
            "CIS601 - Enterprise Computing & Systems Integration",
            "CIS602 - Microsoft: DEV204x Programming with C#",
            "CIS605 - Business Visual Application Development",
            "CIS606 - Application Software Infrastructure",
            "CIS610 - Software Development Methodology",
            "CIS611 - Object-Oriented Systems",
            "CIS620 - IT Communication Infrastructure",
            "CIS655 - Business Database Systems",
            "CIS665 - E-Business Application Technology",
            };

            program.ProgramElectiveCourses = new string[] {
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

        }
        private static void CollectCourseData()
        {
            course = new Course();
            course.Program = program;
            course.CourseName = "CIS602 - Microsoft: DEV204x Programming with C#";
            course.Professor = professor;
            course.StudentList = studenList;

        }
        private static void GenerateProfessorData()
        {
            professor = new Professor("George", "Wallace", "George.Wallace@edx.edu", new string[] { "CIS 1010", "CIS 1080", "CIS602 - Microsoft: DEV204x Programming with C#" });

        }
        private static void GenerateStudentData()
        {
            studenList = new Student[5];
            studenList[0] = new Student("Bob", "Jones", new DateTime(1990, 09, 05), "Bob.Jones@edx.edu", 3.5, "1234 100th Avenue", "", "Schoolville", "CA", 99999, "USA");
            studenList[1] = new Student("Henry", "O'Sage", new DateTime(1989, 09, 25), "Henry.Osage@edx.edu", 3.75, "912 Mexio Avenue", "A", "Schoolville", "CA", 99999, "USA");
            studenList[2] = new Student("Sally", "Smith", new DateTime(1991, 10, 15), "Sally.Smith.Jones@edx.edu", 3.0, "1234 100th Avenue", "", "Schoolville", "CA", 99999, "USA");
            studenList[3] = new Student("Janet", "Grosso", new DateTime(1992, 03, 08), "Janet.Grosso@edx.edu", 4.0, "51 9th Avenue", "", "Schoolville", "CA", 99999, "USA");
            studenList[4] = new Student("Samir", "Sade", new DateTime(1980, 05, 05), "Samir.Sade@edx.edu", 2.85, "9155 101st Street", "", "Schoolville", "CA", 99999, "USA");

        }
        #endregion

        #endregion

    }
}
