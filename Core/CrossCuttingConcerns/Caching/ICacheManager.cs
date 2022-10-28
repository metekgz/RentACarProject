using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        // key verildiğinde bellekte karşılığı olanı getirme
        T Get<T>(string key);
        object Get(string key);
        // cache ekleme gelecek data obje olacak yani her şeyi atayabailiriz
        void Add(string key, object value, int duration);
        // cacheden varsa oradan getirilmesi 
        bool IsAdd(string key);
        // cacheden uçurma işlemi
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
