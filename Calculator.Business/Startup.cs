using Calculator.Business.Abstract;
using Calculator.Business.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
