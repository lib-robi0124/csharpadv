using TaxiManager9000.DataAccess.Abstraction.Interfaces;
using TaxiManager9000.DataAccess.Implementation;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Abstraction.Interfaces;

namespace TaxiManager9000.Services.Abstraction
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected IGenericDb<T> _dbInstance;

        public ServiceBase()
        {
            _dbInstance = new GenericDb<T>();
        }

        public List<T> GetAll()
        {
            return _dbInstance.GetAll();
        }

        public T GetById(int id)
        {
            return _dbInstance.GetById(id);
        }

        public List<T> GetFiltered(Func<T, bool> whereClause)
        {
            return _dbInstance.FilterBy(whereClause);
        }

        public void Insert(T entity)
        {
            _dbInstance.Add(entity);
        }

        public void Update(T entity)
        {
             _dbInstance.Update(entity);
        }

        public void DeleteById(int id)
        {
            _dbInstance.RemoveById(id);
        }

        public void Seed(List<T> entities)
        {
            entities.ForEach(e => _dbInstance.Add(e));
        }
  
    }
}
