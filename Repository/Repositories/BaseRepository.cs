using Dapper;
using Repository.Repositories.Dapper;

namespace Repository.Repositories;

public abstract class BaseRepository<TResultDto>(DapperContext context)
{
    protected async Task<ICollection<TResultDto>> GetAllAsync(string query, object? param = null)
    {
        using var connection = context.CreateConnection();
        var result = param is null
            ? await connection.QueryAsync<TResultDto>(query)
            : await connection.QueryAsync<TResultDto>(query, param);
        return result.ToHashSet();
    }

    protected async Task<ICollection<TDto>> GetAllAsync<TDto>(string query, object? param = null)
    {
        using var connection = context.CreateConnection();
        var result = param is null
            ? await connection.QueryAsync<TDto>(query)
            : await connection.QueryAsync<TDto>(query, param);
        return result.ToHashSet();
    }

    protected async Task<TResultDto> GetAsync(string query, object? param = null)
    {
        using var connection = context.CreateConnection();
        var result = param is null
            ? await connection.QueryFirstOrDefaultAsync<TResultDto>(query)
            : await connection.QueryFirstOrDefaultAsync<TResultDto>(query, param);
        return result;
    }

    protected async Task<TDto> GetAsync<TDto>(string query, object? param = null)
    {
        using var connection = context.CreateConnection();
        var result = param is null
            ? await connection.QueryFirstOrDefaultAsync<TDto>(query)
            : await connection.QueryFirstOrDefaultAsync<TDto>(query, param);
        return result;
    }

    protected async Task ExecuteAsync(string query, object? param = null)
    {
        using var connection = context.CreateConnection();
        if (param is null)
            await connection.ExecuteAsync(query);
        else
            await connection.ExecuteAsync(query, param);
    }
}