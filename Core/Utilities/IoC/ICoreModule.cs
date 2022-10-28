using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        // genel bağımlılıkları yükleme kodları
        void Load(IServiceCollection serviceCollection);
    }
}
