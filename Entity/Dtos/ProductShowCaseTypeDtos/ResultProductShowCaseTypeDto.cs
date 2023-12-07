namespace Entity.Dtos.ProductShowCaseTypeDtos;

public record ResultProductShowCaseTypeDto(short ProductShowCaseTypeID, string ProductShowCaseTypeName)
{
    private ResultProductShowCaseTypeDto() : this(0, string.Empty)
    {
    }
}