namespace RealEstate_Dapper_WebApi.Dtos.PopularLocationDtos;

public record CreatePopularLocationDto(string CityName, string ImageUrl)
{
    CreatePopularLocationDto() : this("default","default"){}
};