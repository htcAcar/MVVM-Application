using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StartApp.Business.Tests
{
    [TestClass]
    public class CategoryManagerTests
    {
        CategoryManager _categoryManager;

        [TestInitialize]
        public void TestInitialize()
        {
            _categoryManager = new CategoryManager("Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");
        }

        [TestMethod]
        [Description("CategoryID ve CategoryName bilgilerini Categories tablosundan alma testi")]
        public void Get_Categories_Test()
        {
            var actualResult = _categoryManager.GetCategories();
            Assert.IsNotNull(actualResult);
        }
    }
}
