namespace RealEstate_UI.Models.ProductModels;
public record ResultProductDto(int ProductID,
    string Title,
    decimal Price,
    string CoverImage,
    string City,
    string District,
    string Address,
    string Description,
    string CategoryName,
    int EmployeeID,
    int ProductShowCaseTypeID,
    bool ProductStatus
);