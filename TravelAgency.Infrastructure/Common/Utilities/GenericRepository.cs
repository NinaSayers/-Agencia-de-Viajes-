using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Domain.Common;
using TravelAgency.Infrastructure.Common.Interfaces;

namespace TravelAgency.Infrastructure.Common.Utilities
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> entity;
        private TravelAgencyContext _context;
        public GenericRepository(TravelAgencyContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            _context = context;
            entity = context.Set<TEntity>();
        }

        public async Task DeleteByIdAsync(int elementId, CancellationToken cancellationToken = default)
        {
            var element = await entity.FindAsync(elementId);
            entity.Remove(element);
            // System.Console.WriteLine("Voy a borrar");
            // entity.Remove(element);
            await _context.SaveChangesAsync(cancellationToken);

        }

        public async Task DeleteAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            // var entity = GetByIdAsync(elementID);
            // entity.Remove(3);.
            // System.Console.WriteLine("Voy a borrar");
            // entity.Remove(element);
            // await _context.SaveChangesAsync(cancellationToken);
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetByIdAsync<TId>(TId elementId, CancellationToken cancellationToken = default)
        {
            return await entity.FindAsync(elementId, cancellationToken);
        }
        

        public async Task CreateAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            entity.Add(element);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            entity.Update(element);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task<IEnumerable<TEntity>> ListAgencyAsync(CancellationToken cancellationToken = default)
        {
            var entities = await entity.ToListAsync(cancellationToken);
            return entities;

        }
    }
}