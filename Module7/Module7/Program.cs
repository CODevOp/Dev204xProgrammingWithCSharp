using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
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
            //Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#");

            //Add your three students to this Course object.
            course.Students.Add(new Student("George", "Harrison", new DateTime(1985, 05, 05), "George.Harrison@edx.edu", 3.0));
            course.Students.Add(new Student("Henry", "Lade", new DateTime(1986, 06, 023), "Henry.Lade@edx.edu", 3.3));
            course.Students.Add(new Student("Lisa", "Stackton", new DateTime(1983, 10, 05), "Lisa.Stackton@edx.edu", 3.9));
            

            //Instantiate at least one Teacher object.            
            Teacher teacher = new Teacher("Eric", "Jordan", "Eric.Jordan@dedx.edu", new string[] { "Programming with C#" });

            //Add that Teacher object to your Course object
            course.Teachers.Add(teacher);

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
            Console.WriteLine("The {0} course contains {1} student(s)", uprogram.Degree.Course.CourseName, course.Students.Count);
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
            this.Teachers = new ArrayList();
            this.Students = new ArrayList();
        }
        #endregion
        #region Fields
        private string _courseName;
        private ArrayList _teacher;
        private ArrayList _students;
        #endregion
        #region Properties
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        public ArrayList Teachers
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public ArrayList Students
        {
            get { return _students; }
            set { _students = value; }
        }
        #endregion
    }
}
