using API.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserRolController : ControllerBase
{

    private readonly IUserRolService _userRolService;
    public UserRolController(IUserRolService userRolService)
    {
        _userRolService = userRolService;
    }

    [HttpPost(Name = "AddUserRol")]
    public int AddUserRol([FromBody] UserRolItem userRolItem)
    {
        return _userRolService.AddUserRol(userRolItem);
    }

    [HttpGet(Name = "GetAllUserRols")]
    public List<UserRolItem> GetAllUserRol()
    {
        return _userRolService.GetAllUserRol();
    }

    [HttpPatch(Name = "UpdateUserRol")]
    public void Patch([FromBody] UserRolItem userRolItem)
    {
        _userRolService.UpdateUserRol(userRolItem);
    }

    [HttpDelete(Name = "DeleteUserRol")]
    public void DeleteUserRol([FromQuery] int id)
    {
        _userRolService.DeleteUserRol(id);
    }

    [HttpGet(Name = "GetUserRolById")]
    public List<UserRolItem> GetUserRolById([FromQuery] int id)
    {
        return _userRolService.GetUserRolById(id);
    }

    [HttpDelete(Name = "DeactivateUserRol")]
    public void DeactivateUserRol([FromQuery] int id)
    {
        _userRolService.DeactivateUserRol(id);
    }
   }
}
