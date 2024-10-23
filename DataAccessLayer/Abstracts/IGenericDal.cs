namespace DataAccessLayer.Abstracts;

public interface IGenericDal<T> where T : class
{
    void Add(T t);
    List<T> GetList();
    void Update(T t);
    void Delete(T t);
    T GetById(int id);
    
}