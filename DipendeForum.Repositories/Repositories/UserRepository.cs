using DipendeForum.Context;
using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using DipendeForumMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Repositories.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly MappingProfiles _MappingProfiles;

        public UserRepository(ForumDbContext ctx, MappingProfiles mpp) : base(ctx)
        {
            _MappingProfiles = mpp;
        }


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
