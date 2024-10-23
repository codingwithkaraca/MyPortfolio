using DataAccessLayer.Abstracts;
using DataAccessLayer.Context;

namespace DataAccessLayer.Repository;

// temel crud işlemlerini burda yap  diğer sınflarda burdan kullan


public class GenericRepository<T> : IGenericDal<T> where T :class   
{
    
    public void Add(T t)
    {
        using var context = new MyPortfolioContext();
        context.Add(t);
        context.SaveChanges();
    }

    public List<T> GetList()
    {
        using var context = new MyPortfolioContext();
        var values = context.Set<T>().ToList();
         return values;
         
    }

    public void Update(T t)
    {
        using var context = new MyPortfolioContext();
        context.Update(t);
        context.SaveChanges();
    }

    public void Delete(T t)
    {
        using var context = new MyPortfolioContext();
        var value = context.Remove(t);
        context.SaveChanges();
    }

    public T GetById(int id)
    {
        using var context = new MyPortfolioContext();
        var value = context.Set<T>().Find(id);

        return value;
    }
}