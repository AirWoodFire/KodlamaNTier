using Entities.Concrete;

namespace Business.Abstract;

public interface ITeacherService
{
    List<Teacher> GetAll();
    void Add(Teacher teacher);
    void Update(Teacher teacher);
    void Delete(Teacher teacher);
    Teacher GetById(int id);
}