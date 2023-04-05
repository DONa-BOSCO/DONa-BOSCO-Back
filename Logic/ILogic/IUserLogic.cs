using Entities.Entities;
using API.Models;


namespace Logic.ILogic
{
    public interface IUserLogic
    {
        int InsertUser(UserItem userItem);
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
        void DeactivateUser(int id);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUsersByCriteria(UserFilter userFilter);
    }
}
