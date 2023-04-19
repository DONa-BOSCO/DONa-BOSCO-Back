using API.IServices;
using Logic.ILogic;
using API.Services;

namespace API.Services
{
    public class UserSecurityService : IUserSecurityService
    {
        private readonly IUserSecurityLogic _userSecurityLogic;
        public UserSecurityService(IUserSecurityLogic userSecurityLogic)
        {
            _userSecurityLogic = userSecurityLogic;
        }
        public string GenerateAuthorizationToken(string email, string userPassword)
        {
            return _userSecurityLogic.GenerateAuthorizationToken(email, userPassword);
        }
        public bool ValidateUserToken(string authorization, List<string> authorizedRols)
        {
            var email = GetUserNameFromAuthorization(authorization);
            var token = GetTokenFromAuthorization(authorization);
            return _userSecurityLogic.ValidateUserToken(email, token, authorizedRols);
        }
        private string GetUserNameFromAuthorization(string authorization)
        {
            var indexToSplit = authorization.IndexOf(':');
            return authorization.Substring(7, indexToSplit - 7);
        }
        private string GetTokenFromAuthorization(string authorization)
        {
            var indexToSplit = authorization.IndexOf(':');
            var email = authorization.Substring(7, indexToSplit - 7);
            return authorization.Substring(indexToSplit + 1, authorization.Length - email.Length - 8);
        }
    }
}