using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IRepositoryGeneric<T> where T : class //reference type
    {


        List<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);
        int Save();






    }
}
