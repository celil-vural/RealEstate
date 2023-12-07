namespace RealEstate_Dapper_WebApi.Repository;

public interface IBaseRepository<TResultDto, in TCreateDto, in TUpdateDto>
{
    Task<ICollection<TResultDto>> GetAllAsync();
    Task<TResultDto> GetByIdAsync(int id);
    void CreateAsync(TCreateDto dto);
    void UpdateAsync(TUpdateDto dto);
    void DeleteAsync(int id);
}