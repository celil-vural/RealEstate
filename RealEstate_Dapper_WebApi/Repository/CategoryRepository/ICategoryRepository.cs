using RealEstate_Dapper_WebApi.Dtos.CategoryDtos;

namespace RealEstate_Dapper_WebApi.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto category);
        void DeleteCategoryAsync(int id);
        void UpdateCategoryAsync(UpdateCategoryDto category);
        Task<ResultCategoryDto> GetCategoryByIdAsync(int id);
    }
}

