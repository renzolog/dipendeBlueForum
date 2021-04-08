using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using DipendeForum.Context;
using DipendeForum.Context.Entities;
using DipendeForumDomain.DomainClass;

namespace DipendeForumService
{
   public class LoginService
    {
        private readonly IMapper _mapper;
        private readonly ForumDbContext _ctx;

        public LoginService(ForumDbContext ctx, IMapper mpp)
        {
            _ctx = ctx;
            _mapper = mpp;
        }
        public UserDomain Login(string userName, string password)
        {
            User user;
            user = _ctx.Users.Where(u=>u.Nickname==userName || u.Email == userName).Where(u=>u.Password==password).FirstOrDefault();
           var userDomain= _mapper.Map<UserDomain>(user);
            return userDomain;
        }
    }
}
