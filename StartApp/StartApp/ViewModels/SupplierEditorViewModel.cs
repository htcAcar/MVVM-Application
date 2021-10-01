using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using System;
using System.Windows;

namespace StartApp.ViewModels
{
    class SupplierEditorViewModel : ViewModelBase
    {
        private Supplier _supplier;
        private SupplierManager _supplierManager;
        private string _oldCompanyName;
        int _checkAddOrUpdate =0;
        bool _checkChanges = false;

        public SupplierEditorViewModel(Supplier updateSupplier)
        {
            SaveCommand = new DelegateCommand<Window>(SaveCommandExecute);
            CancelCommand = new DelegateCommand<Window>(CancelCommandExecute);
            _supplierManager = new SupplierManager(Globals.ConnectionString);
            _supplier = updateSupplier;
            _oldCompanyName = updateSupplier.ContactName;               

            try
            {
                if (updateSupplier.SupplierID > 0)
                {                   
                    CompanyName = updateSupplier.CompanyName;
                    ContactName = updateSupplier.ContactName;
                    ContactTitle = updateSupplier.ContactTitle;
                    Address = updateSupplier.Address;
                    City = updateSupplier.City;
                    Region = updateSupplier.Region;
                    PostalCode = updateSupplier.PostalCode;
                    Country = updateSupplier.Country;
                    Phone = updateSupplier.Phone;
                    Fax = updateSupplier.Fax;
                    HomePage = updateSupplier.HomePage;
                    _checkAddOrUpdate = updateSupplier.SupplierID;
                    _checkChanges = false;
                    PageTitle = String.Format("{0} Update", CompanyName);
                    Title = "Update";
                }
                else
                {
                    PageTitle = "Add Record";
                    Title = "Add Record";
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Warning");
            }
        }
        void SaveCommandExecute(Window window)
        {
            if (SpaceControl() != 0)
            {
                MessageBox.Show("Lütfen gerekli boşlukları doldurun! ", "Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    _supplier.CompanyName = CompanyName;
                    _supplier.ContactName = ContactName;
                    _supplier.ContactTitle = ContactTitle;
                    _supplier.Address = Address;
                    _supplier.City = City;
                    _supplier.Region = Region;
                    _supplier.PostalCode = PostalCode;
                    _supplier.Country = Country;
                    _supplier.Phone = Phone;
                    _supplier.Fax = Fax;
                    _supplier.HomePage = HomePage;

                    if (_checkAddOrUpdate > 0)
                    {
                        _supplierManager.UpdateSupplier(_supplier, _oldCompanyName);
                        MessageBox.Show("Satıcı bilgileri güncellendi!..", "Info", MessageBoxButton.OK);
                    }
                    else
                    {
                        _supplierManager.CreateSupplier(_supplier);
                        MessageBox.Show("Kayıt başarıyla eklendi!..", "Info", MessageBoxButton.OK);
                    }
                    window.DialogResult = true;
                    window.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Warning");
                }
            }
            
        }
        void CancelCommandExecute(Window window)
        {
            if (SpaceControl() < 8 || _checkChanges)
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
            if (string.IsNullOrEmpty(CompanyName))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(ContactName))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(ContactTitle))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Address))
            {
                errorCount++;
            }           
            if (string.IsNullOrEmpty(City))
            {
                errorCount++;
            }            
            if (string.IsNullOrEmpty(PostalCode))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Country))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Phone))
            {
                errorCount++;
            }
            return errorCount;
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(() => Title);
            }
        }
        private string _pageTitle;
        public string PageTitle
        {
            get => _pageTitle;
            set
            {
                _pageTitle = value;
                OnPropertyChanged(() => PageTitle);
            }
        }
        private string _companyName;
        public string CompanyName
        {
            get => _companyName;
            set
            {
                _companyName = value;
                _checkChanges = true;
                OnPropertyChanged(() => CompanyName);
            }
        }
        private string _contactName;
        public string ContactName
        {
            get => _contactName;
            set
            {
                _contactName = value;
                _checkChanges = true;
                OnPropertyChanged(() => ContactName);
            }
        }
        private string _contactTitle;
        public string ContactTitle
        {
            get => _contactTitle;
            set
            {
                _contactTitle = value;
                _checkChanges = true;
                OnPropertyChanged(() => ContactTitle);
            }
        }
        private string _address;
        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                _checkChanges = true;
                OnPropertyChanged(() => Address);
            }
        }
        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                _checkChanges = true;
                OnPropertyChanged(() => City);
            }
        }
        private string _region;
        public string Region
        {
            get => _region;
            set
            {
                _region = value;
                _checkChanges = true;
                OnPropertyChanged(() => Region);
            }
        }
        private string _postalCode;
        public string PostalCode
        {
            get => _postalCode;
            set
            {
                _postalCode = value;
                _checkChanges = true;
                OnPropertyChanged(() => PostalCode);
            }
        }
        private string _country;
        private string Country
        {
            get => _country;
            set
            {
                _country = value;
                _checkChanges = true;
                OnPropertyChanged(() => Country);
            }
        }
        private string _phone;
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                _checkChanges = true;
                OnPropertyChanged(() => Phone);
            }
        }
        private string _fax;
        public string Fax
        {
            get => _fax;
            set
            {
                _fax = value;
                _checkChanges = true;
                OnPropertyChanged(() => Fax);
            }
        }
        private string _homePage;
        public string HomePage
        {
            get => _homePage;
            set
            {
                _homePage = value;
                _checkChanges = true;
                OnPropertyChanged(() => HomePage);
            }
        }
        public DelegateCommand<Window> SaveCommand { get; }
        public DelegateCommand<Window> CancelCommand { get; }
    }
}
