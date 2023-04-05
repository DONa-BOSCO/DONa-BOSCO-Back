using API.Models;
using Entities.Entities;
using Logic.ILogic;


namespace API.IServices
{
    public interface IUserService
    {
        int InsertUser(UserItem userItem);
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
        void DeactivateUser(int id);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUsersByCriteria(UserFilter userFilter);
    }
}
