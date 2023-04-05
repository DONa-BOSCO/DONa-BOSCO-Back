using Entities.Entities;
using System.ComponentModel;

namespace API.Models
{
    public class UserData
    {
        public UserData()
        {
            IsActive = true;
            Rol = 2; 
        }
        public int Rol { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string? ShippingAddress { get; set; }
        public string? PhoneNumber { get; set; }

        public DateTime InsertDate = DateTime.Now;
        public DateTime UpdateDate = DateTime.Now; 
        public bool IsActive { get; set; }
       
    }
}
