using Dapper;
using Entity.Dtos.EmployeeDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.EmployeeRepository;

public class EmployeeRepository(DapperContext context) : IEmployeeRepository
{
    public async Task<ICollection<ResultEmployeeDto>> GetAllEmployeeAsync()
    {
        var query = @"SELECT * FROM Employee";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultEmployeeDto>(query);
        return result.ToHashSet();
    }

    public async void CreateEmployeeAsync(CreateEmployeeDto dto)
    {
        var query =
            @"INSERT INTO Employee (Name,Surname,Email,EmployeePassword,Phone,ImageUrl) VALUES (@Name,@Surname,@Email,@EmployeePassword,@Phone,@ImageUrl)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async void DeleteEmployeeAsync(int id)
    {
        var query = @"DELETE FROM Employee WHERE EmployeeID=@id";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, new { id });
    }

    public async void UpdateEmployeeAsync(UpdateEmployeeDto dto)
    {
        var query =
            @"UPDATE Employee SET Name=@Name,Surname=@Surname,Email=@Email,EmployeePassword=@EmployeePassword,Phone=@Phone,ImageUrl=@ImageUrl 
                WHERE EmployeeID=@EmployeeID";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async Task<ResultEmployeeDto> GetEmployeeByIdAsync(int id)
    {
        var query = @"SELECT * FROM Employee WHERE EmployeeID=@id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultEmployeeDto>(query, new { id });
        return result;
    }
}