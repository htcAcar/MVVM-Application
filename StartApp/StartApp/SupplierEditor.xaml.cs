using StartApp.Entities.Concrete;
using StartApp.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace StartApp
{
    /// <summary>
    /// Interaction logic for SupplierEditor.xaml
    /// </summary>
    public partial class SupplierEditor : Window
    {
        private SupplierEditorViewModel _vm;
        public SupplierEditor(Supplier supplier)
        {
            InitializeComponent();
            _vm = new SupplierEditorViewModel(supplier);
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

        private void supplierEditorWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _vm.CancelCommand.Execute(this);
        }
    }
}
