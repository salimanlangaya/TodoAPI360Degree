using Microsoft.Extensions.DependencyInjection;
using TODO360Degree.Application.Interfaces;
using TODO360Degree.Application.Services;

namespace TODO360Degree.Application.DependencyInjection
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services.AddScoped<ITodoService, TodoService>();
			return services;
		}
	}
}
