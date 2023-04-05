using API.IServices;
using Entities.Entities;
using Logic.ILogic;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public class UserRolService : IUserRolService
    {
        private readonly IUserRolLogic _userRolLogic;

        public UserRolService(IUserRolLogic userRolLogic)
        {
            _userRolLogic = userRolLogic;
        }

        void IUserRolService.DeactivateUserRol(int id)
        {
            _userRolLogic.DeactivateUserRol(id);
        }


        public void DeleteUserRol(int id)
        {
            _userRolLogic.DeleteUserRol(id);
        }

        public List<UserRolItem> GetAllUserRol()
        {
            return _userRolLogic.GetAllUserRol();
        }

        public List<UserRolItem> GetUserRolById(int id)
        {
            return _userRolLogic.GetUserRolById(id);
        }

        public int AddUserRol(UserRolItem userRolItem)
        {

            return _userRolLogic.AddUserRol(userRolItem);
        }

        public void UpdateUserRol(UserRolItem userRolItem)
        {
            _userRolLogic.UpdateUserRol(userRolItem);
        }
    }
}
