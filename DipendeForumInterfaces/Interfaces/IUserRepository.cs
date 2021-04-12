using DipendeForumDomain.DomainClass;
using System;
using System.Collections.Generic;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IUserRepository : IRepository<UserDomain>
    {
        public UserDomain GetByUsername(string _username);
        public void UpdateUserToBan(int id, DateTime _time);
    }
}
