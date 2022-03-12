using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data.Repositories.Interfaces;

namespace MoviesAPI.Data.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T:class
    {
        public MoviesContext _context;
        public DbSet<T> entity;
        public Repository(MoviesContext context)
        {
            _context=context;
            entity = _context.Set<T>();
        }

        public T Get(int id)
        {
            return entity.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entity.ToList();
        }

        public void Insert(T obj)
        {
            entity.Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            entity.Update(obj);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var exitingObj = Get(id);
            if (exitingObj != null)
            {
                entity.Remove(exitingObj);
                _context.SaveChanges();
            }
        }
    }
}
