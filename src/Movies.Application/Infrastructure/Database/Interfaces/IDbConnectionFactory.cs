using System.Data;

namespace Movies.Application.Infrastructure.Database.Interfaces;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}