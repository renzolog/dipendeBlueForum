using DipendeForumDomain.DomainClass;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DipendeForumInterfaces.Interfaces;
using DipendeForumInterfaces.Iservice;

namespace DipendeForumService
{
    public class UserService
    {

        private readonly IUserRepository repo;

        public UserService(IUserRepository _repo)
        {
            repo = _repo;
        }


        public UserDomain GetByUsername(string _username)
        {
            if (_username == null)
                throw new Exception("username non può essere null");

            return repo.GetByUsername(_username);
        }

        public void UpdateUserToBan(int id, DateTime _time)
        {
            repo.UpdateUserToBan(id, _time);
        }

        public void Add(UserDomain obj)
        {
            repo.Add(obj);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public void Update(UserDomain obj)
        {
            repo.Update(obj);
        }

        public IEnumerable<UserDomain> GetAll()
    { 
            return repo.GetAll();
        }

        public UserDomain GetById(int id)
        {
            return repo.GetById(id);
        }
    }
}
