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
    public class EfOperationClaimDal : EfRepositoryBase<OperationClaim, Guid, CommentManagementContext>, IOperationClaimDal
    {
        public EfOperationClaimDal(CommentManagementContext context) : base(context)
        {
        }
    }
} 
