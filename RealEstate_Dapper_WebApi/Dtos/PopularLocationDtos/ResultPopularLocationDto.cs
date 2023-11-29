﻿namespace RealEstate_Dapper_WebApi.Dtos.PopularLocationDtos;

public record ResultPopularLocationDto(int LocationId, string CityName, string ImageUrl)
{
    ResultPopularLocationDto() : this(0, "default", "default") { }
}