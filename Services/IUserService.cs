namespace API_Basic_Security_ASP.Services
{
    public interface IUserService
    {
        public bool IsUser(string email, string pass);
    }
}
