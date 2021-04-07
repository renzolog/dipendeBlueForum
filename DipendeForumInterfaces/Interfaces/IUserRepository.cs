using DipendeForum.Context.Entities;
using System;
using System.Collections.Generic;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        void cane();
    }
}
