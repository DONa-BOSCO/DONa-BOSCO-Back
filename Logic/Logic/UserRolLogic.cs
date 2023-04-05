using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserRolLogic : BaseContextLogic, IUserRolLogic
    {
        public UserRolLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public int AddUserRol(UserRolItem userRolItem)
        {
            _serviceContext.UserRol.Add(userRolItem);
            _serviceContext.SaveChanges();
            return userRolItem.Id;
        }

        public void DeactivateUserRol(int id)
        {
            var userRolToDeactivate = _serviceContext.Set<UserRolItem>()
           .Where(i => i.Id == id).First();

            userRolToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }

        public void DeleteUserRol(int id)
        {
            _serviceContext.UserRol.Remove(_serviceContext.Set<UserRolItem>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();
        }

        public List<UserRolItem> GetAllUserRol()
        {
            return _serviceContext.Set<UserRolItem>().ToList();
        }

        public List<UserRolItem> GetUserRolById(int id)
        {
            var selection = _serviceContext.Set<UserRolItem>()
                .Where(i => i.Id == id).ToList();
            return selection;
        }

        public void UpdateUserRol(UserRolItem userRolItem)
        {
            _serviceContext.UserRol.Update(userRolItem);
            _serviceContext.SaveChanges();
        }

    }
}
