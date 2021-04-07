using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Repositories.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public User GetByUsername(string _username)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserToBan(int id, DateTime _time)
        {
            throw new NotImplementedException();
        }
    }
}
