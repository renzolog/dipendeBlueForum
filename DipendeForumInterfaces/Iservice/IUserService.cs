using System;
using System.Collections.Generic;
using System.Text;
using DipendeForumDomain.DomainClass;

namespace DipendeForumInterfaces.Iservice
{
   public interface IUserService
   {
       public void Add(UserDomain userDomain);
       public void Delete(int id);
       public void Update(UserDomain userDomain);
       public List<UserDomain> GetAll();
       public UserDomain GetById(int id);
       public UserDomain GetByUsername(string username);
       public void UpdateUserToBan(int id, DateTime _time);
   }
}
