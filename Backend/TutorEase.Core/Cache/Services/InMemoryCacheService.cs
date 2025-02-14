﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace TutorEase.Core.Cache.Services
{
    public class InMemoryCacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<InMemoryCacheService> _logger;

        public InMemoryCacheService(IMemoryCache memoryCache, ILogger<InMemoryCacheService> logger)
        {
            _memoryCache = memoryCache;
            _logger = logger;
        }

        public Task<T?> GetAsync<T>(string key) where T : notnull
        {
            return Task.FromResult(_memoryCache.Get<T>(key));
        }

        public Task SetAsync<T>(string key, T value, TimeSpan timeSpan) where T : notnull
        {
            _memoryCache.Set(key, value, timeSpan);
            return Task.CompletedTask;
        }

        public Task<T?> GetOrCreateAsync<T>(string key, Func<Task<T>> generator, TimeSpan? timeSpan = default)
            where T : notnull
        {
            return _memoryCache.GetOrCreateAsync(key, entry =>
            {
                _logger.LogTrace("Retrieving from cache {key}", key);
                entry.SlidingExpiration = timeSpan;
                return generator();
            });
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }
    }
}
