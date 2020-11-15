using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MvvmBlazor.Extensions;
using OurMoneyBlazor.Client.CofigureServices;
using OurMoneyBlazor.Client.Components.Dictionaries.Markets;
using Radzen;

namespace OurMoneyBlazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddMvvm();
            builder.Services.AddViewModels();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //------------ RADZEN ----------------
            //builder.Services.AddScoped<DialogService>();
            //builder.Services.AddScoped<NotificationService>();
            //builder.Services.AddScoped<TooltipService>();
            //builder.Services.AddScoped<ContextMenuService>();
            //------------ RADZEN ----------------

            await builder.Build().RunAsync();
        }
    }
}
