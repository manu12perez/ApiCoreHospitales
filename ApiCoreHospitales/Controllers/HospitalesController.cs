using ApiCoreHospitales.Models;
using ApiCoreHospitales.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreHospitales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private RepositoryHospitales repo;

        public HospitalesController(RepositoryHospitales repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hospital>>> GetHospitales()
        {
            return await this.repo.GetHospitalesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> FindHospital(int id)
        {
            return await this.repo.FindHospitalAsync(id);
        }
    }
}
