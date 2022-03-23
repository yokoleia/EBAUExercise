using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;


namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        
        private DoWorkService _doWorkService;
        private CountingService _CountingService;
        private ReportService _ReportService;

        public TasksController(DoWorkService doWorkService, CountingService CountingService, ReportService reportService)
        {
            _doWorkService = doWorkService;
            _CountingService = CountingService;
            _ReportService = reportService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            // counter increment
            _CountingService.Increment();

            // report services update
            _ReportService.update();



            return Ok(new
            {
                IsDataSaved = _doWorkService.DoWork(),
                Count = _CountingService.Count,


                // report services update
                CustomerReport = Services.ReportService._CustomerReportList,
                StoresReport = Services.ReportService._StoreDailyReportList,
                
            });
        }
    }
}
