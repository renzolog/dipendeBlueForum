using System;
using System.Collections.Generic;
using System.Text;
using DipendeForum.Context.Entities;

namespace DipendeForumDomain
{
    public class UserDomain
    {
        //Id, nickname, password, email, ban, messages, posts, (virtual)

        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BanTime { get; set; }

        public List<MessageDomain> Message { get; set; }
        public List<PostDomain> Post { get; set; }
    }
}
