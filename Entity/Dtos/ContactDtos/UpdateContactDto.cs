namespace Entity.Dtos.ContactDtos;

public record UpdateContactDto(int ContactId, bool Seen, DateTime? SeenDate)
{
    private UpdateContactDto() : this(default, default, default)
    {
    }
}