using System;
using System.Collections.Generic;
using System.Text;
using TPortalProject.Domain.Entities;

namespace TPortalProject.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAll();
    }
}
