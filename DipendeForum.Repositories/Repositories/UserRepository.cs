using System;
using DipendeForum.Context;
using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System.Linq;
using AutoMapper;
using DipendeForumMapper;
using System.Collections.Generic;
using System.Text;
using DipendeForumDomain.DomainClass;

namespace DipendeForum.Repositories.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IMapper _MappingProfiles;

        public UserRepository(ForumDbContext ctx, IMapper mpp) : base(ctx)
        {
            _MappingProfiles = mpp;
        }


        public UserDomain GetByUsername(string _username)
        {
            var UserEntity = _ctx.Users.Single(user => user.Nickname == _username);
            var UserDomainToReturn = _MappingProfiles.Map<UserDomain>(UserEntity);

            return UserDomainToReturn;
        }

        public void UpdateUserToBan(int id, DateTime _time)
        {
            throw new NotImplementedException();
        }
    }
}
