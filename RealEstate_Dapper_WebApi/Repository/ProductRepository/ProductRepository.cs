using Entity.Dtos.ProductDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ProductRepository
{
    public class ProductRepository(DapperContext context)
        : BaseRepository<ResultProductDto>(context), IProductRepository
    {
        public Task<ICollection<ResultProductDto>> GetAllAsync()
        {
            const string query = "select * from Product";
            return base.GetAllAsync(query);
        }

        public Task<ICollection<ResultProductWithDetailsDto>> GetAllProductWithDetailsAsync()
        {
            const string query = """
                                 select ProductID,Title,Price,CoverImage,City,District,Address,
                                        Description,CategoryName=c.CategoryName,EmployeeID,ProductShowCaseTypeName=sct.ProductShowCaseTypeName,
                                        ProductStatus from Product p inner join Category c on p.ProductCategory = c.CategoryID
                                        inner join ProductShowCaseType sct on p.ProductShowCaseTypeID = sct.ProductShowCaseTypeID
                                 """;
            return base.GetAllAsync<ResultProductWithDetailsDto>(query);
        }

        public Task<ResultProductWithDetailsDto> GetProductWithDetailsByIdAsync(int id)
        {
            const string query = """
                                 select ProductID,Title,Price,CoverImage,City,District,Address,
                                        Description,CategoryName=c.CategoryName,EmployeeID,ProductShowCaseTypeName=sct.ProductShowCaseTypeName,
                                        ProductStatus from Product p inner join Category c on p.ProductCategory = c.CategoryID
                                        inner join ProductShowCaseType sct on p.ProductShowCaseTypeID = sct.ProductShowCaseTypeID
                                                      where ProductID = @id
                                 """;
            return GetAsync<ResultProductWithDetailsDto>(query, new { id });
        }

        public Task<ResultProductDto> GetByIdAsync(int id)
        {
            const string query = "select * from Product where ProductID = @id";
            return GetAsync(query, new { id });
        }

        public void CreateAsync(CreateProductDto dto)
        {
            const string query = """
                                 insert into Product (Title,Price,CoverImage,City,District,Address,
                                                      Description,ProductCategory,EmployeeID,ProductShowCaseTypeID,ProductStatus) values
                                                     (@Title,@Price,@CoverImage,@City,@District,@Address,@Description,@ProductCategory,@EmployeeID,
                                                      @ProductShowCaseTypeID,1)
                                 """;
            ExecuteAsync(query, dto);
        }

        public void UpdateAsync(UpdateProductDto dto)
        {
            const string query = """
                                 update Product set Title=@Title,Price=@Price,CoverImage=@CoverImage,City=@City,
                                 District=@District,Address=@Address,Description=@Description,ProductCategory=@ProductCategory,EmployeeID=@EmployeeID,
                                 ProductShowCaseTypeID=@ProductShowCaseTypeID where ProductID = @ProductID
                                 """;
            ExecuteAsync(query, dto);
        }

        public async void DeleteAsync(int id)
        {
            const string query = "delete from Product where ProductID = @id";
            await ExecuteAsync(query, new { id });
        }
    }
}
