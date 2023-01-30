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

namespace Lecture_Example___Classes___Method__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List <Student> students = new List <Student> ();
        Course csi122;
        public MainWindow()
        {
            InitializeComponent();

            csi122 = new Course("CSI 122","Will Cram");
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentsToList();

            int lastStudentEntered = students.Count - 1;
            Student lastStudent = students[lastStudentEntered]; 
            csi122.EnrollStudent(lastStudent);

            rtbDisplay.Text = "";
            rtbDisplay.Text = csi122.CourseName + " " + csi122.Teacher + "\n";
            MessageBox.Show(csi122.ClassRosterAverage().ToString());
            foreach (Student student in csi122.CourseRoster)
            {
                rtbDisplay.Text += student + "\n";
            }
            //DisplayStudent();
           
        }
        public void AddStudentsToList()
        {
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            double CSIGrade = double.Parse(tbCSIGrade.Text);
            double GenEdGrade = double.Parse(tbGenEdGrade.Text);

            Student student = new Student(firstname, lastname, CSIGrade, GenEdGrade);

            students.Add(student);
        }
        public void DisplayStudent()
        {
            rtbDisplay.Text = "";
            for (int i = 0; i < students.Count; i++)
            {
                rtbDisplay.Text += students[i] + "\n";
            }
        }
    }
}
