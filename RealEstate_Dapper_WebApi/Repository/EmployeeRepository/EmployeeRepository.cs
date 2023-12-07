using Entity.Dtos.EmployeeDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.EmployeeRepository;

public class EmployeeRepository(DapperContext context) : BaseRepository<ResultEmployeeDto>(context), IEmployeeRepository
{
    public Task<ICollection<ResultEmployeeDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM Employee";
        return base.GetAllAsync(query);
    }

    public void CreateAsync(CreateEmployeeDto dto)
    {
        const string query =
            "INSERT INTO Employee (Name,Surname,Email,EmployeePassword,Phone,ImageUrl) VALUES (@Name,@Surname,@Email,@EmployeePassword,@Phone,@ImageUrl)";
        ExecuteAsync(query, dto);
    }

    public void DeleteAsync(int id)
    {
        const string query = "DELETE FROM Employee WHERE EmployeeID=@id";
        ExecuteAsync(query, new { id });
    }

    public void UpdateAsync(UpdateEmployeeDto dto)
    {
        const string query = """
                             UPDATE Employee SET Name=@Name,Surname=@Surname,Email=@Email,EmployeePassword=@EmployeePassword,Phone=@Phone,ImageUrl=@ImageUrl
                                             WHERE EmployeeID=@EmployeeID
                             """;
        ExecuteAsync(query, dto);
    }

    public Task<ResultEmployeeDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM Employee WHERE EmployeeID=@id";
        return GetAsync(query, new { id });
    }
}