namespace RealEstate_UI.Dtos.ProductDtos;

public class UpdateProductDto(int ProductID,
    string Title,
    decimal Price,
    string CoverImage,
    string City,
    string District,
    string Address,
    string Description,
    int ProductCategory,
    int EmployeeID,
    short ProductShowCaseTypeID,
    bool ProductStatus
);