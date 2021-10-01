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
    public class CategoryViewModel : ViewModelBase
    {
        private CategoryManager _categoryManager;
        private List<Category> _categoryList = new List<Category>();

        public CategoryViewModel()
        {
            _categoryManager = new CategoryManager(Globals.ConnectionString);
            Load();
            RefreshCommand = new DelegateCommand(RefreshCommandExecute);
            AddCommand = new DelegateCommand(AddCommandExecute);
            DeleteCommand = new DelegateCommand<IEnumerable<object>>(DeleteCommandExecute);
            EditCommand = new DelegateCommand<Category>(EditCommandExecute);
            DoubleClickCommand = new DelegateCommand<Category>(DoubleClickCommandExecute);
        }

        private void Load()
        {
            _categoryList = _categoryManager.GetCategories();
            Categories = new ObservableCollection<Category>(_categoryList); 
        }
        private void Search(string searchText)
        {
            Categories = new ObservableCollection<Category>(_categoryList.Where(c => c.CategoryName.ToLowerInvariant().Contains(searchText)).ToList());
            if (Categories.Count == 0)
            {
                FailVisibility = Visibility.Visible;
            }
        }
        void RefreshCommandExecute()
        {
            Load();
        }
        void DoubleClickCommandExecute(Category category)
        {
            if (category == null) return;
            EditCommandExecute(category);
        }
        void AddCommandExecute()
        {
            Category category = new Category();
            CategoryEditor categoryEditor = new CategoryEditor(category);
            var dialogResult = categoryEditor.ShowDialog();
            if (dialogResult.HasValue && dialogResult.Value && !_categoryList.Any(c => c.CategoryID == category.CategoryID))
            {
                _categoryList.Add(new Category
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description                    
                });
                Categories = new ObservableCollection<Category>(_categoryList);
            }
        }
        void EditCommandExecute(Category category)
        {
            if (category != null)
            {
                Category updatedCategory = new Category
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };
                CategoryEditor categoryEditor = new CategoryEditor(category);
                var dialogResult = categoryEditor.ShowDialog();
                if (dialogResult.HasValue && dialogResult.Value && _categoryList.Any(c => c.CategoryID == category.CategoryID))
                {
                    var editedCategory = _categoryList.First(c => c.CategoryID == updatedCategory.CategoryID);
                    editedCategory.CategoryID = updatedCategory.CategoryID;
                    editedCategory.CategoryName = updatedCategory.CategoryName;
                    editedCategory.Description = updatedCategory.Description;                    
                    Categories = new ObservableCollection<Category>(_categoryList);
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
                    var deletedItems = selectedItems.Cast<Category>();
                    foreach (var deletedItem in deletedItems.ToList())
                    {
                        _categoryManager.DeleteCategory(deletedItem.CategoryID);
                        if (_categoryList.Any(c => c.CategoryID == deletedItem.CategoryID))
                        {
                            _categoryList.Remove(_categoryList.First(p => p.CategoryID == deletedItem.CategoryID));
                            Categories.Remove(Categories.First(p => p.CategoryID == deletedItem.CategoryID));
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

        private ObservableCollection<Category> _categories;
        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                OnPropertyChanged(() => Categories);
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
        public DelegateCommand<Category> EditCommand { get; }

        public DelegateCommand<IEnumerable<object>> DeleteCommand { get; }

        public DelegateCommand AddCommand { get; }
        public DelegateCommand<Window> BackCommand { get; }
        public DelegateCommand<Category> DoubleClickCommand { get; }


    }
}

