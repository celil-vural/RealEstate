namespace RealEstate_Dapper_WebApi.Dtos.PopularLocationDtos;

public record UpdatePopularLocationDto(int LocationId, string CityName, string ImageUrl)
{
    UpdatePopularLocationDto() : this(0, "default", "default"){}
}