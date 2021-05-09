using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedManager.Data
{
    public interface IGenericRepository<TEntity>
    {
        Task Save(TEntity entity);

        Task Delete(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task Update(TEntity entity);
    }
}