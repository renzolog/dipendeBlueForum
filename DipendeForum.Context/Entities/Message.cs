using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Context.Entities
{
  public  class Message
    {
        public int MessageId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime PublishTime { get; set; }
        public bool IsReported { get; set; }
    }
}
