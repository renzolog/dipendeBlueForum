using System;
using System.Collections.Generic;
using System.Text;
using DipendeForumDomain.Enum;

namespace DipendeForumDomain.DomainClass
{
    // int postId, int UserId, string category, string title, bool isClosed, datetima last comment
    public class PostDomain
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public CategoryEnum Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<MessageDomain> Messages { get; set; }
        public DateTime PublishedTime { get; set; }
        public bool IsClosed { get; set; }
        public DateTime LastComment { get; set; }

    }
}
