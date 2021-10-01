using StartApp.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace StartApp
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private RegisterWindowViewModel _vm;
        public RegisterWindow()
        {
            InitializeComponent();
            _vm = new RegisterWindowViewModel();
            this.DataContext = _vm;
        }

        private void SaveOrCancelKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                _vm.SaveCommand.Execute(this);
            }
            if (e.Key == Key.Escape)
            {
                _vm.CancelCommand.Execute(this);
            }
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _vm.Password = txtPassword.Password;
        }
       
    }
}
