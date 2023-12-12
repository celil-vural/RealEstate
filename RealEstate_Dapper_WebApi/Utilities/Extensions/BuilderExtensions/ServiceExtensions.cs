using Repository.Repositories.AddressRepository;
using Repository.Repositories.BottomGridRepository;
using Repository.Repositories.CategoryRepository;
using Repository.Repositories.ContactAddressRepository;
using Repository.Repositories.ContactRepository;
using Repository.Repositories.Dapper;
using Repository.Repositories.EmployeeRepository;
using Repository.Repositories.PopularLocationRepository;
using Repository.Repositories.ProductRepository;
using Repository.Repositories.ProductShowCaseTypeRepository;
using Repository.Repositories.Repository.AddressRepository;
using Repository.Repositories.ServicesRepository;
using Repository.Repositories.StatisticsRepository;
using Repository.Repositories.TestimonialRepository;
using Repository.Repositories.TestimonialRepsitory;
using Repository.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_WebApi.Utilities.Extensions.BuilderExtensions;

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
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
        services.AddScoped<IServicesRepository, ServicesRepository>();
        services.AddScoped<IBottomGridRepository, BottomGridRepository>();
        services.AddScoped<IPopularLocationRepository, PopularLocationRepository>();
        services.AddScoped<ITestimonialRepository, TestimonialRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IContactAddressRepository, ContactAddressRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IProductShowCaseTypeRepository, ProductShowCaseTypeRepository>();
        services.AddScoped<IStatisticsRepository, StatisticsRepository>();
    }
}