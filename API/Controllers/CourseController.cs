using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/v1/courses")]
  public class CourseController : ControllerBase
  {
    [HttpGet()]
    public ActionResult ListAllCourses()
    {
      return Ok();

    }
    [HttpGet("{id}")]
    public ActionResult GetCourse(int id)
    {
      return Ok();
    }

    [HttpPost()]
    public ActionResult AddCourse()
    {
      return StatusCode(201);
    }
    [HttpPut("{id}")]
    public ActionResult UpdateCourse(int id)
    {
      return NoContent();
    }
    [HttpDelete("{id}")]
    public ActionResult DeleteCourse(int id)
    {
      return NoContent();
    }
  }
}