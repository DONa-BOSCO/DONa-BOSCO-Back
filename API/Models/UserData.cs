using Entities.Entities;
using System.ComponentModel;

namespace API.Models
{
    public class UserData
    {
        public UserData()
        {
            IsActive = true;
            IdRol = 2; 
        }
        public int IdRol { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
       

        public DateTime InsertDate = DateTime.Now;
        public DateTime UpdateDate = DateTime.Now; 
        public bool IsActive { get; set; }
       
    }
}
