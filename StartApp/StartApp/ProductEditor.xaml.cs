using StartApp.Entities.Concrete;
using System.Windows;
using System.Windows.Input;
using StartApp.ViewModels;

namespace StartApp
{
    public partial class ProductEditor : Window
    {       
        private ProductEditorViewModel _vm;
        public ProductEditor(Product updateProduct)
        {
            InitializeComponent();            
            _vm = new ProductEditorViewModel(updateProduct);
             this.DataContext = _vm;
        }

        private void SaveOrCancelKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                _vm.SaveCommand.Execute(this);
            }
            if (e.Key == Key.Escape)
            {
                _vm.CancelCommand.Execute(this);
            }
        }

        private void productEditorWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _vm.CancelCommand.Execute(this);
        }
    }

}