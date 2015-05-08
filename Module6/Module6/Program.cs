//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Person
//    {
//        public static int pCount = 0;
//        string firstName;
//        string lastName;
//        string address;
//        string city;
//        string country;

//        public void printInformation()
//        {
//            Console.WriteLine("First Name: {0}", this.firstName);
//            Console.WriteLine("Last Name: {0}", this.lastName);
//            Console.WriteLine("Address: {0}", this.address);
//            Console.WriteLine("City: {0}", this.city);
//            Console.WriteLine("Country: {0}", this.country);
//        }

//        public string Country { get { return country; } set { this.country = value; } }
//        public string Address { get { return address; } set { this.address = value; } }
//        public string City { get { return city; } set { this.city = value; } }
//        public string LastName { get { return lastName; } set { this.lastName = value; } }
//        public string FirstName { get { return firstName; } set { this.firstName = value; } }

//        public Person(string fname, string lname, string addr, string city, string country)
//        {
//            this.country = country;
//            this.firstName = fname;
//            this.lastName = lname;
//            this.address = addr;
//            this.city = city;
//            pCount++;
//        }

//        public Person()
//        {
//            pCount++;
//        }

//    }

//    public class Student : Person
//    {
//        private float Grade;
//        private string studentID;

//        public void takeTest(string subject)
//        {
//            Console.WriteLine("Taking test on {0}", subject);
//        }

//        public float getGraded { get { return Grade; } set { this.Grade = value; } }
//        public string StudentID { get { return studentID; } set { this.studentID = value; } }

//    }

//    public class Teacher : Person
//    {
//        private string degree;
//        private string subject;

//        public void GradeTest(string studentId)
//        {
//            Console.WriteLine("Grading examination script of {0} Id'd student", studentId);
//        }

//        public string getSetDegree { get { return degree; } set { this.degree = value; } }
//        public string getSetSubject { get { return subject; } set { this.subject = value; } }

//    }

//    class Course
//    {
//        public static int i = 0;
//        int length;
//        public string courseName;
//        Student[] courseStudents;
//        Teacher courseTeacher;

//        public Course(int len, string courseName)
//        {
//            this.courseName = courseName;
//            this.length = len;
//            this.studentInit();
//            this.teacherInit();
//        }

//        void studentInit()
//        {
//            courseStudents = new Student[length];

//            for (int l = 0; l < length; l++)
//            {
//                courseStudents[l] = new Student();
//            }
//        }

//        void teacherInit()
//        {
//            courseTeacher = new Teacher();
//        }

//        public void setStudents(Student student)
//        {
//            this.courseStudents[i] = student;
//            i++;
//        }

//        public void setTeacher(Teacher t)
//        {
//            this.courseTeacher = t;
//        }

//        public Student getStudent(int index)
//        {
//            if (index < i && index > 0) return this.courseStudents[index];
//            else return null;
//        }

//    }

//    class Degree
//    {
//        string degreeName;
//        public Course courseObject;

//        public Degree(string degreeName)
//        {
//            this.degreeName = degreeName;
//        }

//        public void setCourseObject(Course course)
//        {
//            this.courseObject = course;
//        }

//        public string getDegreeName()
//        {
//            return degreeName;
//        }
//    }

//    class UProgram
//    {
//        private string uProgramname1;
//        Degree uprog_degree;

//        public string uProgramName
//        {
//            get
//            {
//                return uProgramname1;
//            }

//            set
//            {
//                uProgramname1 = value;
//            }
//        }

//        public Degree degree_uprogram
//        {
//            get
//            {
//                return uprog_degree;
//            }

//            set
//            {
//                uprog_degree = value;
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student[] students = new Student[3];
//            Student test = new Student();

//            Teacher teacher = new Teacher();
//            Course course = new Course(students.Length, "Programming with C#");
//            course.setTeacher(teacher);
//            for (int i = 0; i < students.Length; i++)
//            {
//                course.setStudents(students[i]);
//            }

//            Degree degree = new Degree("Bachelor of Science Degree");
//            degree.setCourseObject(course);

//            UProgram uprogram = new UProgram();
//            uprogram.uProgramName = "Information Technology Program";
//            uprogram.degree_uprogram = degree;

//            Console.WriteLine("The {0} contains the {1}\n", uprogram.uProgramName, uprogram.degree_uprogram.getDegreeName());
//            Console.WriteLine("The {0} contains the course {1}\n", degree.getDegreeName(), degree.courseObject.courseName);
//            Console.WriteLine("The {0} contains {1} student(s)", degree.courseObject.courseName, Course.i);

//        }
//    }
//}
////****************************************************
////Course.cs
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework6
//{
//    public class Course
//    {
//        // private member variable and public accessor to hold course
//        private string _course;
//        public string Course1
//        {
//            get { return _course; }
//            set { _course = value; }
//        }

//        Student[] studentArray = new Student[3]; // array of size 3 to hold student objects
//        Teacher[] teacherArray = new Teacher[3]; // array of size 3 to hold teacher objects

//        // Course constructor
//        public Course()
//        {
//            this.Course1 = "Programming with C#";
//        }

//        // method to add a student to a course
//        public void AddStudentToCourse(Student student)
//        {
//            studentArray[Student.countStudents - 1] = student;
//        }

//        // method to add a student to a course
//        public void AddTeacherToCourse(Teacher teacher)
//        {
//            teacherArray[0] = teacher;
//        }
//    }
//}

////****************************************************
////Degree.cs
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Homework6
//{
//    public class Degree
//    {
//        // private member variable and public accessor to hold degree
//        private string _degree;
//        public string Degree1
//        {
//            get { return _degree; }
//            set { _degree = value; }
//        }

//        // constructor to assign degree
//        public Degree()
//        {
//            this.Degree1 = "Bachelor of Science";
//        }

//        // degree has this course
//        public string hasThisCourse;
//        public void AddCourseToDegree(string course)
//        {
//            this.hasThisCourse = course;
//        }
//    }
//}

////****************************************************
////Person.cs
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Homework6
//{
//    public abstract class Person
//    {
//        // declaring private member variables and their public accessors
//        // these are inherited by student and teacher classes
//        private string Name;
//        public string Name1
//        {
//            get { return Name; }
//            set { Name = value; }
//        }

//        private string Address;
//        public string Address1
//        {
//            get { return Address; }
//            set { Address = value; }
//        }

//        // constructor
//        // inherited by student and teacher classes
//        public Person(string Name, string Address)
//        {
//            this.Name1 = Name;
//            this.Address1 = Address;
//        }
//    }
//}

////****************************************************
////Program.cs
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Homework6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var uProgram1 = new UProgram(); // instantiate a program
//            var degree1 = new Degree(); // instantiate a degree
//            var course1 = new Course(); // instantiate a course

//            //instantiate 3 students with their details
//            var student1 = new Student("Daniel Sturridge", "147 Ainsadale Road, Leicester, UK");
//            var student2 = new Student("Wayne Rooney", "100 London Road, Leicester, UK");
//            var student3 = new Student("David Beckham", "1 Loughborough Road, Leicester, UK");
////var student4 = new Student("David Beckham", "1 Loughborough Road, Leicester, UK");

//            //instantiate teacher
//            var teacher1 = new Teacher("Prof. Plum", "No. 1, The Drawing Room");

//            // add 3 students to course
//            course1.AddStudentToCourse(student1);
//            course1.AddStudentToCourse(student2);
//            course1.AddStudentToCourse(student3);

//            course1.AddTeacherToCourse(teacher1); // add teacher to course
//            degree1.AddCourseToDegree(course1.Course1); // add the course to the degree
//            uProgram1.AddDegreeToUProgram(degree1.Degree1); // add degree to program

//            // write the output
//            Console.WriteLine("The {0} program contains the {1} degree.", uProgram1.uProgram1, uProgram1.hasThisDegree);
//            Console.WriteLine();
//            Console.WriteLine("The {0} degree contains the {1} course.", degree1.Degree1, degree1.hasThisCourse);
//            Console.WriteLine();
//            Console.WriteLine("The {0} course contains {1} student(s).", course1.Course1, Student.countStudents);
//            //Console.WriteLine(student3.Name1); // test
//            //Console.WriteLine(teacher1.Name1); // test
//            Console.WriteLine();
//            Console.WriteLine("Press any key to continue...");
//            Console.ReadLine();
//        }
//    }
//}

////****************************************************
////Student.cs
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Homework6
//{
//    public class Student : Person
//    {
//        // static member variable to count the number of students
//        public static int countStudents = 0;

//        // constructor
//        public Student(string Name, string Address)
//            : base(Name, Address)
//        {
//            countStudents++; //increment the student count every time a student object is created
//        }

//        // method specific to students
//        public void TakeTest()
//        {

//        }
//    }
//}

////****************************************************
////Teacher.cs
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Homework6
//{
//    public class Teacher : Person
//    {
//        // constructor
//        public Teacher(string Name, string Address)
//            : base(Name, Address)
//        { }

//        // method specific to teachers
//        public void MakeTest()
//        {

//        }
//    }
//}

////****************************************************
////UProgram.cs
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Homework6
//{
//    public class UProgram
//    {
//        //private program variable with public member variable to hold program
//        private string _uProgram;
//        public string uProgram1
//        {
//            get { return _uProgram; }
//            set { _uProgram = value; }
//        }

//        //program constructor to assign program
//        public UProgram()
//        {
//            this.uProgram1 = "Information Technology";
//        }

//        public string hasThisDegree;
//        public void AddDegreeToUProgram(string degree)
//        {
//            this.hasThisDegree = degree;
//        }
//    }
//}

using System;

namespace Module6
{
    class Program
    {
        /*
         * What other objects could benefit from inheritance in this code?
         *  There could be base interface for courses inhereted by Teacher who teaches multipel courses and Degree
         *  that has many courses. Students take courses. 
         * Can you think of a different hierarchy for the Person, Teacher, and Student?  What is it?
         * Teacher could inherit Student who obtained a degree. Student could inheret Person. 
         *  
         * */
        static void Main(string[] args)
        {
            //Instantiate three Student objects.
            Student[] students = new Student[3];
            students[0] = new Student("George", "Harrison", new DateTime(1985, 05, 05), "George.Harrison@edx.edu", 3.0);
            students[1] = new Student("Henry", "Lade", new DateTime(1986, 06, 023), "Henry.Lade@edx.edu", 3.3);
            students[2] = new Student("Lisa", "Stackton", new DateTime(1983, 10, 05), "Lisa.Stackton@edx.edu", 3.9);

            //Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#");

            //Add your three students to this Course object.
            course.Students = students;

            //Instantiate at least one Teacher object.            
            Teacher teacher = new Teacher("Eric", "Jordan", "Eric.Jordan@dedx.edu", new string[] { "Programming with C#" });

            //Add that Teacher object to your Course object
            course.Teachers[0] = teacher;

            //Instantiate a Degree object, such as Bachelor.
            Degree degree = new Degree("Masters of Science");

            //Add your Course object to the Degree object.
            degree.Course = course;

            //Instantiate a UProgram object called Information Technology.
            UProgram uprogram = new UProgram("Computer Science");

            //Add the Degree object to the UProgram object.
            uprogram.Degree = degree;

            //The name of the program and the degree it contains
            Console.WriteLine("The {0} program contains the {1} degree\n", uprogram.ProgramName, uprogram.Degree.DegreeName);
            //The name of the course in the degree
            Console.WriteLine("The {0} degree contains the course {1}\n", uprogram.Degree.DegreeName, uprogram.Degree.Course.CourseName);
            //The count of the number of students in the course.
            Console.WriteLine("The {0} course contains {1} student(s)", uprogram.Degree.Course.CourseName, Student.StudentCount);
        }
    }

    public class Person
    {
        string _firstName;
        string _lastName;
        string _emailAddress;


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        #region Constructor
        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = email;

        }

        #endregion

    }

    public class Student : Person
    {
        DateTime? _studentBirthdate;
        double _studentGpa;
        static int _studentCount; //count of every student created.     

        public DateTime? StudentBirthdate
        {
            get { return _studentBirthdate; }
            set { _studentBirthdate = value; }
        }
        public double StudentGpa
        {
            get { return _studentGpa; }
            set { _studentGpa = value; }
        }
        public static int StudentCount
        {
            get { return Student._studentCount; }
        }
        public void TakeTest()
        {
            Console.WriteLine("Student taking test!");
        }

        #region Constructor
        public Student(string firstName, string lastName, DateTime? studentBirthdate, string studentEmail, double studentGpa)
            : base(firstName, lastName, studentEmail)
        {
            this.StudentBirthdate = studentBirthdate;
            this.StudentGpa = studentGpa;
            _studentCount++;
        }

        #endregion

    }
    public class Teacher : Person
    {

        private string[] _professorCoursesTaught;

        public string[] ProfessorCoursesTaught
        {
            get { return _professorCoursesTaught; }
            set { _professorCoursesTaught = value; }
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacther grading test!");

        }
        #region Constructor

        public Teacher(string firstName, string lastName, string email, string[] professorCoursesTaught)
            : base(firstName, lastName, email)
        {
            this._professorCoursesTaught = professorCoursesTaught;
        }

        #endregion
    }

    /// <summary>
    /// this is the from the Upgrogram.cs
    /// </summary>
    public class UProgram
    {
        #region Constructor(s)
        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }
        #endregion
        #region Fields
        private string _universityName;
        private string _programName;
        private Degree degree;
        #endregion
        #region Properties
        public string ProgramName
        {
            get { return _programName; }
            set { _programName = value; }
        }
        public string UniversityName
        {
            get { return _universityName; }
            set { _universityName = value; }
        }
        /// <summary>
        /// In the future this will converted into an array. 
        /// I made it a single item based on course instructions
        /// </summary>
        public Degree Degree
        {
            get { return degree; }
            set { degree = value; }
        }


        #endregion

    }
    /// <summary>
    /// This is from Degree.cs
    /// </summary>
    public class Degree
    {
        #region Constructors
        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }
        #endregion
        #region fields
        string _degreeName;
        private Course _course;
        #endregion
        #region Properties
        public string DegreeName
        {
            get { return _degreeName; }
            set { _degreeName = value; }
        }
        public Course Course
        {
            get { return _course; }
            set { _course = value; }
        }
        #endregion
    }
    /// <summary>
    /// This is from Course.cs
    /// </summary>
    public class Course
    {
        #region Constructor
        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.Teachers = new Teacher[3];
            this.Students = new Student[3];
        }
        #endregion
        #region Fields
        private string _courseName;
        private Teacher[] _teacher;
        private Student[] _students;
        #endregion
        #region Properties
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        public Teacher[] Teachers
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }
        #endregion
    }

}
