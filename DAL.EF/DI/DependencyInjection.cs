using DAL.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.EF.DI
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection UseDAL(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var config = configuration["ConnectionStrings:DefaultConnectionString"];

            serviceCollection.AddDbContext<AppDbContext>(config => config.UseNpgsql(configuration["ConnectionStrings:DefaultConnectionString"]));
            //serviceCollection.AddScoped<IVideoViewsDal, VideoViewsDal>();

            return serviceCollection;
        }
    }
}
