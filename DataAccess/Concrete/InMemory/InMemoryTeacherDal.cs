using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryTeacherDal : ITeacherDal
{
    private List<Teacher> _teachers;

    public InMemoryTeacherDal()
    {
        _teachers = new List<Teacher>
        {
            new Teacher(){TeacherId = 1,FirstName = "Engin",LastName = "Demirog"},
            new Teacher(){TeacherId = 2,FirstName = "Halit Enes",LastName = "Kalaycı"}
        };
    }

    public List<Teacher> GetAll()
    {
        return _teachers;
    }

    public Teacher GetTeacher(int id)
    {
        return _teachers.Find(t => t.TeacherId == id);
    }

    public void Add(Teacher teacher)
    {
        _teachers.Add(teacher);
    }

    public void Update(Teacher teacher)
    {
        Teacher teacherToUpdate = _teachers.SingleOrDefault(t => t.TeacherId == teacher.TeacherId);
        teacherToUpdate.FirstName = teacher.FirstName;
        teacherToUpdate.LastName = teacher.LastName;
    }

    public void Delete(Teacher teacher)
    {
        Teacher teacherToDelete = _teachers.SingleOrDefault(t => t.TeacherId == teacher.TeacherId);
        _teachers.Remove(teacherToDelete);
    }
}