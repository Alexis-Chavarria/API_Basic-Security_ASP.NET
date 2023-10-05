using API_Basic_Security_ASP.Models;

namespace API_Basic_Security_ASP.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        {
            new User(){ email = "alexis@gmail.com", password = "123"},
            new User(){ email = "johan@gmail.com", password = "123"}
        };

        public bool IsUser(string email, string password) =>
            users.Where(d => d.email == email && d.password == password).Count() > 0;



    }
}
