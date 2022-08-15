using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThalesDotNetTest.Models.DAL
{
    public interface IRepository<TEntity>
    where TEntity : class
    {
        Task<TEntity> Get(int Id);
        Task<IEnumerable<TEntity>> GetByIdAsync(int Id);
        Task<IEnumerable<TEntity>> GetAll();       

    }
}
