using Entity.Dtos.EmployeeDtos;

namespace Repository.Repositories.EmployeeRepository;

public interface IEmployeeRepository : IBaseRepository<ResultEmployeeDto, CreateEmployeeDto, UpdateEmployeeDto>;