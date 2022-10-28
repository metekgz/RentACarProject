using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Core.Utilities.IoC;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Core.CrossCuttingConcerns.Caching.Mictosoft
{
    // Adapter Pattern (var olan bir şeyi kendi sistemine uyarlamak)
    public class MemoryCacheManager : ICacheManager
    {
        // bağımlılık zincirinde olmadığı için ctorda enjekte edilse çalışmaz servicetoolda yapılması gerekir
        IMemoryCache _memoryCache;

        public MemoryCacheManager()
        {
            _memoryCache = ServiceTool.ServiceProvider.GetService<IMemoryCache>();
        }

        public void Add(string key, object value, int duration)
        {
            // set ile değer eklenir
            // ne kadar süre verilirse  o süre içinde cachede kalacak
            _memoryCache.Set(key, value, TimeSpan.FromMinutes(duration));
        }

        public T Get<T>(string key)
        {
            return _memoryCache.Get<T>(key);
        }

        public object Get(string key)
        {
            return _memoryCache.Get(key);
        }
        // bellekte cache değeri var mı
        public bool IsAdd(string key)
        {
            // bellekte olup olmadığını kontrol etsin ve bir şey döndürmesin
            return _memoryCache.TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }
        // ona verdiğimiz patterne göre silme işlemi yapılması
        // çalışma anında RemoveByPattern bellekten silmeye yarar
        public void RemoveByPattern(string pattern)
        {
            // bellekte cache ile ilgili olan yapıyı çekme
            // bellekteki EntriesCollection'ı bul
            var cacheEntriesCollectionDefinition = typeof(MemoryCache).GetProperty("EntriesCollection", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            // definitionu _memorycache olanları bul
            var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(_memoryCache) as dynamic;
            List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheItem in cacheEntriesCollection)
            {
                ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);
                cacheCollectionValues.Add(cacheItemValue);
            }
            // her bir cache elemanlarından kurallara uyanlar varsa tek tek gez ve bellekten uçur
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString())).Select(d => d.Key).ToList();

            foreach (var key in keysToRemove)
            {
                _memoryCache.Remove(key);
            }
        }
    }
}
