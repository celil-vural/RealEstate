namespace RealEstate_Dapper_WebApi.Dtos.ContactAddressDtos;

public record ResultContactAddressDto(int ContactAddressId, string Title, string Icon, string Content)
{
    private ResultContactAddressDto() : this(0, string.Empty, string.Empty, string.Empty)
    {
    }
}