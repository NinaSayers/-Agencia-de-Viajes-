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
<<<<<<< HEAD
<<<<<<< HEAD
            var element = await entity.FindAsync(elementId);
            entity.Remove(element);
            // System.Console.WriteLine("Voy a borrar");
            // entity.Remove(element);
=======
            var element = entity.Find(elementId);
            entity.Remove(element);
>>>>>>> master
=======
            var element = entity.Find(elementId);
            entity.Remove(element);
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
            await _context.SaveChangesAsync(cancellationToken);

        }

<<<<<<< HEAD
<<<<<<< HEAD
        public async Task DeleteAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            // var entity = GetByIdAsync(elementID);
            // entity.Remove(3);.
            // System.Console.WriteLine("Voy a borrar");
            // entity.Remove(element);
            // await _context.SaveChangesAsync(cancellationToken);
            throw new NotImplementedException();
        }
=======
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79

        public async Task<TEntity> GetByIdAsync<TId>(TId elementId, CancellationToken cancellationToken = default)
        {
            return await entity.FindAsync(elementId, cancellationToken);
        }
        

<<<<<<< HEAD
<<<<<<< HEAD
        public async Task CreateAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            entity.Add(element);
            await _context.SaveChangesAsync(cancellationToken);
=======
        public async Task<TEntity> CreateAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            entity.Add(element);
            await _context.SaveChangesAsync(cancellationToken);
            return element;
>>>>>>> master
=======
        public async Task<TEntity> CreateAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            entity.Add(element);
            await _context.SaveChangesAsync(cancellationToken);
            return element;
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        }

        public async Task UpdateAsync(TEntity element, CancellationToken cancellationToken = default)
        {
            entity.Update(element);
            await _context.SaveChangesAsync(cancellationToken);
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public async Task<IEnumerable<TEntity>> ListAgencyAsync(CancellationToken cancellationToken = default)
=======
        public async Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default)
>>>>>>> master
=======
        public async Task<IEnumerable<TEntity>> ListAsync(CancellationToken cancellationToken = default)
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
        {
            var entities = await entity.ToListAsync(cancellationToken);
            return entities;

        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
         public TEntity GetById<TId>(TId elementId)
        {
            return  entity.Find(elementId)!;
        }
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    }
}