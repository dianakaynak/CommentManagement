using Business.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class AccountBusinessRules : BaseBusinessRules
{
    IAccountDal _accountDal;

    public AccountBusinessRules(IAccountDal accountDal)
    {
        _accountDal = accountDal;
    }

    public async Task IsExistsAccount(Guid accountId)
    {
        var result = await _accountDal.GetAsync(
            predicate: a => a.Id == accountId,
            enableTracking: false);

        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
      
   

    public async Task<string> Test(string folderPath, string currentPath)
    {
        if (string.IsNullOrEmpty(folderPath)) return currentPath;
        return folderPath;
    }
}