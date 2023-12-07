using RealEstate_Dapper_WebApi.Model.DapperContext;
using RealEstate_Dapper_WebApi.Repository.AddressRepository;
using RealEstate_Dapper_WebApi.Repository.BottomGridRepository;
using RealEstate_Dapper_WebApi.Repository.CategoryRepository;
using RealEstate_Dapper_WebApi.Repository.ContactAddressRepository;
using RealEstate_Dapper_WebApi.Repository.ContactRepository;
using RealEstate_Dapper_WebApi.Repository.EmployeeRepository;
using RealEstate_Dapper_WebApi.Repository.PopularLocationRepository;
using RealEstate_Dapper_WebApi.Repository.ProductRepository;
using RealEstate_Dapper_WebApi.Repository.ProductShowCaseTypeRepository;
using RealEstate_Dapper_WebApi.Repository.ServicesRepository;
using RealEstate_Dapper_WebApi.Repository.TestimonialRepsitory;
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
            services.AddTransient<IServicesRepository, ServicesRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository,PopularLocationRepository>();
            services.AddTransient<ITestimonialRepsitory,TestimonialRepsitory>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IContactAddressRepository, ContactAddressRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IProductShowCaseTypeReposiyory, ProductShowCaseTypeReposiyory>();
        }
    }
}
