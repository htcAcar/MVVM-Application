using StartApp.DataAccess.AdoNet;
using StartApp.Entities.Concrete;
using StartApp.Entities.Dtos;
using System;
using System.Collections.Generic;

namespace StartApp.Business
{
    public class ProductManager
    {
        private ProductDal _productDal;
        public ProductManager(string connectionString)
        {
            _productDal = new ProductDal(connectionString);
        }
        public List<ProductDto> GetProducts()
        {
            return _productDal.GetAll();
        }

        public void CreateProduct(Product product)
        {
            ProductValidation(product);
            CheckProductName(product.ProductName);
            _productDal.Create(product);
        }

        public void UpdateProduct(Product product, string oldProductName)
        {
            ProductValidation(product);

            if (product.ProductName != oldProductName)
            {
                CheckProductName(product.ProductName);
            }

            _productDal.Update(product);
        }

        private void CheckProductName(string productName)
        {
            if (_productDal.ExistsByProductName(productName))
            {
                throw new Exception("Girdiğiniz ürün ismi farklı bir ürünü için kullanılıyor. Ürün ismini değiştirin");
            }
        }

        private void ProductValidation(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName))
            {
                throw new Exception("Ürün adı boş geçilemez");
            }
            if (product.UnitPrice < 0)
            {
                throw new Exception("Ürünü fiyatı 0'dan küçü olamaz.");
            }
            if (product.CategoryID == 0)
            {
                throw new Exception("Kategori seçiniz!");
            }
            if (product.SupplierID == 0)
            {
                throw new Exception("Supplier seçiniz!");
            }
        }

        public void DeleteProduct(int id)
        {
            if (id == 0)
            {
                throw new Exception("Silmek istediğiniz ürün bulunmadı");
            }
            _productDal.Delete(id);               
        }
    }
}
