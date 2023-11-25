using Dapper;
using RealEstate_Dapper_WebApi.Dtos.CategoryDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DapperContext _context;

        public CategoryRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<ICollection<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values =
                    await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToHashSet();
            }
        }

        public async void CreateCategoryAsync(CreateCategoryDto category)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@CategoryName,@CategoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", category.CategoryName);
            parameters.Add("@CategoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategoryAsync(int id)
        {
            string query = "delete from Category where CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateCategoryAsync(UpdateCategoryDto category)
        {
            string query = "update Category set CategoryName = @CategoryName, CategoryStatus=@CategoryStatus where CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", category.CategoryId);
            parameters.Add("@CategoryName", category.CategoryName);
            parameters.Add("@CategoryStatus", category.CategoryStatus);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, category);
            }
        }

        public async Task<ResultCategoryDto> GetCategoryByIdAsync(int id)
        {
            string query = "select * from Category where CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultCategoryDto>(query, parameters);
                return value;
            }
        }
    }
}
