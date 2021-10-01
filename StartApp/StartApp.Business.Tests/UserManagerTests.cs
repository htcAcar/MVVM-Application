using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StartApp.Business.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        UserManager _userManager;

        [TestInitialize]
        public void TestInitialize()
        {
            _userManager = new UserManager("Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");
        }

        /*
         * Kullanıcı sisteme login olabilmeli.
         * Login olurken kullanıcı adı ve şifresi kontrol edilmeli. İkisinden birisi boş ise hata vermeli
         * 
         */
        [TestMethod]
        [Description("Login olabilmek için kullanıcı username ve password kontrolü")]
        public void CheckUser_For_Login_Test()
        {                   
            Assert.IsTrue(_userManager.CheckUser("Hatice", "asas"));
        }

        [TestMethod]
        [Description("Login olabilmek için kullanıcı username ve password kontrolü")]
        [ExpectedException(typeof(Exception))]
        public void CheckUser_For_Not_Login_Test()
        {
            Assert.IsTrue(_userManager.CheckUser("Hatice123", "asas"));
        }

        [TestMethod]
        [Description("Login olabilmek için kullanıcı username ve password kontrolü")]
        [ExpectedException(typeof(Exception))]
        public void CheckUser_For_Not2_Login_Test()
        {
            Assert.IsTrue(_userManager.CheckUser("", ""));
        }


        [TestMethod]
        [Description("Users tablosuna yeni kullanıcı ekleme testi,success")]
        public void Create_Success_Test()
        {
            try
            {
                _userManager.CreateNewUser(new Entities.Concrete.User
                {
                    Name = "user",
                    Password = "password",
                    Mail ="mail@mail.com",
                    Phone = "56464654",
                    Birthday = DateTime.Now,
                    City = "Ankara",
                    //Gender = "Male",
                    //Contact = "Phone"

                });
                Assert.IsTrue(true);
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
        [TestMethod]
        [Description("Users tablosuna yeni kullanıcı ekleme testi,fail")]
        [ExpectedException(typeof(Exception))]
        public void Create_Fail_Test()
        {
              _userManager.CreateNewUser(new Entities.Concrete.User
                {
                    
                    Password = "password",
                    Mail = "mail@mail.com",
                    Phone = "56464654",
                    Birthday = new DateTime(2021,02,09),
                    City = "Ankara",
                    //Gender = "Male",
                    //Contact = "Phone"

                });              
                       
        }
    }
}
