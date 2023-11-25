namespace RealEstate_Dapper_WebApi.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; init; }
        public string Title { get; init; }
        public decimal Price { get; init; }
        public string City { get; init; }
        public string District { get; init; }
        public string CategoryName { get; init; }
    }
}
