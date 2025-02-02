﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfAccountDal : EfRepositoryBase<Account, Guid, CommentManagementContext>, IAccountDal
{
    public EfAccountDal(CommentManagementContext context) : base(context)
    {
    }
}