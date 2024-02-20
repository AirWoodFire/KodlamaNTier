using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    Category GetCategory(int id);
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}