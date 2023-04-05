using API.IServices;
using API.Models;
using API.Services;
using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.AspNetCore.Mvc;

//using Security.IServices;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        //private readonly IUserSecurityService _userSecurityService;
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            //_userSecurityService = userSecurityService;
            _userService = userService;
        }
        //[HttpPost(Name = "LoginUser")]
        //public string Login([FromBody] LoginRequest loginRequest)
        //{

        //    return _userSecurityService.GenerateAuthorizationToken(loginRequest.UserName, loginRequest.UserPassword);
        //}

        [HttpPost(Name = "InsertUser")]
        public int InsertUser([FromBody] NewUserRequestModel newUserRequestModel)
        {
            
            var userItem = new UserItem();
            userItem.Rol = newUserRequestModel.UserData.Rol; 
            userItem.FullName = newUserRequestModel.UserData.FullName;
            userItem.Email = newUserRequestModel.UserData.Email;
            userItem.Password = newUserRequestModel.UserData.Password;
            userItem.Age = newUserRequestModel.UserData.Age;
            userItem.ShippingAddress = newUserRequestModel.UserData.ShippingAddress;
            userItem.PhoneNumber = newUserRequestModel.UserData.PhoneNumber;
            userItem.InsertDate = newUserRequestModel.UserData.InsertDate;
            userItem.UpdateDate = newUserRequestModel.UserData.UpdateDate;
            userItem.IsActive = newUserRequestModel.UserData.IsActive;
            return _userService.InsertUser(userItem);
        }

        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserItem userItem)
        {
            _userService.UpdateUser(userItem);
        }

        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int id)
        {
            _userService.DeleteUser(id);
        }

        [HttpGet(Name = "GetUserByCriteria")]
        public List<UserItem> GetUserByCriteria([FromQuery] UserFilter userFilter)
        {
            return _userService.GetUsersByCriteria(userFilter);
        }

        [HttpDelete(Name = "DeactivateUser")]
        public void DeactivateUser([FromQuery] int id)
        {
            _userService.DeactivateUser(id);
        }

        
    }
 }



