using Karmasis.MVVM.Core;
using StartApp.Business;
using System;
using System.Windows;

namespace StartApp.ViewModels
{
    class MainWindowViewModel: ViewModelBase
    {       
        public MainWindowViewModel()
        {
            GoProductsCommand = new DelegateCommand<Window>(GoProductsCommandExecute);
            GoDetailsCommand = new DelegateCommand<Window>(GoDetailsCommandExecute);
            GoSettingsCommand = new DelegateCommand<Window>(GoSettingsCommandExecute);
            BackCommand = new DelegateCommand<Window>(BackCommandExecute);
        }
        void GoProductsCommandExecute(Window window)
        {
            window.Hide();
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
        }
        void GoDetailsCommandExecute(Window window)
        {
            window.Hide();
            DetailWindow detailWindow = new DetailWindow();
            detailWindow.Show();
        }
        void GoSettingsCommandExecute(Window window)
        {
            window.Hide();
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
        void BackCommandExecute(Window window)
        {
            window.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
        public DelegateCommand<Window> GoProductsCommand { get; }
        public DelegateCommand<Window> GoDetailsCommand { get; }
        public DelegateCommand<Window> GoSettingsCommand { get; }
        public DelegateCommand<Window> BackCommand { get; }

    }
}
