using Karmasis.MVVM.Core;
using StartApp.Business;
using System;
using System.Windows;

namespace StartApp.ViewModels
{
    class LoginWindowViewModel :ViewModelBase
    {
        private UserManager _userManager;
        public LoginWindowViewModel()
        {
            LoginCommand = new DelegateCommand<Window>(LoginCommandExecute);
            RegisterCommand = new DelegateCommand(RegisterCommandExecute);
            _userManager = new UserManager(Globals.ConnectionString);
            
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                //txtPassword.Focus();
                IsRemeberCheckBoxChecked = true;
                UserName = Properties.Settings.Default.UserName;
            }
            else
            {
                //txtUserName.Focus();
            }
        }

        void LoginCommandExecute(Window window)
        {
            try
            {
                if (!_userManager.CheckUser(UserName, Password))
                {
                    throw new Exception("Kullanıcı adı veya şifresi hatalı!");
                }

                if (IsRemeberCheckBoxChecked)
                {
                    StartApp.Properties.Settings.Default.UserName = UserName;
                    StartApp.Properties.Settings.Default.Save();
                }
                window.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            catch (Exception exception)
            {
                Fail = exception.Message;
                FailVisibility = Visibility.Visible;
            }
        }
        void RegisterCommandExecute()
        {
            RegisterWindow registerWindow = new RegisterWindow();
            var dialogResult = registerWindow.ShowDialog();
            if (dialogResult.HasValue && dialogResult.Value)
            {
                UserName = registerWindow.Name;
            }
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged(() => UserName);
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(() => Password);
            }
        }

        private bool _isRemeberCheckBoxChecked;
        public bool IsRemeberCheckBoxChecked
        {
            get => _isRemeberCheckBoxChecked;
            set
            {
                _isRemeberCheckBoxChecked = value;
                OnPropertyChanged(() => IsRemeberCheckBoxChecked);
            }
        }
        private Visibility _failVisibility = Visibility.Collapsed;
        public Visibility FailVisibility
        {
            get => _failVisibility;
            set
            {
                _failVisibility = value;
                OnPropertyChanged(() => FailVisibility);
            }
        }
        private string _fail;
        public string Fail
        {
            get => _fail;
            set
            {
                _fail = value;
                OnPropertyChanged(() => Fail);
            }
        }

        public DelegateCommand<Window> LoginCommand { get; }
        public DelegateCommand RegisterCommand { get; }
    }
}
