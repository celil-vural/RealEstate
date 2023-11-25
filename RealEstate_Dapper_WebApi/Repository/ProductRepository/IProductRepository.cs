using RealEstate_Dapper_WebApi.Dtos.ProductDtos;

namespace RealEstate_Dapper_WebApi.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<ICollection<ResultProductDto>> GetAllProductAsync();
        Task<ICollection<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        Task<ResultProductWithCategoryDto> GetProductWithCategoryByIdAsync(int id);
        Task<ResultProductDto> GetProductByIdAsync(int id);
        void CreateProductAsync(CreateProductDto createProductDto);
        void UpdateProductAsync(UpdateProductDto updateProductDto);
        void DeleteProductAsync(int id);
    }
}
