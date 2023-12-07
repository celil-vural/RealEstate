using Entity.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_WebApi.Repository.EmployeeRepository;

public interface IEmployeeRepository : IBaseRepository<ResultEmployeeDto, CreateEmployeeDto, UpdateEmployeeDto>;