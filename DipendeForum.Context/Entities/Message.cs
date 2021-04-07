using System;

namespace DipendeForum.Context.Entities
{
  public  class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int MessagePoint { get; set; }
        public bool IsReported { get; set; }
        public DateTime PublishTime { get; set; }
        public Post Post_Fk { get; set; }
        public User User_Fk { get; set; }
    }
}
