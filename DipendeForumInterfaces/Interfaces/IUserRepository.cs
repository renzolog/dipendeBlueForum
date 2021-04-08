using DipendeForum.Context.Entities;
using DipendeForumDomain.DomainClass;
using System;
using System.Collections.Generic;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public void UpdateUserToBan(int id, DateTime _time);
        public UserDomain GetByUsername(string _username);
    }
}
