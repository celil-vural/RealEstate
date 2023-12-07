namespace Entity.Dtos.ContactDtos;

public record ResultContactDto(int ContactId,
    string Name, string Subject, string Email, string Message, bool Seen, DateTime SendDate, DateTime? SeenDate)
{
    private ResultContactDto() : this(default, default, default, default, default, default, default, default)
    {
    }
}