using Dapper;
using Entity.Dtos.ProductShowCaseTypeDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ProductShowCaseTypeRepository;

public class ProductShowCaseTypeReposiyory(DapperContext context) : IProductShowCaseTypeReposiyory
{
    public async Task<ICollection<ResultProductShowCaseTypeDto>> GetAllProductShowCaseTypeAsync()
    {
        var query = "SELECT * FROM ProductShowCaseType";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultProductShowCaseTypeDto>(query);
        return result.ToHashSet();
    }

    public async void CreateProductShowCaseTypeAsync(CreateProductShowCaseTypeDto dto)
    {
        var query = "INSERT INTO ProductShowCaseType (ProductShowCaseTypeName) VALUES (@ProductShowCaseTypeName)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public void DeleteProductShowCaseTypeAsync(short id)
    {
        var query = "DELETE FROM ProductShowCaseType WHERE ProductShowCaseTypeID = @ProductShowCaseTypeID";
        using var connection = context.CreateConnection();
        connection.Execute(query, new { ProductShowCaseTypeID = id });
    }

    public void UpdateProductShowCaseTypeAsync(UpdateProductShowCaseTypeDto dto)
    {
        var query = @"UPDATE ProductShowCaseType SET ProductShowCaseTypeName = 
@ProductShowCaseTypeName WHERE ProductShowCaseTypeID = @ProductShowCaseTypeID";
        using var connection = context.CreateConnection();
        connection.Execute(query, dto);
    }

    public async Task<ResultProductShowCaseTypeDto> GetProductShowCaseTypeByIdAsync(short id)
    {
        var query = "SELECT * FROM ProductShowCaseType WHERE ProductShowCaseTypeID = @ProductShowCaseTypeID";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultProductShowCaseTypeDto>(query,
            new { ProductShowCaseTypeID = id });
        return result;
    }
}