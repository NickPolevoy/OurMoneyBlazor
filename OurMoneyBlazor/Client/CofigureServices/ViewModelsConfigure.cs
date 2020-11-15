using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OurMoneyBlazor.Client.Components.Dictionaries.Markets;

namespace OurMoneyBlazor.Client.CofigureServices
{
    public static class ViewModelsConfigure
    {
        public static IServiceCollection AddViewModels(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<MarketsViewModel>();
            return serviceCollection;
        }
    }
}
