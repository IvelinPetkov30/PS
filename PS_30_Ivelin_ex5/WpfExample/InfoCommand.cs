using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand : ICommand
    {
        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");
            NamesWindow names = new NamesWindow();
            names.Show();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        bool ICommand.CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        void ICommand.Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
