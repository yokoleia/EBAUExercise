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


        public TasksController(DoWorkService doWorkService, CountingService CountingService)
        {
            _doWorkService = doWorkService;
            _CountingService = CountingService;
        }

        

        [HttpGet]
        public IActionResult Get()
        {

            // eg. CountingService.Increment()

            _CountingService.Increment();




            return Ok(new
            {
                IsDataSaved = _doWorkService.DoWork(),
                Count = _CountingService.Count,
                // return the current value of the counter here.
            });
        }
    }
}
