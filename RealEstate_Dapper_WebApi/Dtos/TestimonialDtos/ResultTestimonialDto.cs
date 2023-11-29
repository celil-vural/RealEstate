namespace RealEstate_Dapper_WebApi.Dtos.TestimonialDtos;

public record ResultTestimonialDto(int TestimonialId,string NameSurname,string Title,bool Status)
{
    ResultTestimonialDto() : this(0,"default","default",false){}
}