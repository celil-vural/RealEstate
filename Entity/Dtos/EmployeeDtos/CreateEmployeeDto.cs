namespace Entity.Dtos.EmployeeDtos;

public record CreateEmployeeDto(
    string Name,
    string Surname,
    string Email,
    string EmployeePassword,
    string Phone,
    string ImageUrl)
{
    private CreateEmployeeDto() : this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
        string.Empty)
    {
    }
}