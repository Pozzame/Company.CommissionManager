using AutoMapper;
using Company.CommissionManager.Books;

namespace Company.CommissionManager.Web;

public class CommissionManagerWebAutoMapperProfile : Profile
{
    public CommissionManagerWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
