using Entities.Concrete;

namespace Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    Course GetCourse(int id);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
    List<Course> GetAllByCategory(int categoryId);
    List<Course> GetAllByTeacher(int teacherId);
}