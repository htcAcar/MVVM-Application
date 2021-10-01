using Karmasis.MVVM.Core;
using StartApp.Business;
using StartApp.Entities.Concrete;
using System;
using System.Windows;

namespace StartApp.ViewModels
{
    class CategoryEditorViewModel : ViewModelBase
    {
        private Category _category;
        private CategoryManager _categoryManager;
        private string _oldCategoryName;
        int _checkAddOrUpdate =0;
        bool _checkChanges = false;


        public CategoryEditorViewModel(Category updateCategory)
        {
            SaveCommand = new DelegateCommand<Window>(SaveCommandExecute);
            CancelCommand = new DelegateCommand<Window>(CancelCommandExecute);
            _categoryManager = new CategoryManager(Globals.ConnectionString);
            _category = updateCategory;
            _oldCategoryName = updateCategory.CategoryName;

            try
            {
                if (updateCategory.CategoryID > 0)
                {
                    CategoryName = updateCategory.CategoryName;
                    Description = updateCategory.Description;
                    _checkAddOrUpdate = updateCategory.CategoryID;
                    _checkChanges = false;
                    PageTitle =String.Format("{0} Update",CategoryName);
                    Title = "Update";
                }
                else
                {
                    PageTitle = "Add Record";
                    Title = "Add Record";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Warning");
            }
        }
      
        void SaveCommandExecute(Window window)
        {
            if(SpaceControl() != 0)
            {
                MessageBox.Show("Lütfen gerekli boşlukları doldurun! ", "Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    _category.CategoryName = CategoryName;
                    _category.Description = Description;

                    if (_checkAddOrUpdate > 0)
                    {
                        _categoryManager.UpdateCategory(_category, _oldCategoryName);
                        MessageBox.Show("Kategori bilgileri güncellendi!..", "Info", MessageBoxButton.OK);
                    }
                    else
                    {
                        _categoryManager.CreateCategory(_category);
                        MessageBox.Show("Kategori bilgileri başarıyla eklendi!..", "Info", MessageBoxButton.OK);
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
            if(SpaceControl() == 1 || _checkChanges)
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
            if (string.IsNullOrEmpty(CategoryName))
            {
                errorCount++;
            }
            if (string.IsNullOrEmpty(Description))
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
        private string _categoryName;
        public string CategoryName
        {
            get => _categoryName;
            set
            {
                _categoryName = value;
                _checkChanges = true;
                OnPropertyChanged(() => CategoryName);
            }
        }
        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                _checkChanges = true;
                OnPropertyChanged(() => Description);
            }
        }       
        public DelegateCommand<Window> SaveCommand { get; }
        public DelegateCommand<Window> CancelCommand { get; }
    }
}
