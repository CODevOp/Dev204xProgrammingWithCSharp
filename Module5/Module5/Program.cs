using System;

namespace Module5
{
    class Program
    {
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

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Module_Five_Assignment
//{
//    class Course
//    {
//        private string _name;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        private uint _studentIndex;

//        public uint StudentIndex
//        {
//            get { return _studentIndex; }
//            set { _studentIndex = value; }
//        }

//        private Student[] _studentArray = new Student[3];

//        internal Student[] StudentArray
//        {
//            get { return _studentArray; }
//            set { _studentArray = value; }
//        }

//        private uint _teacherIndex;

//        private Teacher[] _teacherArray = new Teacher[3];

//        internal Teacher[] TeacherArray
//        {
//            get { return _teacherArray; }
//            set { _teacherArray = value; }
//        }

//        public uint TeacherIndex
//        {
//            get { return _teacherIndex; }
//            set { _teacherIndex = value; }
//        }

//        public Course(string nm)
//        {
//            this.Name = nm;
//            this.StudentIndex = 0;
//            this.TeacherIndex = 0;
//        }

//        public void AddStudent(Student s)
//        {
//            this.StudentArray[StudentIndex] = s;
//            this.StudentIndex++;
//        }

//        public void AddTeacher(Teacher t)
//        {
//            this.TeacherArray[this.TeacherIndex] = t;
//            this.TeacherIndex++;
//        }
//    }
//}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Module_Five_Assignment
//{
//    class Degree
//    {
//        private string _name;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        private Course _course;

//        public Course Course
//        {
//            get { return _course; }
//            set { _course = value; }
//        }

//        public Degree(string n)
//        {
//            this.Name = n;
//        }

//        public void AddCourse(Course c)
//        {
//            this.Course = c;
//        }
//    }
//}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Module_Five_Assignment
//{
//    class Program
//    {
//        static void doWork()
//        {
//            /* 1. Instantiate three Student objects. */
//            Student studentOne = new Student("Seymour", "Butts");
//            Student studentTwo = new Student("Marcus", "Absent");
//            Student studentThree = new Student("Ivana", "Tinkle");

//            /* 2. Instantiate a Course object called "Programming with C#". */
//            Course course = new Course("Programming with C#");

//            /* 3. Add your three students to this Course object. */
//            course.AddStudent(studentOne);
//            course.AddStudent(studentTwo);
//            course.AddStudent(studentThree);

//            /* 4. Instantiate at least one Teacher object. */
//            Teacher teacherOne = new Teacher("Anne", "Teake");

//            /* 5. Add that Teacher object to your Course object. */
//            course.AddTeacher(teacherOne);

//            /* 6. Instantiate a Degree object, such as Bachelor. */
//            Degree bachelors = new Degree("Bachelors of Science");

//            /* 7. Add your Course object to the Degree object. */
//            bachelors.AddCourse(course);

//            /* 8. Instantiate a UProgram object called Information Technology. */
//            UProgram InformationTechnology = new UProgram("Information Technology");

//            /* 9. Add the Degree object to the UProgram object. */
//            InformationTechnology.AddDegree(bachelors);

//            /* 10. Using Console.WriteLine statements, output the following information to the console window: */
//            /* The name of the program and the degree it contains. */
//            Console.WriteLine("The {0} program contains the {1} degree.", InformationTechnology.Name, bachelors.Name);
//            /* The name of the course in the degree. */
//            Console.WriteLine("\nThe {0} degree contains the course {1}.", bachelors.Name, course.Name);
//            /* The count of the number of students in the course. */
//            Console.WriteLine("\nThe {0} course has {1} students in it.", course.Name, Student.NumOfStudents);
//            Console.WriteLine("\nPress any key to continue...");
//            Console.ReadKey();
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                doWork();
//            }
//            catch (NotImplementedException nyiEx)
//            {
//                Console.WriteLine(nyiEx.Message);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Module_Five_Assignment
//{
//    class Student
//    {
//        private static uint _numOfStudents = 0;

//        public static uint NumOfStudents
//        {
//            get { return Student._numOfStudents; }
//            set { Student._numOfStudents = value; }
//        }

//        private string _firstName;

//        public string FirstName
//        {
//            get { return _firstName; }
//            set { _firstName = value; }
//        }

//        private string _lastName;

//        public string LastName
//        {
//            get { return _lastName; }
//            set { _lastName = value; }
//        }

//        public Student(string fn, string ln)
//        {
//            this.FirstName = fn;
//            this.LastName = ln;
//            Student.NumOfStudents++;
//        }
//    }
//}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Module_Five_Assignment
//{
//    class Teacher
//    {
//        private string _firstName;

//        public string FirstName
//        {
//            get { return _firstName; }
//            set { _firstName = value; }
//        }

//        private string _lastName;

//        public string LastName
//        {
//            get { return _lastName; }
//            set { _lastName = value; }
//        }

//        public Teacher(string fn, string ln)
//        {
//            this.FirstName = fn;
//            this.LastName = ln;
//        }
//    }
//}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace Module_Five_Assignment
//{
//    class UProgram
//    {
//        private string _name;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public UProgram(string n)
//        {
//            this.Name = n;
//        }

//        private Degree _degree;

//        internal Degree Degree
//        {
//            get { return _degree; }
//            set { _degree = value; }
//        }

//        public void AddDegree(Degree d)
//        {
//            this.Degree = d;
//        }
//    }
//}

