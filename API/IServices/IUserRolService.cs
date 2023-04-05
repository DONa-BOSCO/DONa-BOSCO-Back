using Entities.Entities;

using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace API.IServices
{
    public interface IUserRolService
    {
        int AddUserRol(UserRolItem userRolItem);
        List<UserRolItem> GetAllUserRol();
        List<UserRolItem> GetUserRolById(int id);
        void DeactivateUserRol(int id);
        void DeleteUserRol(int id);
        void UpdateUserRol(UserRolItem userRolItem);
    }
}