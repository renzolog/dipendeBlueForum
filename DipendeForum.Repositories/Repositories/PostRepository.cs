using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DipendeForum.Context;
using DipendeForumMapper;
using DipendeForumDomain.DomainClass;

namespace DipendeForum.Repositories.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private readonly MappingProfiles _MappingProfiles;

        public PostRepository(ForumDbContext ctx, MappingProfiles mpp) : base(ctx)
        {
            _MappingProfiles = mpp;
        }

        public List<Post> GetAllByCategory(Enum category)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllByUser(UserDomain userDomain)
        {
            throw new NotImplementedException();
        }

        public void UpdateIsClosedStatus(PostDomain postDomain)
        {
            throw new NotImplementedException();
        }
    }
}
