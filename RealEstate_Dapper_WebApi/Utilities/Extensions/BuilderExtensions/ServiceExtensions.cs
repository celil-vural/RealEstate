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
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
        services.AddTransient<IServicesRepository, ServicesRepository>();
        services.AddTransient<IBottomGridRepository, BottomGridRepository>();
        services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
        services.AddTransient<ITestimonialRepository, TestimonialRepository>();
        services.AddTransient<IContactRepository, ContactRepository>();
        services.AddTransient<IAddressRepository, AddressRepository>();
        services.AddTransient<IContactAddressRepository, ContactAddressRepository>();
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        services.AddTransient<IProductShowCaseTypeRepository, ProductShowCaseTypeRepository>();
    }
}