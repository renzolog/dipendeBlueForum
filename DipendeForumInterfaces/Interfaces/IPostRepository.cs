using DipendeForum.Context.Entities;
using System;
using System.Collections.Generic;
using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IPostRepository : IRepository<PostDomain>
    {
        public List<PostDomain> GetAllByUser(int userId);
        public List<PostDomain> GetAllByCategory(CategoryEnum category);
        public void UpdateIsClosedStatus(int postId);

    }
}
