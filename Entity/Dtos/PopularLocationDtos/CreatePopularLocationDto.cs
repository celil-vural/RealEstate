namespace Entity.Dtos.PopularLocationDtos;

public record CreatePopularLocationDto(string CityName, string ImageUrl)
{
    CreatePopularLocationDto() : this("default","default"){}
};