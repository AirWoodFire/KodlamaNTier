using Entities.Abstract;

namespace Entities.Concrete;

public class Course:IEntity
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public int TeacherId { get; set; }
    public int CategoryId { get; set; }
}