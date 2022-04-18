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
        private void fillFieldWithData(Student stdt)
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

                                textBox.Text = stdt.fName;
                                break;
                            }
                        case "txtMName":
                            {
                                textBox.Text = stdt.mName;
                                break;
                            }
                        case "txtLName":
                            {
                                textBox.Text = stdt.lName;
                                break;
                            }
                        case "txtFac":
                            {
                                textBox.Text = stdt.fac;
                                break;
                            }
                        case "txtSpec":
                            {
                                textBox.Text = stdt.spec;
                                break;
                            }
                        case "txtDeg":
                            {
                                textBox.Text = stdt.degr;
                                break;
                            }
                        case "txtStat":
                            {
                                textBox.Text = stdt.stat;
                                break;
                            }
                        case "txtFNum":
                            {
                                textBox.Text = stdt.Fnum;
                                break;
                            }
                        case "txtCourse":
                            {
                                textBox.Text = stdt.course.ToString();
                                break;
                            }
                        case "txtStream":
                            {
                                textBox.Text = stdt.stream.ToString();
                                break;
                            }
                        case "txtGroup":
                            {
                                textBox.Text = stdt.group.ToString();
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
