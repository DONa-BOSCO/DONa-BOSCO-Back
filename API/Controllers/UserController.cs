using System.Web.Http.Cors;
using API.Attributes;
using API.IServices;
using API.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resources.FilterModels;
using Resources.RequestModels;

namespace API.Controllers
{
    
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserSecurityService _userSecurityService;
        private readonly IUserService _userService;

        public UserController(IUserSecurityService userSecurityService, IUserService userService)
        {
            _userSecurityService = userSecurityService;
            _userService = userService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "LoginUser")]
        public Tuple<string,int> Login([FromBody] LoginRequest loginRequest)
        {
            var usersData = _userService.GetAllUsers();
            UserItem user=usersData.Where(user=> user.Email == loginRequest.Email).First();
            int IdRol=user.IdRol;
            string token = _userSecurityService.GenerateAuthorizationToken(loginRequest.Email, loginRequest.UserPassword);
            return new Tuple<string, int>(token, IdRol); 
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "InsertUser")]
        public int InsertUser([FromBody] NewUserRequest newUserRequest)
        {
            return _userService.InsertUser(newUserRequest);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Operario")]
        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAll()
        {
            return _userService.GetAllUsers();
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserItem userItem)
        {
            _userService.UpdateUser(userItem);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int id)
        {
            _userService.DeleteUser(id);
        }

        // Endpoint para obtener el número de usuarios registrados
        [HttpGet("users/count")]
        public IActionResult GetUserCount()
        {
            int userCount = // Lógica para obtener el número de usuarios registrados en la aplicación
        return Ok(userCount);
        }
        //[EndpointAuthorize(AllowedUserRols = "Administrador, Operario")]
        //[HttpGet(Name = "GetUsersByCriteria")]
        //public List<UserItem> GetByCriteria([FromQuery] UserFilter userFilter)
        //{
        //    return _userService.GetUsersByCriteria(userFilter);
        //}
    }
}
