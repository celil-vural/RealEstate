namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public record ResultProductDto
    {
        public int ProductID { get; init; }
        public string Title { get; init; }
        public string CoverImage { get; init; }
        public string Address { get; init; }
        public decimal Price { get; init; }
        public string City { get; init; }
        public string District { get; init; }
        public int ProductCategory { get; init; }
    }
}
