using Entity.Dtos.ProductDtos;

namespace Repository.Repositories.ProductRepository
{
    public interface IProductRepository : IBaseRepository<ResultProductDto, CreateProductDto, UpdateProductDto>
    {
        Task<ICollection<ResultProductWithDetailsDto>> GetAllProductWithDetailsAsync();
        Task<ResultProductWithDetailsDto> GetProductWithDetailsByIdAsync(int id);
    }
}
