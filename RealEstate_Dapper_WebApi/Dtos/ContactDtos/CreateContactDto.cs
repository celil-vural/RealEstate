namespace RealEstate_Dapper_WebApi.Dtos.ContactDtos;

public record CreateContactDto(string Name, string Subject, string Email, string Message)
{
    private CreateContactDto() : this(default, default, default, default)
    {
    }
}