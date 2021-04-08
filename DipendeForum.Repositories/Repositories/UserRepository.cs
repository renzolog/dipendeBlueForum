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
    public class UserRepository :  IUserRepository
    {
        private readonly IMapper _MappingProfiles;
        private readonly ForumDbContext _ctx;

        public UserRepository(ForumDbContext ctx, IMapper mpp)
        {
            _ctx = ctx;
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

        public void Add(UserDomain obj)
        {
            var toAdd = _MappingProfiles.Map<User>(obj);
            _ctx.Users.Add(toAdd);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDelete = _ctx.Users.Where(u => u.Id == id).FirstOrDefault();
            _ctx.Users.Remove(toDelete);
            _ctx.SaveChanges();
        }

        public void Update(UserDomain obj)
        {
            var user = _ctx.Users.Where(u => u.Id == obj.Id).FirstOrDefault();

            var toUpdate = _ctx.Users.Where(u => u.Id == obj.Id).FirstOrDefault();
            toUpdate.Messages = user.Messages;
            toUpdate.Email = user.Email;
            toUpdate.Nickname = user.Nickname;
            toUpdate.BanTime = user.BanTime;
            toUpdate.Password = user.Password;
            toUpdate.Posts = user.Posts;
            _ctx.SaveChanges();
        }
        

        public IEnumerable<UserDomain> GetAll()
        {
            var list = _ctx.Users;
            var listToGet = _MappingProfiles.ProjectTo<UserDomain>(list);
            return listToGet;
        }

        public UserDomain GetById(int id)
        {
            var user = _ctx.Users.Where(u => u.Id == id).FirstOrDefault();
            var userToGet = _MappingProfiles.Map<UserDomain>(user);
            return userToGet;
        }
    }
}
