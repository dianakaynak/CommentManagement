using Business.Dtos.Requests.AccountRequests;
using Business.Dtos.Responses.AccountResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAccountService
{
    Task<CreatedAccountResponse> AddAsync(CreateAccountRequest createAccountRequest);
    Task<UpdatedAccountResponse> UpdateAsync(UpdateAccountRequest updateAccountRequest);
    Task<DeletedAccountResponse> DeleteAsync(Guid id);
    Task<IPaginate<GetListAccountResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetAccountResponse> GetByIdAsync(Guid id);
}