using Entity.Dtos.CategoryDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.CategoryRepository
{
    public class CategoryRepository(DapperContext context)
        : BaseRepository<ResultCategoryDto>(context), ICategoryRepository
    {
        public Task<ICollection<ResultCategoryDto>> GetAllAsync()
        {
            const string query = "select * from Category";
            return base.GetAllAsync(query);
        }

        public void CreateAsync(CreateCategoryDto dto)
        {
            const string query = "insert into Category (CategoryName) values (@CategoryName)";
            ExecuteAsync(query, dto);
        }

        public void DeleteAsync(int id)
        {
            const string query = "delete from Category where CategoryId = @id";
            ExecuteAsync(query, new { id });
        }

        public void UpdateAsync(UpdateCategoryDto dto)
        {
            const string query =
                "update Category set CategoryName = @CategoryName, CategoryStatus=@CategoryStatus where CategoryId = @CategoryId";
            ExecuteAsync(query, dto);
        }

        public Task<ResultCategoryDto> GetByIdAsync(int id)
        {
            const string query = "select * from Category where CategoryId = @id";
            return GetAsync(query, new { id });
        }
    }
}
