using DipendeForum.Context.Entities;
using System;
using System.Collections.Generic;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public void UpdateUserToBan(int id, DateTime _time);
        public User GetByUsername(string _username);
    }
}
