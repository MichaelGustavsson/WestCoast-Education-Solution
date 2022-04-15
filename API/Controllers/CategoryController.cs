using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/v1/category")]
  public class CategoryController : ControllerBase
  {
    private readonly DataContext _context;

    public CategoryController(DataContext context)
    {
      _context = context;
    }

    [HttpGet()]
    public ActionResult ListAllCategories()
    {
      return Ok();

    }

    [HttpGet("/courses/{categoryId}")]
    public ActionResult GetCourses(int categoryId)
    {
      return Ok();
    }

    [HttpPost()]
    public async Task<ActionResult<Category>> AddCategory(Category model)
    {
      await _context.Categories.AddAsync(model);
      await _context.SaveChangesAsync();

      return StatusCode(201, model);
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