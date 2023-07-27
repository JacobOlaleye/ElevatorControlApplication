using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElevatorControlApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        [HttpPost("request")]
        public IActionResult RequestElevatorToFloor(int currentFloor)
        {
            
            return Ok($"Elevator requested to floor {currentFloor}");
        }

        [HttpPost("bring")]
        public IActionResult BringToFloor(int targetFloor)
        {
            
            return Ok($"Elevator requested to bring to floor {targetFloor}");
        }

        [HttpGet("current-floors")]
        public IActionResult GetCurrentFloors()
        {
           
            var currentFloors = new int[] { 5, 8, 10 };
            return Ok(currentFloors);
        }

        [HttpGet("next-floor")]
        public IActionResult GetNextFloor()
        {
            
            var nextFloor = 12;
            return Ok(nextFloor);
        }
    }
}
