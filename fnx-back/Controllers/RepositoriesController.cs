using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fnx_back.Controllers
{
    public class RepositoriesController : _baseController
    {
        private readonly IRepositoriesService _repositoriesService;

        public RepositoriesController(IRepositoriesService repositoriesService) 
        {
            _repositoriesService = repositoriesService;
        }

        [HttpGet("{search}")]
        [Authorize]
        public async Task<IActionResult> GetRepositories(string search)
        {
            try
            {
                var repos = await _repositoriesService.GetRepositoriesAsync(search);
                return Ok(repos);
            }
            catch (Exception ex)
            {

                return BadRequest("");
            }
        }
    }
}
