using AcutrackFulfillment.Core.Entities;
using AcutrackFulfillment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using AcutrackFulfillment.Infrastructure.Data;

namespace AcutrackFulfillment.Infrastructure.Cache
{
    public class CachedRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly IMyCache _cache;
        private readonly EfRepository<T> _efRepository;
        private readonly IAppLogger<CachedRepository<T>> _logger;
        private static readonly TimeSpan _defaultCacheDuration = TimeSpan.FromSeconds(30);

        public CachedRepository(IMyCache cache, EfRepository<T> efRepository, IAppLogger<CachedRepository<T>> logger)
        {
            _cache = cache;
            this._efRepository = efRepository;
            this._logger = logger;
        }
        public Task<T> AddAsync(T entity)
        {
            _cache.Clear();           
            return _efRepository.AddAsync(entity);
        }

        public Task<int> CountAsync(ISpecification<T> spec)
        {            
            return _efRepository.CountAsync(spec);
        }

        public Task DeleteAsync(T entity)
        {
            _cache.Clear();
            return _efRepository.DeleteAsync(entity);
                             
        }

        public async Task<T> GetByIdAsync(int id)
        {
            string cacheKey = $"{typeof(T).FullName}-{id}-Item";
            return await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                _logger.LogInformation($"PopulatingCache: {cacheKey}");                
                entry.SlidingExpiration = _defaultCacheDuration;
                return await _efRepository.GetByIdAsync(id);
            });
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            string cacheKey = typeof(T).FullName + "-List2";
            return await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                _logger.LogInformation($"PopulatingCache: {cacheKey}");
                entry.SlidingExpiration = _defaultCacheDuration;
                return await _efRepository.ListAllAsync();
            });
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {            
            string cacheKey = $"{typeof(T).FullName}-{spec.CacheKey}-SpecKey";
            return await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                _logger.LogInformation($"PopulatingCache: {cacheKey}");
                entry.SlidingExpiration = _defaultCacheDuration;
                return await _efRepository.ListAsync(spec);
            });
        }

        public Task UpdateAsync(T entity)
        {
            _cache.Clear();
            return _efRepository.UpdateAsync(entity);
        }
    }
}
