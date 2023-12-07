using Entity.Dtos.TestimonialDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;
using RealEstate_Dapper_WebApi.Repository.TestimonialRepository;

namespace RealEstate_Dapper_WebApi.Repository.TestimonialRepsitory;

public class TestimonialRepository(DapperContext context)
    : BaseRepository<ResultTestimonialDto>(context), ITestimonialRepository
{
    public Task<ICollection<ResultTestimonialDto>> GetAllAsync()
    {
        const string query = @"SELECT * FROM Testimonial";
        return GetAllAsync(query);
    }

    public Task<ResultTestimonialDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM Testimonial WHERE TestimonialId = @Id";
        return GetAsync(query, new { Id = id });
    }

    public void CreateAsync(CreateTestimonialDto dto)
    {
        const string query = """
                             INSERT INTO Testimonial (NameSurname,Title,Status)
                             VALUES (@NameSurname, @Title,1)
                             """;
        ExecuteAsync(query, dto);
    }

    public void UpdateAsync(UpdateTestimonialDto dto)
    {
        const string query =
            "UPDATE Testimonial SET NameSurname = @NameSurname, Title = @Title, Status = @Status WHERE TestimonialId = @TestimonialId";
        ExecuteAsync(query, dto);
    }

    public async void DeleteAsync(int id)
    {
        const string query = "DELETE FROM Testimonial WHERE TestimonialId = @Id";
        await ExecuteAsync(query, new { Id = id });
    }
}