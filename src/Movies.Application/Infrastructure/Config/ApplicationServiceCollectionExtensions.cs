using Microsoft.Extensions.DependencyInjection;
using Movies.Application.Infrastructure.Database;
using Movies.Application.Infrastructure.Database.Interfaces;
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

    public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
    {
        services.AddSingleton<IDbConnectionFactory>(_ => new NpgsqlConnectionFactory(connectionString));

        services.AddSingleton<DbInitializer>();

        return services;
    }
}
