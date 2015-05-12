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
using System.Collections;
using System.Collections.Generic;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> _students;
        int _currenStudent;
        public MainWindow()
        {
            _students = new List<Student>();
            _currenStudent = -1;

            InitializeComponent();
            
            //set the Firstname as the active control set focus
            btnNext.IsEnabled = false;
            btnPrevious.IsEnabled = false;

            txtFirstName.Focus();


        }
        /// <summary>
        /// Create new student based on input from form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {            
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.Lastname = txtLastName.Text;
            student.City = txtCity.Text;
            _students.Add(student);
            

            //clear current students data
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Text = "";
           
            //test current student
            //MessageBox.Show(student.PrintStudent());

            EnableButtons();

        }

        private void EnableButtons()
        {
            if(_currenStudent == -1 && _students.Count > 0)
                btnNext.IsEnabled = true;
            if (_currenStudent > -1 && _students.Count > 0)
                btnPrevious.IsEnabled = true;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            int current = --_currenStudent;
            if (current > 0 && current < _students.Count) 
                PopulateForm(_students.ToArray()[current]);
            
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            int current = ++_currenStudent;
            if (current < _students.Count)
                PopulateForm(_students.ToArray()[current]);

        }

        private void PopulateForm(Student student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.Lastname;
            txtCity.Text = student.City;
        }


    }
    /// <summary>
    /// Normally i would place this in seperate file and probably a seperate model project
    /// Add a new class to the project to represent a Student with three properties for the text fields.  
    /// 
    /// </summary>
    class Student
    {

        public String FirstName { get; set; }
        public String Lastname { get; set; }
        public String City { get; set; }

        //using this to test my code
        public String PrintStudent(){
            return string.Format("{0} {1} from {2}", FirstName, Lastname, City);
        }
    }
}

