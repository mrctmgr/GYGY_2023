using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Abstract;

namespace Bussiness.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private List<T> _entities;

        public GenericRepository()
        {
            _entities = new List<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public List<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public void Update(T entity)
        {
            var index = _entities.FindIndex(e => e.Id == entity.Id);
            if (index >= 0)
            {
                _entities[index] = entity;
            }
        }
    }
}
