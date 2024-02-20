using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCategoryDal:ICategoryDal
{
    private List<Category> _categories;

    public InMemoryCategoryDal()
    {
        _categories = new List<Category>
        {
            new Category(){CategoryId = 1, CategoryName = "Programlama"}
        };
    }
    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetCategory(int id)
    {
        return _categories.Find(c => c.CategoryId == id);
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
        categoryToUpdate.CategoryName = category.CategoryName;
    }

    public void Delete(Category category)
    {
        Category categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
        _categories.Remove(categoryToDelete);
    }
}