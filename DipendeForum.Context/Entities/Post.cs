using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Context.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public  string Category { get; set; }
        public  string Title { get; set; }
        public string Description { get; set; }
        public virtual List<Message> Messages { get; set; }
        public DateTime PublishTime { get; set; }
        public bool IsClosed { get; set; }
        public DateTime LastComment { get; set; }
    }
}
