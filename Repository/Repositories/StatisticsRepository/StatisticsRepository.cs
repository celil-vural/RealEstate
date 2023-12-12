using Repository.Repositories.Dapper;

namespace Repository.Repositories.StatisticsRepository;

public class StatisticsRepository(DapperContext context) : BaseRepository<object>(context), IStatisticsRepository
{
    public Task<int> CategoryCount()
    {
        const string query = "SELECT COUNT(CategoryID) FROM Category";
        return GetAsync<int>(query);
    }

    public async Task<int> ActiveCategoryCount()
    {
        const string query = "SELECT COUNT(CategoryID) FROM Category where CategoryStatus = 1";
        return await GetAsync<int>(query);
    }

    public async Task<int> PassiveCategoryCount()
    {
        const string query = "SELECT COUNT(CategoryID) FROM Category where CategoryStatus = 0";
        return await GetAsync<int>(query);
    }

    public async Task<int> ProductCount()
    {
        const string query = "SELECT COUNT(ProductID) FROM Product";
        return await GetAsync<int>(query);
    }

    public async Task<int> ApartmentCount()
    {
        const string query = "SELECT COUNT(*) FROM Product where Title LIKE '%Daire%' ";
        return await GetAsync<int>(query);
    }

    public async Task<string> EmployeeNameByMaxProductCount()
    {
        const string query = @"select Name,Count(*) from Product inner join
Employee on Employee.EmployeeID=Product.EmployeeID group by Name order by Count(*) DESC";
        return await GetAsync<string>(query);
    }

    public async Task<string> CategoryNameByMaxProductCount()
    {
        const string query = @"select top(1) CategoryName,count(*) from Product p inner join Category c 
    on c.CategoryId=p.ProductCategory group by CategoryName order by Count(*) DESC ";
        return await GetAsync<string>(query);
    }

    public async Task<decimal> AverageProductPriceByRent()
    {
        const string query = "select avg(Price) from Product p where ProductShowCaseTypeID = 2";
        return await GetAsync<decimal>(query);
    }

    public async Task<decimal> AverageProductPriceBySale()
    {
        const string query = "select avg(Price) from Product p where ProductShowCaseTypeID = 1";
        return await GetAsync<decimal>(query);
    }

    public async Task<string> CityNameByMaxProductCount()
    {
        const string query = "select top(1) City,count(*) from Product group by City order by City desc";
        return await GetAsync<string>(query);
    }

    public async Task<int> DifferentCityCount()
    {
        const string query = "select count(distinct(City)) from Product";
        return await GetAsync<int>(query);
    }

    public async Task<decimal> LastProductPrice()
    {
        const string query = "select top(1) Price from Product order by ProductID desc";
        return await GetAsync<decimal>(query);
    }

    public async Task<string> NewestBuildingYear()
    {
        const string query = "select top(1) BuiltYear from ProductDetails order by BuiltYear desc";
        return await GetAsync<string>(query);
    }

    public async Task<string> OldestBuildingYear()
    {
        const string query = "select top(1) BuiltYear from ProductDetails order by BuiltYear";
        return await GetAsync<string>(query);
    }

    public async Task<int> ActiveEmployeeCount()
    {
        const string query = "SELECT COUNT(EmployeeID) FROM Employee where Status = 1";
        return await GetAsync<int>(query);
    }

    public async Task<int> AverageRoomCount()
    {
        const string query = "SELECT avg(RoomCount) FROM ProductDetails";
        return await GetAsync<int>(query);
    }
}