
using Calculator.Business;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureBusinessServices();
        }
    }
}
