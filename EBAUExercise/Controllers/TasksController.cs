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

            // eg. CountingService.Increment()

            _CountingService.Increment();
            _ReportService.update();



            return Ok(new
            {
                IsDataSaved = _doWorkService.DoWork(),
                Count = _CountingService.Count,
                CustomerReport = Services.ReportService._CustomerReportList,
                StoresReport = Services.ReportService._StoreDailyReportList,
                //StoreReport = _ReportService.StoreDailyReport().Count,
                // return the current value of the counter here.
            });
        }
    }
}
