#region student3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public int element;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(txtFirstName.Text.ToString(), txtLastName.Text.ToString(), txtCity.Text.ToString());
            students.Add(student);
            element = students.Count;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            element--;
            if (element < 0)
            {
                element = students.Count - 1;
            }

            txtFirstName.Text = students[element].firstName;
            txtLastName.Text = students[element].lastName;
            txtCity.Text = students[element].city;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            element++;
            if (element >= students.Count)
            {
                element = 0;
            }

            txtFirstName.Text = students[element].firstName;
            txtLastName.Text = students[element].lastName;
            txtCity.Text = students[element].city;
        }
    }
}

#endregion
#region student2
////MainWindow.xaml.cs
////Note: My Student.cs class includes an Address struct property that stores the city name in a property named City. Take it into account if you plan to execute the code.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.Collections;

//namespace Mod_9_Homework
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        List<Student> students;
//        int currentindex;

//        public MainWindow()
//        {
//            InitializeComponent();
//            students = new List<Student>();
//            this.currentindex = 0;
//            //gray out previous and next buttons until a student is created
//            btnPrevious.IsEnabled = false;
//            btnNext.IsEnabled = false;
//        }

//        private void btnPrevious_Click(object sender, RoutedEventArgs e)
//        {
//            if (students.Count > 0)
//            {
//                //enable next button if list has at least one item
//                btnNext.IsEnabled = true;
//                //update current index and show the previous student on the list
//                currentindex--;
//                txtFirstName.Text = students[currentindex].FirstName;
//                txtLastName.Text = students[currentindex].LastName;
//                txtCity.Text = students[currentindex].Address.City;
//                //change text from Create Student button to "save changes"
//                btnCreateStudent.Content = "Save Changes";
//            }

//            if (currentindex == 0)
//            {
//                //if start of the list, gray out previous button so that people cannot click negative values 
//                btnPrevious.IsEnabled = false;
//            }
//        }

//        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
//        {
//            //When the first entry is created, enable the Next button
//            if (students.Count == 0)
//            {
//                btnNext.IsEnabled = true;
//            }
//            //create new entry if we are at end of the list
//            if (currentindex == students.Count)
//            {
//                Student entry = new Student(txtFirstName.Text, txtLastName.Text);
//                Address address = new Address();
//                address.City = txtCity.Text;
//                entry.Address = address;
//                students.Add(entry);
//                //move to next blank entry to keep adding students if desired
//                btnNext_Click(this, e);
//            }
//            else
//            {
//                //update student at current index with the newest values
//                Address updated = students[currentindex].Address;
//                updated.City = txtCity.Text;
//                students[currentindex].Address = updated;
//                students[currentindex].FirstName = txtFirstName.Text;
//                students[currentindex].LastName = txtLastName.Text;
//            }
//        }

//        private void btnNext_Click(object sender, RoutedEventArgs e)
//        {
//            if (currentindex < students.Count)
//            {
//                //enable next button if list has at least one item
//                btnPrevious.IsEnabled = true;
//                //update current index and show the next student on the list, or a blank entry if the end was reached
//                currentindex++;
//                if (currentindex == students.Count)
//                {
//                    //if end of the list, gray out next button so that people cannot click further from the blank entry 
//                    btnNext.IsEnabled = false;
//                    txtFirstName.Text = "";
//                    txtLastName.Text = "";
//                    txtCity.Text = "";
//                    //change the text from center button back to "Create Student"
//                    btnCreateStudent.Content = "Create Student";
//                }
//                else
//                {
//                    //else show the student data at the current index position
//                    txtFirstName.Text = students[currentindex].FirstName;
//                    txtLastName.Text = students[currentindex].LastName;
//                    txtCity.Text = students[currentindex].Address.City;
//                }
//            }

//        }
//    }
// class Student
// {
     
//     public Student(string firstname, string lastName)
//     {
//         // TODO: Complete member initialization
//         this.FirstName = firstname;
//         this.LastName = lastName;
//     }

//     public String FirstName { get; set; }
//     public String LastName { get; set; }
//     public Address Address { get; set; }
// }
//    public struct Address { 
//        public String City { get; set; }
//     }
//}
#endregion
#region student1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace Mod_9_Homework
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        private readonly IList<Student> _students;
//        private int _index;

//        public MainWindow()
//        {
//            InitializeComponent();
//            _students = new List<Student>();
//        }

//        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
//        {
//            _students.Add(new Student
//            {
//                FirstName = txtFirstName.Text,
//                LastName = txtLastName.Text,
//                City = txtCity.Text
//            });

//            _index = (_students.Count - 1);

//            MessageBox.Show("Student Saved!");

//            #region Cleanup

//            txtFirstName.Clear();
//            txtLastName.Clear();
//            txtCity.Clear();

//            #endregion Cleanup
//        }

//        private void btnPrevious_Click(object sender, RoutedEventArgs e)
//        {
//            _index--;
//            if (_index < 0)
//            {
//                _index = 0;
//            }
//            SetTextFields(_students[_index]);
//        }

//        private void btnNext_Click(object sender, RoutedEventArgs e)
//        {
//            _index++;
//            if (_index > (_students.Count - 1))
//            {
//                _index = (_students.Count - 1);
//            }
//            SetTextFields(_students[_index]);
//        }

//        private void SetTextFields(Student student)
//        {
//            txtFirstName.Text = student.FirstName;
//            txtLastName.Text = student.LastName;
//            txtCity.Text = student.City;
//        }
//    }
//    class Student
//    {

//        public String FirstName { get; set; }
//        public String LastName { get; set; }
//        public String City { get; set; }
//    }
//}
#endregion
#region mywork
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace Mod_9_Homework
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        List<Student> _students;
//        int _currenStudent;
//        public MainWindow()
//        {
//            _students = new List<Student>();
//            _currenStudent = -1;

//            InitializeComponent();
            
//            //set the Firstname as the active control set focus
//            btnNext.IsEnabled = false;
//            btnPrevious.IsEnabled = false;

//            txtFirstName.Focus();


//        }
//        /// <summary>
//        /// Create new student based on input from form
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
//        {            
//            Student student = new Student();
//            student.FirstName = txtFirstName.Text;
//            student.Lastname = txtLastName.Text;
//            student.City = txtCity.Text;
//            _students.Add(student);
            

//            //clear current students data
//            txtFirstName.Clear();
//            txtLastName.Clear();
//            txtCity.Text = "";
           
//            ToggleNavigationButtons();
//        }
//        /// <summary>
//        /// determine if buttons should be enabled or disabled
//        /// </summary>
//        private void ToggleNavigationButtons()
//        {
//            //if the _currenStudent index is at the begining or greater
//            // and _currenStudent index < the count of students
//            if (_currenStudent >= -1 && _currenStudent < _students.Count )
//                btnNext.IsEnabled = true;
//            //disable the button
//            else
//                btnNext.IsEnabled = false;

//            // if _currentStudent index is not at the begining 
//            //  and there are student records enable btnPrevious
//            if (_currenStudent > -1 && _students.Count > 0)
//                btnPrevious.IsEnabled = true;
//            //disable the button
//            else
//                btnPrevious.IsEnabled = false;            
//        }

//        private void btnPrevious_Click(object sender, RoutedEventArgs e)
//        {
//            //decrease _currenStudent index
//            --_currenStudent;
//            //if _currentStudent index is greater than or equal 0 and the index is less than the count show student
//            if (_currenStudent >= 0 && _currenStudent < _students.Count)
//                PopulateForm(_students.ToArray()[_currenStudent]);
//            if (_currenStudent < 0)
//            { 
//                //the index is at the begining reset it and show an empty student
//                PopulateForm(new Student());
//                _currenStudent = -1;
//            }
//            ToggleNavigationButtons();
//        }

//        private void btnNext_Click(object sender, RoutedEventArgs e)
//        {
//            //increase _currentStudent index
//            ++_currenStudent;
//            //if _currentStudent index is less than count show student
//            if (_currenStudent < _students.Count)
//                PopulateForm(_students[_currenStudent]);

//            //_currentStudent index is equal to total student count shew an empty student
//            if (_currenStudent == _students.Count)
//            { 
//                PopulateForm(new Student());                
//            }
            
//            ToggleNavigationButtons();
//        }
//        /// <summary>
//        /// Populate the form when the user navigate left and right
//        /// </summary>
//        /// <param name="student"></param>
//        private void PopulateForm(Student student)
//        {
//            txtFirstName.Text = student.FirstName;
//            txtLastName.Text = student.Lastname;
//            txtCity.Text = student.City;
//        }


//    }
    /// <summary>
    /// Normally i would place this in seperate file and probably a seperate model project
    /// Add a new class to the project to represent a Student with three properties for the text fields.  
    /// 
    /// </summary>
    //class Student
    //{

    //    public String FirstName { get; set; }
    //    public String Lastname { get; set; }
    //    public String City { get; set; }
    //}
//} 
#endregion
