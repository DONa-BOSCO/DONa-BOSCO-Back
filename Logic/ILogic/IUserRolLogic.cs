using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserRolLogic
    {
        int AddUserRol(UserRolItem userRolItem);
        List<UserRolItem> GetAllUserRol();
        List<UserRolItem> GetUserRolById(int id);
        void DeactivateUserRol(int id);
        void DeleteUserRol(int id);
        void UpdateUserRol(UserRolItem userRolItem);
    }
}
