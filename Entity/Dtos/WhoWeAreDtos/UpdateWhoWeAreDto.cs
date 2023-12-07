namespace Entity.Dtos.WhoWeAreDtos;

public record UpdateWhoWeAreDto(
    int WhoWeAreDetailID,
    string Title, 
    string SubTitle,
    string Description1, 
    string Description2);