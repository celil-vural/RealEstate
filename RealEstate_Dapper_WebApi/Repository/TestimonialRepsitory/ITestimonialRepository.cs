using Entity.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_WebApi.Repository.TestimonialRepository;

public interface
    ITestimonialRepository : IBaseRepository<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>;