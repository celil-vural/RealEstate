using Entity.Dtos.TestimonialDtos;

namespace Repository.Repositories.TestimonialRepository;

public interface
    ITestimonialRepository : IBaseRepository<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>;