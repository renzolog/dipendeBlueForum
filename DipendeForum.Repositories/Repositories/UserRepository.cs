using System;
using DipendeForum.Context;
using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;
using DipendeForumDomain.DomainClass;
using DipendeForumMapper;
using System.Text;

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

            //toDelete.Posts.ForEach(post => post.User_Fk = null); da pensare quando abbiamo un db
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

        public UserDomain GetByUsername(string _username)
        {
            var UserEntity = _ctx.Users.Single(user => user.Nickname == _username);
            var UserDomainToReturn = _MappingProfiles.Map<UserDomain>(UserEntity);

            return UserDomainToReturn;
        }

        public void UpdateUserToBan(int id, DateTime _time)
        {
            var UserEntity = _ctx.Users.Single(user => user.Id == id);
            UserEntity.BanTime = _time;

            _ctx.SaveChanges();
        }
    }
}
