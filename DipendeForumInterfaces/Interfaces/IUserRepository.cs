using DipendeForum.Context.Entities;
using System;
using System.Collections.Generic;
using DipendeForumDomain.DomainClass;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IUserRepository : IRepository<UserDomain>
    {
        public void UpdateUserToBan(int id, DateTime _time);
        public User GetByUsername(string _username);
    }
}
