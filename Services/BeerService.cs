using API_Basic_Security_ASP.Models;
using System.Text.Json;

namespace API_Basic_Security_ASP.Services
{
    public class BeerService : IBeerService
    {
        string path = @"C:\Users\CUN\Documents\CUN\Desarrollo\Proyectos\APIs\API_Basic-Security_ASP\API_Basic-Security_ASP\beers.json";
        public async Task<List<Beer>> Get()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers = JsonSerializer.Deserialize<List<Beer>>(content);

            return beers;
        }
    }
}
