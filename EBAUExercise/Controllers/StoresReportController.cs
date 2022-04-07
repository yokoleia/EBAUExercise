using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;


namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class StoresReportController : ControllerBase
    {

        private StoresReportService _StoresReportService;

        public StoresReportController(StoresReportService StoresReportService)
        {
            _StoresReportService = StoresReportService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _StoresReportService.update();



            return Ok(new
            {
                // report services update
                StoresReport = Services.StoresReportService._StoreDailyReportList,

            });
        }
    }
}
