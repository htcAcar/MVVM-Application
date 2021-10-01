using StartApp.Entities.Enums;
using System;

namespace StartApp.Entities.Concrete
{
    public class User 
    {
         public int UserID { get; set; }
         public string Name { get; set; }
         public string Password { get; set; }
         public string Mail { get; set; }
         public string Phone { get; set; }
         public DateTime? Birthday { get; set; }
         public string City { get; set; }
         public Genders Gender { get; set; }
         public Contacts Contact { get; set; }
           
    }
}
