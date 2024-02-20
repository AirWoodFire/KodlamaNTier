using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCourseDal : ICourseDal
{
    private List<Course> _courses;

    public InMemoryCourseDal()
    {
        _courses = new List<Course>
        {
            new Course(){CourseId = 1, Name = "Senior Yazılım Geliştirici Yetiştirme Kampı",Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",Price = "Ücretsiz",CategoryId = 1,TeacherId = 1},
            new Course(){CourseId = 2, Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",Price = "Ücretsiz",CategoryId = 1,TeacherId = 1},
            new Course(){CourseId = 3, Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",Price = "Ücretsiz",CategoryId = 1,TeacherId = 2}

        };
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetCourse(int id)
    {
        return _courses.SingleOrDefault(c => c.CourseId == id);
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Update(Course course)
    {
        Course courseToUpdated = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
        courseToUpdated.Name = course.Name;
        courseToUpdated.Description = course.Description;
        courseToUpdated.Price = course.Price;
        courseToUpdated.CategoryId = course.CategoryId;
        courseToUpdated.TeacherId = course.TeacherId;
    }

    public void Delete(Course course)
    {
        Course courseToDeleted = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
        _courses.Remove(courseToDeleted);
    }

    public List<Course> GetAllByCategory(int categoryId)
    {
        return _courses.Where(c => c.CategoryId == categoryId).ToList();
    }

    public List<Course> GetAllByTeacher(int teacherId)
    {
        return _courses.Where(c => c.TeacherId == teacherId).ToList();
    }
}