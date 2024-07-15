using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AccountRequests;
using Business.Dtos.Responses.AccountResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using Core.Utilities.Helpers;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class AccountManager : IAccountService
{

    IAccountDal _accountDal;
    IMapper _mapper;
    AccountBusinessRules _accountBusinessRules;

    public AccountManager(IAccountDal accountDal, IMapper mapper, AccountBusinessRules accountBusinessRules)
    {
        _accountDal = accountDal;
        _mapper = mapper;
        _accountBusinessRules = accountBusinessRules;
    }

    public async Task<CreatedAccountResponse> AddAsync(CreateAccountRequest createAccountRequest)
    {

        Account account = _mapper.Map<Account>(createAccountRequest);
        Account addedAccount = await _accountDal.AddAsync(account);
        CreatedAccountResponse createdAccountResponse = _mapper.Map<CreatedAccountResponse>(addedAccount);
        return createdAccountResponse;
    }



    public async Task<DeletedAccountResponse> DeleteAsync(Guid id)
    {
        await _accountBusinessRules.IsExistsAccount(id);
        Account account = await _accountDal.GetAsync(predicate: l => l.Id == id);
        Account deletedAccount = await _accountDal.DeleteAsync(account);
        DeletedAccountResponse deletedAccountResponse = _mapper.Map<DeletedAccountResponse>(deletedAccount);
        return deletedAccountResponse;
    }


    public async Task<IPaginate<GetListAccountResponse>> GetListAsync(PageRequest pageRequest)
    {
        var account = await _accountDal.GetListAsync(
            index: pageRequest.PageIndex,
            size: pageRequest.PageSize,
            include: a => a
            .Include(a => a.User));
        var mappedAccountSession = _mapper.Map<Paginate<GetListAccountResponse>>(account);
        return mappedAccountSession;
    }

    public async Task<GetAccountResponse> GetByIdAsync(Guid id)
    {
        var account = await _accountDal.GetAsync(
            predicate: a => a.Id == id,
            include: a => a
            .Include(a => a.User));
        var mappedAccount = _mapper.Map<GetAccountResponse>(account);
        return mappedAccount;
    }

   
    public async Task<UpdatedAccountResponse> UpdateAsync(UpdateAccountRequest updateAccountRequest)
    {
        await _accountBusinessRules.IsExistsAccount(updateAccountRequest.Id);

        Account account = _mapper.Map<Account>(updateAccountRequest);
        Account updatedAccount = await _accountDal.UpdateAsync(account);
        UpdatedAccountResponse updatedAccountResponse = _mapper.Map<UpdatedAccountResponse>(updatedAccount);
        return updatedAccountResponse;
    }

   
}