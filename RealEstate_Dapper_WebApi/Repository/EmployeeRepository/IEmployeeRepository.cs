using Entity.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_WebApi.Repository.EmployeeRepository;

public interface IEmployeeRepository
{
    Task<ICollection<ResultEmployeeDto>> GetAllEmployeeAsync();
    void CreateEmployeeAsync(CreateEmployeeDto dto);
    void DeleteEmployeeAsync(int id);
    void UpdateEmployeeAsync(UpdateEmployeeDto dto);
    Task<ResultEmployeeDto> GetEmployeeByIdAsync(int id);
}