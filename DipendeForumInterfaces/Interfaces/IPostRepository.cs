using DipendeForum.Context.Entities;
using System;
using System.Collections.Generic;
using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IPostRepository : IRepository<PostDomain>
    {
        public List<Post> GetAllByUser(UserDomain userDomain);
        public List<Post> GetAllByCategory(Enum category);
        public void UpdateIsClosedStatus(PostDomain postDomain);

    }
}
