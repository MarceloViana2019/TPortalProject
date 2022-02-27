using System;
using System.Collections.Generic;
using System.Text;
using TPortalProject.Data.Context;
using TPortalProject.Data.Repositories.Interfaces;
using TPortalProject.Domain.Entities;

namespace TPortalProject.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(TPortalProjectContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return GetQuery(x => !x.IsDeleted);
        }

    }
}
