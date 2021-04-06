using System;
using System.Collections.Generic;

namespace DipendeForum.Context.Entities
{
   public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BanTime { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}
