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


namespace StudentInfoSystem
{

    public partial class MainWindow : Window
    {
        Student student = StudentData.TestStudents[0];
        public MainWindow()
        {
            InitializeComponent();
        }
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

                                textBox.Text = stdnt.fName;
                                break;
                            }
                        case "txtMName":
                            {
                                textBox.Text = stdnt.mName;
                                break;
                            }
                        case "txtLName":
                            {
                                textBox.Text = stdnt.lName;
                                break;
                            }
                        case "txtFac":
                            {
                                textBox.Text = stdnt.fac;
                                break;
                            }
                        case "txtSpec":
                            {
                                textBox.Text = stdnt.spec;
                                break;
                            }
                        case "txtDeg":
                            {
                                textBox.Text = stdnt.degr;
                                break;
                            }
                        case "txtStat":
                            {
                                textBox.Text = stdnt.stat;
                                break;
                            }
                        case "txtFNum":
                            {
                                textBox.Text = stdnt.Fnum;
                                break;
                            }
                        case "txtCourse":
                            {
                                textBox.Text = stdnt.course.ToString();
                                break;
                            }
                        case "txtStream":
                            {
                                textBox.Text = stdnt.stream.ToString();
                                break;
                            }
                        case "txtGroup":
                            {
                                textBox.Text = stdnt.group.ToString();
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

    }
}
