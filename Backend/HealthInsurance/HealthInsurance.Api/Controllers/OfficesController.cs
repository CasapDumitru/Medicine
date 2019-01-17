using HealthInsurance.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthInsurance.Api.Controllers
{
    /// <summary>
    /// Offices Controller
    /// </summary>
    [Route("api/offices")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficesController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        /// <summary>
        /// Get All Offices
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var offices = await _officeService.GetAll();
            return Ok(offices);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var office = await _officeService.GetById(id);
            return Ok(office);
        }
    }
}
