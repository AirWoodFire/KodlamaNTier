using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    Course GetCourse(int id);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
    List<Course> GetAllByCategory(int categoryId);
    List<Course> GetAllByTeacher(int teacherId);
}