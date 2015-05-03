//studen 3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment4
//{
//    class Program
//    {


//        struct Student
//        {

//            public string name, birthDate, course;// = new string[5];
//            public void getName()
//            {
//                Console.WriteLine("Student {0} DOB {1} studies {2} ", name, birthDate, course);
//                Console.ReadLine();
//            }

//        }
//        struct teacher
//        {
//            public string fullName { get; set; }
//            public string faculty { get; set; }
//            public string designation { get; set; }
//        }
//        struct program
//        {
//            private string programName, programLead;
//            private int programCredit;

//            public program(string pn, string pl, int pc)
//            {
//                this.programName = pn;
//                this.programLead = pl;
//                this.programCredit = pc;
//            }
//            public void display()
//            {
//                Console.WriteLine("{0} with credit {1} is lead by {2}", programName, programCredit, programLead);
//            }
//        }
//        struct course
//        {
//            private string name, department, code;

//            public course(string n, string d, string c)
//            {
//                this.name = n;
//                this.department = d;
//                this.code = c;
//            }
//            public void display()
//            {
//                Console.WriteLine("{0} with course code {1} in department {2}", name, code, department);
//            }
//        }
//        static void Main(string[] args)
//        {


//            Student[] s12 = new Student[5];

//            //int nStudent = int.Parse(Console.ReadLine());
//            for (int i = 0; i < 2; i++)
//            {
//                Console.WriteLine("Enter Name of Student {0}: ", i);
//                s12[i].name = Console.ReadLine();
//                Console.WriteLine("Enter Birth date of Students {0}: ", i);
//                s12[i].birthDate = Console.ReadLine();
//                Console.WriteLine("Enter Course of Students {0}: ", i);
//                s12[i].course = Console.ReadLine();
//                s12[i].getName();
//            }
//            //Console.WriteLine(" {0} DOB {1} studies {2}", s12.name[0], s12.birthDate[0], s12.course[0]);
//            teacher t1 = new teacher();
//            Console.WriteLine("Enter teacher Full Name");
//            t1.fullName = Console.ReadLine();
//            Console.WriteLine("Enter teacher Designation");
//            t1.designation = Console.ReadLine();
//            Console.WriteLine("Enter teacher Department");
//            t1.faculty = Console.ReadLine();
//            Console.WriteLine("{0} {1} teaches in {2} ", t1.designation, t1.fullName, t1.faculty);
//            program msc = new program("MIT", "John", 32);
//            msc.display();
//            course IT = new course("IT", "Electrical Engineering", "EE302");
//            IT.display();
//            Console.ReadKey();

//        }
//    }
//} 
////student 2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework_module_4
//{
//    struct student
//    {
//        public int id;
//        public string firstName;
//        public string lastName;
//        public DateTime birthdate;
//        public string address;
//        public string city;
//        public string StateProvince;
//        public string zipPostal;
//        public string country;
//    }
//    struct teacher
//    {
//        public string firstNameP;
//        public string lastNameP;
//        public int tel;
//    }
//    struct program
//    {
//        public string programName;
//        public string credit;
//    }
//    struct course
//    {
//        public string courseName;
//        public string degreeOffered;
//        public string department;
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            student[] studentArray = new student[5];

//            studentArray[0].id = 1;
//            studentArray[0].firstName = "Juan";
//            studentArray[0].lastName = "Marín";
//            DateTime date = new DateTime(1985, 12, 25, 00, 00, 0);
//            studentArray[0].birthdate = date;
//            studentArray[0].address = "Calle 33c";
//            studentArray[0].city = "Medellín";
//            studentArray[0].StateProvince = "Antioquia";
//            studentArray[0].zipPostal = "005";
//            studentArray[0].country = "Colombia";

//            Console.WriteLine("student ID: {0}", studentArray[0].id);
//            Console.WriteLine("student First Name: {0}", studentArray[0].firstName);
//            Console.WriteLine("student Last Name: {0}", studentArray[0].lastName);
//            Console.WriteLine("student Birthdate: {0}", studentArray[0].birthdate);
//            Console.WriteLine("student Address: {0}", studentArray[0].address);
//            Console.WriteLine("student City: {0}", studentArray[0].city);
//            Console.WriteLine("student State: {0}", studentArray[0].StateProvince);
//            Console.WriteLine("student ZIP: {0}", studentArray[0].zipPostal);
//            Console.WriteLine("student Country: {0}", studentArray[0].country);

//            Console.ReadKey();
//        }

//    }
//}

////student 1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //create arrays of size 5 for students
//            Student[] student = new Student[5];
//            Random rnd = new Random();
//            // Assign values to the fields in at least one of the student structs in the array
//            student[0].FirstName = "firstName0";
//            student[0].LastName = "lastName0";
//            student[0].Birthdate = new DateTime(rnd.Next(1989, 1998), rnd.Next(1, 13), rnd.Next(1, 28));
//            student[0].AddressLine1 = "addressLine1_0";
//            student[0].AddressLine2 = "addressLine2_0";
//            student[0].City = "city0";
//            student[0].Province = "province0";
//            student[0].ZipPostal = "zipPostal0";
//            student[0].Country = "country0";
//            //Assign values with Constructors
//            student[1] = new Student("firstName1", "lastName1", new DateTime(rnd.Next(1989, 1998), rnd.Next(1, 13), rnd.Next(1, 28)),
//            "addressLine1_1", "addressLine2_1", "city1",
//            "province1", "zipPostal1", "country1");

//            // assign the others with loop
//            for (int i = 2; i < 5; i++)
//            {
//                student[i] = new Student("firstName" + i, "lastName" + i, new DateTime(rnd.Next(1989, 1998), rnd.Next(1, 13), rnd.Next(1, 28)),
//                "addressLine1_" + i, "addressLine2_" + i, "city" + i,
//                "province" + i, "zipPostal" + i, "country" + i);
//            }

//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("----------- STUDENT {0} INFORMATION -----------", i + 1);
//                Console.WriteLine("First Name:{0} Last Name:{1} Birthdate:{2} Student's age: {3} ", student[i].FirstName, student[i].LastName, student[i].Birthdate, student[i].Age);
//                Console.WriteLine("Student's Address Line1: {0} ", student[i].AddressLine1);
//                Console.WriteLine("Student's Address Line2: {0} ", student[i].AddressLine2);
//                Console.WriteLine("Student's City: {0} ", student[i].City);
//                Console.WriteLine("Student's State: {0} ", student[i].Province);
//                Console.WriteLine("Student's Zip: {0} ", student[i].ZipPostal);
//                Console.WriteLine("Student's Country: {0} ", student[i].Country);
//            }
//            Console.WriteLine("Press any key to continue");
//            Console.ReadKey();
//        }
//    }

//    public struct Student
//    {
//        public static int enrolledStudent;
//        // private member variables
//        private DateTime _birthdate;

//        // public properties
//        public DateTime Birthdate
//        {
//            get
//            {
//                return _birthdate;
//            }
//            set
//            {
//                _birthdate = value;
//            }
//        }

//        // public read only properties	
//        public int Age
//        {
//            get
//            {
//                return ((int)(DateTime.Now - this._birthdate).Days) / 365;
//            }
//        }

//        // Auto-implemented properties
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string AddressLine1 { get; set; }
//        public string AddressLine2 { get; set; }
//        public string City { get; set; }
//        public string Province { get; set; }
//        public string ZipPostal { get; set; }
//        public string Country { get; set; }

//        // Constructors
//        public Student(string firstName, string lastName, DateTime birthdate,
//        string addressLine1, string addressLine2, string city,
//        string province, string zipPostal, string country)
//            : this()
//        {

//            this.FirstName = firstName;
//            this.LastName = lastName;
//            this.Birthdate = birthdate;
//            this.AddressLine1 = addressLine1;
//            this.AddressLine2 = addressLine2;
//            this.City = city;
//            this.Province = province;
//            this.ZipPostal = zipPostal;
//            this.Country = country;
//        }
//    }

//    public struct Teacher
//    {
//        // auto-implemented property
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public DateTime Birthdate { get; set; }
//        public string Role { get; set; }
//        public string Department { get; set; }
//        public string Email { get; set; }

//        // Constructors
//        public Teacher(string firstName, string lastName, DateTime birthdate,
//        string role, string department, string email)
//            : this()
//        {

//            this.FirstName = firstName;
//            this.LastName = lastName;
//            this.Birthdate = birthdate;
//            this.Role = role;
//            this.Department = department;
//            this.Email = email;

//        }

//        public Teacher(string firstName, string lastName)
//            : this()
//        {

//            this.FirstName = firstName;
//            this.LastName = lastName;
//        }
//    }

//    public struct Course
//    {
//        // auto-implemented property
//        public Student[] Student { get; set; }
//        public Teacher[] Teacher { get; set; }
//        public string CourseName { get; set; }
//        public int CourseCredit { get; set; }
//        public int CourseNumber { get; set; }
//        public string SemesterOffered { get; set; }

//        // Constructors
//        public Course(int courseNumber, string courseName, Student[] student, Teacher[] teacher, int courseCredit, string semesterOffered)
//            : this()
//        {
//            this.CourseNumber = courseNumber;
//            this.CourseName = courseName;
//            this.Student = student;
//            this.Teacher = teacher;
//            this.CourseCredit = courseCredit;
//            this.SemesterOffered = semesterOffered;
//        }

//        public Course(string courseName)
//            : this()
//        {
//            this.CourseName = courseName;
//        }
//    }

//    public struct Degrees
//    {
//        public Course Course { get; set; }
//        public string Schools { get; set; }
//        public string Degree { get; set; }
//        public string DegreesType { get; set; }
//        public int CreditsRequired { get; set; }
//        public decimal CumulativeGpa { get; set; }

//        // Constructors
//        public Degrees(string Degree)
//            : this()
//        {

//            this.Degree = Degree;
//        }

//        public Degrees(string degreesType, Course course, String schools, String degree, int creditsRequired, decimal cumulativeGpa)
//            : this()
//        {
//            this.DegreesType = degreesType;
//            this.Course = course;
//            this.Schools = schools;
//            this.Degree = degree;
//            this.CreditsRequired = creditsRequired;
//            this.CumulativeGpa = cumulativeGpa;
//        }
//    }

//    public struct UProgram
//    {
//        public Degrees Degrees { get; set; }
//        public string ProgramName { get; set; }

//        public UProgram(string programName, Degrees degrees)
//            : this()
//        {
//            this.ProgramName = programName;
//            this.Degrees = degrees;
//        }

//        public UProgram(string programName)
//            : this()
//        {
//            this.ProgramName = programName;
//        }

//    }
//}