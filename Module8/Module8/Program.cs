#region Classmate3
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication2
//{
//    public class Person
//    {
//        public Person(string fname, string lname, DateTime birth)
//        {
//            _firstName = fname;
//            _lastName = lname;
//            _birthDate = birth;
//        }

//        protected string _firstName;
//        protected string _lastName;
//        protected DateTime _birthDate;

//        public string FirstName
//        {
//            get { return _firstName; }
//            set { _firstName = value; }
//        }

//        public string LastName
//        {
//            get { return _lastName; }
//            set { _lastName = value; }
//        }

//        public DateTime BirthDate
//        {
//            get { return _birthDate; }
//            set { _birthDate = value; }
//        }
//    }
//    public class Student : Person
//    {
//        public Student(string fname, string lname, DateTime birth)
//            : base(fname, lname, birth)
//        {
//            Grades = new Stack<int>();
//            ++_numberOf;
//        }

//        Stack<int> Grades; //this goes against my naming conventions :(
//        static int _numberOf;

//        public Stack<int> GradeStack
//        {
//            get { return Grades; }
//        }

//        public static int NumberOf
//        {
//            get { return _numberOf; }
//        }

//        public void TakeTest()
//        {
//            Console.WriteLine("Student {0} {1} is taking a test.\r\n", _firstName, _lastName);
//        }
//    }

//    public class Teacher : Person
//    {
//        public Teacher(string fname, string lname, DateTime birth, bool isTenured)
//            : base(fname, lname, birth)
//        {
//            _isTenured = isTenured;
//        }

//        private bool _isTenured;

//        public bool IsTenured
//        {
//            get { return _isTenured; }
//            set { _isTenured = value; }
//        }

//        public void GradeTest()
//        {
//            Console.WriteLine("Teacher {0} {1} is grading a test.\r\n", _firstName, _lastName);
//        }
//    }

//    public class UProgram
//    {
//        public UProgram(string name, string type, int creditReq, Degree degree)
//        {
//            _name = name;
//            _type = type;
//            _creditReq = creditReq;
//            _degree = degree;
//        }

//        private Degree _degree;
//        private string _name;
//        private string _type;
//        private int _creditReq;

//        public Degree Degree
//        {
//            get { return _degree; }
//            set { _degree = value; }
//        }

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public string Type
//        {
//            get { return _type; }
//            set { _type = value; }
//        }

//        public int CreditRequirement
//        {
//            get { return _creditReq; }
//            set { _creditReq = value; }
//        }
//    }

//    public class Course
//    {
//        public Course(string name, string area, int credits)
//        {
//            _name = name;
//            _area = area;
//            _creditsEarned = credits;
//            _students = new List<Student>();
//        }

//        private List<Student> _students;
//        private Teacher[] _teachers;
//        private string _name;
//        private string _area;
//        private int _creditsEarned;

//        public List<Student> Students
//        {
//            get { return _students; }
//            set { _students = value; }
//        }

//        public Teacher[] Teachers
//        {
//            get { return _teachers; }
//            set { _teachers = value; }
//        }

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public string Area
//        {
//            get { return _area; }
//            set { _area = value; }
//        }

//        public int CreditsEarned
//        {
//            get { return _creditsEarned; }
//            set { _creditsEarned = value; }
//        }

//        public void ListStudents()
//        {
//            foreach (var s in _students)
//            {
//                Student stud = s as Student;
//                Console.WriteLine("{0} {1}\r\n", stud.FirstName, stud.LastName);
//            }
//        }
//    }

//    public class Degree
//    {
//        public Degree(string name, string type, int years, Course course)
//        {
//            _name = name;
//            _type = type;
//            _years = years;
//            _course = course;
//        }

//        private Course _course;
//        private string _name;
//        private string _type;
//        private int _years;

//        public Course Course
//        {
//            get { return _course; }
//            set { _course = value; }
//        }

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public string Type
//        {
//            get { return _type; }
//            set { _type = value; }
//        }

//        public int Years
//        {
//            get { return _years; }
//            set { _years = value; }
//        }
//    }

//    class Application
//    {
//        static void Main(string[] args)
//        {
//            Student[] students;
//            Teacher[] teachers;
//            students = new Student[3];
//            teachers = new Teacher[1];

//            students[0] = new Student("hello", "world", new DateTime(1987, 1, 1));
//            students[1] = new Student("foo", "bar", new DateTime(1988, 12, 25));
//            students[2] = new Student("baz", "qux", new DateTime(2011, 11, 15));

//            students[0].GradeStack.Push(1);
//            students[0].GradeStack.Push(2);
//            students[0].GradeStack.Push(3);
//            students[0].GradeStack.Push(4);
//            students[0].GradeStack.Push(5);

//            students[1].GradeStack.Push(11);
//            students[1].GradeStack.Push(21);
//            students[1].GradeStack.Push(31);
//            students[1].GradeStack.Push(41);
//            students[1].GradeStack.Push(51);

//            students[2].GradeStack.Push(91);
//            students[2].GradeStack.Push(92);
//            students[2].GradeStack.Push(93);
//            students[2].GradeStack.Push(94);
//            students[2].GradeStack.Push(95);

//            teachers[0] = new Teacher("Simon", "Cowell", new DateTime(1600, 11, 15), false);

//            Course course = new Course("Programming with C#", "Online", 42);

//            course.Students.AddRange(students);
//            course.Teachers = teachers;

//            Degree degree = new Degree("Bachelor", "Science", 4, course);

//            UProgram uprogram = new UProgram("Information Technology", "Weekend", 9000, degree);

//            //Console.WriteLine("The {0} program contains the {1} of {2} degree\r\n", uprogram.Name, uprogram.Degree.Name, uprogram.Degree.Type);
//            //Console.WriteLine("The {0} of {1} degree contains the course {2}\r\n", uprogram.Degree.Name, uprogram.Degree.Type, uprogram.Degree.Course.Name);
//            //Console.WriteLine("The {0} course contains {1} students(s)\r\n", uprogram.Degree.Course.Name, Student.NumberOf);

//            uprogram.Degree.Course.ListStudents();

//            Console.WriteLine("Press any key to continue . . .", uprogram.Degree.Course.Name, Student.NumberOf);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Classmate2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MsDev204M8
//{
//    // abstract base class with common attributes for a Person
//    abstract class Person
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
//    }

//    class Teacher : Person
//    {
//        public Teacher(string title, string firstname, string lastname)
//        {
//            this.Title = title;
//            this.FirstName = firstname;
//            this.LastName = lastname;
//        }
//        private string _title;

//        public string Title
//        {
//            get { return _title; }
//            set { _title = value; }
//        }

//        public void GradeTest()
//        {
//            Console.WriteLine("All get A's");
//        }
//    }

//    class Student : Person
//    {
//        public Student(string firstname, string lastname, string birthdate)
//        {
//            this.FirstName = firstname;
//            this.LastName = lastname;
//            this.BirthDate = birthdate;
//            this.Grades = new Stack<int>();
//        }
//        private string _birthDate;

//        public string BirthDate
//        {
//            get { return _birthDate; }
//            set { _birthDate = value; }
//        }

//        private Stack<int> _grades;

//        public Stack<int> Grades
//        {
//            get { return _grades; }
//            set { _grades = value; }
//        }

//        public void TakeTest()
//        {
//            Console.WriteLine("Writing up code for the test.");
//        }
//    }

//    class Degree
//    {
//        public Degree(string title, string field, string level)
//        {
//            this.Title = title;
//            this.Field = field;
//            this.Level = level;
//        }
//        private string _title;

//        public string Title
//        {
//            get { return _title; }
//            set { _title = value; }
//        }
//        private string _field;

//        public string Field
//        {
//            get { return _field; }
//            set { _field = value; }
//        }
//        private string _level;

//        public string Level
//        {
//            get { return _level; }
//            set { _level = value; }
//        }

//        private Course _course;

//        public Course Course
//        {
//            get { return _course; }
//            set { _course = value; }
//        }
//    }

//    class Course
//    {
//        public Course(string name)
//        {
//            this.Name = name;
//            this.Students = new List<Student>();
//        }
//        private string _name;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
//        private List<Student> _students;

//        public List<Student> Students
//        {
//            get { return _students; }
//            set { _students = value; }
//        }
//        private Teacher[] _teachers;

//        public Teacher[] Teachers
//        {
//            get { return _teachers; }
//            set { _teachers = value; }
//        }

//        public void ListStudents()
//        {
//            foreach (Student s in Students)
//            {
//                Console.WriteLine(" * {0} {1}", s.FirstName, s.LastName);
//            }
//        }
//    }

//    class UProgram
//    {
//        public UProgram(string title, string dephead)
//        {
//            this.Title = title;
//            this.DepHead = dephead;
//        }

//        private string _title;

//        public string Title
//        {
//            get { return _title; }
//            set { _title = value; }
//        }
//        private Degree _degreesOffered;

//        public Degree DegreesOffered
//        {
//            get { return _degreesOffered; }
//            set { _degreesOffered = value; }
//        }
//        private string _depHead;

//        public string DepHead
//        {
//            get { return _depHead; }
//            set { _depHead = value; }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Course theCourse = new Course("Programming with C#");

//            Student student1 = new Student("Alex", "Smith", "Jan-01-1991");
//            student1.Grades.Push(100);
//            student1.Grades.Push(90);
//            student1.Grades.Push(80);
//            student1.Grades.Push(70);
//            student1.Grades.Push(60);
//            theCourse.Students.Add(student1);

//            Student student2 = new Student("Bill", "Bond", "Feb-02-1992");
//            student2.Grades.Push(100);
//            student2.Grades.Push(90);
//            student2.Grades.Push(80);
//            student2.Grades.Push(70);
//            student2.Grades.Push(60);
//            theCourse.Students.Add(student2);

//            Student student3 = new Student("Cherry", "Stoke", "Mar-03-1993");
//            student3.Grades.Push(100);
//            student3.Grades.Push(90);
//            student3.Grades.Push(80);
//            student3.Grades.Push(70);
//            student3.Grades.Push(60);
//            theCourse.Students.Add(student3);

//            Teacher teacher = new Teacher("Dr.", "Virtual", "Professor");
//            theCourse.Teachers = new Teacher[] { teacher };

//            Degree degree = new Degree("Bachelor of Engineering", "Computer", "Bachelor");
//            degree.Course = theCourse;

//            UProgram program = new UProgram("Information Technology", "Paul");
//            program.DegreesOffered = degree;

//            Console.WriteLine("Program {0} with {1} degree.", program.Title, program.DegreesOffered.Title);
//            Console.WriteLine("Course {0}", program.DegreesOffered.Course.Name);
//            Console.WriteLine("There are {0} students enrolled:", program.DegreesOffered.Course.Students.Count);
//            theCourse.ListStudents();
//        }
//    }
//}
#endregion
#region  Classmate1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace edXmodule08HW
//{

//    #region "STUDENT CLASS"

//    //•Create a class to represent a student
//    public class Student
//    {
//        private string fName;
//        private string fSurname;
//        private int fAge;

//        //•Create a Stack<T> object, of the proper data type, inside the Student object, called Grades
//        Stack<int> fGrades = new Stack<int>(); //CODE ADDED FOR THIS.MODULE08 HOMEWORK

//        public string Name
//        {
//            set
//            {
//                fName = value;
//            }
//            get
//            {
//                return fName;
//            }
//        }
//        public string Surname
//        {
//            set
//            {
//                fSurname = value;
//            }
//            get
//            {
//                return fSurname;
//            }
//        }
//        public int Age
//        {
//            set
//            {
//                fAge = value;
//            }
//        }

//        public int Grade
//        {
//            set
//            {
//                fGrades.Push(value); //CODE ADDED SINCE MODULE07 HOMEWORK. WORKS FOR MODULE08 HW BECAUSE OF INHERITANCE!
//            }

//        }
//        public Student(string pName, string pSurname, int pAge)
//        {
//            this.fName = pName;
//            this.fSurname = pSurname;
//            this.fAge = pAge;
//        }

//        public Stack<int> GetGrades() //CODE ADDED FOR THIS.MODULE08 HOMEWORK. Just for passing grades stack<T>!
//        {
//            return fGrades;
//        }
//    }
//    #endregion

//    #region "TEACHER CLASS"
//    //•Create a Class to represent a teacher
//    public class Teacher
//    {
//        private string fName;
//        private string fSurname;
//        private string fTitle;

//        public string Name
//        {
//            set
//            {
//                fName = value;
//            }
//        }
//        public string Surname
//        {
//            set
//            {
//                fSurname = value;
//            }
//        }
//        public string Title
//        {
//            set
//            {
//                fTitle = value;
//            }
//        }

//    }

//    #endregion

//    #region "UPROGRAM CLASS"

//    //•Create a Class to represent a program
//    public class UProgram
//    {
//        private string fProgramName;
//        //for the purposes of this assignment, just ensure you have a single variable in UProgram to hold a Degree 
//        //and single variable in Degree to hold a Course. 
//        private object fProgramDegree;

//        public string ProgramName
//        {
//            get
//            {
//                return fProgramName;
//            }
//            set
//            {
//                fProgramName = value;
//            }
//        }

//        public void ProgramDegree(Degree pDegree)
//        {
//            fProgramDegree = pDegree;
//        }

//        public void ProgramInfo()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    #endregion

//    #region "DEGREE CLASS"

//    //•Create a Class to represent a Degree
//    public class Degree
//    {
//        private string fDegreeName;
//        //for the purposes of this assignment, just ensure you have a single variable in UProgram to hold a Degree 
//        //and single variable in Degree to hold a Course. 
//        private object fCourse;

//        //Set Degree Name
//        public string DegreeName
//        {
//            get
//            {
//                return fDegreeName;
//            }
//            set
//            {
//                fDegreeName = value;
//            }
//        }

//        //Hold Course info
//        public void Course(Course pCourse)
//        {
//            fCourse = pCourse;
//        }
//    }

//    #endregion

//    #region "COURSE CLASS"

//    //•Create a Class to represent a course
//    public class Course
//    {
//        private string fCourseName;
//        private object[] fTeacher = new object[3];

//        //•Create an ArrayList to replace the array and to hold students, inside the Course object.
//        //ArrayList fStudent = new ArrayList(); //CODE ADDED FOR THIS.MODULE07 HOMEWORK

//        //•Create a List<T>, of the proper data type, to replace the ArrayList and to hold students, inside the Course object.
//        List<Student> fStudent = new List<Student>(); //CODE ADDED FOR THIS.MODULE08 HOMEWORK

//        //Set Course Name
//        public string CourseName
//        {
//            get
//            {
//                return fCourseName;
//            }
//            set
//            {
//                fCourseName = value;
//            }
//        }
//        public int Count
//        {
//            get
//            {
//                return fStudent.Count;
//            }
//        }

//        //Constructor overload for setting course name using the Accessor
//        public Course(string pCourse)
//        {
//            this.CourseName = pCourse;
//        }

//        //Method to update student Arraylist
//        public void Student(Student pStudent)
//        {
//            fStudent.Add(pStudent); //CODE ADDED FOR THIS.MODULE07 HOMEWORK
//        }

//        //•Create a method inside the Course object called ListStudents() that contains the foreach loop
//        public void ListStudents()
//        {
//            int i = 0;
//            Console.WriteLine("STUDENTS ON THIS COURSE:\n");

//            //•Using a foreach loop, iterate over the Students in the List<T> and output their first and last names 
//            foreach (Student fstud in fStudent) //CODE ADDED FOR THIS.MODULE07 HOMEWORK
//            {
//                Console.WriteLine("STUDENT {0}: {1} {2}", i++, fstud.Name, fstud.Surname);

//                //Display Grades
//                Stack<int> fgrd = fstud.GetGrades();
//                foreach (int grd in fgrd) //Parameter now of type int rather than object
//                {
//                    Console.Write("{0} ", grd);
//                }
//                Console.WriteLine("\n-------------");
//            }

//        }

//        //Method to update student array. Fixed to one spot because homework doesn't require multiple entry.
//        public void Teacher(Teacher pTeacher)
//        {
//            fTeacher[0] = pTeacher;
//        }
//    }

//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //1.Instantiate three Student objects 
//            Student st1 = new Student("Uno", "First", 21);
//            Student st2 = new Student("Dos", "Two", 22);
//            Student st3 = new Student("Tres", "Three", 23);

//            //•Add 5 grades to the Stack<T> in the each Student object
//            for (int i = 1; i <= 5; i++) { st1.Grade = 80 + i; } //CODE FROM MODULE07 HOMEWORK
//            for (int i = 1; i <= 5; i++) { st2.Grade = 85 + i; } //SEE STUDENT GRADE PROPERTY SETTER FOR LIST<T> ADD IMPLEMENTATION
//            for (int i = 1; i <= 5; i++) { st3.Grade = 90 + i; }

//            //2.Instantiate a Course object called Programming with C#.
//            Course cors = new Course("Programming with C#");

//            //3.Add your three students to this Course object.
//            cors.Student(st1);
//            cors.Student(st2);
//            cors.Student(st3);

//            //4.Instantiate at least one Teacher object.
//            Teacher teach = new Teacher();
//            teach.Title = "Dr.";
//            teach.Name = "Who";
//            teach.Surname = "Aryo";

//            //5.Add that Teacher object to your Course object
//            cors.Teacher(teach);

//            //6.Instantiate a Degree object, such as Bachelor.
//            Degree deg = new Degree();
//            deg.DegreeName = "Bachelor of Science";

//            //7.Add your Course object to the Degree object.
//            deg.Course(cors);

//            //8.Instantiate a UProgram object called Information Technology.
//            UProgram uprog = new UProgram();
//            uprog.ProgramName = "Information Technology";

//            //9.Add the Degree object to the UProgram object.
//            uprog.ProgramDegree(deg);

//            Console.WriteLine("edX module 08 Homework");
//            Console.WriteLine();

//            //10.Using Console.WriteLine statements, output the following information to the console window:
//            //1.The name of the program and the degree it contains
//            Console.WriteLine("The {0} program contains {1} Degree", uprog.ProgramName, deg.DegreeName);
//            Console.WriteLine();

//            //2.The name of the course in the degree
//            Console.WriteLine("The {0} contains the course {1}", deg.DegreeName, cors.CourseName);
//            Console.WriteLine();

//            //3.The count of the number of students in the course.
//            Console.WriteLine("The {0} course contains {1} students", cors.CourseName, cors.Count);
//            Console.WriteLine();

//            //•Call the ListStudents() method from Main(). 
//            cors.ListStudents(); //CODE ADDED FOR THIS.MODULE07. SAME FOR MODULE08 HW!

//            Console.WriteLine("");
//            Console.WriteLine("Press any key to continue...");
//            Console.ReadKey();

//        }
//    }

//}
#endregion
#region MyCode
using System;
using System.Collections;
using System.Collections.Generic;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#");

            //Add your three students to this Course object.
            course.Students.Add(new Student("George", "Harrison", new DateTime(1985, 05, 05), "George.Harrison@edx.edu", 3.0));
            course.Students.Add(new Student("Henry", "Lade", new DateTime(1986, 06, 023), "Henry.Lade@edx.edu", 3.3));
            course.Students.Add(new Student("Lisa", "Stackton", new DateTime(1983, 10, 05), "Lisa.Stackton@edx.edu", 3.9));

            // Add 5 grades to the the Stack in the each Student object. 
            foreach (Student student in course.Students)
            {
                student.Grades.Push("A");
                student.Grades.Push("B");
                student.Grades.Push("B+");
                student.Grades.Push("B-");
                student.Grades.Push("A+");

            }

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

            //print Class Students
            course.ListStudents();

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
        //public Person() { }
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
        Stack<String> _grades;

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
        public Stack<String> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }
        #region Constructor
        //public Student() { }
        public Student(string firstName, string lastName, DateTime? studentBirthdate, string studentEmail, double studentGpa)
            : base(firstName, lastName, studentEmail)
        {
            this.StudentBirthdate = studentBirthdate;
            this.StudentGpa = studentGpa;
            this.Grades = new Stack<String>();
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
            this.Students = new List<Student>();
        }
        #endregion
        #region Fields
        private string _courseName;
        private ArrayList _teacher;
        private List<Student> _students;
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
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }
        #endregion



        #region Methods
        internal void ListStudents()
        {
            Console.WriteLine("\nThe {0} course contains the following {1} student(s)", CourseName, Students.Count);
            foreach (Student student in Students)
            {
                Console.WriteLine("\t{0} {1}", student.FirstName, student.LastName);
            }

        }
        #endregion
    }
}

#endregion