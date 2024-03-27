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
<<<<<<< HEAD
        Task CreateAsync(TEntity element, CancellationToken cancellationToken = default);
=======
        Task <TEntity>CreateAsync(TEntity element, CancellationToken cancellationToken = default);
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        Task UpdateAsync(TEntity element, CancellationToken cancellationToken = default);
        Task<TEntity> GetByIdAsync<TId>(TId elementId, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default);
        Task DeleteByIdAsync(int elementId, CancellationToken cancellationToken = default);
<<<<<<< HEAD
=======
        Task <TEntity>CreateAsync(TEntity element, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity element, CancellationToken cancellationToken = default);
        Task<TEntity> GetByIdAsync<TId>(TId elementId, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default);
        Task DeleteByIdAsync(int elementId, CancellationToken cancellationToken = default);
        TEntity GetById<TId>(TId elementId);
>>>>>>> master
=======
        TEntity GetById<TId>(TId elementId);
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        
    }
}