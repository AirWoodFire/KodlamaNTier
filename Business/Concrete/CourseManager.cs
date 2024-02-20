using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course GetCourse(int id)
    {
        return _courseDal.GetCourse(id);
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAllByCategory(int categoryId)
    {
        return _courseDal.GetAllByCategory(categoryId);
    }

    public List<Course> GetAllByTeacher(int teacherId)
    {
        return _courseDal.GetAllByTeacher(teacherId);
    }
}