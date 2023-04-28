using API.IServices;
using Entities.Entities;
using Logic.ILogic;
using Resources.FilterModels;
using Resources.RequestModels;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        private readonly IUserSecurityLogic _userSecurityLogic;
        public UserService(IUserLogic userLogic, IUserSecurityLogic userSecurityLogic)
        {
            _userLogic = userLogic;
            _userSecurityLogic = userSecurityLogic;
        }

        public void DeleteUser(int id)
        {
            _userLogic.DeleteUser(id);
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

       

        public int InsertUser(NewUserRequest newUserRequest)
        {
            var newUserItem = newUserRequest.ToUserItem();
            newUserItem.EncryptedPassword = _userSecurityLogic.HashString(newUserRequest.Password);
            return _userLogic.InsertUser(newUserItem);
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }
        public int InsertUser(UserItem userItem)
        {
            if (!ValidateModel(userItem))
            {
                throw new InvalidDataException();
            }
            _userLogic.InsertUser(userItem);
            if (!ValidateInsertedEvent(userItem))

            {
                throw new InvalidOperationException();
            }
            return userItem.IdRol;


        }

        public static bool ValidateModel(UserItem userItem)
        {

            if (userItem == null)
            {
                return false;
            }

            if (userItem.UserName == null || userItem.UserName == "")
            {
                return false; ;
            }


            return true;
        }

        public static bool ValidateInsertedEvent(UserItem userItem)
        {
            if (!ValidateModel(userItem))

            {
                return false;
            }
            if (userItem.IdRol < 1)
            {
                return false;
            }
            return true;
        }
    }
}
