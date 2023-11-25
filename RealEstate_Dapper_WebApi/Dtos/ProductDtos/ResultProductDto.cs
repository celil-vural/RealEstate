namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; init; }
        public string Title { get; init; }
        public decimal Price { get; init; }
        public string City { get; init; }
        public string District { get; init; }
        public int ProductCategory { get; init; }
    }
}
