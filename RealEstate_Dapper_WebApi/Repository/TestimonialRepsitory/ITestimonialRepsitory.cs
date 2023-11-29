using RealEstate_Dapper_WebApi.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_WebApi.Repository.TestimonialRepsitory;

public interface ITestimonialRepsitory
{
    Task<ICollection<ResultTestimonialDto>> GetAllTestimonialDetailAsync();
    Task<ResultTestimonialDto> GetTestimonialDetailByIdAsync(int id);
    void CreateTestimonialDetailAsync(CreateTestimonialDto dto);
    void UpdateTestimonialDetailAsync(UpdateTestimonialDto dto);
    void DeleteTestimonialDetailAsync(int id);
}