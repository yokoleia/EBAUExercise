using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class CustomerReportController : ControllerBase
    {

        private CustomerReportService _CustomerReportService;

        public CustomerReportController(CustomerReportService CustomerReportService)
        {
            _CustomerReportService = CustomerReportService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // report services update
            _CustomerReportService.update();



            return Ok(new
            {
                // report services update
                customerReport = Services.CustomerReportService._CustomerReportList,

            });
        }
    }
}
