namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public record CreateProductDto(string Title, decimal Price, string City, string District, int ProductCategory);
}
