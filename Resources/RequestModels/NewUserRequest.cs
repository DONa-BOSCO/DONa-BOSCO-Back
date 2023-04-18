using Entities.Entities;

namespace Resources.RequestModels
{
    public class NewUserRequest
    {
        public int IdRol { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            userItem.IdRol = 2;
            userItem.FirstName = FirstName;
            userItem.LastName = LastName;
            userItem.UserName = UserName;
            userItem.Email = Email;
            userItem.Password = Password;
            userItem.InsertDate = DateTime.Now;
            userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;

            return userItem;
        }
    }
}
