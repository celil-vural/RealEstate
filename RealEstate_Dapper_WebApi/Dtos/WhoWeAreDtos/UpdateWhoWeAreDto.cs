namespace RealEstate_Dapper_WebApi.Dtos.WhoWeAreDtos;

public record UpdateWhoWeAreDto(
    int WhoWeAreDetailID,
    string Title, 
    string SubTitle,
    string Description1, 
    string Description2);