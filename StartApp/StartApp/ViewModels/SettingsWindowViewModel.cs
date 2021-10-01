using Karmasis.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StartApp.ViewModels
{
    class SettingsWindowViewModel : ViewModelBase
    {
        public SettingsWindowViewModel()
        {
            DoubleClickCommand = new DelegateCommand(DoubleClickCommandExecute);
        }
        void DoubleClickCommandExecute()
        {            
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }
        public DelegateCommand DoubleClickCommand { get; }
    }
}
