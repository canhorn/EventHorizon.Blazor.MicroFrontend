using System;
using Blazor.Counter.State;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.MicroFrontend
{
    public static class CounterFeatureExtensions
    {
        public static IServiceCollection AddCounterFeature(
            this IServiceCollection services
        )
        {
            return services
                .AddSingleton<InMemoryCounterState>()
                .AddSingleton<CounterState>(services=> services.GetRequiredService<InMemoryCounterState>())
                .AddSingleton<CounterActions>(services => services.GetRequiredService<InMemoryCounterState>())
            ;
        }

        public static IApplicationBuilder UseCounterFeature(
            this IApplicationBuilder app
        )
        {
            return app;
        }
    }
}
