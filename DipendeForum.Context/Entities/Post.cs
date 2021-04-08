using System;
using System.Collections.Generic;

namespace DipendeForum.Context.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte Category { get; set; }
        public string Description { get; set; }
        public int PostPoint { get; set; }
        public bool IsClosed { get; set; }
        public DateTime PublishTime { get; set; }
        public User LastUser { get; set; }
        public User User_Fk { get; set; }

        public virtual List<Message> Messages { get; set; }
    }
}
