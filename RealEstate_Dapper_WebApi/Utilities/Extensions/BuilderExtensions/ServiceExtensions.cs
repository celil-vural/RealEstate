using RealEstate_Dapper_WebApi.Model.DapperContext;
using RealEstate_Dapper_WebApi.Repository.CategoryRepository;
using RealEstate_Dapper_WebApi.Repository.ProductRepository;
using RealEstate_Dapper_WebApi.Repository.WhoWeAreRepository;

namespace RealEstate_Dapper_WebApi.Utilities.Extensions.BuilderExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureService(this IServiceCollection services)
        {
            services.ConfigureIoC();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public static void ConfigureIoC(this IServiceCollection services)
        {
            services.AddTransient<DapperContext>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
        }
    }
}
