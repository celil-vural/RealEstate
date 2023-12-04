using RealEstate_Dapper_WebApi.Dtos.ProductShowCaseTypeDtos;

namespace RealEstate_Dapper_WebApi.Repository.ProductShowCaseTypeRepository;

public interface IProductShowCaseTypeReposiyory
{
    Task<ICollection<ResultProductShowCaseTypeDto>> GetAllProductShowCaseTypeAsync();
    void CreateProductShowCaseTypeAsync(CreateProductShowCaseTypeDto dto);
    void DeleteProductShowCaseTypeAsync(short id);
    void UpdateProductShowCaseTypeAsync(UpdateProductShowCaseTypeDto dto);
    Task<ResultProductShowCaseTypeDto> GetProductShowCaseTypeByIdAsync(short id);
}