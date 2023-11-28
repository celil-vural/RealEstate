using Dapper;
using RealEstate_Dapper_WebApi.Dtos.ProductDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ProductRepository
{
    public class ProductRepository(DapperContext context) : IProductRepository
    {
        public async Task<ICollection<ResultProductDto>> GetAllProductAsync()
        {
            string query = "select * from Product";
            using (var connection = context.CreateConnection())
            {
                var values =
                    await connection.QueryAsync<ResultProductDto>(query);
                return values.ToHashSet();
            }
        }

        public async Task<ICollection<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = @"select ProductID,Title,Price,CoverImage,City,District,Address,Description,CategoryName=c.CategoryName,EmployeeID,ProductShowCaseTypeID,ProductStatus from Product p inner join Category c on p.ProductCategory = c.CategoryID";
            using (var connection = context.CreateConnection())
            {
                var values =
                    await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToHashSet();
            }
        }

        public async Task<ResultProductWithCategoryDto> GetProductWithCategoryByIdAsync(int id)
        {
            string query = @"select ProductID,Title,Price,CoverImage,Address,City,District,
       Description,CategoryName,EmployeeID,ProductShowCaseTypeID,ProductStatus from Product p inner join Category c on p.ProductCategory = c.CategoryId where ProductID = @id";
            using (var connection = context.CreateConnection())
            {
                var values =
                    await connection.QueryFirstOrDefaultAsync<ResultProductWithCategoryDto>(query, new { id });
                return values;
            }
        }

        public async Task<ResultProductDto> GetProductByIdAsync(int id)
        {
            string query = "select * from Product where ProductID = @id";
            using (var connection = context.CreateConnection())
            {
                var values =
                    await connection.QueryFirstOrDefaultAsync<ResultProductDto>(query, new { id });
                return values;
            }
        }

        public void CreateProductAsync(CreateProductDto createProductDto)
        {
            string query = @"insert into Product (Title,Price,CoverImage,City,District,Address,
                     Description,ProductCategory,EmployeeID,ProductShowCaseTypeID,ProductStatus) values 
                    (@Title,@Price,@CoverImage,@City,@District,@Address,@Description,@ProductCategory,@EmployeeID,
                     @ProductShowCaseTypeID,1)";
            using (var connection = context.CreateConnection())
            {
                connection.Execute(query, createProductDto);
            }
        }

        public void UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            string query = @"update Product set Title=@Title,Price=@Price,CoverImage=@CoverImage,City=@City,
District=@District,Address=@Address,Description=@Description,ProductCategory=@ProductCategory,EmployeeID=@EmployeeID,
ProductShowCaseTypeID=@ProductShowCaseTypeID where ProductID = @ProductID";
            using (var connection = context.CreateConnection())
            {
                connection.Execute(query, updateProductDto);
            }
        }

        public void DeleteProductAsync(int id)
        {
            string query = "delete from Product where ProductID = @id";
            using (var connection = context.CreateConnection())
            {
                connection.Execute(query, new { id });
            }
        }
    }
}
