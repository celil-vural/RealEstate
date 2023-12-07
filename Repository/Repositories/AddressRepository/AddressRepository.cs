using Entity.Dtos.AddressDtos;
using Repository.Repositories.AddressRepository;
using Repository.Repositories.Dapper;

namespace Repository.Repositories.Repository.AddressRepository;

public class AddressRepository(DapperContext context) : BaseRepository<ResultAddressDto>(context), IAddressRepository
{
    public Task<ICollection<ResultAddressDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM Address";
        return base.GetAllAsync(query);
    }

    public void CreateAsync(CreateAddressDto dto)
    {
        const string query = """
                             INSERT INTO Address (AddressTitle, Address)
                             VALUES (@AddressTitle, @Address)
                             """;
        ExecuteAsync(query, dto);
    }

    public void DeleteAsync(int id)
    {
        const string query = "DELETE FROM Address WHERE AddressId = @Id";
        ExecuteAsync(query, new { Id = id });
    }

    public void UpdateAsync(UpdateAddressDto dto)
    {
        const string query = """
                             UPDATE Address SET AddressTitle = @AddressTitle, Address = @Address,
                                                Status=@Status WHERE AddressId = @Id
                             """;
        ExecuteAsync(query, dto);
    }

    public Task<ResultAddressDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM Address WHERE AddressId = @id";
        return GetAsync(query, new { id });
    }
}