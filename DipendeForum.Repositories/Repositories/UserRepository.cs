using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Repositories.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public void cane()
        {
            throw new NotImplementedException();
        }
    }
}
