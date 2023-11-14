using Microsoft.Extensions.DependencyInjection;
using Movies.Application.Repositories;
using Movies.Application.Repositories.Interfaces;

namespace Movies.Application.Infrastructure.Config;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<IMovieRepository, MovieRepository>();
        return services;
    }
}
