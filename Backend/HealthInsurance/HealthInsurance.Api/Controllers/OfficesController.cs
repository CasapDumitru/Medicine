using HealthInsurance.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsurance.Api.Controllers
{
    /// <summary>
    /// Offices Controller
    /// </summary>
    [Route("api/offices")]
    [Produces("application/json")]
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
        public IActionResult Get()
        {
            var offices = _officeService.GetAll();

            return Ok(offices);
        }

        /// <summary>
        /// Get offices by name
        /// </summary>
        /// <param name="officeName">Office name</param>
        /// <returns>Instance of Office Class</returns>
        [HttpGet("{officeName}")]
        public IActionResult Get(string officeName)
        {
            var offices = _officeService.GetAll();
            return Ok(offices);
        }
    }
}
