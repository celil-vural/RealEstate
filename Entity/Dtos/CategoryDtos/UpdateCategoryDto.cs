namespace Entity.Dtos.CategoryDtos
{
    public record UpdateCategoryDto(int CategoryId, string CategoryName, bool CategoryStatus)
    {
        public UpdateCategoryDto() : this(default, default, default)
        {
        }
    }
}
