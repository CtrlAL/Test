using BL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BL.Services.DI
{
	public static partial class DependencyInjection
	{
		public static IServiceCollection UseBL(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<ICurrentDailyConsumptionBL, CurrentDailyConsumptionBL>();
			serviceCollection.AddScoped<INewDailyConsumptionBL, NewDailyConsumptionBL>();
			serviceCollection.AddScoped<IPersonalSuggestionBL, PersonalSuggestionBL>();
			serviceCollection.AddScoped<IDiagnosticBL, DiagnosticBL>();
			serviceCollection.AddScoped<INutrientConsumptionBL, NutrientConsumptionBL>();

			return serviceCollection;
		}
	}
}