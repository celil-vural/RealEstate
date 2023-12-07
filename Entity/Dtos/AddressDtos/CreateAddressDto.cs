namespace Entity.Dtos.AddressDtos;

public record CreateAddressDto(string AddressTitle, string Address)
{
    private CreateAddressDto() : this(default, default)
    {
    }
}