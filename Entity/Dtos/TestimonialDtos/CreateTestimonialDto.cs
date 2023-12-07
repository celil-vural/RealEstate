namespace Entity.Dtos.TestimonialDtos;
public record CreateTestimonialDto(string NameSurname,string Title,string Comment)
{
    CreateTestimonialDto():this("default","default","default"){}
}