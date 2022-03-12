using System.Collections.Generic;

namespace MoviesAPI.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Insert(T obj);
        void Update(T obj);
        bool Delete(int id);
    }
}