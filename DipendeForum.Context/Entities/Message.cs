using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

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
        public int like { get; set; }
        public int dislike { get; set; }
    }
}
