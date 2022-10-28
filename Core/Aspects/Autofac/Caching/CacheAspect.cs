using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        // süre verilmezse veri 60 dakika cachede duracak ve sonra cacheden atılacak
        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            // namespace ve classın ismini verir . da sonra da methodun adını ver
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            // methodun parametresi varsa listeye çevir
            var arguments = invocation.Arguments.ToList();
            // parametre değeri varsa methodun içerisine ekle ama verilmediyse null geçilir
            // bir araya getir ve araya , koy
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            // bellekte cache anahtarı var mı
            if (_cacheManager.IsAdd(key))
            {
                // varsa methodu çalıştırma çünkü cachede var
                // returnvalue cachedeki data
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }
            // yoksa methodu devam ettir
            invocation.Proceed();
            // cacheye ekle
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
