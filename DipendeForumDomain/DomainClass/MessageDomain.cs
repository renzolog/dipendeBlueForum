using System;
using System.Collections.Generic;
using System.Text;

namespace DipendeForum.Context.Entities
{
    public class MessageDomain
    {
        // MessageId, PostId, UserId, Text, datetime publishedTime, bool isReported, 

        public int MessageId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime PublishedTime { get; set; }
        public bool isReported { get; set; }
    }
}
