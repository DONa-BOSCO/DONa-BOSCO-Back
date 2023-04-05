using API.IServices;
using API.Models;
using Data;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;


namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        private readonly ServiceContext _serviceContext;
        //private readonly IUserSecurityLogic _userSecurityLogic;
        public UserService(ServiceContext serviceContext, IUserLogic userLogic)
        {
            _userLogic = userLogic;
            _serviceContext = serviceContext;
            //_userSecurityLogic = userSecurityLogic;
        }

        public void DeleteUser(int id)
        {
            _userLogic.DeleteUser(id);
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public List<UserItem> GetUsersByCriteria(UserFilter userFilter)
        {
            return _userLogic.GetUsersByCriteria(userFilter);
        }

        int IUserService.InsertUser(UserItem userItem)
        {
            _serviceContext.Users.Add(userItem);
            _serviceContext.SaveChanges();
            return userItem.Id;
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }

        void IUserService.DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }
    }
}
