using Entity.Dtos.ProductShowCaseTypeDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ProductShowCaseTypeRepository;

public class ProductShowCaseTypeRepository(DapperContext context)
    : BaseRepository<ResultProductShowCaseTypeDto>(context), IProductShowCaseTypeRepository
{
    public Task<ICollection<ResultProductShowCaseTypeDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM ProductShowCaseType";
        return base.GetAllAsync(query);
    }

    public void CreateAsync(CreateProductShowCaseTypeDto dto)
    {
        const string query =
            "INSERT INTO ProductShowCaseType (ProductShowCaseTypeName) VALUES (@ProductShowCaseTypeName)";
        ExecuteAsync(query, dto);
    }

    public async void DeleteAsync(int id)
    {
        const string query = "DELETE FROM ProductShowCaseType WHERE ProductShowCaseTypeID = @ProductShowCaseTypeID";
        await ExecuteAsync(query, new { ProductShowCaseTypeID = (short)id });
    }

    public void UpdateAsync(UpdateProductShowCaseTypeDto dto)
    {
        const string query = """
                             UPDATE ProductShowCaseType SET ProductShowCaseTypeName =
                             @ProductShowCaseTypeName WHERE ProductShowCaseTypeID = @ProductShowCaseTypeID
                             """;
        ExecuteAsync(query, dto);
    }

    public Task<ResultProductShowCaseTypeDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM ProductShowCaseType WHERE ProductShowCaseTypeID = @ProductShowCaseTypeID";
        return GetAsync(query, new { ProductShowCaseTypeID = (short)id });
    }
}