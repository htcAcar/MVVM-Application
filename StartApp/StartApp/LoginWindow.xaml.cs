using StartApp.Business;
using StartApp.ViewModels;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;

namespace StartApp
{
    public partial class LoginWindow : Window
    {
        private LoginWindowViewModel _vm;
        public LoginWindow()
        {
            InitializeComponent();
            _vm = new LoginWindowViewModel();
            this.DataContext = _vm;

        }

        private void SaveOrCancelKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                _vm.LoginCommand.Execute(this);
            }
        }
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _vm.Password = txtPassword.Password;
        }
        private void BtnForgotPasswordClick(object sender, RoutedEventArgs e)
        {
        }
    }
}