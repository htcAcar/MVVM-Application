using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using StartApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StartApp.ViewModels
{
    public class ProductWindowViewModel
        : ViewModelBase
    {
        private List<ProductDto> _orginialProducts = new List<ProductDto>();

        private ProductManager _productManager;
        public ProductWindowViewModel()
        {
            _productManager = new ProductManager(Globals.ConnectionString);
            Loaded();
            RefreshCommand = new DelegateCommand<Window>(RefreshCommandExecute);
            AddCommand = new DelegateCommand(AddCommandExecute);            
            EditCommand = new DelegateCommand<ProductDto>(EditCommandExecute);              
            DeleteCommand = new DelegateCommand<IEnumerable<object>>(DeleteCommandExecute);
            DoubleClickCommand = new DelegateCommand<ProductDto>(DoubleClickCommandExecute);
            BackCommand = new DelegateCommand<Window>(BackCommandExecute);
        }

        private void Loaded()
        {
            _orginialProducts = _productManager.GetProducts();
            Products = new ObservableCollection<ProductDto>(_orginialProducts);
        }

        private void Search(string searchText)
        {
            Products = new ObservableCollection<ProductDto>(_orginialProducts.Where(p => p.ProductName.ToLowerInvariant().Contains(searchText)).ToList());
            if(Products.Count == 0)
            {
                FailVisibility = Visibility.Visible;
            }
        }

        private ObservableCollection<ProductDto> _products;
        public ObservableCollection<ProductDto> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged(() => Products);
            }
        }

         private ProductDto _selectedProduct;
         public ProductDto SelectedProduct
         {
             get => _selectedProduct;
             set
             {
                _selectedProduct = value;
                OnPropertyChanged(() => SelectedProduct);
             }
         }


        void RefreshCommandExecute(Window window )
        {
            Loaded();
            window.UpdateLayout();
        }

        void AddCommandExecute()
        {
            Product product = new Product();
            ProductEditor productEditor = new ProductEditor(product);
            var dialogResult = productEditor.ShowDialog();
            if (dialogResult.HasValue && dialogResult.Value && !_orginialProducts.Any(p => p.ProductID == product.ProductID))
            {
                _orginialProducts.Add(new ProductDto
                {
                    Category = productEditor.cbCategory.Text,
                    CompanyName = productEditor.cbCompanyName.Text,
                    CategoryID = product.CategoryID,
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    QuantityPerUnit = product.QuantityPerUnit,
                    SupplierID = product.SupplierID,
                    UnitPrice = product.UnitPrice
                });
                Products = new ObservableCollection<ProductDto>(_orginialProducts);
            }
        }

        void EditCommandExecute(ProductDto productDto)
        {
            if(productDto != null)
            {
                Product updateProduct = new Product
                {
                    ProductID = productDto.ProductID,
                    ProductName = productDto.ProductName,
                    SupplierID = productDto.SupplierID,
                    CategoryID = productDto.CategoryID,
                    QuantityPerUnit = productDto.QuantityPerUnit,
                    UnitPrice = productDto.UnitPrice
                };
                ProductEditor productEditor = new ProductEditor(updateProduct);
                var dialogResult = productEditor.ShowDialog();
                if (dialogResult.HasValue && dialogResult.Value && _orginialProducts.Any(p => p.ProductID == updateProduct.ProductID))
                {
                    var editedProduct = _orginialProducts.First(p => p.ProductID == updateProduct.ProductID);
                    editedProduct.ProductID = updateProduct.ProductID;
                    editedProduct.ProductName = updateProduct.ProductName;
                    editedProduct.CompanyName = _orginialProducts.Find(s => s.SupplierID == updateProduct.SupplierID).CompanyName;
                    editedProduct.Category = _orginialProducts.Find(c => c.CategoryID == updateProduct.CategoryID).Category;
                    editedProduct.QuantityPerUnit = updateProduct.QuantityPerUnit;
                    editedProduct.UnitPrice = updateProduct.UnitPrice;
                    Products = new ObservableCollection<ProductDto>(_orginialProducts);
                }
            }
           
        }
        
        void DeleteCommandExecute(IEnumerable<object> selectedItems)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Seçtiğiniz ürünleri silmek istiyor musunuz?", "Warning!", button: MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var deletedItems = selectedItems.Cast<ProductDto>();
                    foreach (var deletedItem in deletedItems.ToList())
                    {
                        _productManager.DeleteProduct(deletedItem.ProductID);
                        if (_orginialProducts.Any(p => p.ProductID == deletedItem.ProductID))
                        {
                            _orginialProducts.Remove(_orginialProducts.First(p => p.ProductID == deletedItem.ProductID));
                            Products.Remove(Products.First(p => p.ProductID == deletedItem.ProductID));
                        }
                    }
                    MessageBox.Show("Seçtiğiniz ürünler başarıyla silindi");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        void DoubleClickCommandExecute(ProductDto productDto)
        {
                if (productDto == null) return;
                EditCommandExecute(productDto);
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

        void BackCommandExecute(Window window)
        {
            window.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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

        public DelegateCommand<Window> RefreshCommand { get; }
        public DelegateCommand AddCommand { get; }
        public DelegateCommand<ProductDto> EditCommand { get; }
        public DelegateCommand<IEnumerable<object>> DeleteCommand { get; }
        public DelegateCommand<ProductDto> DoubleClickCommand { get; }
        public DelegateCommand<Window> BackCommand { get; }

    }
}
