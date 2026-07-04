using Microsoft.Extensions.DependencyInjection;
using TODO360Degree.Application.Interfaces;
using TODO360Degree.Infrastructure.Repositories;

namespace TODO360Degree.Infrastructure.DependencyInjection
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services)
		{
			services.AddSingleton<ITodoRepository, InMemoryTodoRepository>();
			return services;
		}
	}
}
