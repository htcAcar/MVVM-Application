using System;
using System.Collections.Generic;
using StartApp.DataAccess.AdoNet;
using StartApp.Entities.Concrete;


namespace StartApp.Business
{
    public class CategoryManager
    {
        private CategoryDal _categoryDal;
        public CategoryManager(string connectionString)
        {
            _categoryDal = new CategoryDal(connectionString);
        }
        public List<Category> GetCategories()
        {
            return _categoryDal.GetAll();
        }
        public void CreateCategory(Category category)
        {
            CategoryValidation(category);
            CheckCategoryName(category.CategoryName);
            _categoryDal.Create(category);
        }
        public void UpdateCategory(Category category, string oldCategoryName)
        {
            CategoryValidation(category);
            if (category.CategoryName != oldCategoryName)
            {
                CheckCategoryName(category.CategoryName);
            }
            _categoryDal.Update(category);
        }

        private void CheckCategoryName(string categoryName)
        {
            if (_categoryDal.ExistsByProductName(categoryName))
            {
                throw new Exception("Girdiğiniz kategori ismi farklı bir kategori için kullanılıyor. kategori ismini değiştirin");
            }
        }

        public void DeleteCategory(int id)
        {
            if (id == 0)
            {
                throw new Exception("Silmek istediğiniz ürün bulunmadı");
            }
            _categoryDal.Delete(id);
        }

        private void CategoryValidation(Category category)
        {
            if (string.IsNullOrEmpty(category.CategoryName))
            {
                throw new Exception("Kategori adı boş geçilemez!");
            }
            if (string.IsNullOrEmpty(category.Description))
            {
                throw new Exception("Açıklama kısmı boş geçilemez!");
            }
           
        }
    }
}
