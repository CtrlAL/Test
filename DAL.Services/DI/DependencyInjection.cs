﻿using DAL.EF.Context;
using DAL.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Services.DI
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection UseDAL(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var config = configuration["ConnectionStrings:DefaultConnectionString"];

            serviceCollection.AddDbContext<AppDbContext>(config => config.UseNpgsql(configuration["ConnectionStrings:DefaultConnectionString"]));

            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<INutrientRepository, NutrientRepository>();
            serviceCollection.AddScoped<IRecomendationRepository, RecomendationRepository>();
            serviceCollection.AddScoped<IDiagnosticRepository, DiagnosticRepository>();
            serviceCollection.AddScoped<INutrientConsumptionRepository, NutrientConsumptionRepository>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            serviceCollection.AddScoped<IPersonalSuggestionRepository, PersonalSuggestionRepository>();

			serviceCollection.AddScoped<ICurrentDailyConsamptionMapper, CurrentDailyConsamptionMapper>();
			serviceCollection.AddScoped<INewDailyConsamptionMapper, NewDailyConsamptionMapper>();

			return serviceCollection;
        }
    }
}
