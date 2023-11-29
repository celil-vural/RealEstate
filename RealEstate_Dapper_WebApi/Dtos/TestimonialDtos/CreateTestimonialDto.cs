namespace RealEstate_Dapper_WebApi.Dtos.TestimonialDtos;
public record CreateTestimonialDto(string NameSurname,string Title)
{
    CreateTestimonialDto():this("default","default"){}
}