using StartApp.Entities.Concrete;
using StartApp.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace StartApp
{
    /// <summary>
    /// Interaction logic for CategoryEditor.xaml
    /// </summary>
    public partial class CategoryEditor : Window
    {
        private CategoryEditorViewModel _vm;
        
        public CategoryEditor(Category category)
        {
            InitializeComponent();
            _vm = new CategoryEditorViewModel(category);
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
       
        private void categoryEditorWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {          
            _vm.CancelCommand.Execute(this);                       
        }
    }
}