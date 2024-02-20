using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class TeacherManager : ITeacherService
{
    private ITeacherDal _teacherDal;

    public TeacherManager(ITeacherDal teacherDal)
    {
        _teacherDal = teacherDal;
    }

    public List<Teacher> GetAll()
    {
        return _teacherDal.GetAll();
    }

    public void Add(Teacher teacher)
    {
        _teacherDal.Add(teacher);
    }

    public void Update(Teacher teacher)
    {
        _teacherDal.Update(teacher);
    }

    public void Delete(Teacher teacher)
    {
        _teacherDal.Delete(teacher);
    }

    public Teacher GetById(int id)
    {
        return _teacherDal.GetTeacher(id);
    }
}