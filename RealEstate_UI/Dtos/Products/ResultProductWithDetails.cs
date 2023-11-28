namespace RealEstate_UI.Dtos.Products;

public record ResultProductWithDetails(
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
);