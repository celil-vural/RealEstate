namespace RealEstate_Dapper_WebApi.Dtos.TestimonialDtos;

public record UpdateTestimonialDto(int TestimonialId,string NameSurname,string Title,bool Status)
{
    UpdateTestimonialDto():this(0,"default","default",true){}
}