using System;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate three Student objects.
            Student[] students = new Student[3];
            students[0] = new Student("George", "Harrison", new DateTime(1985,05,05), "George.Harrison@edx.edu", 3.0 );
            students[1] = new Student("Henry", "Lade", new DateTime(1986,06,023), "Henry.Lade@edx.edu", 3.3 );
            students[2] = new Student("Lisa", "Stackton", new DateTime(1983,10,05), "Lisa.Stackton@edx.edu", 3.9 );
            
            //Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#");
            
            //Add your three students to this Course object.
            course.Students = students;

            //Instantiate at least one Teacher object.            
            Teacher teacher = new Teacher("Eric", "Jordan", "Eric.Jordan@dedx.edu", new string[]{"Programming with C#"});
            
            //Add that Teacher object to your Course object
            course.Teachers[0] = teacher;

            //Instantiate a Degree object, such as Bachelor.
            Degree degree = new Degree("Masters of Science");

            //Add your Course object to the Degree object.
            degree.Course = course;

            //Instantiate a UProgram object called Information Technology.
            UProgram uprogram  = new UProgram("Computer Science");

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
    /// <summary>
    /// This is from the Student.cs file
    /// </summary>
    public class Student
    {
        #region fields
        //field members are private by default
        string _studentFirstName;
        string _studentLastName;
        DateTime? _studentBirthdate;
        double _studentGpa;
        string _studentEmail;
        static int _studentCount; //count of every student created.        
        #endregion
        #region properties
        public string StudentFirstName
        {
            get { return _studentFirstName; }
            set { _studentFirstName = value; }
        }
        public string StudentLastName
        {
            get { return _studentLastName; }
            set { _studentLastName = value; }
        }
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
        public string StudentEmail
        {
            get { return _studentEmail; }
            set { _studentEmail = value; }
        }
        public static int StudentCount
        {
            get { return Student._studentCount; }
        }
        #endregion
        #region Constructor
        public Student(string studentFirstName, string studentLastName, DateTime? studentBirthdate, string studentEmail, double studentGpa)
        {
            this.StudentFirstName = studentFirstName;
            this.StudentLastName = studentLastName;
            this.StudentBirthdate = studentBirthdate;
            this.StudentEmail = studentEmail;
            this.StudentGpa = studentGpa;
            _studentCount++;

        }
       
        #endregion

    }
    /// <summary>
    /// this is from the Professor.cs file
    /// </summary>
    public class Teacher
    {
        #region Fields
        private string _professorFirstName;
        private string _professorLastName;
        private string _professorEmail;
        private string[] _professorCoursesTaught;


        #endregion
        #region Properties
        public string ProfessorFirstName
        {
            get { return _professorFirstName; }
            set { _professorFirstName = value; }
        }
        public string ProfessorLastName
        {
            get { return _professorLastName; }
            set { _professorLastName = value; }
        }

        public string ProfessorEmail
        {
            get { return _professorEmail; }
            set { _professorEmail = value; }
        }
        public string[] ProfessorCoursesTaught
        {
            get { return _professorCoursesTaught; }
            set { _professorCoursesTaught = value; }
        }
        #endregion
        #region Constructor

        public Teacher(string firstName, string lastName, string email, string[] professorCoursesTaught)
        {
            this._professorFirstName = firstName;
            this._professorLastName = lastName;
            this._professorEmail = email;
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