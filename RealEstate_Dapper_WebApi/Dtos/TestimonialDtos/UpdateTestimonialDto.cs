namespace RealEstate_Dapper_WebApi.Dtos.TestimonialDtos;

public record UpdateTestimonialDto(int TestimonialId,string NameSurname,string Title,string Comment,bool Status)
{
    UpdateTestimonialDto():this(0,"default","default","default",true){}
}