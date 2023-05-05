using BL.Models;

namespace BL.Interfaces
{
    public interface IRepositoriesService
    {
        Task<List<RepositoryModel>> GetRepositoriesAsync(string search);
    }
}