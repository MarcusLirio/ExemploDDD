using System.Collections.Generic;

namespace DDDWebAPI.Domain.Core.Interfaces.Services
{
    public interface IServiceBases<TEntity> where TEntity : class
    {

        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
