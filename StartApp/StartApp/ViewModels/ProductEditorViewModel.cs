using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows;

namespace StartApp.ViewModels
{
    class ProductEditorViewModel : ViewModelBase
    {
        
        private Product _product;
        private ProductManager _productManager;
        private SupplierManager _supplierManager;
        private CategoryManager _categoryManager;
        private string _oldProductName;
        int _checkAddOrUpdate = 0;
        bool _checkChanges = false;

        public ProductEditorViewModel(Product updateProduct)
        {           
            SaveCommand = new DelegateCommand<Window>(SaveCommandExecute);
            CancelCommand = new DelegateCommand<Window>(CancelCommandExecute);

            _productManager = new ProductManager(Globals.ConnectionString);
            _categoryManager = new CategoryManager(Globals.ConnectionString);
            _supplierManager = new SupplierManager(Globals.ConnectionString);
            _product = updateProduct;
            _oldProductName = updateProduct.ProductName;
       
             try
             {
                 SupplierList = _supplierManager.GetSuppliers();
                 CategoryList = _categoryManager.GetCategories();

                 if (updateProduct.ProductID > 0)
                 {                      
                     this.Title = "Product Update";
                     Title = "Product Update";
                     ProductName = updateProduct.ProductName;
                     SelectedCategory = CategoryList.Find(c => c.CategoryID == updateProduct.CategoryID);
                     SelectedCompanyName = SupplierList.Find(s => s.SupplierID == updateProduct.SupplierID);
                     Category = SelectedCategory.CategoryName;
                     CompanyName = SelectedCompanyName.CompanyName;
                     QuantityPerUnit = updateProduct.QuantityPerUnit;
                     UnitPrice = updateProduct.UnitPrice.ToString();
                     SelectedCategory.CategoryName = Category;
                     SelectedCompanyName.CompanyName = CompanyName;
                     _checkAddOrUpdate = updateProduct.ProductID;

                 }
                 else
                 {
                     this.Title = "Add Product";
                     Title= "Add Product";
                 }
             }
             catch (Exception exception)
             {
                 MessageBox.Show(exception.Message, "Warning");
             }


        }
     
        private List<Supplier> _suplierList;
        public List<Supplier> SupplierList
        {
            get => _suplierList;
            set
            {
                _suplierList = value;
                OnPropertyChanged(() => SupplierList);
            }
        }
        private List<Category> _categoryList;
        public List<Category> CategoryList
        {
            get => _categoryList;
            set
            {
                _categoryList = value;
                OnPropertyChanged(() => CategoryList);
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
                    _product.ProductName = ProductName;
                    _product.SupplierID = SelectedCompanyName.SupplierID;
                    _product.CategoryID = SelectedCategory.CategoryID;
                    _product.QuantityPerUnit = QuantityPerUnit;
                    _product.UnitPrice = Convert.ToDecimal(UnitPrice);

                    if (_checkAddOrUpdate > 0)
                    {
                        _productManager.UpdateProduct(_product, _oldProductName);
                        MessageBox.Show("Ürün güncellendi!..", "Info", MessageBoxButton.OK);
                    }
                    else
                    {
                        _productManager.CreateProduct(_product);
                        MessageBox.Show("Ürün başarıyla eklendi!..");                        
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
            if (SpaceControl() < 5 || _checkChanges)
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

            if (string.IsNullOrEmpty(ProductName))
            {              
                errorCount++;
            }
            if (string.IsNullOrEmpty(QuantityPerUnit))
            { 
                errorCount++;
            }
            if (string.IsNullOrEmpty(UnitPrice))
            {  
                errorCount++;
            }
            if (string.IsNullOrEmpty(CompanyName))
            {   
                errorCount++;
            }
            if (string.IsNullOrEmpty(Category))
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

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                _checkChanges = true;
                OnPropertyChanged(() => ProductName);
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
        private Supplier _selectedCompanyName;
        public Supplier SelectedCompanyName
        {
            get => _selectedCompanyName;
            set
            {
                _selectedCompanyName = value;
                _checkChanges = true;
                OnPropertyChanged(() => SelectedCompanyName);
            }
        }

        private string _category;
        public string Category
        {
            get => _category;
            set
            {
                _category = value;
                _checkChanges = true;
                OnPropertyChanged(() => Category);
            }
        }
        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                _selectedCategory = value;
                _checkChanges = true;
                OnPropertyChanged(() => SelectedCategory);
            }
        }

        private string _quantityPerUnit;
        public string QuantityPerUnit
        {
            get => _quantityPerUnit;
            set
            {
                _quantityPerUnit = value;
                _checkChanges = true;
                OnPropertyChanged(() => QuantityPerUnit);
            }
        }

        private string _unitPrice;
        public string UnitPrice
        {
            get => _unitPrice;
            set
            {
                _unitPrice = value;
                _checkChanges = true;
                OnPropertyChanged(() => UnitPrice);
            }
        }

        private Visibility _errorVisibility = Visibility.Collapsed;
        public Visibility ErrorVisibility
        {
            get => _errorVisibility;
            set
            {
                _errorVisibility = value;
                _checkChanges = true;
                OnPropertyChanged(() => ErrorVisibility);
            }
        }
        public DelegateCommand<Window> SaveCommand { get; }

        public DelegateCommand<Window> CancelCommand { get; }

    }
}
