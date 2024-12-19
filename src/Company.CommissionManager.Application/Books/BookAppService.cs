using System;
using Company.CommissionManager.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Company.CommissionManager.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = CommissionManagerPermissions.Books.Default;
        GetListPolicyName = CommissionManagerPermissions.Books.Default;
        CreatePolicyName = CommissionManagerPermissions.Books.Create;
        UpdatePolicyName = CommissionManagerPermissions.Books.Edit;
        DeletePolicyName = CommissionManagerPermissions.Books.Delete;
    }
}