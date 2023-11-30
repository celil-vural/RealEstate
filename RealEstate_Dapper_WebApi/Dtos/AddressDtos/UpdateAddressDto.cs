namespace RealEstate_Dapper_WebApi.Dtos.AddressDtos;

public record UpdateAddressDto(int AddressId, string AddressTitle, string Address, bool Status)
{
    private UpdateAddressDto() : this(default, default, default, default)
    {
    }
}