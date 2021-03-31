using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Context.Entities
{
   public class User
    {   public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime BannTime { get; set; }
        public  string email { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}
