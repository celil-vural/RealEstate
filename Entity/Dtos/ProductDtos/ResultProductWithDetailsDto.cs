namespace Entity.Dtos.ProductDtos
{
    public record ResultProductWithDetailsDto(
        int ProductID,
        string Title,
        decimal Price,
        string CoverImage,
        string City,
        string District,
        string Address,
        string Description,
        int EmployeeID,
        string ProductShowCaseTypeName,
        bool ProductStatus,
        string CategoryName
    )
    {
        ResultProductWithDetailsDto() : this(0, "", 0, "", "", "", "", "", 0, "", false, "") { }
    };
}