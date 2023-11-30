namespace RealEstate_Dapper_WebApi.Dtos.ContactDtos;

public record UpdateContactDto(int ContactId, bool Seen, DateTime? SeenDate)
{
    private UpdateContactDto() : this(default, default, default)
    {
    }
}