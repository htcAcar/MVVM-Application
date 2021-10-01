using StartApp.DataAccess.AdoNet;
using StartApp.Entities.Concrete;
using StartApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartApp.Business
{
    
    public class UserManager
    {
        private UserDal _userDal;
        public UserManager(string connectionString)
        {
           _userDal = new UserDal(connectionString);
        }
        public void CreateNewUser(User user)
        {           
            if (_userDal.Create(user) == 0)
            {
                throw new Exception("Kullanıcı bilgileri kaydedilemedi. tekrar deneyin.");
            }          
        }
        public bool CheckUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Kullanıcı adı veya şifre geçersiz.");
            }
            return _userDal.ExistsUserInLoginPage(name, password);            
        }
        
    }

}
