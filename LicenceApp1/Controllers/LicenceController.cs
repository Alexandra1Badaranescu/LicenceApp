using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LicenceApp1.Models.Entities;
using LicenceApp1.Models.DTOs;
using LicenceApp1.Repositories.LicenceRepository;
using LicenceApp1.Repositories.ProductRepository;

namespace LicenceApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenceController : ControllerBase
    {
        private readonly ILicenceRepository _repositoryLicence;

        public LicenceController(ILicenceRepository repositoryLicence)
        {
            _repositoryLicence = repositoryLicence;

        }


        // READ all licences
        [HttpGet]

        public async Task<IActionResult> GetAllLicences()
        {
            var licences = await _repositoryLicence.GetAllLicences();

            var licencesToReturn = new List<LicenceDTO>();

            foreach (var licence in licences)
            {
                var auxLicence = new LicenceDTO(licence);

                licencesToReturn.Add(auxLicence);
            }

            return Ok(licencesToReturn);
        }

        [HttpGet("{name}")]

        public async Task<IActionResult> GetLicenceByName(string name)
        {
            var licence = await _repositoryLicence.GetLicencesByName(name);
            if (licence == null)
            {
                return BadRequest("The Licence you search cannot be found!");
            }
            var LicenceToReturn = new LicenceDTO(licence);

            return Ok(LicenceToReturn);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllLicenses()
        {
            var licences = await _repositoryLicence.GetAllLicences();
            return Ok(licences);
        }
    
    }
}

