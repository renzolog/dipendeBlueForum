using System;

namespace DipendeForumDomain.DomainClass
{
    public class MessageDomain
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int MessagePoint { get; set; }
        public bool IsReported { get; set; }
        public DateTime PublishTime { get; set; }
        public PostDomain Post_Fk{ get; set; }
        public UserDomain User_Fk { get; set; }
    }
}
