namespace Entity.Dtos.EmployeeDtos;

public record ResultEmployeeDto(
    int EmployeeID,
    string Name,
    string Surname,
    string Email,
    string Phone,
    string ImageUrl,
    bool Status)
{
    private ResultEmployeeDto() : this(0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, false)
    {
    }
}