using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.QuerySpecifications.Product;

namespace OBMCShopApp.Services
{
    public class GenericDataService<T> : IDataService<T> where T : BaseDomainModel
    {
        private readonly OBMCShopAppContext _context;
        private readonly IHttpContextAccessor _accessor;
        private readonly DbSet<T> _set;
        
        public GenericDataService(OBMCShopAppContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
            _set = context.Set<T>();
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            var query = await _set.AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
            return query.AsReadOnly();
        }

        public async Task<T> GetOne(int id)
        {
            var query = await _set.AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
            return query;
        }

        public async Task<T> GetOne(ISpecification<T> spec)
        {
            var specResult = ApplySpecification(spec);
            return await specResult.SingleOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<T>> GetAll(ISpecification<T> spec)
        {
            var specQueryable = ApplySpecification(spec);
            var result = await specQueryable.ToListAsync().ConfigureAwait(false);
            return result.AsReadOnly();
        }

        public void CreateOne(T one)
        {
            _set.Add(one);
        }

        public void UpdateOne(T one)
        {
            _context.Entry(one).State = EntityState.Modified;
        }

        public void DeleteOne(T one)
        {
            _context.Entry(one).State = EntityState.Modified;
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            var evaluator = new SpecificationEvaluator();
            var specResult = evaluator.GetQuery(_set.AsQueryable(), spec);
            return specResult;
        }
        
        public async Task Commit()
        {
            var user = _accessor.HttpContext?.User.Identity?.Name ?? "Anonymous User";
            foreach (var entity in _context.ChangeTracker.Entries<T>())
            {
                if (entity.State == EntityState.Added)
                {
                    entity.Entity.CreatedAt = DateTimeOffset.Now;
                    entity.Entity.UpdatedAt = DateTimeOffset.Now;
                    if (string.IsNullOrEmpty(entity.Entity.CreatedBy))
                    {
                        entity.Entity.CreatedBy = user;
                        entity.Entity.UpdatedBy = user;
                    }
                }

                if (entity.State == EntityState.Modified)
                {
                    entity.Entity.UpdatedAt = DateTimeOffset.Now;
                    if (string.IsNullOrEmpty(entity.Entity.UpdatedBy))
                    {
                        entity.Entity.UpdatedBy = user.ToUpperInvariant();
                    }
                }

            }

            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}