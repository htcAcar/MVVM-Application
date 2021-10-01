using System;
using System.Collections.Generic;
using StartApp.DataAccess.AdoNet;
using StartApp.Entities.Concrete;

namespace StartApp.Business
{
    public class SupplierManager
    {
        private SupplierDal _supplierDal;
        public SupplierManager(string connectionString)
        {
            _supplierDal = new SupplierDal(connectionString);
        }
        public List<Supplier> GetSuppliers()
        {
            return _supplierDal.GetAll();
        }  
        public void CreateSupplier(Supplier supplier)
        {
            SupplierValidation(supplier);
            CheckCompanyName(supplier.CompanyName);
            _supplierDal.Create(supplier);
        }
        public void UpdateSupplier(Supplier supplier, string oldCompanyName)
        {
            SupplierValidation(supplier);
            if (supplier.CompanyName != oldCompanyName)
            {
                CheckCompanyName(supplier.CompanyName);
            }
            _supplierDal.Update(supplier);
        }

        private void CheckCompanyName(string companyName)
        {
            if (_supplierDal.ExistsByProductName(companyName))
            {
                throw new Exception("Girdiğiniz şirket ismi farklı bir şirket için kullanılıyor. Şirket ismini değiştirin");
            }
        }

        public void DeleteSupplier(int id)
        {
            if (id == 0)
            {
                throw new Exception("Silmek istediğiniz ürün bulunmadı");
            }
            _supplierDal.Delete(id);
        }

        private void SupplierValidation(Supplier supplier)
        {
            if (string.IsNullOrEmpty(supplier.CompanyName))
            {
                throw new Exception("Şirket adı boş geçilemez!");
            }
            if (string.IsNullOrEmpty(supplier.ContactName))
            {
                throw new Exception("İletişim adı boş geçilemez!");
            }
            if (string.IsNullOrEmpty(supplier.ContactTitle))
            {
                throw new Exception("İletişim başlığı boş geçilemez!");
            }
            if (string.IsNullOrEmpty(supplier.Address))
            {
                throw new Exception("Adres boş geçilemez!");
            }
            if (string.IsNullOrEmpty(supplier.City))
            {
                throw new Exception("Şehir boş geçilemez!");
            }            
            if (string.IsNullOrEmpty(supplier.PostalCode))
            {
                throw new Exception("Posta kodu boş geçilemez!");
            }
            if (string.IsNullOrEmpty(supplier.Country))
            {
                throw new Exception("Ülke boş geçilemez!");
            }
            if (string.IsNullOrEmpty(supplier.Phone))
            {
                throw new Exception("Telefon boş geçilemez!");
            }                 
        }
    }
}
