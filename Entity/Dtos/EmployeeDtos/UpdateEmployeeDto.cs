namespace Entity.Dtos.EmployeeDtos;

public record UpdateEmployeeDto(
    int EmployeeID,
    string Name,
    string Surname,
    string Email,
    string EmployeePassword,
    string Phone,
    string ImageUrl,
    bool Status)
{
    private UpdateEmployeeDto() : this(0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
        string.Empty, false)
    {
    }
}