namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public record ResultProductDto(int ProductID,
        string Title,
        decimal Price,
        string CoverImage,
        string City,
        string District,
        string Address,
        string Description,
        int ProductCategory,
        int EmployeeID,
        int ProductShowCaseID,
        bool ProductStatus
    );
}
