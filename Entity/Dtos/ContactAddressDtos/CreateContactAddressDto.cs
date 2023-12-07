namespace Entity.Dtos.ContactAddressDtos;

public record CreateContactAddressDto(string Title, string Icon, string Content)
{
    private CreateContactAddressDto() : this(string.Empty, string.Empty, string.Empty)
    {
    }
}