using Entity.Dtos.ProductShowCaseTypeDtos;

namespace RealEstate_Dapper_WebApi.Repository.ProductShowCaseTypeRepository;

public interface IProductShowCaseTypeRepository : IBaseRepository<ResultProductShowCaseTypeDto,
    CreateProductShowCaseTypeDto, UpdateProductShowCaseTypeDto>;