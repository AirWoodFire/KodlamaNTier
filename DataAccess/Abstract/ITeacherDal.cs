using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ITeacherDal
{
    List<Teacher> GetAll();
    Teacher GetTeacher(int id);
    void Add(Teacher teacher);
    void Update(Teacher teacher);
    void Delete(Teacher teacher);
}