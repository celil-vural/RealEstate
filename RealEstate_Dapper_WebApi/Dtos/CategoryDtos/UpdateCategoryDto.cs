namespace RealEstate_Dapper_WebApi.Dtos.CategoryDtos
{
    public record UpdateCategoryDto(int CategoryId, string CategoryName, bool CategoryStatus)
    {
        private UpdateCategoryDto() : this(default, default, default)
        {
        }
    }
}
