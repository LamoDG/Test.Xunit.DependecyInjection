using Calculator.Business.Contract.Math;
using Calculator.Business.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Business
{
    public static class Startup
    {
        public static void ConfigureBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IMathOperation, MathOperation>();
        }
    }
}
