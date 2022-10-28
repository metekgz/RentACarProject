using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    // IServiceCollection = apimizin service bağımlılıklarını eklediğimiz ya da araya girmesini istediğimiz
    // servisleri eklediğimiz koleksiyondur
    public static class ServiceCollectionExtensions
    {
        // burada istediğimiz kadar resolverları ekleyebiliriz( ICoreModulleri )
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
