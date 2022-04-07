using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
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

            // counter increment
            _CountingService.Increment();


            return Ok(new
            {
                IsDataSaved = _doWorkService.DoWork(),
                Count = _CountingService.Count,               
            });
        }
    }
}
