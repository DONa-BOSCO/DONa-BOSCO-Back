namespace API.IServices
{
    public interface IUserSecurityService
    {
        string GenerateAuthorizationToken(string email, string userPassword);
        bool ValidateUserToken(string authorization, List<string> authorizedRols);
    }
}