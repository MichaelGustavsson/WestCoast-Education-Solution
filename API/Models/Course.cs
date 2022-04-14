using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
  public class Course
  {
    public int Id { get; set; }
    public string CourseNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Duration { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category Category { get; set; } = new Category();
  }
}