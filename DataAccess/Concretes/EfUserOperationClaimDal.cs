﻿using Core.DataAccess.Repositories;
using Core.Entities;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfUserOperationClaimDal : EfRepositoryBase<UserOperationClaim, Guid, CommentManagementContext>, IUserOperationClaimDal
    {
        public EfUserOperationClaimDal(CommentManagementContext context) : base(context)
        {
        }
    }
} 
