using Assignment1.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics;

namespace Assignment1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {

        [HttpGet("GetPractice")]
        public void GetPractice()
        {
            Response.StatusCode = StatusCodes.Status201Created;
            Response.ContentType = "application/json";
            var response = "{\"Name\":\"Practice\"}";
            Response.WriteAsync(response);
            //return "Practice";
        }


        [HttpGet("GetThing")]
        public IActionResult GetThing()
        {

            return Ok(new { Name = "Practice" });
            
        }


        [HttpGet("GetActionResult")]
        public IActionResult GetActionResult()
        {

            //return new OkThingResult(new { Name = "Practice" });
            var response = new ObjectResult(new { Name = "Practice" });
            response.StatusCode = StatusCodes.Status200OK;
            return response;
        }


        [HttpPost("PostPractice")]
        public IActionResult PostPractice([FromBody] Practice practice)
        {

            return new OkObjectResult(practice.Name);
        }

    }
}
