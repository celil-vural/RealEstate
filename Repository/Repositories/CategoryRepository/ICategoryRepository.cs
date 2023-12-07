using Entity.Dtos.CategoryDtos;

namespace RealEstate_Dapper_WebApi.Repository.CategoryRepository
{
    public interface ICategoryRepository : IBaseRepository<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>;
}

