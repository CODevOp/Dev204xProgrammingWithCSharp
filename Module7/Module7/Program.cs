#region Classmate Code
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Module7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            #region Module5 Part Commented

//            Student sn1 = new Student("Carlos", "Martinez", new DateTime(1970, 12, 28), "Villa Capri 0919", "", "US", "Houston");
//            Student sn2 = new Student("Eydan", "Maldonado", new DateTime(1982, 02, 21), "Lomas Verdes RF56", "", "PR", "Carolina");
//            Student sn3 = new Student("Maria", "Torres", new DateTime(1980, 04, 09), "Campo AlegreCA 19", "", "COL", "Cali");
//            sn1.Grades = new Stack();
//            sn2.Grades = new Stack();
//            sn3.Grades = new Stack();
//            sn1.Grades.Push("A"); sn1.Grades.Push("B"); sn1.Grades.Push("A"); sn1.Grades.Push("D"); sn1.Grades.Push("A");
//            sn2.Grades.Push("A"); sn2.Grades.Push("A"); sn2.Grades.Push("A"); sn2.Grades.Push("A"); sn2.Grades.Push("A");
//            sn3.Grades.Push("B"); sn3.Grades.Push("B"); sn3.Grades.Push("B"); sn3.Grades.Push("D"); sn3.Grades.Push("A");

//            #endregion

//            Course cou1 = new Course("Programming with C#", "Mathematics", 202);
//            cou1.students = new ArrayList();
//            cou1.students.Add(sn1);
//            cou1.students.Add(sn2);
//            cou1.students.Add(sn3);

//            cou1.ListStudents(cou1.students);
//            Console.WriteLine("Press any key to continue");
//            Console.ReadLine();
             
//        }
//    }

//    class Student
//    {
//        public static short studentsEnrolled = 0;
//        public Stack Grades;

//        #region Student Private Fields

//        private string _sname;
//        private string _slname;
//        private DateTime _sbirthdate;
//        private string _sadress1;
//        private string _sadress2;
//        private string _scountry;
//        private string _scity;

//        #endregion

//        #region Student Accessors

//        public string Sname
//        {
//            get { return _sname; }
//            set { _sname = value; }
//        }

//        public string Slname
//        {
//            get { return _slname; }
//            set { _slname = value; }
//        }

//        public string Sadress
//        {
//            get { return _sadress1; }
//            set { _sadress1 = value; }
//        }

//        public DateTime Sbirthdate
//        {
//            get { return _sbirthdate; }
//            set { _sbirthdate = value; }
//        }

//        public string Sadress2
//        {
//            get { return _sadress2; }
//            set { _sadress2 = value; }
//        }

//        public string Scity
//        {
//            get { return _scity; }
//            set { _scity = value; }
//        }

//        public string Scountry
//        {
//            get { return _scountry; }
//            set { _scountry = value; }
//        }
//        #endregion

//        public Student(string name, string lname, DateTime
//        birthdate, string address1, string address2, string country,
//        string city)
//        {
//            this.Sname = name;
//            this.Slname = lname;
//            this.Sbirthdate = birthdate;
//            this.Sadress = address1;
//            this.Sadress2 = address2;
//            this.Scountry = country;
//            this.Scity = city;
//            studentsEnrolled += 1;
//        }
//    }

//    class Course
//    {
//        #region Course Private Fields

//        private string _cname;
//        private string _cdepartment;
//        private int _ccredits;

//        #endregion

//        //public Student[] cstudents; Module 5
//        public ArrayList students;

//        #region Course Accessors

//        public string Cdepartment
//        {
//            get { return _cdepartment; }
//            set { _cdepartment = value; }
//        }

//        public int Ccredits
//        {
//            get { return _ccredits; }
//            set { _ccredits = value; }
//        }
//        public string Cname
//        {
//            get { return _cname; }
//            set { _cname = value; }
//        }

//        #endregion

//        public Course(string cname, string cdepartment, int ccredits)
//        {
//            this.Cname = cname;
//            this.Cdepartment = cdepartment;
//            this.Ccredits = ccredits;
//        }

//        public void ListStudents(ArrayList students)
//        {
//            foreach (Student s in students)
//            {
//                Console.WriteLine("Student Full Name: {0} {1}", s.Sname, s.Slname);
//            }
//        }
//    }
//}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace M7
//{
//    // per Module7 assignment, the following codes are modified
//    // from Module6 project

//    #region Person Class definition
//    class Person
//    {
//        // Person class will be the base class of Student class and Teacher class

//        // default constructor
//        public Person()
//        {
//            firstName = "Default";
//            lastName = "Default";
//            Birthdate = "00/00/0000";
//            Gender = "NA";
//        }

//        // properties
//        public string firstName { get; set; }
//        public string lastName { get; set; }
//        protected string Birthdate { get; set; }
//        protected string Gender { get; set; }
//        protected string Address { get; set; }

//    }

//    #endregion

//    #region Student Class definition
//    class Student : Person
//    {
//        // Student class inherits from the Person class

//        // static class vairalbe numberStudentCreate to track
//        // the number of students instances created
//        public static int numberStudentCreated = 0;

//        // track number of new student enrolled
//        public Student()
//        {
//            // Static constructor. numberStudentCreated is incremented each time
//            // a new instances of student is created. 
//            ++numberStudentCreated;
//        }

//        public Student(string fname, string lname, string bdate, string gender, string address)
//        {
//            // instance constructor with 5 parameters
//            this.firstName = fname;
//            this.lastName = lname;
//            this.Birthdate = bdate;
//            this.Gender = gender;
//            this.Address = address;
//        }

//        // property of Student, but not of Person 
//        public void TakeTest(string course)
//        {
//            Console.WriteLine("Remember to take the test of {}! ", course);
//        }
//        // add Grades stack for Student
//        public Stack Grades = new Stack();
//    }
//    #endregion

//    #region Teacher Class definition
//    class Teacher : Person
//    {
//        // teacher class specific properties
//        private string Department;
//        private string classTeach;

//        public Teacher(string fname, string lname, string bdate, string gender, string address, string department, string classteach)
//        {
//            // instance constructor of teacher class with 7 parameters
//            this.firstName = fname;
//            this.lastName = lname;
//            this.Birthdate = bdate;
//            this.Gender = gender;
//            this.Address = address;
//            this.Department = department;
//            this.classTeach = classteach;
//        }

//        public void GradeTest(string classteach)
//        {
//            Console.WriteLine("Please grade the test of the course {0}", classteach);
//        }

//    }

//    #endregion

//    #region UProgram Class definition
//    class UProgram
//    {
//        private string programName;

//        public string ProgramName
//        {
//            get { return programName; }
//            set { programName = value; }
//        }

//        private string degree;

//        public string Degree
//        {
//            get { return degree; }
//            set { degree = value; }
//        }

//        private string departmentHead;

//        public string DepartmentHead
//        {
//            get { return departmentHead; }
//            set { departmentHead = value; }
//        }

//        // Degree object
//        public Degree programDegree = new Degree();
//    }

//    #endregion

//    #region Degree Class definition
//    class Degree
//    {
//        private string degreeName;
//        public string DegreeName
//        {
//            get { return degreeName; }
//            set { degreeName = value; }
//        }

//        private string creditRequired;
//        public string CreditRequired
//        {
//            get { return creditRequired; }
//            set { creditRequired = value; }
//        }

//        // Course object
//        public Course degreeCourse = new Course();
//    }
//    #endregion

//    #region Course Class definition
//    class Course
//    {
//        private string courseName;
//        public string CourseName
//        {
//            get { return courseName; }
//            set { courseName = value; }
//        }

//        private string courseCredit;
//        public string CourseCredit
//        {
//            get { return courseCredit; }
//            set { courseCredit = value; }
//        }

//        private string courseDepartment;
//        public string CourseDepartment
//        {
//            get { return courseDepartment; }
//            set { courseDepartment = value; }
//        }

//        // ArrayList collections for Student objects and Teacher objects
//        public ArrayList courseStudent = new ArrayList();
//        public Teacher[] conrseTeacher = new Teacher[3];

//        // ListStudents() method to iterate over Students in ArrayList
//        // and output the first and last names to the console window
//        public void ListStudents()
//        {
//            foreach (Student student in this.courseStudent)
//            {
//                Console.WriteLine("First Name: {0}, Last Name: {1}", student.firstName, student.lastName);
//            }
//        }
//    }
//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // instantiate three Student objects
//            Student student1 = new Student("Stan", "Marsh", "01/01/1995", "Male", "1200 E California Blvd, Pasadena, CA 91125, USA");
//            Student student2 = new Student("Kyle", "Broflovski", "02/01/1995", "Male", "1210 E California Blvd, Pasadena, CA 91125, USA");
//            Student student3 = new Student("Eric", "Cartman", "03/01/1995", "Male", "1220 E California Blvd, Pasadena, CA 91125, USA");

//            // assign 5 grades to the Stack in each Student object
//            // student1
//            student1.Grades.Push("A");
//            student1.Grades.Push("A-");
//            student1.Grades.Push("B+");
//            student1.Grades.Push("B");
//            student1.Grades.Push("B-");
//            //student2
//            student2.Grades.Push("A+");
//            student2.Grades.Push("A-");
//            student2.Grades.Push("A");
//            student2.Grades.Push("B+");
//            student2.Grades.Push("B");
//            //student3
//            student3.Grades.Push("A-");
//            student3.Grades.Push("B+");
//            student3.Grades.Push("B");
//            student3.Grades.Push("B-");
//            student3.Grades.Push("C");

//            // instantiate a Course object called "Programming with C#"
//            Course course = new Course();
//            course.CourseName = "Programming with C#";

//            // add three students to the course object
//            course.courseStudent.Add(student1);
//            course.courseStudent.Add(student2);
//            course.courseStudent.Add(student3);

//            // instantiate at least one Teacher object
//            Teacher teacher = new Teacher("Herbert", "Garrison", "04/01/1965", "Male",
//            "1200 E California Blvd, Pasadena, CA 91125, USA", "Computer Science", "Programming with C#");

//            // add teacher object to course object
//            course.conrseTeacher[0] = teacher;

//            // instantiate a Degree object, such as Bachelor
//            Degree degree = new Degree();
//            degree.DegreeName = "Bachelor";
//            degree.CreditRequired = "2";

//            // add course object to degree object
//            degree.degreeCourse = course;

//            // instantiate a Uprogram object called Information Technology
//            UProgram program = new UProgram();
//            program.Degree = "Bachelor of Science";
//            program.DepartmentHead = "John Smith";
//            program.ProgramName = "Information Technology";

//            // add the degree object to the UProgram object
//            program.programDegree = degree;

//            // call ListStudents() method from Mai()
//            course.ListStudents();
//        }
//    }
//}
#endregion

#region MyCode
using System;
using System.Collections;

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
                student.Grades.Push("C");
                student.Grades.Push("D");
                student.Grades.Push("A");

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
        Stack _grades;



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
        public Stack Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }
        #region Constructor
        public Student(string firstName, string lastName, DateTime? studentBirthdate, string studentEmail, double studentGpa)
            : base(firstName, lastName, studentEmail)
        {
            this.StudentBirthdate = studentBirthdate;
            this.StudentGpa = studentGpa;
            this.Grades = new Stack();
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



        #region Methods
        internal void ListStudents()
        {
            Console.WriteLine("\nThe {0} course contains the following {1} student(s)", CourseName, Students.Count);
            foreach (Object studentObject in Students)
            {
                Student student = (Student)studentObject;
                Console.WriteLine("\t{0} {1}", student.FirstName, student.LastName);
            }

        }
        #endregion
    }
}

#endregion