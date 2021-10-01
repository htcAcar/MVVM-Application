using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using System.Windows;

namespace StartApp.ViewModels
{
    class DetailWindowViewModel :ViewModelBase
    {
              
        public DetailWindowViewModel()
        {
            BackCommand = new DelegateCommand<Window>(BackCommandExecute);           
            Load();
            if (SelectedTab == 0)
            {
                SelectedObject = new Category();
            }
            else
            {
                SelectedObject = new Supplier();
            }
        }
        private void Load()
        {
            SupplierViewModel = new SupplierViewModel();
            CategoryViewModel = new CategoryViewModel();
        }
        void BackCommandExecute(Window window)
        {
            window.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }


        private int _selectedTab;
        public int SelectedTab
        {
            get => _selectedTab;
            set
            {
                _selectedTab = value;
                OnPropertyChanged(() => SelectedTab);
            }
        }
        private object _selectedObject;
        public object SelectedObject
        {
            get => _selectedObject;
            set
            {
                _selectedObject = value;
                OnPropertyChanged(() => SelectedObject);
            }
        }

        private SupplierViewModel _supplierViewModel;
        public SupplierViewModel SupplierViewModel
        {
            get => _supplierViewModel;
            set
            {
                _supplierViewModel = value;
                OnPropertyChanged(() => SupplierViewModel);
            }
        }
        private CategoryViewModel _categoryViewModel;
        public CategoryViewModel CategoryViewModel
        {
            get => _categoryViewModel;
            set
            {
                _categoryViewModel = value;
                OnPropertyChanged(() => CategoryViewModel);
            }
        }

        public DelegateCommand<Window> BackCommand { get; }

    }
}
