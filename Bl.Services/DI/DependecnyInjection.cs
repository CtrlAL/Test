using Microsoft.Extensions.DependencyInjection;

namespace BL.Services.DI
{
	public static partial class DependencyInjection
	{
		public static IServiceCollection UseBL(this IServiceCollection serviceCollection)
		{
			return serviceCollection;
		}
	}
}
