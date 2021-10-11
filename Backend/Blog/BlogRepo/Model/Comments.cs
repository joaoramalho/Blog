using System;
namespace BlogRepo.Model
{
    public class Comments
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime Published { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserChange { get; set; }
        public DateTime DateChange { get; set; }
    }
}
