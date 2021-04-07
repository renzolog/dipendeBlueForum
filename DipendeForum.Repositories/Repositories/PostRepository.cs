using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Repositories.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
    }
}
