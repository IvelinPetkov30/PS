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

namespace WPFHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);

            peopleListBox.SelectedItem = james;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
            //string s = null;
            //foreach (var item in gridgrid.Children)
            //{
            //    if (item is TextBox)
            //    {
            //        s = s + ((TextBox)item).Text;
            //        s = s + '\n';
            //    }
            //}
            //if (txtName.Text.Length >= 2)
           // {
                //MessageBox.Show("Hello, " + s + "\nThis is my first program in VS 2022.");
            //    MyMessage anotherWindow = new MyMessage();
             //   anotherWindow.Show();
           // }
           // else
           // {
                //MessageBox.Show("Please enter a valid name, with 2 characters or more.");
           //     MyMessage anotherWindow = new MyMessage();
           //     anotherWindow.Show();

           // }

        }

        public void Window_Close(object sender, ConsoleCancelEventArgs e)
        {
            string msg = "Close without saving?";
            MessageBoxResult result =
              MessageBox.Show(
                msg,
                "Data App",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }

        }

        private void peopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnGreet_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
