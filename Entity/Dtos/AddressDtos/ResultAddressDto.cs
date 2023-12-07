namespace Entity.Dtos.AddressDtos;

public record ResultAddressDto(int AddressId, string AddressTitle, string Address, bool Status)
{
    private ResultAddressDto() : this(default, default, default, default)
    {
    }
}