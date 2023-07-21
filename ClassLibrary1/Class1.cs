using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static void Add(this IServiceCollection services)
        {
            services.AddMsalAuthentication
        }
    }
}