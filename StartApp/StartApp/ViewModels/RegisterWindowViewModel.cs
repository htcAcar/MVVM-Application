using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using StartApp.Entities.Enums;
using System;
using System.Windows;
using StartApp.ValidationRules;
using MvvmValidation;

namespace StartApp.ViewModels
{
    class RegisterWindowViewModel
        : ViewModelBase
    {
        private UserManager _userManager;

        public RegisterWindowViewModel()
        {
            SaveCommand = new DelegateCommand<Window>(SaveCommandExecute);
            CancelCommand = new DelegateCommand<Window>(CancelCommandExecute);
            GenderSelectCommand = new DelegateCommand<string>(GenderSelectCommandExecute);
            ContactSelectCommand = new DelegateCommand<string>(ContactSelectCommandExecute);

            _userManager = new UserManager(Globals.ConnectionString);
        }

        void ContactSelectCommandExecute(string contact)
        {
            Contact = (Contacts)int.Parse(contact);
        }

        void GenderSelectCommandExecute(string gender)
        {
            Gender = (Genders)int.Parse(gender);
        }

        void SaveCommandExecute(Window window)
        {
            User user = new User();
            user.Name = Name;
            user.Password = Password;
            user.Mail = Mail;
            user.Phone = Phone;
            user.City = Location;
            user.Gender = Gender;
            user.Contact = Contact;
            user.Birthday = BirthDay;

                       
            if (SpaceControl() != 0)         
            {
                MessageBox.Show("Lütfen gerekli boşlukları doldurun! ", "Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {  
                    _userManager.CreateNewUser(user);

                    MessageBox.Show("Kullanıcı bilgileri kaydedildi. Login ekranına yönlendirileceksiniz.");
                    window.DialogResult = true;
                    window.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show($@"Error: \n {exception.Message}", "Warning");
                }
            }
        }

        void CancelCommandExecute(Window window)
        {
            if (SpaceControl() < 6 )
            {
                MessageBoxResult result = MessageBox.Show("Kaydetmeden önce kapatmak istiyor musunuz?", "Close Window", button: MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    window.DialogResult = false;
                }
            }
            else
            {
                window.DialogResult = false;
            }
        }


        private int SpaceControl()
        {
            int errorCount = 0;
            if (string.IsNullOrEmpty(Name))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Password))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Mail))
            {               
                errorCount++;
            }
            if (string.IsNullOrEmpty(Phone))
            {
                errorCount++;
            }
            if (!BirthDay.HasValue)
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Location))
            {
                errorCount++;
            }

            return errorCount;
        }
       

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(() => Name);
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

        private string _mail;
        public string Mail
        {
            get => _mail;
            set
            {
                _mail = value;
                OnPropertyChanged(() => Mail);
            }
        }

        private string _phone;
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(() => Phone);
            }
        }

        private DateTime? _birthDay;
        public DateTime? BirthDay
        {
            get => _birthDay;
            set
            {
                _birthDay = value;
                OnPropertyChanged(() => BirthDay);
            }
        }

        private string _location;
        public string Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(() => Location);
            }
        }

        private Genders _gender;
        public Genders Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(() => Gender);
            }
        }

        private Contacts _contact;
        public Contacts Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(() => Contact);
            }
        }

        private Visibility _errorVisibility = Visibility.Collapsed;
        public Visibility ErrorVisibility
        {
            get => _errorVisibility;
            set
            {
                _errorVisibility = value;
                OnPropertyChanged(() => ErrorVisibility);
            }
        }

        public DelegateCommand<Window> SaveCommand { get; }

        public DelegateCommand<Window> CancelCommand { get; }

        public DelegateCommand<string> GenderSelectCommand { get; }

        public DelegateCommand<string> ContactSelectCommand { get; }

    }
}
