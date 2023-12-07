using Entity.Dtos.ProductShowCaseTypeDtos;

namespace Repository.Repositories.ProductShowCaseTypeRepository;

public interface IProductShowCaseTypeRepository : IBaseRepository<ResultProductShowCaseTypeDto,
    CreateProductShowCaseTypeDto, UpdateProductShowCaseTypeDto>;