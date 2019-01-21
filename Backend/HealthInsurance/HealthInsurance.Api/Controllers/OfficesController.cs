using HealthInsurance.Core.Interfaces.Services;
using HealthInsurance.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthInsurance.Api.Controllers
{
    /// <summary>
    /// Offices Controller
    /// </summary>
    [Route("api/offices")]
    [ApiController]
    public class OfficesController : Controller
    {
        private readonly IOfficeService _officeService;

        public OfficesController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

		/// <summary>
		/// GET All Offices
		/// </summary>
		/// <returns></returns>
		[HttpGet()]
        public async Task<IActionResult> Get()
        {
            var offices = await _officeService.SearchByName("Maria");
            return Ok(offices);
        }

		/// <summary>
		/// GET Office By Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
        [HttpGet("{id}", Name = "GetOffice")]
        public async Task<IActionResult> GetById(int id)
        {
            var office = await _officeService.GetFullById(id);
            return Ok(office);
        }

		/// <summary>
		/// ADD an Office
		/// </summary>
		/// <param name="office"></param>
		/// <returns></returns>
		[HttpPost()]
		public async Task<IActionResult> AddOffice(
			[FromBody] OfficeForCreationDto office)
		{
			if (office == null)
			{
				return BadRequest();
			}

			var addedOffice = await _officeService.Add(office);

			return CreatedAtRoute("GetOffice",
				new { id = addedOffice.Id },
				addedOffice);
		}
	}
}
