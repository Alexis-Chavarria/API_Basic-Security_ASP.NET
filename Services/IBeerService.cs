using API_Basic_Security_ASP.Models;

namespace API_Basic_Security_ASP.Services
{
    public interface IBeerService
    {
        public Task<List<Beer>> Get();
    }
}
