using HealthInsurance.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsurance.Api.Controllers
{
    [Route("api/offices")]
    [ApiController]
    public class OfficesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var officeService = new OfficeService();
            var offices = officeService.GetAll();

            return Ok(offices);
        }
    }
}
