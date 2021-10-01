using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace StartApp.ViewModels
{
    public class SupplierViewModel
        : ViewModelBase
    {
        private SupplierManager _supplierManager;
        private List<Supplier> _supplierList = new List<Supplier>();

        public SupplierViewModel()
        { 
            _supplierManager = new SupplierManager(Globals.ConnectionString);
            Load();
            RefreshCommand =new DelegateCommand(RefreshCommandExecute);
            AddCommand = new DelegateCommand(AddCommandExecute);
            DeleteCommand = new DelegateCommand<IEnumerable<object>>(DeleteCommandExecute);
            EditCommand = new DelegateCommand<Supplier>(EditCommandExecute);
            DoubleClickCommand = new DelegateCommand<Supplier>(DoubleClickCommandExecute);
        }

        private void Load()
        {
            _supplierList = _supplierManager.GetSuppliers();
            Suppliers= new ObservableCollection<Supplier>(_supplierList);
        }
        private void Search(string searchText)
        {
            Suppliers = new ObservableCollection<Supplier>(_supplierList.Where(s => s.CompanyName.ToLowerInvariant().Contains(searchText)).ToList());
            if (Suppliers.Count == 0)
            {
               FailVisibility = Visibility.Visible;
            }
        }
        void RefreshCommandExecute()
        {
            Load();
        }
        void DoubleClickCommandExecute(Supplier supplier)
        {
            if (supplier == null) return;
            EditCommandExecute(supplier);
        }
        void AddCommandExecute()
        {
            Supplier supplier = new Supplier();
            SupplierEditor supplierEditor = new SupplierEditor(supplier);
            var dialogResult = supplierEditor.ShowDialog();
            if(dialogResult.HasValue && dialogResult.Value && !_supplierList.Any(s => s.SupplierID == supplier.SupplierID))
            {
                _supplierList.Add(new Supplier
                {
                    SupplierID = supplier.SupplierID,
                    CompanyName = supplier.CompanyName,
                    ContactName = supplier.ContactName,
                    ContactTitle = supplier.ContactTitle,
                    Address = supplier.Address,
                    City = supplier.City,
                    Region = supplier.Region,
                    PostalCode = supplier.PostalCode,
                    Country = supplier.Country,
                    Phone = supplier.Phone,
                    Fax = supplier.Fax,
                    HomePage = supplier.HomePage
                });
                Suppliers = new ObservableCollection<Supplier>(_supplierList);
            }
        }
        void EditCommandExecute(Supplier supplier)
        {
            if(supplier != null)
            {
                Supplier updatedSupplier = new Supplier
                {
                    SupplierID = supplier.SupplierID,
                    CompanyName = supplier.CompanyName,
                    ContactName = supplier.ContactName,
                    ContactTitle = supplier.ContactTitle,
                    Address = supplier.Address,
                    City = supplier.City,
                    Region = supplier.Region,
                    PostalCode = supplier.PostalCode,
                    Country = supplier.Country,
                    Phone = supplier.Phone,
                    Fax = supplier.Fax,
                    HomePage = supplier.HomePage
                };
                SupplierEditor supplierEditor = new SupplierEditor(updatedSupplier);
                var dialogResult = supplierEditor.ShowDialog();
                if (dialogResult.HasValue && dialogResult.Value && _supplierList.Any(s => s.SupplierID == updatedSupplier.SupplierID))
                {
                    var editedSupplier = _supplierList.First(s => s.SupplierID == updatedSupplier.SupplierID);
                    editedSupplier.CompanyName = updatedSupplier.CompanyName;
                    editedSupplier.ContactName = updatedSupplier.ContactName;
                    editedSupplier.ContactTitle = updatedSupplier.ContactTitle;
                    editedSupplier.Address = updatedSupplier.Address;
                    editedSupplier.City = updatedSupplier.City;
                    editedSupplier.Region = updatedSupplier.Region;
                    editedSupplier.PostalCode = updatedSupplier.PostalCode;
                    editedSupplier.Country = updatedSupplier.Country;
                    editedSupplier.Phone = updatedSupplier.Phone;
                    editedSupplier.Fax = updatedSupplier.Fax;
                    editedSupplier.HomePage = updatedSupplier.HomePage;
                    Suppliers = new ObservableCollection<Supplier>(_supplierList);
                }
            }
        }
        void DeleteCommandExecute(IEnumerable<object> selectedItems)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Seçtiğiniz kayıtları silmek istiyor musunuz?", "Warning!", button: MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var deletedItems = selectedItems.Cast<Supplier>();
                    foreach (var deletedItem in deletedItems.ToList())
                    {
                        _supplierManager.DeleteSupplier(deletedItem.SupplierID);
                        if (_supplierList.Any(s => s.SupplierID == deletedItem.SupplierID))
                        {
                            _supplierList.Remove(_supplierList.First(p => p.SupplierID == deletedItem.SupplierID));
                            Suppliers.Remove(Suppliers.First(p => p.SupplierID == deletedItem.SupplierID));
                        }
                    }
                    MessageBox.Show("Seçtiğiniz kayıtlar başarıyla silindi");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
       
        private ObservableCollection<Supplier> _suppliers;
        public ObservableCollection<Supplier> Suppliers
        {
            get => _suppliers;
            set
            {
                _suppliers = value;
                OnPropertyChanged(() => Suppliers);
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
        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged(() => SearchText);
                Search(_searchText);
            }
        }
        public DelegateCommand RefreshCommand { get; }
        public DelegateCommand<Supplier> EditCommand { get; }

        public DelegateCommand<IEnumerable<object>> DeleteCommand { get; }

        public DelegateCommand AddCommand { get; }
        public DelegateCommand<Window> BackCommand { get; }
        public DelegateCommand<Supplier> DoubleClickCommand { get; }


    }
}
