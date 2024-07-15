using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IAccountDal : IRepository<Account, Guid>, IAsyncRepository<Account, Guid>
{
}