using Dapper;
using RealEstate_Dapper_WebApi.Dtos.ProductDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;

        public ProductRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<ICollection<ResultProductDto>> GetAllProductAsync()
        {
            string query = "select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values =
                    await connection.QueryAsync<ResultProductDto>(query);
                return values.ToHashSet();
            }
        }

        public async Task<ICollection<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "select ProductID,Title,Price,City,District,CategoryName from Product p inner join Category c " +
                           "on p.ProductCategory = c.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values =
                    await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToHashSet();
            }
        }

        public async Task<ResultProductWithCategoryDto> GetProductWithCategoryByIdAsync(int id)
        {
            string query = "select ProductID,Title,Price,City,District,CategoryName from Product p inner join Category c " +
                           "on p.ProductCategory = c.CategoryId where ProductID = @id";
            using (var connection = _context.CreateConnection())
            {
                var values =
                    await connection.QueryFirstOrDefaultAsync<ResultProductWithCategoryDto>(query, new { id });
                return values;
            }
        }

        public async Task<ResultProductDto> GetProductByIdAsync(int id)
        {
            string query = "select * from Product where ProductID = @id";
            using (var connection = _context.CreateConnection())
            {
                var values =
                    await connection.QueryFirstOrDefaultAsync<ResultProductDto>(query, new { id });
                return values;
            }
        }

        public void CreateProductAsync(CreateProductDto createProductDto)
        {
            string query = "insert into Product (Title,Price,City,District,ProductCategory) values (@Title,@Price,@City,@District,@ProductCategory)";
            using (var connection = _context.CreateConnection())
            {
                connection.Execute(query, createProductDto);
            }
        }

        public void UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            string query = "update Product set Title = @Title,Price = @Price,City = @City,District = @District,ProductCategory = @ProductCategory where ProductID = @ProductID";
            using (var connection = _context.CreateConnection())
            {
                connection.Execute(query, updateProductDto);
            }
        }

        public void DeleteProductAsync(int id)
        {
            string query = "delete from Product where ProductID = @id";
            using (var connection = _context.CreateConnection())
            {
                connection.Execute(query, new { id });
            }
        }
    }
}
