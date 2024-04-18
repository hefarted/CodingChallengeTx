using CodingChallengeTx.Interfaces;
using CodingChallengeTx.Services;

namespace CodingChallengeTx
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IValidationService, ValidationService>();
            services.AddScoped<IExpenseService, ExpenseService>();
        }
    }
}
