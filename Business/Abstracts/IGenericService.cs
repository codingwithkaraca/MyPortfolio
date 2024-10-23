namespace Business.Abstracts;

public interface IGenericService<T>
{
    
    void TAdd(T entity);
    List<T> TGetList();
    void TUpdate(T entity);
    void TDelete(T entity);
    T TGetById(int id);
    
}