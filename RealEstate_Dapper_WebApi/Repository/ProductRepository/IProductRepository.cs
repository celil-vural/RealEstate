using Entity.Dtos.ProductDtos;

namespace RealEstate_Dapper_WebApi.Repository.ProductRepository
{
    public interface IProductRepository : IBaseRepository<ResultProductDto, CreateProductDto, UpdateProductDto>
    {
        Task<ICollection<ResultProductWithDetailsDto>> GetAllProductWithDetailsAsync();
        Task<ResultProductWithDetailsDto> GetProductWithDetailsByIdAsync(int id);
    }
}
