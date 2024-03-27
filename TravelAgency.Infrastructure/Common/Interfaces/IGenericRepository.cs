using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Domain.Common;

namespace TravelAgency.Infrastructure.Common.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity:BaseEntity
    {
<<<<<<< HEAD
        Task CreateAsync(TEntity element, CancellationToken cancellationToken = default);
=======
        Task <TEntity>CreateAsync(TEntity element, CancellationToken cancellationToken = default);
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> origin/real-Nanda's-Branch
>>>>>>> 8c8298ebcb71b5da9c90eea6cc660729afc04947
        Task UpdateAsync(TEntity element, CancellationToken cancellationToken = default);
        Task<TEntity> GetByIdAsync<TId>(TId elementId, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default);
        Task DeleteByIdAsync(int elementId, CancellationToken cancellationToken = default);
        TEntity GetById<TId>(TId elementId);
        
    }
}