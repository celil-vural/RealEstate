namespace RealEstate_Dapper_WebApi.Dtos.ContactAddressDtos;

public record CreateContactAddressDto(string Title, string Icon, string Content)
{
    private CreateContactAddressDto() : this(string.Empty, string.Empty, string.Empty)
    {
    }
}