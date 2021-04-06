using System;
using System.Collections.Generic;
using System.Text;
using DipendeForumDomain.Enum;

namespace DipendeForumDomain.DomainClass
{
    // int postId, int UserId, string category, string title, bool isClosed, datetima last comment
    public class PostDomain
    {
        public int Id { get; set; }
        public int UserId { get; set; } //Fk
        public string Title { get; set; }
        public CategoryEnum Category { get; set; }
        public string Description { get; set; }
        public int PostPoint { get; set; }
        public bool IsClosed { get; set; }
        public DateTime PublishTime { get; set; }
        public UserDomain LastUser { get; set; }
        public List<MessageDomain> Messages { get; set; }

    }
}
