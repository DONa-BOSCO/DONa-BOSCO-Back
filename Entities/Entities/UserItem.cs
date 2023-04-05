


namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem() { }
        public int Id { get; set; }
        public int Rol { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string? ShippingAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        
      

    }
}
