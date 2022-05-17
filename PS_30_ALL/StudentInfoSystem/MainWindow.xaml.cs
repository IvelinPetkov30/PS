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
using UserLogin;
using System.Data;
using System.Data.SqlClient;


namespace StudentInfoSystem
{

    public partial class MainWindow : Window
    {
        Student student = StudentData.TestStudents[0];
        public List<string> StudStatusChoices { get; set; }
        
        public MainWindow()
        {
            this.DataContext = this;

            if (TestStudentsIfEmpty())
                CopyTestStudents();

            FillStudStatusChoices();
            InitializeComponent();
        }

        public Student studentt { get; set; }



        private void fillFieldWithData(Student stdnt)
        {
            foreach (var item in Grid.Children)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    switch (textBox.Name)
                    {
                        case "txtFName":
                            {

                                textBox.Text = stdnt.Name;
                                break;
                            }
                        case "txtMName":
                            {
                                textBox.Text = stdnt.Surname;
                                break;
                            }
                        case "txtLName":
                            {
                                textBox.Text = stdnt.FamilyName;
                                break;
                            }
                        case "txtFac":
                            {
                                textBox.Text = stdnt.Faculty;
                                break;
                            }
                        case "txtSpec":
                            {
                                textBox.Text = stdnt.Specialty;
                                break;
                            }
                        case "txtDeg":
                            {
                                textBox.Text = stdnt.Degree;
                                break;
                            }
                        case "txtStat":
                            {
                                textBox.Text = stdnt.Status;
                                break;
                            }
                        case "txtFNum":
                            {
                                textBox.Text = stdnt.FacultyNumber.ToString();
                                break;
                            }
                        case "txtCourse":
                            {
                                textBox.Text = stdnt.Course.ToString();
                                break;
                            }
                        case "txtStream":
                            {
                                textBox.Text = stdnt.Stream.ToString();
                                break;
                            }
                        case "txtGroup":
                            {
                                textBox.Text = stdnt.Group.ToString();
                                break;
                            }
                    }
                }
            }
        }

        private void clrAllTxt()
        {
            foreach (var item in Grid.Children)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    textBox.Text = " ";
                }
            }
        }

        private void disablCntrl()
        {
            foreach (Control ctr in Grid.Children)
            {
                if (ctr.Name == "btnUnlck" || ctr.Name == "btnFill")
                {
                    ctr.IsEnabled = true;
                }
                else
                {
                    ctr.IsEnabled = false;
                }
            }
        }
        private void enablCntrl()
        {
            foreach (Control ctr in Grid.Children)
            {
                ctr.IsEnabled = true;
            }
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            fillFieldWithData(student);
        }

        private void btnSInfo_Click(object sender, RoutedEventArgs e)
        {
            fillFieldWithData(student);
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            clrAllTxt();
        }
        private void btnLck_Click(object sender, RoutedEventArgs e)
        {
            disablCntrl();
        }

        private void btnUnlck_Click(object sender, RoutedEventArgs e)
        {
            enablCntrl();
        }
        


        private void FillStudStatusChoices()
        {

            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    NotEndOfResult = reader.Read();
                }
            }
            this.DataContext = this;
        }
        private Boolean TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();

            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();

            if (countStudents == 0)
                return true;

            return false;
        }
        private void TestIfEmpty_Click(object sender, RoutedEventArgs e)
        {
            TestStudentsIfEmpty();
        }
        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (var st in context.Students)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
        }

        //ItemsSource="{Binding StudStatusChoices}"/>


    }

}
