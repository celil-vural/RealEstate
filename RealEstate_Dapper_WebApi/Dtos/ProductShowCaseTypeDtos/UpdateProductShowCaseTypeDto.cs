namespace RealEstate_Dapper_WebApi.Dtos.ProductShowCaseTypeDtos;

public record UpdateProductShowCaseTypeDto(short ProductShowCaseTypeID, string ProductShowCaseTypeName)
{
    private UpdateProductShowCaseTypeDto() : this(0, string.Empty)
    {
    }
}