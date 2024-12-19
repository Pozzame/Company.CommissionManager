using AutoMapper;
using Company.CommissionManager.Books;

namespace Company.CommissionManager;

public class CommissionManagerApplicationAutoMapperProfile : Profile
{
    public CommissionManagerApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
