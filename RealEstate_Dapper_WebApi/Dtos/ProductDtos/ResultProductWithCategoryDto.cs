namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public record ResultProductWithCategoryDto(int ProductID,
        string Title,
        decimal Price,
        string CoverImage,
        string City,
        string District,
        string Address,
        string Description,
        string CategoryName,
        int EmployeeID,
        int ProductShowCaseID,
        bool ProductStatus
    );
}
