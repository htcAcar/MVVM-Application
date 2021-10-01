using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StartApp.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        ProductManager _productManager;

        [TestInitialize]
        public void TestInitialize()
        {
            _productManager = new ProductManager("Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");
        }

        [TestMethod]
        [Description("Product kayıtlarının tümünü db'den çekme testi")]
        public void GetAll_Test()
        {
            var actualResult = _productManager.GetProducts();

            // Asssert
            Assert.IsNotNull(actualResult);
        }

        [TestMethod]
        [Description("Yeni bir ürün ekleme testi, success")]
        public void Create_Success_Test()
        {
            try
            {
                _productManager.CreateProduct(new Entities.Concrete.Product
                {
                    CategoryID = 1,
                    ProductName = "Test 2",
                    QuantityPerUnit = "1",
                    UnitPrice = 1,
                    SupplierID = 1
                });
                Assert.IsTrue(true);
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }

        [TestMethod]
        [Description("Yeni bir ürün ekleme testi,fail")]
        [ExpectedException(typeof(Exception))]
        public void Create_Fail_Test()
        {
            _productManager.CreateProduct(new Entities.Concrete.Product
            {
                CategoryID = 1,
                ProductName = "Test 1",
                QuantityPerUnit = "1",
                UnitPrice = -11,
                SupplierID = 1
            });
        }

        [TestMethod]
        [Description("Mevcut ürünü güncelleme testi,ProductName kontrol, success")]
        public void UpdateProduct_Compare_ProductName_Success_Test()
        {
            string oldName = "Chang";
            try
            {
                _productManager.UpdateProduct(new Entities.Concrete.Product
                {
                    ProductName = "Chang",
                    SupplierID = 16,
                    CategoryID = 1,
                    QuantityPerUnit= "24-12 oz bottles",
                    UnitPrice = 10,                    
                }, oldName);
                Assert.IsTrue(true);
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }

        [TestMethod]
        [Description("Mevcut ürünü güncelleme testi,ProductName kontrol, fail")]
        [ExpectedException(typeof(Exception))]
        public void UpdateProduct_Compare_ProductName_Fail_Test()
        {
            string oldName = "Aniseed Syrup";
         
                _productManager.UpdateProduct(new Entities.Concrete.Product
                {
                    ProductName = "Chang",
                    SupplierID = 16,
                    CategoryID = 1,
                    QuantityPerUnit = "24-12 oz bottles",
                    UnitPrice = 10,
                }, oldName);           
        }

        [TestMethod]
        [Description("Ürün silme test, productId kontrol, success")]
   
        public void DeleteProduct_Check_By_Id_Success_Test()
        {            
            try
            {
                _productManager.DeleteProduct(99);
                Assert.IsTrue(true);
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }

        } 

        [TestMethod]
        [Description("Ürün silme test, productId kontrol, fail")]
        [ExpectedException(typeof(Exception))]
        public void DeleteProduct_Check_By_Id_Fail_Test()
        {                       
            _productManager.DeleteProduct(0);        
        }
     

    }
}
