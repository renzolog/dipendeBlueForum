using System;

namespace DipendeForumDomain.DomainClass
{
    public class MessageDomain
    {
        public int Id { get; set; }
        public int PostId { get; set; } //Fk
        public UserDomain User { get; set; } //Fk
        public string Text { get; set; }
        public int MessagePoint { get; set; }
        public bool IsReported { get; set; }
        public DateTime PublishTime { get; set; }
    }
}
