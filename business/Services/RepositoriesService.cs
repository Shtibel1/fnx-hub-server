using BL.Interfaces;
using BL.Models;
using Newtonsoft.Json;

namespace BL.Services
{
    public class RepositoriesService : IRepositoriesService
    {
        private readonly HttpClient _client;

        public RepositoriesService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<RepositoryModel>> GetRepositoriesAsync(string search)
        {
            var res = await _client.GetAsync($"https://api.github.com/search/repositories?q={search}");
            var resStr = await res.Content.ReadAsStringAsync();
            var repositoriesJson = JsonConvert.DeserializeObject<RepositoriesJson>(resStr);
            return repositoriesJson?.Items?.ToList() ?? new List<RepositoryModel>();
        }
    }
}

class RepositoriesJson
{
    public List<RepositoryModel> Items { get; set; }
}
