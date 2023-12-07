using Entity.Dtos.CategoryDtos;

namespace Repository.Repositories.CategoryRepository
{
    public interface ICategoryRepository : IBaseRepository<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>;
}

