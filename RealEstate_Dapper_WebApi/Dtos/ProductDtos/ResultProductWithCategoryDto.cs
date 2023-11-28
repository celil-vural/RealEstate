namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public record ResultProductWithCategoryDto(
        int ProductID,
        string Title,
        decimal Price,
        string CoverImage,
        string City,
        string District,
        string Address,
        string Description,
        int EmployeeID,
        short ProductShowCaseTypeID,
        bool ProductStatus,
        string CategoryName
    )
    {
        ResultProductWithCategoryDto() : this(0, "", 0, "", "", "", "", "", 0, 0, false, "") { }
    };
}