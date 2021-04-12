using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DipendeForum.Context.Entities
{
   public class User
    {
        public int Id { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime BanTime { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}
