using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StartApp.Business.Tests
{
    [TestClass]
    public class SupplierManagerTests
    {
        SupplierManager _supplierManager;

        [TestInitialize]
        public void TestInitialize()
        {
            _supplierManager = new SupplierManager("Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");
        }

        [TestMethod]
        [Description("SupplierID ve CompanyName bilgilerini Suppliers tablosundan alma testi")]
        public void Get_Suppliers_Test()
        {
            var actualResult = _supplierManager.GetSuppliers();
            Assert.IsNotNull(actualResult);
        }
    }
}
