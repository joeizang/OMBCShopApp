using Microsoft.Extensions.Caching.Memory;
using System;

namespace OBMCShopApp.Infrastructure
{
    public class ObmcMemoryCache
    {
        public MemoryCache Cache { get; } = new MemoryCache(
            new MemoryCacheOptions
            {
                SizeLimit = 2048,
                ExpirationScanFrequency = new TimeSpan(1, 30, 0)
            });
    }
}
