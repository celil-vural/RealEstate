namespace RealEstate_Dapper_WebApi.Dtos.ContactAddressDtos;

public record UpdateContactAddressDto(int ContactAddressId, string Title, string Icon, string Content)
{
    private UpdateContactAddressDto() : this(0, string.Empty, string.Empty, string.Empty)
    {
    }
}