using Entities.Abstract;

namespace Entities.Concrete;

public class Teacher:IEntity
{
    public int TeacherId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}