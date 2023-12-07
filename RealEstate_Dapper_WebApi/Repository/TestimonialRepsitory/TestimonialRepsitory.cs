using Dapper;
using Entity.Dtos.TestimonialDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.TestimonialRepsitory;

public class TestimonialRepsitory(DapperContext context): ITestimonialRepsitory
{
    public async Task<ICollection<ResultTestimonialDto>> GetAllTestimonialDetailAsync()
    {
        string query = @"SELECT * FROM Testimonial";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultTestimonialDto>(query);
        return result.ToHashSet();
    }

    public async Task<ResultTestimonialDto> GetTestimonialDetailByIdAsync(int id)
    {
        string query = "SELECT * FROM Testimonial WHERE TestimonialId = @Id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultTestimonialDto>(query, new { Id = id });
        return result;
    }

    public async void CreateTestimonialDetailAsync(CreateTestimonialDto dto)
    {
        string query = @"INSERT INTO Testimonial (NameSurname,Title,Status)
VALUES (@NameSurname, @Title,1)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public void UpdateTestimonialDetailAsync(UpdateTestimonialDto dto)
    {
        string query = @"UPDATE Testimonial SET NameSurname = @NameSurname, Title = @Title, Status = @Status WHERE TestimonialId = @TestimonialId";
        using var connection = context.CreateConnection();
        connection.Execute(query, dto);
    }

    public void DeleteTestimonialDetailAsync(int id)
    {
        string query = @"DELETE FROM Testimonial WHERE TestimonialId = @Id";
        using var connection = context.CreateConnection();
        connection.Execute(query, new { Id = id });
    }
}